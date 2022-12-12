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

namespace WpfStyles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // create brush
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.Navy, 1));
            //add to resource dictionary
            this.Resources.Add("gradientBrush", gradientBrush);

            //use static resource
            //btnOK.Background = (Brush)this.TryFindResource("gradientBrush");
            //btnOK.Background = (Brush)this.Resources["gradientBrush"];

            //use dynamic resource
            btnOK.SetResourceReference(BackgroundProperty, "gradientBrush");
            btnCancel.SetResourceReference(BackgroundProperty, "gradientBrush");
        }
    }
}
