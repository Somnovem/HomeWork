using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1Server
{
    internal class UserStats
    {
        public int RequestsRemaining { get; set; }
        public DateTime LastRequest { get; set; }
    }
}
