using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            openToolStripMenuItem.Text = Resources.Resource1.Open;
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            newToolStripMenuItem1.Click += NewToolStripMenuItem_Click;
            var dirs = Directory.GetDirectories("../");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Creation time");
            listView1.Columns.Add("Accessability");
            listView1.Columns.Add("Size");
            foreach (var dir in dirs)
            {
                listView1.Items.Add(dir);

            }

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.Filter = "All files(*.*)|(*.*)|RTF files(*.rtf)|(*.rtf)||";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = stream.ReadToEnd();
                stream.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All files(*.*)|(*.*)|RTF files(*.rtf)|(*.rtf)||";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog pg = new PrintDialog();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.DocumentName = "fileName";
            pg.Document = pd;

            if(pg.ShowDialog() == DialogResult.OK)pd.Print();
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = color.Color;
            }
        }

        int i = 0;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (i >= richTextBox1.Text.Length)
            {
                i = 0;
            }
            while (richTextBox1.Text.IndexOf("double", i) != -1) {
                i = richTextBox1.Text.IndexOf("double", i);
                richTextBox1.Select(i, 6);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.Select(richTextBox1.Text.Length, 0);
                richTextBox1.SelectionColor = Color.Black;
                i += "double".Length;
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
            }

        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
