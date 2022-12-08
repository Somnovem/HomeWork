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

namespace WPF_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserData user;
        int ids = 1;
        List<UserData> users = new List<UserData>();
        public MainWindow()
        {
            user = new UserData();
            InitializeComponent();
            userGrid.DataContext = user;
            users.Add(user);
            users.Add(user);
            users.Add(user);
            listUserData.ItemsSource = users;
            //Binding b = new Binding("Value");
            //Binding b1 = new Binding();
            //b.ElementName = "slider";
            //b1.Path = new PropertyPath("Value");
            //b1.ElementName = "slider";
            //text.SetBinding(TextBlock.FontSizeProperty,b1);
        }

        //private void btnClear_Click(object sender, RoutedEventArgs e)
        //{
        //    BindingOperations.ClearBinding(text,TextBlock.TextProperty);
        //    text.Text = "Cleared";
        //}
    }
}
