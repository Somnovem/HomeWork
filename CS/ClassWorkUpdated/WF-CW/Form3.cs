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
    public partial class Form3 : Form
    {
        public string TextEdit
        { 
            get{ return textBox1.Text; }
            set
            { textBox1.Text = value; } }
        public Form3()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(string t)
        {
            textBox1.Text = t;
            return ShowDialog();
        }

        public DialogResult ShowDialog(Form2 t)
        {
            this.Owner = t;
            TextEdit = t.TextForm2;
            return ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.Owner as Form2).TextForm2 = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
