using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilProgram
{
    public partial class AddEditForm : Form
    {
        public string ProductName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public double Price 
        {
            get {return double.Parse(textBox2.Text); }
            set { textBox2.Text = Convert.ToString(value); } 
        }
        public AddEditForm(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
