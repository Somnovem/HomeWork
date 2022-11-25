using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW
{
    public partial class Currency : Form
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        public Currency()
        {
            InitializeComponent();
            List<string> images = Directory.GetFiles(@"unedited\", "*.jpg").ToList();
            List<string> names = new List<string>();
            images = images.OrderBy(x => x).ToList();
            for (int i = 0; i < images.Count; i++)
            {
                names.Add(images[i].Substring(images[i].LastIndexOf("\\") + 1));
                names[i] = names[i].Substring(0, names[i].LastIndexOf('.'));
            }
            listView1.View = View.Tile;
            imageList1.ImageSize = new Size(32, 32);
            listView1.LargeImageList = imageList1;
            listView2.View = View.Tile;
            listView2.LargeImageList = imageList1;
            int count = 0;
            for (int i = 0; i < names.Count; i++)
            {
                ListViewItem listItem1 = new ListViewItem();
                listItem1.ImageIndex = count++;
                imageList1.Images.Add(new Bitmap(images[i]));
                listItem1.Text = names[i];
                listItem1.Font = new Font("Italic", 14, FontStyle.Regular);
                listView1.Items.Add(listItem1);
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            Label_Result.Text = "0p";
            listView1.SelectedItems.Clear();
            result.Clear();
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var items = new List<ListViewItem>();
            items.Add((ListViewItem)e.Item);
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (!items.Contains(item))
                {
                    items.Add(item);
                }
                
            }
            listView1.DoDragDrop(items, DragDropEffects.Copy);
        }

        private void listView2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                foreach (ListViewItem item in items)
                {

                    listView2.Items.Add(item.Clone() as ListViewItem);
                    string currency = listView2.Items[listView2.Items.Count - 1].Text;
                    string number = "";
                    int i = 0;
                    while (System.Char.IsDigit(currency[i]))
                    {
                        number += currency[i++];
                    }
                    if (result.ContainsKey(currency.Substring(number.Length)))
                    {
                        result[currency.Substring(number.Length)] += Convert.ToInt32(number);

                    }
                    else
                    {
                        result.Add(currency.Substring(number.Length), Convert.ToInt32(number));
                    }
                }
                string res = "";
                foreach (KeyValuePair<string,int> item in result)
                {
                    res += item.Value + " " + item.Key + " ";
                }
                Label_Result.Text = res;
            }
        }
    }
}
