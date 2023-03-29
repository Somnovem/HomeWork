using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4_1Client
{

    public partial class MainFormRecipes_Client : Form
    {
        private UdpClient client;
        private UdpClient receiver;
        private List<string> productList;
        private List<Recipe> recipes;
        private Task connectedTask;
        public MainFormRecipes_Client()
        {
            client = null;
            productList = new List<string>();
            InitializeComponent();
            this.FormClosing += MainFormRecipes_Client_FormClosing;
            lbRecipes.SelectedIndexChanged += LbRecipes_SelectedIndexChanged;
        }

        private void LbRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRecipes.SelectedItem == null || lbRecipes.Items.Count == 0) return;
            imgRecipe.Image = recipes[lbRecipes.SelectedIndex].image;
        }

        private void MainFormRecipes_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                btnDisconnect_Click(null, null);
            }
            catch { }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (client != null) return;
            client = new UdpClient();
            receiver = new UdpClient((int)edLocalPort.Value);
            btnDisconnect.Enabled = true;
            gbSending.Enabled = true;
            btnConnect.Enabled = false;
            connectedTask = Task.Run(ReceiveMessages);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (client == null) return;
            try
            {
                client.Close();
                receiver.Close();
            }
            catch
            {

            }
            finally
            {
                client = null;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                gbSending.Enabled = false;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edNewProduct.Text)) return;
            if (!productList.Contains(edNewProduct.Text))
            {
                productList.Add(edNewProduct.Text);
                edNewProduct.Text = "";
                UpdateProductList();
            }
        }

        private byte[] bytesSend = null;
        
        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (client == null) return;
            btnSend.Enabled = false;
            try
            {
                string products = "";
                for (int i = 0; i < productList.Count; i++)
                {
                    products += productList[i] + ";";
                }
                bytesSend = Encoding.UTF8.GetBytes(products);
                await client.SendAsync(bytesSend, bytesSend.Length,
                    new IPEndPoint(IPAddress.Parse(edRemoteAdress.Text), (int)edRemotePort.Value));
            }
            catch { }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private void UpdateProductList()
        {
            lbProducts.Items.Clear();
            for (int i = 0; i < productList.Count; i++)
            {
                lbProducts.Items.Add(productList[i]);
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void UpdateRecipes()
        {
            lbRecipes.Items.Clear();
            for (int i = 0; i < recipes.Count; i++)
            {
                lbRecipes.Items.Insert(0, recipes[i].recipe);
            }
            lbRecipes.SelectedIndex = 0;
        }


        private void ReceiveMessages()
        {

            IPEndPoint remotePoint = null;
            StringBuilder builderRecipe = new StringBuilder();
            try
            {
                while (true)
                {
                    recipes = new List<Recipe>();
                    do
                    {
                        byte[] data = receiver.Receive(ref remotePoint);
                        builderRecipe.Append(Encoding.UTF8.GetString(data));
                    } while (receiver.Available > 0);
                    List<byte> receivedByteImage = new List<byte>();
                    do
                    {
                        byte[] imageData = receiver.Receive(ref remotePoint);
                        receivedByteImage.AddRange(imageData);
                    } while (receiver.Available > 0);
                    Image receivedImage = ByteArrayToImage(receivedByteImage.ToArray());
                    recipes.Add(new Recipe(builderRecipe.ToString(), receivedImage));
                    UpdateRecipes();
                    builderRecipe.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                receiver = null;
            }

        }
    }

    public class Recipe
    {
        public string recipe;
        public Image image;
        public Recipe(string recipe, Image image)
        {
            this.recipe = recipe;
            this.image = image;
        }
    }
}
