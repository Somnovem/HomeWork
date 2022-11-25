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

namespace WF_CW
{
    public partial class GDL : Form
    {
        public GDL()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = this.CreateGraphics();
            g.TranslateTransform(200, 100);
            Pen pen = new Pen(Brushes.Aquamarine, 5);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            g.DrawEllipse(pen, 50, 50, 200, 100);
        }


        private void GDL_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Rectangle rect = new Rectangle() { X = 0, Y = 0, Width = 816, Height = 50 };
            //LinearGradientBrush lg = new LinearGradientBrush(rect,Color.Coral,Color.Orchid,LinearGradientMode.Horizontal);
            //g.FillRectangle(lg, new Rectangle() {Width = this.Width, Height = this.Height});

            //Rectangle r1 = new Rectangle() { X = 0, Y = 20, Width = 816, Height = 50 };
            //HatchBrush hb = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Green);
            //g.FillRectangle(hb, r1);

            //Rectangle r2 = new Rectangle() { X = 200, Y = 200, Width = 500, Height = 200 };
            //TextureBrush tb = new TextureBrush(new Bitmap(@"C:\Users\Artem\Documents\GitHub\HomeWork\CS\ClassWorkUpdated\WF-CW\img\scrudge.png"),WrapMode.Tile);
            //g.FillRectangle(tb, r2);

            //g.DrawString("Hello World!", new Font("Impact",20,FontStyle.Italic),Brushes.Tomato,new Point(350,20));
            //Rectangle r1 = new Rectangle(40, 40, 150, 150);
            //Rectangle r2 = new Rectangle(100, 100, 150, 150);
            //Region reg1 = new Region(r1);
            //Region reg2 = new Region(r2);
            //g.DrawRectangle(Pens.Tomato,r1);
            //g.DrawRectangle(Pens.BlueViolet,r2);

            //reg1.Intersect(reg2);
            //reg1.Exclude(reg2);
            //reg1.Union(reg2);
            //reg1.Xor(reg2);
            //reg1.Complement(reg2);


            ////g.FillRegion(Brushes.Coral, reg1);
            //g.Dispose();
        }
    }
}
