using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    internal class Product
    {
        public double Price { get; set; }
        public decimal Count { get; set; }
        public decimal Cost() => ((decimal)Price * Count);
    }
}
