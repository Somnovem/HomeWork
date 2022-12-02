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

namespace WPF_CW
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

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            TextResult.FontSize = 0.04 * (int)(this.Width + this.Height);
        }

        private void Button_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((Button)sender).FontSize = 0.015 * (int)(this.Width + this.Height);
        }
        private void ExtraButton_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((Button)sender).FontSize = 0.011 * (int)(this.Width + this.Height);
        }
    }
}
