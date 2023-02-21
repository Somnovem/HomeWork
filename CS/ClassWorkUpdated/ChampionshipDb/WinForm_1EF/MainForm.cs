using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EF;
using Match = EF.Match;

namespace WinForm_1EF
{
    public partial class MainForm : Form
    {
        private ChampionshipDb dbEntities;
        public MainForm()
        {
            InitializeComponent();
            dbEntities = new ChampionshipDb();

            dgvSearch.ReadOnly = true;
            dgvQueries.ReadOnly = true;
            dgvControls.ReadOnly = true;
            dgvControls.MultiSelect = false;
            dgvControls.AutoGenerateColumns = false;
            dgvControls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQueries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlMatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlMatches.ReadOnly = true;
            dgvControlMatches.MultiSelect = false;
            dgvControlMatches.AutoGenerateColumns = false;

            UpdateControlsView();
            UpdateControlMatchesView();
        }

        private void ClearQueriesView() 
        {
            dgvQueries.Columns.Clear();
            dgvQueries.DataSource = null;
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
            ClearQueriesView();
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u=>u.Wins).Take(1).ToList();
        }

        private void btnShowMaxLosses_Click(object sender, EventArgs e)
        {
            ClearQueriesView();
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u => u.Losses).Take(1).ToList();
        }

        private void btnShowMaxTies_Click(object sender, EventArgs e)
        {
            ClearQueriesView();
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u => u.Ties).Take(1).ToList();
        }

        private void btnShowMaxGoalsScored_Click(object sender, EventArgs e)
        {
            ClearQueriesView();
            dgvQueries.DataSource = dbEntities.Teams.OrderByDescending(u => u.GoalsScored).Take(1).ToList();
        }

        private void btnShowMaxGoalsMissed_Click(object sender, EventArgs e)
        {
            ClearQueriesView();
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

            Team team = new Team()
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
            Team team = dgvControls.SelectedRows[0].DataBoundItem as Team;
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
            Team team = dbEntities.Teams.Where(u => u.Name == edTeamName.Text && u.City == edTeamCity.Text).ToArray()[0];
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
            Team team = dgvControls.SelectedRows[0].DataBoundItem as Team;
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

        ////////////////////////////////////////////////////////////

        private void btnShowDiffScoredMissed_Click(object sender, EventArgs e)
        {
            ClearQueriesView();
            dgvQueries.ColumnCount = 2;
            dgvQueries.Columns[0].Name = "Team";
            dgvQueries.Columns[1].Name = "Difference";
            foreach (Team team in dbEntities.Teams)
            {
                dgvQueries.Rows.Add(team.Name, team.GoalsScored - team.GoalsMissed);
            }
        }

        private void btnShowMatch_Click(object sender, EventArgs e)
        {
            ClearQueriesView();
            dgvQueries.DataSource = dbEntities.Matches.ToList();
        }

        private void btnShowMatchOnDate_Click(object sender, EventArgs e)
        {
            ClearQueriesView();
            dgvQueries.DataSource = dbEntities.Matches.Where(m=>m.DateOfMatch == edQueryDate.Value).ToList();
        }

        private void btnShowMatchesOfTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edQueryName.Text))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }
            Team team = dbEntities.Teams.Where(t => t.Name == edQueryName.Text).ToArray()[0];
            if (team == null)
            {
                MessageBox.Show("No such team found!");
                return;
            }
            ClearQueriesView();
            int id = team.Id;
            dgvQueries.DataSource = (from m in dbEntities.Matches
                                     where m.Team1Id == id || m.Team2Id == id
                                     select new { Team1Id = m.Team1Id, Team2Id = m.Team2Id, Date = m.DateOfMatch, GoalsScoredTeam1 = m.GoalsScoredTeam1, GoalsScoredTeam2 = m.GoalsScoredTeam2 }
                                     ).ToList();
        }

        private void btnShowPlayersScoredOnDate_Click(object sender, EventArgs e)
        {
            List<Match> matches = dbEntities.Matches.Where(m => m.DateOfMatch == edQueryDate.Value).ToList();
            if (matches.Count == 0)
            {
                MessageBox.Show("No matches on INPUT date");
                return;
            }
            ClearQueriesView();
            dgvQueries.ColumnCount = 5;
            dgvQueries.Columns[0].Name = "Lastname";
            dgvQueries.Columns[1].Name = "Firstname";
            dgvQueries.Columns[2].Name = "Country";
            dgvQueries.Columns[3].Name = "Number";
            dgvQueries.Columns[4].Name = "Position";
            foreach (Match match in matches)
            {
                foreach (Player player in match.PlayersWhoScored)
                {
                    dgvQueries.Rows.Add(player.Lastname, player.Firstname, player.Country, player.Number, player.Position);
                }
            }
        }

        ////////////////////////////////////////////////////////////

        private void UpdateControlMatchesView(bool save = false)
        {
            dgvControlMatches.DataSource = null;
            if (save) dbEntities.SaveChanges();
            dgvControlMatches.DataSource = dbEntities.Matches.ToList();
        }
        private void btnMatchesAdd_Click(object sender, EventArgs e)
        {
            if (dbEntities.Matches.Where(u => u.Team1Id == edMatchTeam1.Value && u.Team2Id == edMatchTeam2.Value && u.DateOfMatch == edMatchDate.Value).Count() != 0)
            {
                MessageBox.Show("Such match already exists");
                return;
            }
            Match match = new Match()
            { 
            Team1Id = (int)edMatchTeam1.Value,
            Team2Id = (int)edMatchTeam2.Value,
            GoalsScoredTeam1 = (int)edMatchGoals1.Value,
            GoalsScoredTeam2 = (int)edMatchGoals2.Value,
            DateOfMatch = edMatchDate.Value
            };
            btnMatchesAdd.Enabled = false;
            try
            {
                dbEntities.Matches.Add(match);
                UpdateControlMatchesView(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnMatchesAdd.Enabled = true;
            }
        }

        private void btnMatchesDelete_Click(object sender, EventArgs e)
        {
            Match match = dbEntities.Matches.Where(u => u.Team1Id == edMatchTeam1.Value && u.Team2Id == edMatchTeam2.Value && u.DateOfMatch == edMatchDate.Value).ToArray()[0];
            if (match == null)
            {
                MessageBox.Show("No such match found!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            dbEntities.Matches.Remove(match);
            UpdateControlsView();
        }

        private void btnMatchesUpdate_Click(object sender, EventArgs e)
        {
            UpdateControlMatchesView();
        }

        private void btnMatchesSave_Click(object sender, EventArgs e)
        {
            if (dgvControlMatches.SelectedRows.Count == 0)
                return;
            Match match = dgvControlMatches.SelectedRows[0].DataBoundItem as Match;
            if (match == null)
                return;
            match.Team1Id = (int)edMatchTeam1.Value;
            match.Team2Id = (int)edMatchTeam2.Value;
            match.GoalsScoredTeam1 = (int)edMatchGoals1.Value;
            match.GoalsScoredTeam2 = (int)edMatchGoals2.Value;
            match.DateOfMatch = edMatchDate.Value;
            UpdateControlMatchesView(true);
        }

        private void dgvControlMatches_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlMatches.SelectedRows.Count == 0)
                return;
            Match match = dgvControlMatches.SelectedRows[0].DataBoundItem as Match;
            if (match == null)
                return;
            edMatchTeam1.Value  = match.Team1Id;
            edMatchTeam2.Value  = match.Team2Id;
            edMatchGoals1.Value = match.GoalsScoredTeam1;
            edMatchGoals2.Value = match.GoalsScoredTeam2;
            edMatchDate.Value = match.DateOfMatch;
        }
    }
}
