using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Binding
{
    internal class UserData
    {
        private static int ids = 1;
        public UserData()
        {
            UserId = ids;
            Name = $"user {ids}";
            Login = $"login {ids}";
            Birth = DateTime.Now;
            ids++;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public DateTime Birth { get; set; }
        public override string ToString()
        {
            return $"{UserId}){Name} ({Login}) , {Birth.ToShortDateString()}";
        }
    }
}
