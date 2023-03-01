using Dapper;
using System.Data;
using System.Data.Common;


namespace Main
{
    public partial class MainForm : Form
    {
        SaleProductsDbContext dbContext;
        IDbConnection db;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                dbContext = new SaleProductsDbContext();
                db = dbContext.dbConnection;
                MessageBox.Show("Succefully connected to the database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Coudln't connect to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Init();
        }

        private void Init()
        {
            ApplyDataGridSettings();
            UpdateControlCustomers();
            UpdateControlCountries();
            UpdateControlCities();
            UpdateControlSections();
            UpdateControlSales();
            UpdateControlProducts();
        }

        private void ApplyDataGridSettings()
        {
            List<DataGridView> views = new List<DataGridView>() { dgvQueries ,dgvControlCustomers, dgvSectionsCustomer ,
                                                                  dgvControlCountries , dgvControlCities,dgvControlSections, 
                                                                  dgvControlSales,dgvControlProducts,dgvQueries2, dgvQueries3 };
            foreach (DataGridView view in views)
            {
                view.ReadOnly = true;
                view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                view.AutoGenerateColumns = false;
                view.MultiSelect = false;
            }
        }

        private bool ExecuteQueryToView(Button btn, string sql, object param,string msg)
        {
            btn.Enabled = false;
            try
            {
                db.ExecuteAsync(sql,  param );
                MessageBox.Show(msg);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void ExecuteQuery(DataGridView dgv, string sql,List<string> columns, object param = null)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            var result =db.QueryAsync(sql, param).Result.ToList();
            for (int i = 0; i < columns.Count; i++)
            {
                dgv.Columns.Add($"colQueries1{columns[i]}", columns[i]);
                dgv.Columns[i].DataPropertyName = columns[i];
            }
            dgv.DataSource = result;
        }

        #region Queries
        private void ClearDgvInit()
        {
            if(dgvQueries.ColumnCount !=0)dgvQueries.Columns.Clear();
            dgvQueries.DataSource = null;
        }

        private void ShowUnlinkedInfo(List<string> columns,string sql) 
        {
            ClearDgvInit();
            for (int i = 0; i < columns.Count; i++)
            {
                dgvQueries.Columns.Add($"colQueries1{columns[i]}", columns[i]);
                dgvQueries.Columns[i].DataPropertyName = columns[i];
            }
            dgvQueries.DataSource = db.Query(sql).ToList();
        }
        private void btnShowAllCustomers_Click(object sender, EventArgs e)
        {
            ClearDgvInit();
            List<Customer> result = db.Query<Customer,City,Customer>("select * from Customers as c join Cities as ct on c.CityId = ct.Id", (cust, city) => { cust.City = city;return cust; }).ToList();
            dgvQueries.ColumnCount = 7;
            dgvQueries.Columns[0].Name = "Firstname";
            dgvQueries.Columns[1].Name = "Lastname";
            dgvQueries.Columns[2].Name = "Fathersname";
            dgvQueries.Columns[3].Name = "Gender";
            dgvQueries.Columns[4].Name = "Birthday";
            dgvQueries.Columns[5].Name = "City";
            dgvQueries.Columns[6].Name = "E-mail";
            foreach (Customer item in result)
            {
                dgvQueries.Rows.Add(item.Firstname,item.Lastname,item.Fathersname,item.Gender,item.Birthdate.ToShortDateString(),item.City.Name,item.Email);
            }
        }

        private void btnShowAllEmails_Click(object sender, EventArgs e)
        {
            ClearDgvInit();
            ShowUnlinkedInfo(new List<string>() { "Email"},"select Email from Customers");
        }

        private void btnShowAllSections_Click(object sender, EventArgs e)
        {
            ClearDgvInit();
            ShowUnlinkedInfo(new List<string>() { "Name" },"select Name from Sections");
        }

        private void btnShowAllSaled_Click(object sender, EventArgs e)
        {
            ClearDgvInit();
            List<Product> result = db.Query<Product, Sales,Section, Product>("select * from Products as c" +
                                                                    " join Sales as s on s.ProductId = c.Id join Sections as sec on c.SectionId = sec.Id", (cus, sal,sec) => { sal.Product = cus; cus.Section = sec; return cus;  }).ToList();
            dgvQueries.ColumnCount = 4;
            dgvQueries.Columns[0].Name = "Name";
            dgvQueries.Columns[1].Name = "Prime Cost";
            dgvQueries.Columns[2].Name = "Price";
            dgvQueries.Columns[3].Name = "Section";
            foreach (Product item in result)
            {
                dgvQueries.Rows.Add(item.Name,item.PrimeCost,item.Price,item.Section.Name);
            }
        }

        private void btnShowAllCities_Click(object sender, EventArgs e)
        {
            ClearDgvInit();
            ShowUnlinkedInfo(new List<string>() { "Name" }, "select Name from Cities");
        }

        private void btnShowAllCountries_Click(object sender, EventArgs e)
        {
            ClearDgvInit();
            ShowUnlinkedInfo(new List<string>() { "Name" }, "select Name from Countries");
        }

        private void btnShowCustomersInputCity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueriesCity.Text))
            {
                MessageBox.Show("Some impotant values were left empty");
                return;
            }

            var p = new DynamicParameters();
            p.Add("@city", edQueriesCity.Text);

