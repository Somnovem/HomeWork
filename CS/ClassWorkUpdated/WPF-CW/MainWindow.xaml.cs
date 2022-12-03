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
            int newSize = (int)(this.Width + this.Height);
            TextResult.FontSize = 0.04 * newSize;
            SidePanel.Width = 0.2 * newSize;
            SidePanel.Visibility = (Width > 600) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void Button_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((Button)sender).FontSize = 0.015 * (int)(this.Width + this.Height);
            Window_SizeChanged(null, null);
        }
        private void ExtraButton_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((Button)sender).FontSize = 0.011 * (int)(this.Width + this.Height);
        }

        private void buttonStats_Click(object sender, RoutedEventArgs e)
        {
            buttonStats.FontStyle = FontStyles.Italic;
            buttonHistory.FontStyle = FontStyles.Normal;
        }

        private void buttonHistory_Click(object sender, RoutedEventArgs e)
        {
            buttonStats.FontStyle = FontStyles.Normal;
            buttonHistory.FontStyle = FontStyles.Italic;
        }
    }
}
