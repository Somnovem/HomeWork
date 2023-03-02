using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_1Child
{
    public partial class MainFormChild : Form
    {
        public MainFormChild(string[] args)
        {
            InitializeComponent();
            if (args == null || args.Length != 2)
            {
                edMathResult.Text = "0+0=0";
                edFilesResult.Text = "0";
            }
            else
            {
                edMathResult.Text = args[0];
                edFilesResult.Text = args[1];
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
