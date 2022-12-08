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
        BindingList<Contact> contacts = new BindingList<Contact>();
        string numberPattern = "^[\\+][0-9]{9}$";

        private void RefreshList()
        {
            contactList.ItemsSource = null;
            contactList.ItemsSource = contacts;
        }
        public MainWindow()
        {
            InitializeComponent();
            LoadContacts();
            contactList.ItemsSource = contacts;
            contactList.Background = null;
        }
        private void LoadContacts()
        {
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
                        contacts.Add(temp);
                    }
                }
            }
        }
        private void SaveContacs()
        {
            using (Stream stream = new FileStream("contacts.txt",FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    foreach (Contact contact in contacts)
                    {
                        sw.WriteLine(contact.Firstname);
                        sw.WriteLine(contact.Lastname);
                        sw.WriteLine(contact.Phone);
                        sw.WriteLine(contact.Tag);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            contacts[contactList.SelectedIndex].Firstname = textFirstname.Text;
            contacts[contactList.SelectedIndex].Lastname = textLastname.Text;
            contacts[contactList.SelectedIndex].Phone = textPhone.Text;
            contacts[contactList.SelectedIndex].Tag = textTag.Text;
            RefreshList();
        }

        private void contactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (contactList.ItemsSource != null && contactList.SelectedIndex > -1)
            {
                contactInfo.DataContext = contacts[contactList.SelectedIndex];
                if (!btnSave.IsEnabled) btnSave.IsEnabled = true;
                if (!btnDelete.IsEnabled) btnDelete.IsEnabled = true;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            contacts.Add(new Contact() {Firstname = "No info",Lastname = "No info", Phone = "No info" ,Tag = "No info" });
            RefreshList();
            contactList.SelectedIndex = contacts.Count - 1;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            contacts.RemoveAt(contactList.SelectedIndex);
            if (contactList.SelectedIndex > -1)
            {
                contactList.Items.RemoveAt(contactList.SelectedIndex);
                contactList.SelectedIndex = 0;
                RefreshList();
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            SaveContacs();
        }

        private void textPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            textPhone.Text = new string(textPhone.Text.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
