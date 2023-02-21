using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado9_2EF
{
    public partial class MainFormPhones : Form
    {
        PhonesDbContext phonesDb;
        public MainFormPhones()
        {
            InitializeComponent();

            phonesDb = new PhonesDbContext();

            if (phonesDb.Manufacturers.Count() == 0)
            {
                FillTemplateData();
            }
            dgvManufacturers.SelectionChanged += DgvManufacturers_SelectionChanged;
            dgvManufacturers.DataSource = phonesDb.Manufacturers.ToList();

            btnSaveChanges.Click += BtnSaveChanges_Click;
        }

        private void FillTemplateData()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            int i;
            for (i = 1; i <= 5; i++)
            {
                Manufacturer m = new Manufacturer()
                {
                    FullName = "M " + i,
                    Country = "C " + i,
                    Owner = "O " + i,
                    Capital = 10000 * i
                };
                manufacturers.Add(m);
            }

            phonesDb.Manufacturers.AddRange(manufacturers);

            i = 1;
            foreach (Manufacturer manufacturer in manufacturers)
            {
                Phone phone = new Phone()
                {
                    Name = "P " + i,
                    MemorySize = 16 * i,
                    Color = ((ConsoleColor)i).ToString(),
                    DateOfIssue = DateTime.Now,
                    OSName = "OS" + (i++).ToString(),
                    Manufacturer = manufacturer
                };
                phonesDb.Phones.Add(phone);

            }
            phonesDb.SaveChanges();
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            phonesDb.SaveChanges();
            dgvManufacturers.DataSource = null;
            dgvManufacturers.DataSource = phonesDb.Manufacturers.ToList();
        }

        private void DgvManufacturers_SelectionChanged(object sender, EventArgs e)
        {
            dgvPhones.DataSource = null;

            if (dgvManufacturers.SelectedRows.Count == 0) return;

            Manufacturer m = dgvManufacturers.SelectedRows[0].DataBoundItem as Manufacturer;

            if (m == null) return;

            //dgvPhones.DataSource = m.Phones?.ToList();
            dgvPhones.DataSource = phonesDb.Phones.Where(p => p.ManufacturerId == m.Id).ToList();
        }
    }
}