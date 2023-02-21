using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Ado10_1EF
{
    public partial class MainFormCore : Form
    {
        private GymDbContext db;
        public MainFormCore()
        {
            InitializeComponent();
            db = new GymDbContext();

            //dgvPerson.DataSource = db.People.ToList();
            //dgvTraining.DataSource = db.Trainings.ToList();
            dgvPerson.SelectionChanged += DgvPerson_SelectionChanged;
            dgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerson.MultiSelect = false;

            dgvTraining.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTraining.MultiSelect = false;


            dgvPerson.DataSource = new BindingList<Person>(db.People.ToList());
        }

        private void DgvPerson_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count == 0) return;
            Person? personSelected = dgvPerson.SelectedRows[0].DataBoundItem as Person;
            if (personSelected == null)
                return;
            var person = (db.People.Where(a => a.Id == personSelected.Id)).Include(b=>b.TrainingDays);//инклюд загружает св€занный обьект другого класса


            //dgvTraining.DataSource = person.FirstOrDefault()?.TrainingDays.Select(t => new { t.DateOf,t.WithTrainer}).ToList(); --только дл€ чтени€, так как анонимный обьект
            dgvTraining.DataSource = person.FirstOrDefault()?.TrainingDays.ToList();
            dgvTraining.Columns[0].Visible = false;
            dgvTraining.Columns[dgvTraining.ColumnCount-1].Visible = false;
            dgvTraining.Columns[dgvTraining.ColumnCount-2].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}