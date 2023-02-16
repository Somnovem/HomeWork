using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonesDb
{
    public partial class MainForm : Form
    {
        PhonesDbContext db;
        public MainForm()
        {
            db = new PhonesDbContext();
            InitializeComponent();
            if(db.manufacturers.Count() == 0) FillTempData();
            UpdateView();
        }
        private void FillTempData()
        {
            List<Manufacturer> mans = new List<Manufacturer>();
            for (int i = 1; i < 6; i++)
            {
                Manufacturer m = new Manufacturer()
                {
                    Fullname = $"M{i}",
                    Country = $"C{i}",
                    Owner = $"O{i}",
                    Capital = 10000*i,
                };
                mans.Add(m);
            }
            db.manufacturers.AddRange(mans);
            int j = 1;
            foreach (Manufacturer m in mans)
            {
                Phone phone = new Phone() 
                {
                Name = $"P{j}",
                MemorySize = (decimal)16.25* j,
                Color = ((ConsoleColor)j).ToString(),
                Release = DateTime.Now,
                OSName = $"OS{j++}",
                Manufacturer = m
                };
                db.Phones.Add(phone);
            }
            db.SaveChanges();
        }
        private void UpdateView()
        {
            dgvManufacturers.DataSource = null;
            dgvManufacturers.DataSource = db.manufacturers.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            UpdateView();
        }

        private void dgvManufacturers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvManufacturers.SelectedRows.Count == 0) return;
            Manufacturer m = dgvManufacturers.SelectedRows[0].DataBoundItem as Manufacturer;
            if (m == null) return;
            //dgvPhones.DataSource = m.Phones?.ToList();
            dgvPhones.DataSource = db.Phones.Where(p => p.ManufacturerId == m.Id).ToList();
        }
    }
}
