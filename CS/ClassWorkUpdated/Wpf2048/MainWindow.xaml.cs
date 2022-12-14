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
        // private int GetFreeTile() return tag of tile that is empty or 0 if there is none
        //animations of moving,appearing and merging
        //funcs for every move(left,right,up,down)
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == null || staticStyles == null)
            {
                return;
            }
            TextBox textHolder = (TextBox)sender;
            if (textHolder.Text == " ")
            {
                ((Border)textHolder.Parent).Style = (Style)FindResource("borderNumberDefault");
            }
            ((Border)textHolder.Parent).Style = (Style)FindResource($"borderNumber{textHolder.Text}");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Border border = new Border();
                Border leftBorder = new Border();

                foreach (Border item in gridNumbers.Children)
                {
                    if (((TextBox)item.Child).Text != " ")
                    {
                        border = item;
                    }
                }
                ((TextBox)border.Child).Text = "4";
            }
        }
    }
}
