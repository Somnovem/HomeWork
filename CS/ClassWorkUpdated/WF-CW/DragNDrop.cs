using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;

namespace WF_CW
{
    public partial class DragNDrop : Form
    {
        public DragNDrop()
        {
            InitializeComponent();
        }

        private void listBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            string[] txt = listBox1.SelectedItems.Cast<string>().ToArray();
            listBox1.DoDragDrop(txt, DragDropEffects.All);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string[])))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] res = e.Data.GetData(typeof(string[])) as string[];
            foreach (var item in res)
            {
                listBox2.Items.Add(item);
            }
            if (e.Effect == DragDropEffects.Move)
            {
                foreach (var item in res)
                {
                listBox1.Items.Remove(item);
                }

            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
