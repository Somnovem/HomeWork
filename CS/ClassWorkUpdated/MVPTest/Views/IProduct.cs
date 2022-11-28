using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Views
{
    internal interface IProduct
    {
        decimal Count { get; set; }
        string PriceText { get; set; }
        string CostText { get; set; }
    }
}
