using Microsoft.Win32;
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

namespace WpfAppGraphics
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

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button == null)
            {
                return;
            }
            switch (button.Content.ToString())
            {
                case "Open":
                    OpenFileDialog dlg = new OpenFileDialog();
                    if (dlg.ShowDialog() == true)
                    {
                        mp.Source = new Uri(dlg.FileName);
                    }
                    break;
                case "Play":
                    mp.Play();
                    break;
                case "Pause":
                    mp.Pause();
                    break;
                default:
                    break;
            }


        }

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mp.Volume = e.NewValue/100;
        }

        private void mp_Loaded(object sender, RoutedEventArgs e)
        {
            backBorder.Background = Brushes.LightCoral;
        }

        private void mp_MediaEnded(object sender, RoutedEventArgs e)
        {
            mp.Position = new TimeSpan();
        }
    }
}
