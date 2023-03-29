using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace Homework4_1Server
{
    public partial class MainFormRecipes_Server : Form
    {
        private const int portNumber = 8000;
        private UdpClient receiver;
        private List<Recipe> recipes;
        public MainFormRecipes_Server()
        {
            InitializeComponent();
            FillRecipes();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbMessages.Items.Clear();
            receiver = new UdpClient(portNumber);
            Thread thread = new Thread(ReceiveData);
            thread.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void FillRecipes()
        {
            recipes = new List<Recipe>();
            using (StreamReader reader = new StreamReader(@"..\..\Recipes.txt"))
            {
                while (!reader.EndOfStream)
                {
                    Recipe recipe = new Recipe();
                    recipe.name = reader.ReadLine();
                    recipe.imagePath = reader.ReadLine();
                    recipe.ingridients = new List<string>();
                    string next = reader.ReadLine();
                    while (!next.StartsWith("---"))
                    {
                        recipe.ingridients.Add(next);
                        next = reader.ReadLine();
                    }
                    recipes.Add(recipe);
                }

            }
        }


        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    IPEndPoint remoteEndpoint = null;
                    byte[] data = receiver.Receive(ref remoteEndpoint);

                    Thread thread = new Thread(() => HandleData(data, remoteEndpoint));
                    thread.Start();
                }
            }
            catch { }
        }

        private void HandleData(byte[] data, IPEndPoint remoteEndpoint)
        {
            try
            {
                string message = Encoding.UTF8.GetString(data);
                string[] ingridients = message.Split(';');
                Action a = () =>
                {
                    lbMessages.Items.Insert(0,$"{remoteEndpoint.Address}:{remoteEndpoint.Port} >> {message.Replace(';', '\n')}");
                };
                if (InvokeRequired) Invoke(a);
                else a();
                Recipe mostInCommonRecipe = null;
                int maxCount = 0;
                for (int i = 0; i < recipes.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < recipes[i].ingridients.Count; j++)
                    {
                        if (ingridients.Contains(recipes[i].ingridients[j])) count++;
                    }
                    if (count > maxCount)
                    {
                        mostInCommonRecipe = recipes[i];
                        maxCount = count;
                    }
                }
                //if (mostInCommonRecipe == null) no matches, send denial?
                string recipe = "";
                recipe += mostInCommonRecipe.name + '\n';
                for (int i = 0; i < mostInCommonRecipe.ingridients.Count; i++)
                {
                    recipe += mostInCommonRecipe.ingridients[i] + '\n';
                }
                byte[] sendingData = Encoding.UTF8.GetBytes(recipe);
                UdpClient client = new UdpClient();
                client.Send(sendingData, sendingData.Length, remoteEndpoint);
                byte[] imageData = File.ReadAllBytes(mostInCommonRecipe.imagePath);
                int chunkSize = 1024;
                List<byte[]> chunks = new List<byte[]>();
                for (int i = 0; i < imageData.Length; i += chunkSize)
                {
                    int chunkLength = Math.Min(chunkSize, imageData.Length - i);
                    byte[] chunk = new byte[chunkLength];
                    Array.Copy(imageData, i, chunk, 0, chunkLength);
                    chunks.Add(chunk);
                }
                foreach (byte[] chunk in chunks)
                {
                    client.Send(chunk, chunk.Length, remoteEndpoint);
                }
                client.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                receiver.Close();
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch { }
        }
    }

    public class Recipe
    {
        public string name;
        public string imagePath;
        public List<string> ingridients;
    }
}
