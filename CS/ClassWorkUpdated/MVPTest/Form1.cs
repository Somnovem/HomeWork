using MVPTest.Views;
using MVPTest.Presenters;
namespace MVPTest
{
    public partial class Form1 : Form,IProduct
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal Count { get => numCount.Value; set => numCount.Value = value; }
        public string PriceText { get => txtPrice.Text; set => txtPrice.Text = value; }
        public string CostText { get => lblCost.Text; set => lblCost.Text = value; }

        private void btnCost_Click(object sender, EventArgs e)
        {
            ProductPresenter presenter = new ProductPresenter(this);
            presenter.Cost();
        }
    }
}