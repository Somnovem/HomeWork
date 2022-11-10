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
    public partial class ClassWork : Form
    {
        BindingList<string> months = new BindingList<string> { "November", "January", "February" };
        public ClassWork()
        {
            InitializeComponent();
            
            listBox2.DataSource = months;
            comboBox1.Items.AddRange(new string[]{ "November", "January", "February"});
            comboBox1.BackColor = Color.White;
            comboBox1.Text = "Selected";
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            toolTip2.SetToolTip(textBox1, "Dynamic");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                foreach (var item in listBox1.SelectedItems)
                {
                        listBox2.Items.Add(item);
                }
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                while (listBox1.SelectedItems.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[0]);
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
            }
        }

        private void Lister_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            months.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
