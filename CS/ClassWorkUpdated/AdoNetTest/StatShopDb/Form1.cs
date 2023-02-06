using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatShopDb
{
    public partial class Form1 : Form
    {
        private string connString = System.Configuration.ConfigurationManager.ConnectionStrings["StatShopDbConnection"].ConnectionString;
        SqlDataAdapter adapterProd,adapterFirms,adapterTypes,adapterSellers,adapterComplex,adapterSales;
        DataTable products,firms,types,sellers,complex,sales;
        SqlCommandBuilder cmdbProd,cmdbTypes,cmdbFirms,cmdbSellers,cmdbSales;



        public Form1()
        {
            InitializeComponent();
            adapterProd = new SqlDataAdapter("select * from Products", connString);
            adapterTypes = new SqlDataAdapter("select * from Types", connString);
            adapterFirms = new SqlDataAdapter("select * from Firms", connString);
            adapterSellers = new SqlDataAdapter("select * from Sellers", connString);
            adapterSales = new SqlDataAdapter("select * from Sales", connString);
            adapterComplex = new SqlDataAdapter("", connString);
           

            cmdbProd = new SqlCommandBuilder(adapterProd);
            cmdbTypes = new SqlCommandBuilder(adapterTypes);
            cmdbFirms = new SqlCommandBuilder(adapterFirms);
            cmdbSellers = new SqlCommandBuilder(adapterSellers);
            cmdbSales = new SqlCommandBuilder(adapterSales);

            products = new DataTable("Products");
            firms = new DataTable("Firms");
            types = new DataTable("Types");
            sellers = new DataTable("Sellers");
            complex = new DataTable("Complex");
            sales = new DataTable("Sales");

            dgvComplex.MultiSelect = false;
            dgvComplex.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComplex.ReadOnly = true;

            btnProdUpdate_Click(null, null);
            btnFirmsUpdate_Click(null, null);
            btnSellersUpdate_Click(null, null);
            btnTypesUpdate_Click(null, null);
            btnSalesUpdate_Click(null, null);
        }


        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            dgvProd.DataSource = null;
            products.Clear();
            adapterProd.Fill(products);
            dgvProd.DataSource = products;
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            adapterProd.Update(products);
            btnProdUpdate_Click(null, null);
        }

        private void btnFirmsUpdate_Click(object sender, EventArgs e)
        {
            dgvFirms.DataSource = null;
            firms.Clear();
            adapterFirms.Fill(firms);
            dgvFirms.DataSource = firms;
        }

        private void btnSalesUpdate_Click(object sender, EventArgs e)
        {
            dgvSales.DataSource = null;
            sales.Clear();
            adapterSales.Fill(sales);
            dgvSales.DataSource = sales;
        }

        private void btnSalesSave_Click(object sender, EventArgs e)
        {
            adapterSales.Update(sales);
            btnSalesUpdate_Click(null, null);
        }

        private void btnFirmsSave_Click(object sender, EventArgs e)
        {
            adapterFirms.Update(firms);
            btnFirmsUpdate_Click(null, null);
        }

        private void btnSellersSave_Click(object sender, EventArgs e)
        {
            adapterSellers.Update(sellers);
            btnSellersSave_Click(null, null);
        }

        private void btnSellersUpdate_Click(object sender, EventArgs e)
        {
            dgvSellers.DataSource = null;
            sellers.Clear();
            adapterSellers.Fill(sellers);
            dgvSellers.DataSource = sellers;
        }
        private void btnTypesUpdate_Click(object sender, EventArgs e)
        {
            dgvTypes.DataSource = null;
            types.Clear();
            adapterTypes.Fill(types);
            dgvTypes.DataSource = types;
        }

        private void btnTypesSave_Click(object sender, EventArgs e)
        {
            adapterTypes.Update(types);
            btnTypesUpdate_Click(null, null);
        }

        private void ExecSqlToComplex(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                dgvComplex.DataSource = sql;
                conn.Open();
                ClearComplex();
                adapterComplex.SelectCommand = new SqlCommand(sql,conn);
                adapterComplex.Fill(complex);
                dgvComplex.DataSource = complex;
            }

        }

        private void ClearComplex()
        {
            complex.Clear();
            complex.Columns.Clear();
        }

        
        private void btnMostSoldProducts_Click(object sender, EventArgs e)
        {
            string sql = "select S.Lastname,S.Firstname,SL.[NumberSold] from Sellers as S, (select top 1 SellerId,sum(NumberSold) as 'NumberSold' from Sales group by SellerId order by 'NumberSold' desc) as SL where S.Id = SL.SellerId";
            ExecSqlToComplex(sql);
        }
        private void btnMaximalRevenue_Click(object sender, EventArgs e)
        {
            string sql = "select S.Lastname,S.Firstname,SL.[RevenueMade] from Sellers as S, (select top 1 S.SellerId,sum(S.NumberSold*P.Price) as 'RevenueMade' from Sales as S,Products as P where S.ProductId = P.Id group by SellerId order by 'RevenueMade' desc) as SL where S.Id = SL.SellerId";
            ExecSqlToComplex(sql);
        }
        private void btnMaximalRevenueRanged_Click(object sender, EventArgs e)
        {
            string sql = "select S.Lastname,S.Firstname,SL.[RevenueMade] from Sellers as S, (select top 1 S.SellerId,sum(S.NumberSold*P.Price) as 'RevenueMade' from Sales as S,Products as P where S.ProductId = P.Id and S.SellDate between @rangestart and @rangeend group by SellerId order by 'RevenueMade' desc) as SL where S.Id = SL.SellerId";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                dgvComplex.DataSource = null;
                ClearComplex();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@rangestart", edRangeStart.Value));
                cmd.Parameters.Add(new SqlParameter("@rangeend", edRangeEnd.Value));
                adapterComplex.SelectCommand = cmd;
                adapterComplex.Fill(complex);
                dgvComplex.DataSource = complex;
            }
        }
        private void btnMostExpensiveBuy_Click(object sender, EventArgs e)
        {
            string sql = "select F.[Name],F.[Phone],F.[Country],SL.[RevenueMade] from Firms as F, (select top 1 S.FirmId,max(S.NumberSold*P.Price) as 'RevenueMade' from Sales as S,Products as P where S.ProductId = P.Id group by S.FirmId order by 'RevenueMade' desc) as SL where F.Id = SL.FirmId";
            ExecSqlToComplex(sql);
        }
        private void btnMostSoldType_Click(object sender, EventArgs e)
        {
            string sql = "select T.[Name],SL.[NumberSold] from [Types] as T, (select top 1 T.[Id],sum(S.NumberSold) as 'NumberSold' from Sales as S,Products as P,[Types] as T where S.ProductId = P.Id and P.TypeId = T.Id group by T.[Id] order by 'NumberSold' desc) as SL where T.Id = SL.Id";
            ExecSqlToComplex(sql);
        }
        private void btnMostPaidType_Click(object sender, EventArgs e)
        {
            string sql = "select T.[Name],SL.[RevenueMade] from [Types] as T, (select top 1 T.[Id],sum(S.NumberSold*P.Price) as 'RevenueMade' from Sales as S,Products as P,[Types] as T where S.ProductId = P.Id and P.TypeId = T.Id group by T.[Id] order by 'RevenueMade' desc) as SL where T.Id = SL.Id";
            ExecSqlToComplex(sql);
        }
        private void btnMostPopular_Click(object sender, EventArgs e)
        {
            string sql = "select T.[Name],SL.[NumberSold] from [Types] as T, (select top 10 P.[Id],sum(S.NumberSold) as 'NumberSold' from Sales as S,Products as P where S.ProductId = P.Id group by P.[Id] order by 'NumberSold' desc) as SL where T.Id = SL.Id";
            ExecSqlToComplex(sql);
        }
        private void btnNotSoldProducts_Click(object sender, EventArgs e)
        {
            string sql = "select * from Products where Id not in (select distinct P.Id from Products as P,Sales as S where S.ProductId = P.Id and datediff(DAY,S.SellDate,getdate()) <= @date)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                dgvComplex.DataSource = null;
                ClearComplex();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@date", (int)edDaysNumber.Value));
                adapterComplex.SelectCommand = cmd;
                adapterComplex.Fill(complex);
                dgvComplex.DataSource = complex;
            }
        }
    }
}
