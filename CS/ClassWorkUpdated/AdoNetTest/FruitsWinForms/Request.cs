using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsWinForms
{
    public partial class Request : Form
    {
        public static string strAnswer;
        public Request(string requestText)
        {
            InitializeComponent();
            edRequestText.Text = requestText;
            edRequestText.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (edAnswer.Text == "") return;
            strAnswer = edAnswer.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
