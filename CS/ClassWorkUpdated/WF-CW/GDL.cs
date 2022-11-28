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
using System.Windows.Input;

namespace WF_CW
{
    public partial class GDL : Form
    {
        int seconds;
        int minutes;
        int hours;
        public GDL()
        {
            InitializeComponent();
            DateTime Now  = DateTime.Now;
            seconds = Now.Second;
            secondsDeg = seconds * 6;
            minutes = Now.Minute;
            minutesDeg = minutes * 6;
            hours = Now.Hour;
            hoursDeg = hours * 30;
            menuStrip1.BackColor = Color.White;
        }
        int secondsDeg = 0;
        int minutesDeg = 0;
        int hoursDeg = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            secondsDeg = 6*seconds;
            if (secondsDeg == 360)
            {
                secondsDeg = 0;
                seconds = 0;
                minutes++;
                minutesDeg = 6 * minutes;
                if (minutesDeg == 360)
                {
                    minutesDeg = 0;
                    minutes = 0;
                    hours++;
                    hoursDeg = 30 * hours;
                    if (hoursDeg == 360)
                    {
                        hoursDeg = 0;
                        hours = 0;
                    }
                }
            }
            OnPaint(null);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TranslateTransform((int)(this.Width * 0.5)-20, (int)(this.Height * 0.5)-20);
            Font textFont = new Font(FontFamily.GenericSerif, (int)(0.03 * Height));
            Brush textBrush = (BackColor == Color.White) ? Brushes.Black : Brushes.Lime;
            g.DrawString("12", textFont, textBrush, -(int)(0.025 * Width), -(int)(0.425 * Width));
            g.DrawString("1", textFont, textBrush, (int)(0.1875 * Width), -(int)(0.375 * Width));
            g.DrawString("2", textFont, textBrush, (int)(0.3375 * Width), -(int)(0.225 * Width));
            g.DrawString("3", textFont, textBrush, (int)(0.40 * Width), -(int)(0.02 * Width));
            g.DrawString("4", textFont, textBrush, (int)(0.3375 * Width), (int)(0.18 * Width));
            g.DrawString("5", textFont, textBrush, (int)(0.195 * Width), (int)(0.345 * Width));
            g.DrawString("6", textFont, textBrush, -(int)(0.015 * Width), (int)(0.40 * Width));
            g.DrawString("7", textFont, textBrush, -(int)(0.22 * Width), (int)(0.35 * Width));
            g.DrawString("8", textFont, textBrush, -(int)(0.38 * Width), (int)(0.2 * Width));
            g.DrawString("9", textFont, textBrush, -(int)(0.43 * Width), -(int)(0.02 * Width));
            g.DrawString("10", textFont, textBrush, -(int)(0.39 * Width), -(int)(0.24 * Width));
            g.DrawString("11", textFont, textBrush, -(int)(0.23 * Width), -(int)(0.39 * Width));
            {
                
                Pen clockPen = new Pen(ForeColor, 1);
                int x = (int)(0.225 * Width);
                int y = (int)(0.225 * Width);
                int deg = 0;
                Graphics clockGraphics = this.CreateGraphics();
                clockGraphics.TranslateTransform((int)(this.Width * 0.5) - 20, (int)(this.Height * 0.5) - 20);
                clockGraphics.RotateTransform(195);
                while (deg < 360)
                {
                    clockGraphics.RotateTransform(6);
                    clockGraphics.DrawLine(clockPen, x, y, x + (int)(0.025 * Width), y + (int)(0.025 * Width));
                    deg += 6;
                }
                deg = 0;
                clockPen.Width = 3;
                int hour = 0;
                while (deg <= 360)
                {
                    clockGraphics.RotateTransform(30);
                    clockGraphics.DrawLine(clockPen, x, y, x + (int)(0.0375 * Width), y + (int)(0.0375 * Width));
                    hour++;
                    deg += 30;
                }
                clockGraphics.Dispose();
            }
            g.Dispose();




            Pen arrowPen = new Pen(ForeColor, 5);
            arrowPen.StartCap = LineCap.RoundAnchor;
            arrowPen.EndCap = LineCap.ArrowAnchor;
            Graphics secondsGraphics = this.CreateGraphics();
            Graphics minutesGraphics = this.CreateGraphics();
            Graphics hoursGraphics = this.CreateGraphics();
            Graphics[] arrows = new Graphics[3] {secondsGraphics,minutesGraphics,hoursGraphics};
            foreach (var item in arrows)
            {
                item.TranslateTransform((int)(this.Width * 0.5) - 20, (int)(this.Height * 0.5) - 20);
                item.SmoothingMode = SmoothingMode.HighQuality;
            }

            secondsGraphics.RotateTransform(secondsDeg);
            secondsGraphics.DrawLine(arrowPen, 0, 0, 0, -(int)(0.225 * Width));
            secondsGraphics.Dispose();

            minutesGraphics.RotateTransform(minutesDeg);
            minutesGraphics.DrawLine(arrowPen, 0, 0, 0, -(int)(this.Width * 0.15));
            minutesGraphics.Dispose();

            hoursGraphics.RotateTransform(hoursDeg);
            hoursGraphics.DrawLine(arrowPen, 0, 0, 0, -(int)(this.Width * 0.1125));
            hoursGraphics.Dispose();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                return;
            }
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Black)
            {
                return;
            }
            this.BackColor = Color.Black;
            this.ForeColor = Color.Lime;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Lime;
        }


        private void GDL_SizeChanged(object sender, EventArgs e)
        {
            if (Width != Height)
            {
                if (Width > Height)
                {
                    Height = Width;
                }
                else
                {
                    Width = Height;
                }
            }
        }
    }
}
