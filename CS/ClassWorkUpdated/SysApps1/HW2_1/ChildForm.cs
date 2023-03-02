using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace HW2_1
{
    public partial class ChildForm : Form
    {
        public ChildForm(string[] args)
        {
            InitializeComponent();
            if (args == null || args.Length != 2) 
            {
                Environment.Exit(4);
            }
            edMathResult.Text = args[0];
            edFilesResult.Text = args[1];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
