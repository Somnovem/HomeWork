using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    internal class Contact
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
