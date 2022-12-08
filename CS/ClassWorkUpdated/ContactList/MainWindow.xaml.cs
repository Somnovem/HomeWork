using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ContactRepository contactRepository;
        public MainWindow()
        {
            contactRepository = new ContactRepository();
            InitializeComponent();
            contactList.Background = null;
            ObjectDataProvider provider = new ObjectDataProvider();
            provider.ObjectInstance = contactRepository;
            provider.MethodName = "GetContacts";
            Binding binding = new Binding() { Source = provider };
            contactList.SetBinding(ListBox.ItemsSourceProperty, binding);
        }
        static public BindingList<Contact> LoadContacts()
        {
            BindingList<Contact> res = new BindingList<Contact>();
            using (Stream stream = new FileStream("contacts.txt",FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    while (!sr.EndOfStream)
                    {
                        Contact temp = new Contact();
                        temp.Firstname = sr.ReadLine();
                        temp.Lastname = sr.ReadLine();
                        temp.Phone = sr.ReadLine();
                        temp.Tag = sr.ReadLine();
                        res.Add(temp);
                    }
                }
            }
            return res;
        }
        private void SaveContacts()
        {
            using (Stream stream = new FileStream("contacts.txt",FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    foreach (Contact contact in contactRepository.GetContacts())
                    {
                        sw.WriteLine(contact.Firstname);
                        sw.WriteLine(contact.Lastname);
                        sw.WriteLine(contact.Phone);
                        sw.WriteLine(contact.Tag);
                    }
                }
            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var rep = contactRepository.GetContacts();
            rep.Add(new Contact() {Firstname = "No info",Lastname = "No info", Phone = "No info" ,Tag = "No info" });
            contactList.SelectedIndex = rep.Count - 1;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (contactList.SelectedIndex == -1) return;
            int id = contactList.SelectedIndex;
            contactRepository.GetContacts().RemoveAt(id);
            if (id > 0)
            {
                contactList.SelectedIndex = id - 1;
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            SaveContacts();
        }

        private void textPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            textPhone.Text = new string(textPhone.Text.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
