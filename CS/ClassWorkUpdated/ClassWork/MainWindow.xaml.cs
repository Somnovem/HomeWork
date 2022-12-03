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

namespace ClassWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    txt1.Text = txt1.Text + " sender: " + $" {sender} \n";
        //    txt1.Text += $"source: {e.Source}\n\n";
        //}

        //private void RepeatButton_Click(object sender, RoutedEventArgs e)
        //{
        //    txt1.Text += "D";
        //}

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyboardDevice.Modifiers & ModifierKeys.Control) == ModifierKeys.Control &&
            (e.KeyboardDevice.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt &&
             e.Key == Key.P)
            {
                MessageBox.Show("Success");
            }
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBlock.Text += e.ChangedButton.ToString();
        }
    }
}
