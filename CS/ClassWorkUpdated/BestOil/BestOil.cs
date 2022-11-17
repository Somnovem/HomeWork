using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using BestOil.Properties;

namespace BestOilProgram
{

    public partial class BestOil : Form
    {

        BindingList<Oil> oils = new BindingList<Oil>();
        BindingList<ProductStats> stats = new BindingList<ProductStats>();
        private static string Language  = Settings.Default.Language;
        async private void Save<T>(string path, BindingList<T> list)
        {
            var file = new FileInfo(path);
            if (file.Exists)
            {
                File.Delete(path);
            }
            var package = new ExcelPackage(file);
            var ws = package.Workbook.Worksheets.Add("Main");
            var range = ws.Cells["A1"].LoadFromCollection(list, true);
            range.AutoFitColumns();
            await package.SaveAsync();
        }
        private void ShowProducts()
        {
            panel1.Controls.Clear();
            foreach (var item in products) 
            {
                item.CheckBox_Enable.Checked = false;
            }
            for (int i = 0; i < stats.Count; i++)
            {
                CheckBox check = new CheckBox();
                check.Location = new Point(6, 12 + i * 28);
                check.Text = stats[i].Name;
                check.CheckedChanged += Check_CheckedChanged;

                TextBox textPrice = new TextBox();
                textPrice.Text = stats[i].price.ToString();
                textPrice.Location = new Point(109, 12 + i * 28);
                textPrice.Size = new Size(70, 22);
                textPrice.ReadOnly = true;



                NumericUpDown numeric = new NumericUpDown();
                numeric.Location = new Point(188, 12 + i * 28);
                numeric.Size = new Size(70, 22);
                numeric.Minimum = 0;
                numeric.Maximum = 1000;
                numeric.Enabled = false;
                numeric.ValueChanged += Numeric_ValueChanged;
                products.Add(new Product
                {
                    Stats = new ProductStats
                    {
                        Name = stats[i].Name,
                        price = stats[i].price
                    },
                    CheckBox_Enable = check,
                    TextBox_Price = textPrice,
                    Amount = numeric
                });
                panel1.Controls.Add(check);
                panel1.Controls.Add(textPrice);
                panel1.Controls.Add(numeric);
            }
        }
        private void LoadOil()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(@"Oils.xlsx")))
            {
                var myWorksheet = xlPackage.Workbook.Worksheets.First();
                var totalRows = myWorksheet.Dimension.End.Row;
                var totalColumns = myWorksheet.Dimension.End.Column;
                for (int rowNum = 2; rowNum <= totalRows; rowNum++) //select starting row here
                {
                    Oil oil = new Oil();
                    var row = myWorksheet.Cells[rowNum, 1, rowNum, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString()).ToList();
                    oil.Name = row[0];
                    oil.Price = Convert.ToDouble(row[1]);
                    oils.Add(oil);
                }
            }
        }
        private string receiptsPath;
        private void LoadProducts()
        {
            using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(@"Stats.xlsx")))
            {
                var myWorksheet = xlPackage.Workbook.Worksheets.First();
                var totalRows = myWorksheet.Dimension.End.Row;
                var totalColumns = myWorksheet.Dimension.End.Column;
                for (int rowNum = 2; rowNum <= totalRows; rowNum++) //select starting row here
                {
                    ProductStats stat = new ProductStats();
                    var row = myWorksheet.Cells[rowNum, 1, rowNum, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString()).ToList();
                    stat.Name = row[0];
                    stat.price = Convert.ToDouble(row[1]);
                    stats.Add(stat);
                }
            }
        }
        double totalIncome = 0;
        private  System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private  BindingList<Product> products = new BindingList<Product>();
        private bool isAdmin;
        public BestOil(bool admin)
        {
            LoadOil();
            LoadProducts();
            receiptsPath = "Receipts\\";
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(Language);
            InitializeComponent();
            isAdmin = admin;
            #region Oil and Prices
            comboBox1.DataSource = (from oil in oils select oil.Name).ToList();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
            textBox1.Text = (from oil in oils select oil.Price).ToList()[0].ToString();
            Price1.Text = "0,00";
            Btn_Calculate.Click += Btn_Calculate_Click;
            Price2.Text = "0,00";
            #endregion
            #region Food
            ShowProducts();
            timer.Tick += Timer_Tick;
            timer.Interval = 10000;
            #endregion
            #region Payment for oil
            Quantity.CheckedChanged += Quantity_CheckedChanged;
            Quantity.Checked = true;
            OilSum.CheckedChanged += OilSum_CheckedChanged;
            #endregion
            #region Style
            textBox1.KeyPress += (sender, e) => e.Handled = true;
            Picture.ImageLocation = "scrudge.jpg";
            this.FormClosing += BestOil_FormClosing;
            #endregion
            if (admin)
            {
                PriceOptions.Visible = false;
                FoodPrice1.Visible = false;
                FoodPrice2.Visible = false;
                QuantityText.Visible = false;
                SumText.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                FinalPrice.Visible = false;
                Station.Size = new Size(300, 279);
                Cafe.Size = new Size(340, 279);
                this.Size = new Size(814, 450);
                panel2.Visible = true;
                panel3.Visible = true;
                chooseReceiptsLocationToolStripMenuItem.Visible = false;
            }
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            double res = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].CheckBox_Enable.Checked)
                {
                    res += (double)products[i].Amount.Value * products[i].Stats.price;
                }

            }
            Price2.Text = String.Format("{0:0.00}", res);
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].CheckBox_Enable == check)
                {
                    products[i].Amount.Enabled = check.Checked;
                    Numeric_ValueChanged(sender, e);
                    break;
                }
            }
        }

        private void BestOil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save("Oils.xlsx", oils);
            Save("Stats.xlsx", stats);
            timer.Stop();
            if(!isAdmin && label9.Text != "0.00") MessageBox.Show($"Загальна виручка за день: {totalIncome} грн", "BestOil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            double res;
            if (OilSum.Checked)
            {
                res = Convert.ToDouble(SumText.Text) + Convert.ToDouble(Price2.Text);
            }
            else
            {
                res = Convert.ToDouble(Price1.Text) + Convert.ToDouble(Price2.Text);
            }
            totalIncome += res;
            label9.Text = String.Format("{0:0.00}", res);
            if (!timer.Enabled)
            {
                timer.Start();
            }
            Directory.CreateDirectory(receiptsPath);
            using (FileStream stream =new FileStream(receiptsPath + DateTime.Now.ToString().Replace(':','.') +".txt",FileMode.Create,FileAccess.Write,FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(stream, Encoding.Default))
                {
                    if (QuantityText.Text != "") sw.WriteLine($"Taken {comboBox1.SelectedText} {QuantityText.Text} litres for {double.Parse(textBox1.Text) * double.Parse(QuantityText.Text)} hryvnyas");
                    else sw.WriteLine($"Taken {comboBox1.SelectedText} {double.Parse(SumText.Text) / double.Parse(textBox1.Text)} litres for {SumText.Text} hryvnyas");
                    List<Product> takenProductsList = (from pr in products where pr.CheckBox_Enable.Checked select pr).ToList();
                    if (takenProductsList.Count != 0)
                    {
                        foreach (Product product in takenProductsList)
                        {
                            sw.WriteLine($"Taken {product.Amount.Value} {product.Stats.Name} for {(double)product.Amount.Value * double.Parse(product.TextBox_Price.Text)} hryvnyas");
                        }
                    }
                    sw.WriteLine($"Total income: {label9.Text} hryvnyas");
                    sw.Close();
                }
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Хочете очистити форму?", "BestOil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                timer.Stop();
                comboBox1.SelectedIndex = 0;
                Quantity.Checked = false;
                OilSum.Checked = false;
                QuantityText.Text = "";
                SumText.Text = "";
                Price1.Text = "0,00";
                foreach (var item in products)
                {
                    item.Amount.Value = 0;
                    item.Amount.Enabled = false;
                    item.CheckBox_Enable.Checked = false;
                }
                //checkBox1.Checked = false;
                //checkBox2.Checked = false;
                //checkBox3.Checked = false;
                //checkBox4.Checked = false;
                //txtbox5.Text = "0";
                //txtbox6.Text = "0";
                //txtbox7.Text = "0";
                //txtbox8.Text = "0";
                label9.Text = "0.00";
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.DataSource == null) return;
            textBox1.Text = (from oil in oils select oil.Price).ToList()[comboBox1.SelectedIndex].ToString();
            if (Quantity.Checked)
            {
                var temp = QuantityText.Text;
                QuantityText.Text = "";
                QuantityText.Text = temp;
            }
            else if (OilSum.Checked)
            {
                var temp = SumText.Text;
                SumText.Text = "";
                SumText.Text = temp;
            }
        }

        private void OilSum_CheckedChanged(object sender, EventArgs e)
        {
            if (OilSum.Checked)
            {
                FoodPrice2.Text = "До видачі:";
                label5.Text = "л.";
                QuantityText.Enabled = false;
                SumText.Enabled = true;
            }
        }

        private void Quantity_CheckedChanged(object sender, EventArgs e)
        {
            if (Quantity.Checked)
            {
                FoodPrice2.Text = "До оплати:";
                label5.Text = "грн.";
                QuantityText.Enabled = true;
                SumText.Enabled = false;
            }
        }
        private void SumText_TextChanged(object sender, EventArgs e)
        {
            if (SumText.Text == "")
            {
                return;
            }
            try
            {
                if (Convert.ToDouble(SumText.Text) < 0)
                {
                    SumText.Text = "0";
                }
            }
            catch (Exception)
            {
                SumText.Text = "";
                return;
            }
            QuantityText.Text = (Convert.ToDouble(SumText.Text) / Convert.ToDouble(textBox1.Text)).ToString();
            Price1.Text = QuantityText.Text;
        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {
            if (QuantityText.Text == "")
            {
                return;
            }
            try
            {
                if (Convert.ToDouble(QuantityText.Text) < 0)
                {
                    QuantityText.Text = "0";
                }
            }
            catch (Exception)
            {
                QuantityText.Text = "";
                return;
            }
            Price1.Text = String.Format("{0:0.00}", Convert.ToDouble(QuantityText.Text) * Convert.ToDouble(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Language);
            if (form.ShowDialog() == DialogResult.OK)
            {
                oils.Add(new Oil() { Name = form.ProductName, Price = form.Price });
            }
            comboBox1.DataSource = null;
            comboBox1.DataSource = (from oil in oils select oil.Name).ToList();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = comboBox1.SelectedIndex;
            if(MessageBox.Show($"Видалити {oils.ElementAt(ind).Name}?","Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                oils.RemoveAt(ind);
            }
            comboBox1.DataSource = null;
            comboBox1.DataSource = (from oil in oils select oil.Name).ToList();
            comboBox1.SelectedIndex = 0;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Language);
            if (form.ShowDialog() == DialogResult.OK)
            {
                stats.Add(new ProductStats() { Name = form.ProductName, price = form.Price });
            }
            ShowProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Product> checkedProducts = (from pr in products where pr.CheckBox_Enable.Checked select pr).ToList();
            if (checkedProducts.Count == 0)
            {
                MessageBox.Show("Select some products first");
                return;
            }
            if (MessageBox.Show("Do you want to delete the selected item(s)?","Caution",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            foreach (var item in checkedProducts)
            {
                stats.RemoveAt(products.IndexOf(item));
                products.Remove(item);

            }
            ShowProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Language);
            form.ProductName = comboBox1.SelectedItem as string;
            form.Price = double.Parse(textBox1.Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                oils[comboBox1.SelectedIndex].Name = form.ProductName;
                oils[comboBox1.SelectedIndex].Price = form.Price;
                comboBox1.DataSource = null;
                comboBox1.DataSource = (from oil in oils select oil.Name).ToList();
                comboBox1.SelectedIndex = 0;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<Product> checkedProducts = (from pr in products where pr.CheckBox_Enable.Checked select pr).ToList();
            if (checkedProducts.Count != 1)
            {
                MessageBox.Show("Can only edit one product at a time");
                return;
            }
            AddEditForm form = new AddEditForm(Language);
            form.ProductName = checkedProducts[0].Stats.Name;
            form.Price = checkedProducts[0].Stats.price;
            if (form.ShowDialog() == DialogResult.OK)
            {
                int ind = products.IndexOf(checkedProducts[0]);
                products[ind].Stats.Name = form.ProductName;
                products[ind].Stats.price = form.Price;
                stats[ind].Name = form.ProductName;
                stats[ind].price = form.Price;
            }
            ShowProducts();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Language == "uk-UK")
            {
                return;
            }
            Language = "uk-UK";
            Settings.Default.Language = Language;
            Settings.Default.Save();
                BestOil form = new BestOil(isAdmin);
                form.Show();
                this.Close();

        }

        private void englsihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Language == "en-EN")
            {
                return;
            }
            Language = "en-EN";
            Settings.Default.Language = Language;
            Settings.Default.Save();
            BestOil form = new BestOil(isAdmin);
            form.Show();
            this.Close();
        }

        private void chooseReceiptsLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                receiptsPath = folderBrowserDialog1.SelectedPath + "\\";
            }
        }
    }

    class ProductStats
    {
        public string Name { get; set; }
        public double price { get; set; }

    }
    class Product
    {
        public ProductStats Stats { get; set; }
        public CheckBox CheckBox_Enable { get; set; }
        public TextBox TextBox_Price { get; set; }
        public NumericUpDown Amount { get; set; }
    }
    class Oil
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
