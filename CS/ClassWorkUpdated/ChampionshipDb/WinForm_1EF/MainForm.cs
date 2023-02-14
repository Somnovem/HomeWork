using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinForm_1EF
{
    public partial class MainForm : Form
    {
        private ChampionshipDbEntities1 dbEntities;
        public MainForm()
        {
            InitializeComponent();
            dbEntities = new ChampionshipDbEntities1();
            dgvSearch.ReadOnly = true;
            dgvQueries.ReadOnly = true;
            dgvControls.ReadOnly = true;
            dgvControls.MultiSelect = false;
            dgvControls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateControlsView();
        }

        ////////////////////////////////////////////////////////////
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSearchName.Text))
                return;
            dgvSearch.DataSource = dbEntities.Teams.Where(u => u.Name == edSearchName.Text).ToList();
        }

        private void btnSearchCity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSearchCity.Text))
                return;
            dgvSearch.DataSource = dbEntities.Teams.Where(u=>u.City == edSearchCity.Text).ToList();
        }

        private void btnSearchNameCity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSearchCity.Text) || string.IsNullOrEmpty(edSearchName.Text))
                return;
            dgvSearch.DataSource = dbEntities.Teams.Where(u => u.City == edSearchCity.Text && u.Name == edSearchName.Text).ToList();
        }

        ////////////////////////////////////////////////////////////


        private void btnShowMaxWins_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u=>u.Wins).Take(1).ToList();
        }

        private void btnShowMaxLosses_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u => u.Losses).Take(1).ToList();
        }

        private void btnShowMaxTies_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u => u.Ties).Take(1).ToList();
        }

        private void btnShowMaxGoalsScored_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u => u.GoalsScored).Take(1).ToList();
        }

        private void btnShowMaxGoalsMissed_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u => u.GoalsMissed).Take(1).ToList();
        }

        ////////////////////////////////////////////////////////////

        private async void UpdateControlsView()
        {
            dgvControls.DataSource = null;
            await SaveDatabase();
            dgvControls.DataSource = dbEntities.Teams.ToList();
        }

        private async Task<int> SaveDatabase()
        {
            try
            {
                await dbEntities.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't save to database : {ex.Message}");
                throw;
            }
            return 1;
        }
        
        private void btnTeamAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTeamName.Text) || string.IsNullOrEmpty(edTeamCity.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }

            if (dbEntities.Teams.Count(u => u.Name == edTeamName.Text && u.City == edTeamCity.Text) != 0)
            {
                MessageBox.Show("Such team already exists!");
                return;
            }

            Teams team = new Teams()
            {
            Name = edTeamName.Text,
            City = edTeamCity.Text,
            Wins = (int)edNumWins.Value,
            Losses = (int)edNumLosses.Value,
            Ties = (int)edNumTies.Value,
            GoalsScored = (int)edNumGoalsScored.Value,
            GoalsMissed = (int)edNumGoalsMissed.Value,
            };
            btnTeamAdd.Enabled = false;
            try
            {
                dbEntities.Teams.Add(team);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnTeamAdd.Enabled = true;
            }
            UpdateControlsView();
        }

        private void btnTeamSave_Click(object sender, EventArgs e)
        {
            if (dgvControls.SelectedRows.Count == 0)
                return;
            Teams team = dgvControls.SelectedRows[0].DataBoundItem as Teams;
            if (team == null)
                return;
            team.Name = edTeamName.Text;
            team.City = edTeamCity.Text;
            team.Wins = (int)edNumWins.Value;
            team.Losses = (int)edNumLosses.Value;
            team.Ties = (int)edNumTies.Value;
            team.GoalsScored = (int)edNumGoalsScored.Value;
            team.GoalsMissed = (int)edNumGoalsMissed.Value;
            UpdateControlsView();
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTeamName.Text) || string.IsNullOrEmpty(edTeamCity.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            Teams team = dbEntities.Teams.Where(u => u.Name == edTeamName.Text && u.City == edTeamCity.Text).ToArray()[0];
            if (team == null)
            {
                MessageBox.Show("No such team found!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            dbEntities.Teams.Remove(team);
            UpdateControlsView();
        }

        private void btnTeamUpdate_Click(object sender, EventArgs e)
        {
            UpdateControlsView();
        }

        private void dgvControls_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControls.SelectedRows.Count == 0)
                return;
            Teams team = dgvControls.SelectedRows[0].DataBoundItem as Teams;
            if (team == null)
                return;
            edTeamName.Text = team.Name;
            edTeamCity.Text = team.City;
            edNumWins.Value = team.Wins;
            edNumLosses.Value = team.Losses;
            edNumTies.Value = team.Ties;
            edNumGoalsScored.Value = team.GoalsScored;
            edNumGoalsMissed.Value = team.GoalsMissed;
        }
    }
}
