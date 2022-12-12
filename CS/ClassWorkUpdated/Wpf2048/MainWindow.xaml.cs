using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        List<Style> staticStyles;
        public MainWindow()
        {
            InitializeComponent();
            staticStyles = this.Resources.Values.Cast<Style>().ToList();
            Border border = ((Border)gridNumbers.Children[new Random().Next(0, 16)]);
            ((TextBox)border.Child).Text = "2";
            txtCurrentScore.Text = "2";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            TextBox textHolder = (TextBox)sender;
            ((Border)textHolder.Parent).Style = staticStyles[(int)Math.Log2(Convert.ToInt32(textHolder.Text)) + 4];
        }
    }
}
