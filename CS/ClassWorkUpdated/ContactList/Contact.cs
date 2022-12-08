using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class ContactRepository
    {
        BindingList<Contact> contacts = new BindingList<Contact>();
        public ContactRepository()
        {
            contacts = MainWindow.LoadContacts();
        }
        public BindingList<Contact> GetContacts() => contacts;
    }
    public class Contact
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Tag { get; set; }
        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
