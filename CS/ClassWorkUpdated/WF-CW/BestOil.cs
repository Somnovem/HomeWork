using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW
{

    public partial class BestOil : Form
    {
        List<Oil> oils = new List<Oil>();
        List<ProductStats> stats = new List<ProductStats>();
        async private void Save<T>(string path, List<T> list)
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

        private void LoadOil()
        {
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
        Timer timer = new Timer();
        List<Product> products = new List<Product> ();
        public BestOil()
        {
            LoadOil();
            LoadProducts();
            InitializeComponent();
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

            for (int i = 0; i < stats.Count; i++)
            {
                CheckBox check = new CheckBox();
                check.Location = new Point(6, 12 + i * 28);
                check.Text = stats[i].Name;
                check.CheckedChanged += Check_CheckedChanged;

                TextBox textPrice = new TextBox();
                textPrice.Text = stats[i].price.ToString();
                textPrice.Location = new Point(109,12 + i * 28);
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
                    products[i].Amount.Enabled = check.Enabled;
                    Numeric_ValueChanged(sender, e);
                    break;
                }
            }
        }

        private void BestOil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save("Oils.xslx",oils);
            Save("Stats.xslx", stats);
            MessageBox.Show($"Tolal income for the day: {totalIncome} грн", "BestOil", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            label9.Text = String.Format("{0:0.00}",res);
            if (!timer.Enabled)
            {
                timer.Start();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to clear the form?", "BestOil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                timer = null;
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
                label9.Text = "";
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
