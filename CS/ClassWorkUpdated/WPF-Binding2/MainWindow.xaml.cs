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

namespace WPF_Binding2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookRepository bookRepository;
        public MainWindow()
        {
            bookRepository = new BookRepository();

            InitializeComponent();
            ObjectDataProvider provider = new ObjectDataProvider();
            provider.ObjectInstance = bookRepository;
            provider.MethodName = "GetBooks";
            Binding binding = new Binding();
            binding.Source = provider;
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            listBooks.SetBinding(ListBox.ItemsSourceProperty, binding);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var books = bookRepository.GetBooks();
            int id = books.Count + 1;
            books.Add(new Book() {BookId = id, Name = $"Book {id}"});
            listBooks.SelectedIndex = books.Count-1;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBooks.SelectedIndex == -1) return;
            int id = listBooks.SelectedIndex;
            bookRepository.GetBooks().RemoveAt(id);
            if (id > 0)
            {
                listBooks.SelectedIndex = id-1;
            }
        }
    }
}
