using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPTest.Models;
using MVPTest.Views;
namespace MVPTest.Presenters
{
    internal class ProductPresenter
    {
        IProduct productView;
        public ProductPresenter(IProduct prod)
        {
            productView = prod;
        }
        public void Cost()
        {
            Product product = new Product();
            product.Price = Double.Parse(productView.PriceText);
            product.Count = productView.Count;
            productView.CostText = product.Cost().ToString();
            
        }
    }
}
