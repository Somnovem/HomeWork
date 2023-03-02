using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (args == null || args.Length != 5)
            {
                edMathResult.Text = "0+0=0";
                edFilesResult.Text = "0";
            }
            else
            {
                decimal num1 = Convert.ToDecimal(args[0]);
                decimal num2 = Convert.ToDecimal(args[2]);
                char sign = args[1][0];
                decimal res = 0m;
                
                switch (sign)
                {
                    case '+':
                        res = num1 + num2;
                        break;
                    case '-':
                        res = num1 - num2;
                        break;
                    case '*':
                        res = num1 * num2;
                        break;
                    case '/':
                        res = num1 / num2;
                        break;
                    case '^':
                        res = (decimal)Math.Pow((double)num1, (double)num2);
                        break;
                    default:
                        break;
                }
                edMathResult.Text = $"{num1} {sign} {num2} = {res}";
                
                string path = args[3];
                if (path != "0")
                {
                    string fileName = args[4];
                    int count = Directory.EnumerateFiles(path).Where(p => p.Contains(fileName)).Count();
                    var subdirectories = Directory.EnumerateDirectories(path);
                    foreach (var directory in subdirectories)
                    {
                        try
                        {
                            count += Directory.EnumerateFiles(directory).Where(p => p.Contains(fileName)).Count();
                        }
                        catch
                        {
                            // do nothing(error - access denied )
                        }

                    }
                    edFilesResult.Text = $"{count}";
                }
                else
                {
                    edFilesResult.Text = "0";
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
