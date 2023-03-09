using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1_1
{
    public partial class MainFormProgressbars : Form
    {
        public MainFormProgressbars()
        {
            InitializeComponent();
        }
        List<ProgressBarEx> bars;
        ValueProvider provider;
        private void btnStart_Click(object sender, EventArgs e)
        {
            flpBars.Controls.Clear();
            bars = new List<ProgressBarEx>();
            Random rnd = new Random();
            for (int i = 0; i < (int)edProgressbarsCount.Value; i++)
            {
                ProgressBarEx bar = new ProgressBarEx();
                bar.Width = flpBars.Width - 25;
                bar.Height = 50;
                bar.Minimum = 1;
                bar.Maximum = 100;
                bar.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                flpBars.Controls.Add(bar);
                bars.Add(bar);
            }
            provider = new ValueProvider((int)edProgressbarsCount.Value);
            provider.ReadyToProvide += Provider_ReadyToProvide;
            provider.StartProviding();
        }

        private void Provider_ReadyToProvide(int[] arr)
        {
           Action a = () =>
           {
               for (int i = 0; i < arr.Length; i++)
               {
                   bars[i].Value = arr[i];
               }
           };
           if (InvokeRequired) Invoke(a);
           else a();
        }

        private void MainFormProgressbars_FormClosing(object sender, FormClosingEventArgs e)
        {
            provider?.Dispose();
        }

        private void flpBars_SizeChanged(object sender, EventArgs e)
        {
           for (int i = 0; i < bars.Count; i++)
           {
               bars[i].Width = flpBars.Width - 25;
           }
        }
    }




    public class ProgressBarEx : ProgressBar
    {
        public ProgressBarEx()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = null;
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);

            rec.Width = (int)((rec.Width * scaleFactor) - 4);
            rec.Height -= 4;
            brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }

}
