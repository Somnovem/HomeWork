using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW
{
    public partial class Main : Form
    {
        Label label = new Label();
        Label count = new Label();
        int record = 0;
        public Main()
        {
            this.BackColor = Color.LawnGreen;
            label.Text = "Catch Me";
            label.BackColor = Color.Aquamarine;
            label.Size = new Size(100, 30);
            label.Location = new Point(400, 225);
            label.MouseEnter += Label_MouseEnter;
            label.Click += Label_Click;
            label.Font = new Font(FontFamily.GenericSerif,16);
            this.Controls.Add(label);
            count.Size = new Size(120, 30);
            count.Location = new Point(40, 10);
            count.Font = new Font(FontFamily.GenericSerif, 16);
            this.Controls.Add(count);
            InitializeComponent();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            count.Text = $"Clicked:{++record}";
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            label.Location = new Point(random.Next(0, this.Width - 100), random.Next(0, this.Height - 80));
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left");
            }
        }
    }
}
