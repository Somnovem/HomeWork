using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW
{
    public partial class BestOil : Form
    {
        List<string> names = new List<string> { "A-76", "A-92" , "A-95" , "Дизель" , "Газ","A-44", "A-80" };
        List<double> prices = new List<double> { 6.40, 7.80, 9.00, 5.00, 3.46, 5.65, 7.15 };
        double totalIncome = 0;
        Timer timer = new Timer();
        public BestOil()
        {
            InitializeComponent();
            #region Oil and Prices
            comboBox1.DataSource = names;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
            textBox1.Text = prices[0].ToString();
            Price1.Text = "0,00";
            Btn_Calculate.Click += Btn_Calculate_Click;
            #endregion

            #region Food
            txtbox1.Text = "4,00";
            txtbox2.Text = "5,40";
            txtbox3.Text = "7,20";
            txtbox4.Text = "4,40";
            txtbox5.Text = "0";
            txtbox6.Text = "0";
            txtbox7.Text = "0";
            txtbox8.Text = "0";
            txtbox5.Enabled = false;
            txtbox6.Enabled = false;
            txtbox7.Enabled = false;
            txtbox8.Enabled = false;
            Price2.Text = "0,00";
            #endregion

            #region Payment for oil
            Quantity.CheckedChanged += Quantity_CheckedChanged;
            OilSum.CheckedChanged += OilSum_CheckedChanged;
            QuantityText.Enabled = false;
            SumText.Enabled = false;
            #endregion

            #region Quantity of food
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox4_CheckedChanged;
            txtbox5.TextChanged += Txt_TextChanged;
            txtbox6.TextChanged += Txt_TextChanged;
            txtbox7.TextChanged += Txt_TextChanged;
            txtbox8.TextChanged += Txt_TextChanged;
            #endregion

            #region Style
            textBox1.KeyPress += (sender, e) => e.Handled = true;
            txtbox1.KeyPress += (sender, e) => e.Handled = true;
            txtbox2.KeyPress += (sender, e) => e.Handled = true;
            txtbox3.KeyPress += (sender, e) => e.Handled = true;
            txtbox4.KeyPress += (sender, e) => e.Handled = true;
            Picture.ImageLocation = "scrudge.jpg";
            this.FormClosing += BestOil_FormClosing;
            #endregion
        }

        private void BestOil_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                timer.Interval = 10000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to clear the form?", "BestOil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                timer.Stop();
                comboBox1.SelectedIndex = 0;
                Quantity.Checked = false;
                OilSum.Checked = false;
                QuantityText.Text = "";
                SumText.Text = "";
                Price1.Text = "0,00";
                Price2.Text = "0,00";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                txtbox5.Text = "0";
                txtbox6.Text = "0";
                txtbox7.Text = "0";
                txtbox8.Text = "0";
                label9.Text = "";
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = prices[comboBox1.SelectedIndex].ToString();
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

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32((sender as TextBox).Text) < 0)
                {
                    (sender as TextBox).Text = "0";
                }
            }
            catch (Exception)
            {
                (sender as TextBox).Text = "";
                return;
            }
            double res = 0;
            if (checkBox1.Checked)
            {
                res += Convert.ToInt32(txtbox5.Text) * Convert.ToDouble(txtbox1.Text);
            }
            if (checkBox2.Checked)
            {
                res += Convert.ToInt32(txtbox6.Text) * Convert.ToDouble(txtbox2.Text);
            }
            if (checkBox3.Checked)
            {
                res += Convert.ToInt32(txtbox7.Text) * Convert.ToDouble(txtbox3.Text);
            }
            if (checkBox4.Checked)
            {
                res += Convert.ToInt32(txtbox8.Text) * Convert.ToDouble(txtbox4.Text);
            }
            Price2.Text = String.Format("{0:0.00}",res);
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                txtbox8.Enabled = true;
            }
            else
            {
                txtbox8.Enabled = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                txtbox7.Enabled = true;
            }
            else
            {
                txtbox7.Enabled = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtbox6.Enabled = true;
            }
            else
            {
                txtbox6.Enabled = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtbox5.Enabled = true;
            }
            else
            {
                txtbox5.Enabled = false;
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
}
