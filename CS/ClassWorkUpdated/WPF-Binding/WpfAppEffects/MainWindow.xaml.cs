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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEffects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Loaded += MainWindow_Loaded;
        }

        //private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        //{
        //    DoubleAnimation animWidth = new DoubleAnimation();
        //    animWidth.From = btnAnimmed.ActualWidth;
        //    animWidth.By = 100;
        //    animWidth.Duration = TimeSpan.FromSeconds(5);
        //    animWidth.AutoReverse = true;

        //    DoubleAnimation animHeight = new DoubleAnimation();
        //    animHeight.From = btnAnimmed.ActualHeight;
        //    animHeight.By = 30;
        //    animHeight.Duration = TimeSpan.FromSeconds(3);
        //    animHeight.AutoReverse = true;
        //    btnAnimmed.BeginAnimation(Button.WidthProperty, animWidth);
        //    btnAnimmed.BeginAnimation(Button.HeightProperty, animHeight);
        //}
    }
}