            ClearDgvInit();
            List<Customer> result = db.Query<Customer, City, Customer>("select * from Customers as c join Cities as ct on c.CityId = ct.Id where ct.Name = @city", (cust, city) => { cust.City = city; return cust; },p).ToList();
            dgvQueries.ColumnCount = 7;
            dgvQueries.Columns[0].Name = "Firstname";
            dgvQueries.Columns[1].Name = "Lastname";
            dgvQueries.Columns[2].Name = "Fathersname";
            dgvQueries.Columns[3].Name = "Gender";
            dgvQueries.Columns[4].Name = "Birthday";
            dgvQueries.Columns[5].Name = "City";
            dgvQueries.Columns[6].Name = "E-mail";
            foreach (Customer item in result)
            {
                dgvQueries.Rows.Add(item.Firstname, item.Lastname, item.Fathersname, item.Gender, item.Birthdate.ToShortDateString(), item.City.Name, item.Email);
            }
        }

        private void btnShowCustomersInputCountry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueriesCountry.Text))
            {
                MessageBox.Show("Some impotant values were left empty");
                return;
            }
            var p = new DynamicParameters();
            p.Add("@country", edQueriesCountry.Text);

            ClearDgvInit();
            List<Customer> result = db.Query<Customer, City, Country,Customer>("select * from Customers as c join Cities as ct on c.CityId = ct.Id join Countries as coun on ct.CountryId = coun.Id where coun.Name = @country", (cust, city,coun) => { city.Country = coun; cust.City = city; return cust; }, p).ToList();
            dgvQueries.ColumnCount = 7;
            dgvQueries.Columns[0].Name = "Firstname";
            dgvQueries.Columns[1].Name = "Lastname";
            dgvQueries.Columns[2].Name = "Fathersname";
            dgvQueries.Columns[3].Name = "Gender";
            dgvQueries.Columns[4].Name = "Birthday";
            dgvQueries.Columns[5].Name = "City";
            dgvQueries.Columns[6].Name = "E-mail";
            foreach (Customer item in result)
            {
                dgvQueries.Rows.Add(item.Firstname, item.Lastname, item.Fathersname, item.Gender, item.Birthdate.ToShortDateString(), item.City.Name, item.Email);
            }
        }

        private void btnSalesInputCountry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueriesCountry.Text))
            {
                MessageBox.Show("Some impotant values were left empty");
                return;
            }
            var p = new DynamicParameters();
            p.Add("@country", edQueriesCountry.Text);

            ClearDgvInit();
            List<Sales> result = db.Query<Sales, Country,Product, Sales>("select * from Sales as s join Countries as c on s.CountryId = c.Id join Products as p on s.ProductId = p.Id where c.Name = @country", (s, c,p) => { s.Country = c;s.Product = p; return s; },p).ToList();
            dgvQueries.ColumnCount = 5;
            dgvQueries.Columns[0].Name = "Product";
            dgvQueries.Columns[1].Name = "Start date";
            dgvQueries.Columns[2].Name = "End date";
            dgvQueries.Columns[3].Name = "Country";
            dgvQueries.Columns[4].Name = "Sale percent";
            foreach (Sales item in result)
            {
                dgvQueries.Rows.Add(item.Product.Name,item.StartDate.ToShortDateString(),item.EndDate.ToShortDateString(),item.Country.Name,item.SalePercent);
            }
        }

        private void btnShowCititesInputCountry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueriesCountry.Text))
            {
                MessageBox.Show("Some impotant values were left empty");
                return;
            }
            var p = new DynamicParameters();
            p.Add("@country", edQueriesCountry.Text);

            ClearDgvInit();
            List<City> result = db.Query<City,Country,City>("select * from Cities as c join Countries as coun on c.CountryId = coun.Id where coun.Name = @country", (c, coun) => { c.Country = coun; return c; },p).ToList();
            dgvQueries.ColumnCount = 1;
            dgvQueries.Columns[0].Name = "Name";
            foreach (City item in result)
            {
                dgvQueries.Rows.Add(item.Name);
            }
        }

        private void btnShowSaledOfInputSection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueriesSection.Text))
            {
                MessageBox.Show("Some impotant values were left empty");
                return;
            }
            var p = new DynamicParameters();
            p.Add("@section", edQueriesSection.Text);
            string sql = @"select * from Products as p join Sections as s on p.SectionId = s.Id join Sales as sal on sal.ProductId = p.Id where s.Name = @section";
            ClearDgvInit();
            List<Product> result = db.Query<Product, Section,Sales, Product>(sql, (p, s,sal) => { p.Section = s;sal.Product = p; return p; }, p).ToList();
            dgvQueries.ColumnCount = 4;
            dgvQueries.Columns[0].Name = "Name";
            dgvQueries.Columns[1].Name = "Prime Cost";
            dgvQueries.Columns[2].Name = "Price";
            dgvQueries.Columns[3].Name = "Section";
            foreach (Product item in result)
            {
                dgvQueries.Rows.Add(item.Name, item.PrimeCost, item.Price, item.Section.Name);
            }
        }

        private void btnShowSectionsCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueryFirstname.Text) || string.IsNullOrEmpty(edQueryLastname.Text) || (cbQueryFathersname.Checked && string.IsNullOrEmpty(edQueryFathersname.Text)))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            string sql = cbQueryFathersname.Checked 
                ? 
                "select Name from Sections as s " +
                "join Interests as i on i.SectionId = s.Id " +
                "join Customers as c on i.CustomerId = c.Id where c.Firstname = @Firstname and c.Lastname = @Lastname and c.Fathersname = @Fathersname"
                :
                "select Name from Sections as s " +
                "join Interests as i on i.SectionId = s.Id " +
                "join Customers as c on i.CustomerId = c.Id where c.Firstname = @Firstname and c.Lastname = @Lastname";
            Customer customer = new Customer() { Firstname = edQueryFirstname.Text, Lastname = edQueryLastname.Text,Fathersname = edQueryFathersname.Text };
            dgvSectionsCustomer.DataSource = db.Query<Section>(sql, customer).ToList();
        }
        #endregion

        #region Customers

        private void UpdateControlCustomers()
        {
            dgvControlCustomers.DataSource = null;
            dgvControlCustomers.DataSource = db.Query<Customer>("select * from Customers").ToList();
        }
        private void btnCustomersAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edCustomersFirstname.Text) || string.IsNullOrEmpty(edCustomersLastname.Text) || string.IsNullOrEmpty(edCustomersGender.Text) || string.IsNullOrEmpty(edCustomersEmail.Text) || (cbCustomersFathersname.Checked && string.IsNullOrEmpty(edCustomersFathersname.Text)))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            Customer customer = new Customer() { Email = edCustomersEmail.Text};
            if (db.Query("select Email from Customers where Email = @Email", customer).Count() != 0)
            {
                MessageBox.Show("Such email already exists");
                return;
            }
            bool fathersnameUsed = cbCustomersFathersname.Checked;
            customer.Firstname = edCustomersFirstname.Text;
            customer.Lastname = edCustomersLastname.Text;
            if(fathersnameUsed) customer.Fathersname = edCustomersFathersname.Text;
            customer.Birthdate = edCustomersBirthdate.Value;
            customer.CityId = (int)edCustomersCityId.Value;
            customer.Gender = edCustomersGender.Text;
            string sqlInsert = fathersnameUsed
                ? "Insert into Customers(Firstname,Lastname,Fathersname,Birthdate,CityId,Gender,Email) " +
                "values(@Firstname,@Lastname,@Fathersname,@Birthdate,@CityId,@Gender,@Email)"
                : "Insert into Customers(Firstname,Lastname,Birthdate,CityId,Gender,Email) " +
                "values(@Firstname,@Lastname,@Birthdate,@CityId,@Gender,@Email)";
            if (ExecuteQueryToView(btnCustomersAdd, sqlInsert, customer, "Successfully added!")) UpdateControlCustomers();
        }

        private void dgvControlCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlCustomers.SelectedRows.Count == 0) return;
            Customer customer = dgvControlCustomers.SelectedRows[0].DataBoundItem as Customer;
            if (customer == null) return;
            edCustomersBirthdate.Value = customer.Birthdate;
            edCustomersCityId.Value = customer.CityId;
            edCustomersFathersname.Text = customer.Fathersname;
            edCustomersFirstname.Text = customer.Firstname;
            edCustomersLastname.Text = customer.Lastname;
            edCustomersGender.Text = customer.Gender;
            cbCustomersFathersname.Checked = !string.IsNullOrEmpty(customer.Fathersname);
            edCustomersEmail.Text = customer.Email;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (dgvControlCustomers.SelectedRows.Count == 0) return;
            Customer customer = dgvControlCustomers.SelectedRows[0].DataBoundItem as Customer;
            if (customer == null) return;
            var dialogResult = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;
            string sqlDelete = "Delete from Customers where Id = @Id";
            if (ExecuteQueryToView(btnCustomerDelete, sqlDelete, customer, "Successfully deleted!")) UpdateControlCustomers();

        }

        private void btnCustomersUpdate_Click(object sender, EventArgs e) => UpdateControlCustomers();

        private void btnCustomersSave_Click(object sender, EventArgs e)
        {
            if (dgvControlCustomers.SelectedRows.Count == 0) return;
            Customer customerToChange = dgvControlCustomers.SelectedRows[0].DataBoundItem as Customer;
            if (customerToChange == null) return;
            if (string.IsNullOrEmpty(edCustomersFirstname.Text) || string.IsNullOrEmpty(edCustomersLastname.Text) || string.IsNullOrEmpty(edCustomersGender.Text) || string.IsNullOrEmpty(edCustomersEmail.Text) || (cbCustomersFathersname.Checked && string.IsNullOrEmpty(edCustomersFathersname.Text)))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            Customer customer = new Customer() { Email = edCustomersEmail.Text };
            Customer customerTemp = db.Query<Customer>("select * from Customers where Email = @Email", customer).ToArray()[0];
            if (customerTemp.Id != customerToChange.Id)
            {
                MessageBox.Show("Such email already exists");
                return;
            }
            bool fathersnameUsed = cbCustomersFathersname.Checked;
            customer.Id = customerToChange.Id;
            customer.Firstname = edCustomersFirstname.Text;
            customer.Lastname = edCustomersLastname.Text;
            if (fathersnameUsed) customer.Fathersname = edCustomersFathersname.Text;
            customer.Birthdate = edCustomersBirthdate.Value;
            customer.CityId = (int)edCustomersCityId.Value;
            customer.Gender = edCustomersGender.Text;
            string sqlUpdate = fathersnameUsed ? "UPDATE Customers SET Firstname = @Firstname,Lastname = @Lastname,Fathersname = @Fathersname,Birthdate = @Birthdate,CityId = @CityId,Gender = @Gender,Email = @Email where Id = @Id"
                : "UPDATE Customers SET Firstname = @Firstname,Lastname = @Lastname,Birthdate = @Birthdate,CityId = @CityId,Gender = @Gender,Email = @Email where Id = @Id";
            if (ExecuteQueryToView(btnCustomersSave, sqlUpdate, customer, "Successfully saved!")) UpdateControlCustomers();
        }
        #endregion

        #region Countries
        private void UpdateControlCountries()
        {
            dgvControlCountries.DataSource = null;
            dgvControlCountries.DataSource = db.Query<Country>("select * from Countries").ToList();
        }
        private void btnCountriesAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edCountriesName.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            Country country = new Country() { Name = edCountriesName.Text };
            if (db.Query("select * from Countries where Name = @Name", country).Count() != 0)
            {
                MessageBox.Show("Such country already exists");
                return;
            }
            string sqlInsert = "INSERT INTO Countries(Name) VALUES(@Name)";
            if (ExecuteQueryToView(btnCountriesAdd, sqlInsert, country, "Successfully added!")) UpdateControlCountries();
        }

        private void btnCountriesDelete_Click(object sender, EventArgs e)
        {
            if (dgvControlCountries.SelectedRows.Count == 0) return;
            Country country = dgvControlCountries.SelectedRows[0].DataBoundItem as Country;
            if (country == null) return;
            var dialogResult = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;
            string sqlDelete = "Delete from Countries where Id = @Id";
            if (ExecuteQueryToView(btnCountriesDelete, sqlDelete, country, "Successfully deleted!")) UpdateControlCountries();
        }

        private void btnCountriesUpdate_Click(object sender, EventArgs e) => UpdateControlCountries();

        private void btnCountriesSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edCountriesName.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            if (dgvControlCountries.SelectedRows.Count == 0) return;
            Country countryToChange = dgvControlCountries.SelectedRows[0].DataBoundItem as Country;
            if (countryToChange == null) return;
            Country country = new Country() { Id = countryToChange.Id, Name = edCountriesName.Text };
            if (db.Query("select * from Countries where Name = @Name", country).Count() != 0)
            {
                MessageBox.Show("Such country already exists");
                return;
            }
            string sqlSave = "UPDATE Countries SET Name = @Name where Id = @Id";
            if (ExecuteQueryToView(btnCountriesSave, sqlSave, country, "Successfully saved!")) UpdateControlCountries();
        }

        private void dgvControlCountries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlCountries.SelectedRows.Count == 0) return;
            Country country = dgvControlCountries.SelectedRows[0].DataBoundItem as Country;
            if (country == null) return;
            edCountriesName.Text = country.Name;
        }

        #endregion

        #region Cities
        private void UpdateControlCities()
        {
            dgvControlCities.DataSource = null;
            dgvControlCities.DataSource = db.Query<City>("select * from Cities").ToList();
        }
        private void btnCitiesAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edCitiesName.Text)) 
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            City city = new City() { Name = edCitiesName.Text, CountryId = (int)edCitiesCountryId.Value };
            if (db.Query("select * from Countries where Id = @CountryId",  city).Count() == 0)
            {
                MessageBox.Show("No such country found!");
                return;
            }
            string sqlInsert = "Insert into Cities(Name,CountryId) values(@Name,@CountryId)";
            if (ExecuteQueryToView(btnCitiesAdd, sqlInsert, city, "Successfully added!")) UpdateControlCities();
        }

        private void btnCitiesDelete_Click(object sender, EventArgs e)
        {
            if (dgvControlCountries.SelectedRows.Count == 0) return;
            City city = dgvControlCountries.SelectedRows[0].DataBoundItem as City;
            if (city == null) return;
            var dialogResult = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;
            string sqlDelete = "DELETE FROM Cities WHERE Id = @Id";
            if (ExecuteQueryToView(btnCitiesDelete, sqlDelete, city, "Successfully deleted!")) UpdateControlCities();
        }

        private void btnCitiesUpdate_Click(object sender, EventArgs e) => UpdateControlCities();

        private void btnCitiesSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edCitiesName.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            if (dgvControlCities.SelectedRows.Count == 0) return;
            City cityToChange = dgvControlCities.SelectedRows[0].DataBoundItem as City;
            if (cityToChange == null) return;
            City city = new City() { Name = edCitiesName.Text, CountryId = (int)edCitiesCountryId.Value,Id = cityToChange.Id };
            if (db.Query("select * from Countries where Id = @CountryId", city).Count() == 0)
            {
                MessageBox.Show("No such country found!");
                return;
            }
            string sqlSave = "Update Cities Set Name = @Name,CountryId = @CountryId where Id = @Id";
            if (ExecuteQueryToView(btnCitiesSave, sqlSave, city, "Successfully saved!")) UpdateControlCities();
        }

        private void dgvControlCities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlCities.SelectedRows.Count == 0) return;
            City city = dgvControlCities.SelectedRows[0].DataBoundItem as City;
            if (city == null) return;
            edCitiesCountryId.Value = city.CountryId;
            edCitiesName.Text = city.Name;

        }
        #endregion

        #region Sections
        private void UpdateControlSections()
        {
            dgvControlSections.DataSource = null;
            dgvControlSections.DataSource = db.Query<Section>("select * from Sections").ToList();
        }
        private void dgvControlSections_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlSections.SelectedRows.Count == 0) return;
            Section section = dgvControlSections.SelectedRows[0].DataBoundItem as Section;
            if (section == null) return;
            edSectionsName.Text = section.Name;
        }
        private void btnSectionsAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSectionsName.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            Section section = new Section() { Name = edSectionsName.Text};
            if (db.Query("select Name from Sections where Name = @Name", section).Count() != 0) 
            {
                MessageBox.Show("Such section already exists");
                return;
            }
            string sqlInsert = "INSERT INTO Sections(Name) values(@Name)";
            if(ExecuteQueryToView(btnSectionsAdd,sqlInsert,section, "Successfully added!")) UpdateControlSections();
        }
        private void btnSectionsDelete_Click(object sender, EventArgs e)
        {
            if (dgvControlSections.SelectedRows.Count == 0) return;
            Section section = dgvControlSections.SelectedRows[0].DataBoundItem as Section;
            if (section == null) return;
            var dialogResult = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;
            string sqlDelete = "DELETE FROM Sections where Id = @Id";
            if (ExecuteQueryToView(btnSectionsDelete, sqlDelete, section, "Successfully deleted!")) UpdateControlSections();
        }

        private void btnSectionsUpdate_Click(object sender, EventArgs e) =>UpdateControlSections();

        private void btnSectionsSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSectionsName.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            if (dgvControlSections.SelectedRows.Count == 0) return;
            Section sectionToChange = dgvControlSections.SelectedRows[0].DataBoundItem as Section;
            if (sectionToChange == null) return;
            Section section = new Section() { Name = edSectionsName.Text ,Id = sectionToChange.Id};
            if (db.Query("select Name from Sections where Name = @Name", section).Count() != 0)
            {
                MessageBox.Show("Such section already exists");
                return;
            }
            string sqlSave = "UPDATE Sections Set Name = @Name where Id = @Id";
            if (ExecuteQueryToView(btnSectionsSave, sqlSave, section, "Successfully saved!")) UpdateControlSections();
        }


        #endregion

        #region Sales
        private void UpdateControlSales() 
        {
            dgvControlSales.DataSource = null;
            dgvControlSales.DataSource = db.Query<Sales>("select * from Sales").ToList();
        }
        private void btnSalesAdd_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales() { ProductId = (int)edSalesProductId.Value, CountryId = (int)edSalesCountryId.Value};
            if (db.Query("select Name from Countries where Id = @CountryId", sale).Count() == 0 || db.Query("select Name from Products where Id = @ProductId", sale).Count() == 0)
            {
                MessageBox.Show("No such country or product found!");
                return;
            }
            sale.SalePercent = (int)edSalesPercent.Value;
            sale.StartDate = edSalesStartDate.Value;
            sale.EndDate = edSalesEndDate.Value;
            string sqlInsert = "INSERT INTO Sales(ProductId,CountryId,SalePercent,StartDate,EndDate) values(@ProductId,@CountryId,@SalePercent,@StartDate,@EndDate)";
            if (ExecuteQueryToView(btnSalesAdd, sqlInsert, sale, "Successfully added!")) UpdateControlSales();
        }

        private void btnSalesDelete_Click(object sender, EventArgs e)
        {
            if (dgvControlSales.SelectedRows.Count == 0) return;
            Sales sale = dgvControlSales.SelectedRows[0].DataBoundItem as Sales;
            if (sale == null) return;
            var dialogResult = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;
            string sqlDelete = "DELETE FROM Sales where Id = @Id";
            if (ExecuteQueryToView(btnSalesDelete, sqlDelete, sale, "Successfully deleted!")) UpdateControlSales();
        }

        private void btnSalesUpdate_Click(object sender, EventArgs e) => UpdateControlSales();

        private void btnSalesSave_Click(object sender, EventArgs e)
        {
            if (dgvControlSales.SelectedRows.Count == 0) return;
            Sales saleToChange = dgvControlSales.SelectedRows[0].DataBoundItem as Sales;
            if (saleToChange == null) return;
            Sales sale = new Sales() { ProductId = (int)edSalesProductId.Value,CountryId = (int)edSalesCountryId.Value}; 
            if (db.Query("select Name from Countries where Id = @CountryId", sale).Count() == 0 || db.Query("select Name from Products where Id = @ProductId", sale).Count() == 0)
            {
                MessageBox.Show("No such country or product found!");
                return;
            }
            sale.SalePercent = (int)edSalesPercent.Value;
            sale.EndDate = edSalesEndDate.Value;
            sale.StartDate = edSalesStartDate.Value;
            sale.Id = saleToChange.Id;
            string sqlSave = "UPDATE Sales Set SalePercent = @SalePercent, EndDate = @EndDate, StartDate = @StartDate, ProductId = @ProductId, CountryId = @CountryId where Id = @Id";
            if (ExecuteQueryToView(btnSalesSave, sqlSave, sale, "Successfully saved!")) UpdateControlSales();
        }

        private void dgvControlSales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlSales.SelectedRows.Count == 0) return;
            Sales sale = dgvControlSales.SelectedRows[0].DataBoundItem as Sales;
            if (sale == null) return;
            edSalesCountryId.Value = sale.CountryId;
            edSalesEndDate.Value = sale.EndDate;
            edSalesStartDate.Value = sale.StartDate;
            edSalesPercent.Value = sale.SalePercent;
            edSalesProductId.Value = sale.ProductId;
        }
        #endregion

        #region Products
        private void UpdateControlProducts()
        {
            dgvControlProducts.DataSource = null;
            dgvControlProducts.DataSource = db.Query<Product>("select * from Products").ToList();
        }
        private void btnProductsAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edProductsName.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            Product product = new Product() { Name = edProductsName.Text ,SectionId = (int)edProductsSectionId.Value,Price = edProductsPrice.Value,PrimeCost = edProductsPrimeCost.Value };
            if (db.Query("select Name from Products where Name = @Name", product).Count() != 0)
            {
                MessageBox.Show("A product with such name already exists");
                return;
            }
            if (db.Query("select Name from Sections where Id = @SectionId", product).Count() == 0)
            {
                MessageBox.Show("No such section found");
                return;
            }
            string sqlInsert = "INSERT INTO Products(Name,SectionId,PrimeCost,Price) values(@Name,@SectionId,@PrimeCost,@Price)";
            if (ExecuteQueryToView(btnProductsAdd, sqlInsert, product, "Successfully added!")) UpdateControlProducts();
        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {
            if (dgvControlProducts.SelectedRows.Count == 0) return;
            Product product = dgvControlProducts.SelectedRows[0].DataBoundItem as Product;
            if (product == null) return;
            var dialogResult = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;
            string sqlDelete = "DELETE FROM Products where Id = @Id";
            if (ExecuteQueryToView(btnProductsDelete, sqlDelete, product, "Successfully deleted!")) UpdateControlProducts();
        }

        private void btnProductsUpdate_Click(object sender, EventArgs e) => UpdateControlProducts();

        private void btnProductsSave_Click(object sender, EventArgs e)
        {
            if (dgvControlProducts.SelectedRows.Count == 0) return;
            Product productToChange = dgvControlProducts.SelectedRows[0].DataBoundItem as Product;
            if (productToChange == null) return;
            if (string.IsNullOrEmpty(edProductsName.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            Product product = new Product() { Name = edProductsName.Text };
            Product productSuggested = db.Query<Product>("select * from Products where Name = @Name", product).First();
            if (productSuggested != null && productSuggested.Id != productToChange.Id)
            {
                MessageBox.Show("A product with such name already exists");
                return;
            }
            product.SectionId = (int)edProductsSectionId.Value;
            if (db.Query("select Name from Sections where Id = @SectionId", product).Count() == 0)
            {
                MessageBox.Show("No such section found");
                return;
            }
            product.Id = productToChange.Id;
            product.Price = edProductsPrice.Value;
            product.PrimeCost = edProductsPrimeCost.Value;
            string sqlSave = "UPDATE Products SET Name = @Name,SectionId = @SectionId,Price = @Price,PrimeCost = @PrimeCost where Id = @Id";
            if (ExecuteQueryToView(btnProductsSave, sqlSave, product, "Successfully saved!")) UpdateControlProducts();
        }

        private void dgvControlProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlProducts.SelectedRows.Count == 0) return;
            Product product = dgvControlProducts.SelectedRows[0].DataBoundItem as Product;
            if (product == null) return;
            edProductsName.Text = product.Name;
            edProductsPrice.Value = product.Price;
            edProductsPrimeCost.Value = product.PrimeCost;
            edProductsSectionId.Value = product.SectionId;
        }
        #endregion

        #region Queries2.0

        private void btnCustomersPerCity_Click(object sender, EventArgs e)
        {
            string sql = "select C.[Name],count(Cus.Lastname) as 'Number of customers' from Customers Cus join Cities C on Cus.CityId = C.Id group by C.[Name];";
            List<string> columns = new List<string>() { "Name", "Number of customers" };
            ExecuteQuery(dgvQueries2,sql, columns);
        }

        private void btnCustomersPerCountry_Click(object sender, EventArgs e)
        {
            string sql = "select Coun.Name,count(Cus.Lastname) as 'Number of customers' from Customers Cus join Cities C on Cus.CityId = C.Id join Countries Coun on C.CountryId = Coun.Id group by Coun.Name;";
            List<string> columns = new List<string>() { "Name", "Number of customers" };
            ExecuteQuery(dgvQueries2, sql, columns);
        }

        private void btnCitiesPerCountry_Click(object sender, EventArgs e)
        {
            string sql = "select Coun.[Name],count(C.[Name]) as 'Number of cities' from Cities C join Countries Coun on C.CountryId = Coun.Id group by Coun.Name;";
            List<string> columns = new List<string>() { "Name", "Number of cities" };
            ExecuteQuery(dgvQueries2, sql, columns);
        }

        private void btnAvgCitiesPerCountry_Click(object sender, EventArgs e)
        {
            string sql = "select avg(F.[Number of cities]) as 'Average number of cities' from(select Coun.[Name],count(C.[Name]) as 'Number of cities' from Cities C join Countries Coun on C.CountryId = Coun.Id group by Coun.Name) as F;";
            List<string> columns = new List<string>() { "Average number of cities" };
            ExecuteQuery(dgvQueries2,sql, columns);
        }

        private void btnFavouritesPerCountry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueries2Country.Text))
            {
                MessageBox.Show("Some important values were left empty");
                return;
            }
            Country country = new Country() { Name = edQueries2Country.Text };
            string sql = "select distinct S.[Name] from Sections as S join Interests as I on I.SectionId = S.Id join Customers as C on I.CustomerId = C.Id join Cities as Cit on C.CityId = Cit.Id join Countries as Coun on Cit.CountryId = Coun.Id where Coun.[Name] = @Name; ";
            List<string> columns = new List<string>() {"Name" };
            ExecuteQuery(dgvQueries2,sql, columns, country);
        }

        private void btnRangedSales_Click(object sender, EventArgs e)
        {
            if (edQueries2End.Value < edQueries2Start.Value)
            {
                MessageBox.Show("End date earlier than the start");
                return;
            }
            Sales sale = new Sales() { EndDate = edQueries2End.Value, StartDate = edQueries2Start.Value };
            string sql = "select ProductId,CountryId,SalePercent,StartDate,EndDate from Sales where StartDate >= @StartDate and EndDate <= @EndDate";
            List<string> columns = new List<string>() {"ProductId","CountryId", "SalePercent", "StartDate", "EndDate" };
            ExecuteQuery(dgvQueries2, sql,columns, sale);
        }

        private void btnSaledForCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer() { Id = (int)edQueries2Customer.Value};
            string sql = "select P.Name, P.PrimeCost, P.Price,P.SectionId from Products as P join Sections as S on P.SectionId = S.Id join Interests as I on I.SectionId = S.Id join Customers as C on I.CustomerId = C.Id where C.Id = @Id";
            List<string> columns = new List<string>() { "Name", "PrimeCost","Price","SectionId" };
            ExecuteQuery(dgvQueries2, sql,columns, customer);
        }

        private void btnTop3CountriesOnCustomers_Click(object sender, EventArgs e)
        {
            string sql = "select top 3 Coun.Name,count(Cus.Lastname) as 'Number of customers' from Customers Cus join Cities C on Cus.CityId = C.Id join Countries Coun on C.CountryId = Coun.Id group by Coun.Name order by 'Number of customers' desc;";
            List<string> columns = new List<string>() { "Name", "Number of customers" };
            ExecuteQuery(dgvQueries2, sql, columns);
        }

        private void btnTop1CountriesOnCustomers_Click(object sender, EventArgs e)
        {
            int max = db.ExecuteScalar<int>("select top 1 count(Cus.Lastname) as 'Number of customers' from Customers Cus join Cities C on Cus.CityId = C.Id join Countries Coun on C.CountryId = Coun.Id group by Coun.Name order by 'Number of customers' desc;");
            var p = new DynamicParameters();
            p.Add("@Max", max);

            string sql = "select Coun.Name,count(Cus.Lastname) as 'Number of customers' from Customers Cus  join Cities C on Cus.CityId = C.Id join Countries Coun on C.CountryId = Coun.Id group by Coun.Name having count(Cus.Lastname) = @Max;";
            List<string> columns = new List<string>() { "Name", "Number of customers" };
            ExecuteQuery(dgvQueries2, sql,columns, p);
        }

        private void btnTop3CitiesOnCustomers_Click(object sender, EventArgs e)
        {
            string sql = "select top 3 C.[Name],count(Cus.Lastname) as 'Number of customers' from Customers Cus join Cities C on Cus.CityId = C.Id group by C.[Name] order by 'Number of customers' desc;";
            List<string> columns = new List<string>() { "Name", "Number of customers" };
            ExecuteQuery(dgvQueries2, sql, columns);
        }

        private void btnTop1CitiesOnCustomers_Click(object sender, EventArgs e)
        {
            int max = db.ExecuteScalar<int>("select top 1 count(Cus.Lastname) as 'Number of customers' from Customers Cus join Cities C on Cus.CityId = C.Id group by C.[Name] order by 'Number of customers' desc;");
            var p = new DynamicParameters();
            p.Add("@Max", max);

            string sql = "select C.[Name],count(Cus.Lastname) as 'Number of customers' from Customers Cus join Cities C on Cus.CityId = C.Id group by C.[Name] having count(Cus.Lastname) = @Max;";
            List<string> columns = new List<string>() { "Name", "Number of customers" };
            ExecuteQuery(dgvQueries2, sql, columns, p);
        }
        #endregion

        #region Queries3.0
        private void btnTop3MostPopularSections_Click(object sender, EventArgs e)
        {
            string sql = "select top 3 S.[Name],count(I.[CustomerId]) as 'Number of subscribers' from Sections as S join Interests as I on I.SectionId = S.Id group by S.[Name] order by 'Number of subscribers' desc; ";
            List<string> columns = new List<string>() { "Name", "Number of subscribers" };
            ExecuteQuery(dgvQueries3, sql,columns);
        }

        private void btnTopMostPopularSections_Click(object sender, EventArgs e)
        {
            string sql = "select top 1 S.[Name],count(I.[CustomerId]) as 'Number of subscribers' from Sections as S join Interests as I on I.SectionId = S.Id group by S.[Name] order by 'Number of subscribers' desc; ";
            List<string> columns = new List<string>() { "Name", "Number of subscribers" };
            ExecuteQuery(dgvQueries3, sql,columns);
        }

        private void btnTop3MostUnpopularSections_Click(object sender, EventArgs e)
        {
            string sql = "select top 3 S.[Name],count(I.[CustomerId]) as 'Number of subscribers' from Sections as S join Interests as I on I.SectionId = S.Id group by S.[Name] order by 'Number of subscribers'; ";
            List<string> columns = new List<string>() { "Name", "Number of subscribers" };
            ExecuteQuery(dgvQueries3, sql,columns);
        }

        private void btnTopMostUnpopularSections_Click(object sender, EventArgs e)
        {
            string sql = "select top 1 S.[Name],count(I.[CustomerId]) as 'Number of subscribers' from Sections as S join Interests as I on I.SectionId = S.Id group by S.[Name] order by 'Number of subscribers'; ";
            List<string> columns = new List<string>() { "Name", "Number of subscribers" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnTop3MostPopularSectionsOnSale_Click(object sender, EventArgs e)
        {
            string sql = "select top 3 S.[Name],count(Sl.ProductId) as 'Number of products' from Sections as S join Products as P on P.SectionId = S.Id join Sales as Sl on Sl.ProductId = P.Id group by S.[Name] order by 'Number of products' desc; ";
            List<string> columns = new List<string>() { "Name", "Number of products" };
            ExecuteQuery(dgvQueries3, sql,columns);
        }

        private void btnTopMostPopularSectionsOnSale_Click(object sender, EventArgs e)
        {
            string sql = "select top 1 S.[Name],count(Sl.ProductId) as 'Number of products' from Sections as S join Products as P on P.SectionId = S.Id join Sales as Sl on Sl.ProductId = P.Id group by S.[Name] order by 'Number of products' desc; ";
            List<string> columns = new List<string>() { "Name", "Number of products" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnTop3MostUnpopularSectionsOnSale_Click(object sender, EventArgs e)
        {
            string sql = "select top 3 S.[Name],count(Sl.ProductId) as 'Number of products' from Sections as S join Products as P on P.SectionId = S.Id join Sales as Sl on Sl.ProductId = P.Id group by S.[Name] order by 'Number of products' ; ";
            List<string> columns = new List<string>() { "Name", "Number of products" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnTopMostUnpopularSectionsOnSale_Click(object sender, EventArgs e)
        {
            string sql = "select top 1 S.[Name],count(Sl.ProductId) as 'Number of products' from Sections as S join Products as P on P.SectionId = S.Id join Sales as Sl on Sl.ProductId = P.Id group by S.[Name] order by 'Number of products'; ";
            List<string> columns = new List<string>() { "Name", "Number of products" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnSaleEndsIn3Days_Click(object sender, EventArgs e)
        {
            string sql = "select P.[Name],P.Price,P.PrimeCost from Sales as Sl join Products as P on Sl.ProductId = P.Id join Sections as S on P.SectionId = S.Id where DATEDIFF(Day,Sl.EndDate,getdate()) = 3;";
            List<string> columns = new List<string>() { "Name", "Price","PrimeCost" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnSalesEnded_Click(object sender, EventArgs e)
        {
            string sql = "select P.[Name], P.Price,P.PrimeCost,SL.SalePercent,Sl.StartDate,Sl.EndDate from Sales as Sl join Products as P on Sl.ProductId = P.Id join Sections as S on P.SectionId = S.Id where getdate() > Sl.EndDate;";
            List<string> columns = new List<string>() { "Name", "Price", "PrimeCost" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnMoveExpiredSalesToArchive_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Move expired sales to archive?","Warning" ,MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var expired = db.Query("select * from Sales as Sl where getdate() > Sl.EndDate;");
            string sqlDelete = "delete from Sales where Id = @Id";
            db.Execute(sqlDelete, expired);
            string sqlInsert = "Insert into ArchiveSales(ProductId,SalePercent,StartDate,EndDate,CountryId) values(@ProductId,@SalePercent,@StartDate,@EndDate,@CountryId)";
            db.Execute(sqlInsert, expired);
        }

        private void btnAvgAgePerSection_Click(object sender, EventArgs e)
        {
            string sql = "select S.[Name],avg(DATEDIFF(YEAR,C.Birthdate,getdate())) as 'Average age' from Sections as S join Interests as I on I.SectionId = S.Id join Customers as C on I.CustomerId = C.Id group by S.[Name];";
            List<string> columns = new List<string>() { "Name", "Average age" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnAvgAgePerCity_Click(object sender, EventArgs e)
        {
            string sql = "select Ct.[Name],avg(DATEDIFF(YEAR,C.Birthdate,getdate())) as 'Average age' from Cities as Ct join Customers as C on C.CityId = Ct.Id group by Ct.[Name];";
            List<string> columns = new List<string>() { "Name", "Average age" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnAvgAgePerCountry_Click(object sender, EventArgs e)
        {
            string sql = "select Cn.[Name],avg(DATEDIFF(YEAR,C.Birthdate,getdate())) as 'Average age' from Cities as Ct join Countries as Cn on Ct.CountryId = Cn.Id join Customers as C on C.CityId = Ct.Id group by Cn.[Name];";
            List<string> columns = new List<string>() { "Name", "Average age" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void ShowPopularPerGenderNumbered(int num)
        {
            dgvQueries3.Columns.Clear();
            dgvQueries3.DataSource = null;
            var genders = from g in db.Query("select distinct Gender from Customers")
                          select g.Gender;
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();

            dc.ColumnName = "colQueries3Name";
            dc.DataType = typeof(string);
            dc.Caption = "Name";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "colQueries3Gender";
            dc.DataType = typeof(string);
            dc.Caption = "Gender";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "colQueries3Max";
            dc.DataType = typeof(Int32);
            dc.Caption = "Maxim";
            dt.Columns.Add(dc);
            foreach (string gender in genders)
            {
                var max = db.Query($"select top {num} S.[Name],C.Gender,count(distinct I.CustomerId) as 'Maxim'" +
                                             " from Sections as S" +
                                             " join Interests as I on I.SectionId = S.Id" +
                                             " join Customers as C on I.CustomerId = C.Id" +
                                             $" where C.Gender = '{gender}'" +
                                             " group by S.[Name],C.Gender" +
                                             " order by 'Maxim' desc");

                foreach (var item in max)
                {
                    dt.Rows.Add(item.Name, item.Gender, item.Maxim);
                }
            }

            foreach (DataColumn column in dt.Columns)
            {
                dgvQueries3.Columns.Add(column.ColumnName,column.Caption);
            }
            foreach (DataRow row in dt.Rows)
            {
                dgvQueries3.Rows.Add(row.ItemArray);
            }
        }

        private void btnMostPopularSectionPerGender_Click(object sender, EventArgs e)
        {
            ShowPopularPerGenderNumbered(1);
        }

        private void btnTop3MostPopularSectionPerGender_Click(object sender, EventArgs e)
        {
            ShowPopularPerGenderNumbered(3);
        }

        private void btnCustomersPerGender_Click(object sender, EventArgs e)
        {
            string sql = "select C.Gender,count(C.Gender) as 'Number of customers' from Customers as C group by C.Gender;";
            List<string> columns = new List<string>() { "Gender", "Number of customers" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }

        private void btnCustomersPerGenderPerCountry_Click(object sender, EventArgs e)
        {
            string sql = "select cn.Name,c.Gender,count(C.Gender) as 'Number of customers' from Customers as C join Cities as Ct on c.CityId = ct.Id join Countries as cn on ct.CountryId = cn.Id group by C.Gender,cn.Name;";
            List<string> columns = new List<string>() { "Name","Gender", "Number of customers" };
            ExecuteQuery(dgvQueries3, sql, columns);
        }
        #endregion
    }
}