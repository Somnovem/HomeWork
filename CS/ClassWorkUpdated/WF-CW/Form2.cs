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
    public partial class Form2 : Form
    {
        public string TextForm2
        {
            get { return textBox1.Text; }
            set
            { textBox1.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formEdit = new Form3();
            //formEdit.TextEdit = textBox1.Text;
            DialogResult d = formEdit.ShowDialog(this);
            if (d == DialogResult.OK)
            {
                textBox1.Text = formEdit.TextEdit;
            }
            
        }
    }
}
