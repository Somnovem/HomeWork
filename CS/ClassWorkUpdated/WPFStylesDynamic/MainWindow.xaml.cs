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

namespace WPFStylesDynamic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<string> styles  = new List<string>() {"light","dark"};
            InitializeComponent();
            
            cmbSwitchTheme.ItemsSource = styles;
            cmbSwitchTheme.SelectionChanged += CmbSwitchTheme_SelectionChanged;
            cmbSwitchTheme.SelectedItem = "dark";
        }

        private void CmbSwitchTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string style = cmbSwitchTheme.SelectedItem.ToString();
            Uri uri = new Uri(style + ".xaml",UriKind.Relative);
            //load resources
            ResourceDictionary dictionary = Application.LoadComponent(uri) as ResourceDictionary;
            //clear previous
            Application.Current.Resources.Clear();
            //apply new
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
