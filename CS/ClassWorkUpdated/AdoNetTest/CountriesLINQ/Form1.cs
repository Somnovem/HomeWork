using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesLINQ
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source = (local)\sqlexpress;Initial Catalog = CountriesDb;Integrated Security = true";
        private DataContext dbContext;
        private Table<Country> countries;
        public Form1()
        {
            InitializeComponent();
            dbContext = new DataContext(connectionString);
            countries = dbContext.GetTable<Country>();
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = from row in dbContext.GetTable<Country>() select row;
        }

        private void btnShowAllNames_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = dbContext.GetTable<Country>().Select(u => new { Name = u.Name}).ToList();
        }

        private void btnShowAllCapitals_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = dbContext.GetTable<Country>().Select(u => new { Capital = u.Capital }).ToList();
        }

        private void btnShowEuropeNames_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            var table = from u in dbContext.GetTable<Country>()
                        where u.Continent == "Europe"
                        select new { Name = u.Name };
            dgv.DataSource = table;
        }

        private void btnAreaBigger_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            var table = from u in dbContext.GetTable<Country>()
                        where u.Area > edAreaBigger.Value
                        select new { Name = u.Name };
            dgv.DataSource = table;
        }

        private void btnShowCountriesAU_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            var table = from u in dbContext.GetTable<Country>()
                        where (u.Name.Contains("a") || u.Name.Contains("A")) && (u.Name.Contains("u") || u.Name.Contains("U"))
                        select new { Name = u.Name };
            dgv.DataSource = table;
        }

        private void btnShowCountriesA_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            var table = from u in dbContext.GetTable<Country>()
                        where u.Name.Contains("a") || u.Name.Contains("A")
                        select new { Name = u.Name };
            dgv.DataSource = table;
        }

        private void btnShowCountriesRanged_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            var table = from u in dbContext.GetTable<Country>()
                        where u.Area > edRangeStart.Value && u.Area < edRangeEnd.Value
                        select new { Name = u.Name };
            dgv.DataSource = table;
        }

        private void btnShowCountriesPopulationMore_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            var table = from u in dbContext.GetTable<Country>()
                        where u.Population > edPopultaionBigger.Value
                        select new { Name = u.Name };
            dgv.DataSource = table;
        }

        private void btnTop5Area_Click(object sender, EventArgs e)
        {
            dgv.DataSource = dbContext.GetTable<Country>()
                .Select(u => new { Name = u.Name, Area = u.Area })
                .OrderByDescending(u => u.Area)
                .Take(5)
                .ToList();
        }

        private void btnTop5Population_Click(object sender, EventArgs e)
        {
            dgv.DataSource = dbContext.GetTable<Country>()
                .Select(u => new { Name = u.Name, Population = u.Population })
                .OrderByDescending(u => u.Population)
                .Take(5)
                .ToList();
        }

        private void btnMaxArea_Click(object sender, EventArgs e)
        {
            dgv.DataSource = dbContext.GetTable<Country>()
                             .Select(u => new { Name = u.Name, Area = u.Area })
                             .OrderByDescending(u => u.Area)
                             .Take(1)
                             .ToList();
        }

        private void btnMaxPopulation_Click(object sender, EventArgs e)
        {
            dgv.DataSource = dbContext.GetTable<Country>()
                            .Select(u => new { Name = u.Name, Population = u.Population })
                            .OrderByDescending(u => u.Population)
                            .Take(1)
                            .ToList();
        }

        private void btnMinAreaAfrica_Click(object sender, EventArgs e)
        {
            dgv.DataSource = dbContext.GetTable<Country>()
                 .Select(u => new { Name = u.Name, Area = u.Area,Continent = u.Continent})
                 .OrderBy(u => u.Area)
                 .Take(1)
                 .Where(u=>u.Continent == "Africa")
                 .ToList();
        }

        private void btnAvgAreaAsia_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Average population in Asia");
            dt.Rows.Add((from c in dbContext.GetTable<Country>() where c.Continent == "Asia" select c.Area).Average());
            dgv.DataSource =dt;

        }
    }
}
