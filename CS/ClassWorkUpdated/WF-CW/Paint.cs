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
    public partial class Paint : Form
    {
        int x, y;
        Label label1;
        List<Label> labels = new List<Label>();
        public Paint()
        {
            InitializeComponent();

        }
        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1 = new Label();
                label1.AutoSize = false;
                label1.Location = new Point(x, y);
                label1.Name = "label1";
                label1.Size = new Size(e.Location.X - x, e.Location.Y - y);
                if (label1.Size.Width < 10 && label1.Size.Height < 10)
                {
                    MessageBox.Show("Cant create a static this small", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                var temp = typeof(Color).GetProperties();
                Random random = new Random();
                label1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                label1.MouseClick += Label1_Click;
                label1.MouseDoubleClick += Label1_MouseDoubleClick;
                this.Controls.Add(label1);
                labels.Add(label1);
            }
        }
        private List<Label> GetLabelsUnderCursorSortedByTabIndex()
        {
            Point p = this.PointToClient(Cursor.Position);
            int x = p.X;
            int y = p.Y;
            List<Label> res = new List<Label>();
            foreach (var item in labels)
            {
                if (x >= item.Location.X && x <= item.Location.X + item.Width)
                {
                    if (y >= item.Location.Y && y <= item.Location.Y + item.Height)
                    {
                        res.Add(item);
                    }
                }
            }
            if (res.Count() == 0)
            {
                return null;
            }
            return res.OrderByDescending(l => l.TabIndex).ToList();
        }
        private void Label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var temp = GetLabelsUnderCursorSortedByTabIndex();
                if (temp == null)
                {
                    return;
                }
                Label biggest = temp.Last();
                this.Controls.Remove(biggest);
                labels.Remove(biggest);
            }
        }

        private void Label1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var temp = GetLabelsUnderCursorSortedByTabIndex();
                if (temp == null)
                {
                    return;
                }
                Label biggest = temp.First();
                this.Text = $"Size: {biggest.Size.Width * biggest.Size.Height}; X:= {biggest.Location.X} Y:= {biggest.Location.Y}";
            }
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.Location.X;
                y = e.Location.Y;
            }

        }
    }
}
