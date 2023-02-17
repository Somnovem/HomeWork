using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_ChessDb
{
    public partial class MainForm : Form
    {
        ChessChampionshipDbContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new ChessChampionshipDbContext();
            ApplyDataGridSettings();
            UpdateTournamView();
            UpdateContestantsView();
            UpdateTournContView();
            UpdateResultsView();
        }
        private void ApplyDataGridSettings()
        {
            dgvQueries.ReadOnly = true;
            dgvQueries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQueries.MultiSelect = false;

            dgvControlContestants.ReadOnly = true;
            dgvControlContestants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlContestants.AutoGenerateColumns = false;
            dgvControlContestants.MultiSelect = false;

            dgvControlTournaments.ReadOnly = true;
            dgvControlTournaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlTournaments.AutoGenerateColumns = false;
            dgvControlTournaments.MultiSelect = false;

            dgvControlTournCont.ReadOnly = true;
            dgvControlTournCont.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlTournCont.AutoGenerateColumns = false;
            dgvControlTournCont.MultiSelect = false;

            dgvControlResults.ReadOnly = true;
            dgvControlResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlResults.AutoGenerateColumns = false;
            dgvControlResults.MultiSelect = false;
        }

        private void btnFutureTournaments_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = db.Tournaments.Where(t => DateTime.Compare(t.StartDate,DateTime.Now) > 0).ToList();
        }

        private void btnShowChampions_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = (from t in db.Results
                                    join s in db.Contestants on t.WinnerId equals s.Id
                                    select new { Firstname = s.Firtsname, Lastname = s.Lastname, Rank = s.Rank, Birthdate = s.Birthdate, Country = s.Country }).ToList();

        }

        private void btnShowCurrentTournaments_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = db.Tournaments.Where(t => t.StartDate  <= DateTime.Now && t.EndDate > DateTime.Now).ToList();
        }

        private void btnWinnerOfTournament_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTournamentQueryName.Text))
                return;
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = (from t in db.Results
                                    join c in db.Tournaments on t.TournamentId equals c.Id
                                    join s in db.Contestants on t.WinnerId equals s.Id
                                    where c.Name == edTournamentQueryName.Text
                                    select new { Firstname = s.Firtsname, Lastname = s.Lastname, Rank = s.Rank, Birthdate = s.Birthdate, Country = s.Country }).ToList();
        }

        private void btnShowMaxContestants_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.ColumnCount = 2;
            dgvQueries.Columns[0].Name = "TournamentId";
            dgvQueries.Columns[1].Name = "Count";
            IGrouping<int, TournamentContestant> temp = db.TournamentContestants.GroupBy(u => u.Tournament_Id).OrderByDescending(s => s.Count()).Take(1).ToArray()[0];
            dgvQueries.Rows.Add(db.Tournaments.Where(u=>u.Id == temp.Key).ToArray()[0].Name, temp.Count());
        }
        //-----------------------------------------------------------------------------------------
        private void UpdateContestantsView(bool save = false)
        {
            dgvControlContestants.DataSource = null;
            if (save) db.SaveChanges();
            dgvControlContestants.DataSource = db.Contestants.ToList();
        }

        private void dgvControlContestants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlContestants.SelectedRows.Count == 0)
                return;
            Contestant contestant = dgvControlContestants.SelectedRows[0].DataBoundItem as Contestant;
            if (contestant == null)
                return;
            edContestantFirstname.Text = contestant.Firtsname;
            edContestantLastname.Text = contestant.Lastname;
            edContestantCountry.Text = contestant.Country;
            edContestantRank.Value = contestant.Rank;
            edContestantBirth.Value = contestant.Birthdate;
        }
        private void btnContestantsAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edContestantFirstname.Text) || string.IsNullOrEmpty(edContestantLastname.Text) || string.IsNullOrEmpty(edContestantCountry.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            if (db.Contestants.Count(u => u.Firtsname == edContestantFirstname.Text && u.Lastname == edContestantLastname.Text && u.Country == edContestantCountry.Text) != 0)
            {
                MessageBox.Show("Such contestant already exists!");
                return;
            }
            Contestant contestant = new Contestant()
            {
                Firtsname = edContestantFirstname.Text,
                Lastname = edContestantLastname.Text,
                Country = edContestantCountry.Text,
                Rank = (int)edContestantRank.Value,
                Birthdate = edContestantBirth.Value
            };
            btnContestantsAdd.Enabled = false;
            try
            {
                db.Contestants.Add(contestant);
                UpdateContestantsView(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnContestantsAdd.Enabled = true;
            }
        }

        private void btnContestantsDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edContestantFirstname.Text) || string.IsNullOrEmpty(edContestantLastname.Text) || string.IsNullOrEmpty(edContestantCountry.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            Contestant contestant = db.Contestants.Where(u => u.Firtsname == edContestantFirstname.Text && u.Lastname == edContestantLastname.Text && u.Country == edContestantCountry.Text).ToArray()[0];
            if (contestant == null)
            {
                MessageBox.Show("No such contestant found!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            db.Contestants.Remove(contestant);
            UpdateContestantsView(true);
        }

        private void btnContestantsUpdate_Click(object sender, EventArgs e)
        {
            UpdateContestantsView();
        }

        private void btnContestantsSave_Click(object sender, EventArgs e)
        {
            if (dgvControlContestants.SelectedRows.Count == 0)
                return;
            Contestant contestant = dgvControlContestants.SelectedRows[0].DataBoundItem as Contestant;
            if (contestant == null)
                return;
                contestant.Firtsname = edContestantFirstname.Text;
                contestant.Lastname = edContestantLastname.Text;
                contestant.Country = edContestantCountry.Text;
                contestant.Rank = (int)edContestantRank.Value;
                contestant.Birthdate = edContestantBirth.Value;
                UpdateContestantsView(true);
        }
        //-----------------------------------------------------------------------------------------
        private void UpdateTournamView(bool save = false)
        {
            dgvControlTournaments.DataSource = null;
            if (save) db.SaveChanges();
            dgvControlTournaments.DataSource = db.Tournaments.ToList();
        }
        private void dgvControlTournaments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlTournaments.SelectedRows.Count == 0)
                return;
            Tournament tournament = dgvControlTournaments.SelectedRows[0].DataBoundItem as Tournament;
            if (tournament == null)
                return;
            edTournamName.Text = tournament.Name;
            edTournamPrize.Value = tournament.Prize;
            edTournamStart.Value = tournament.StartDate;
            edTournamEnd.Value = tournament.EndDate;
        }
        private void btnTournamAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTournamName.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            if (db.Tournaments.Count(u => u.Name == edTournamName.Text) != 0)
            {
                MessageBox.Show("Such tournament already exists!");
                return;
            }
            if (edTournamStart.Value > edTournamEnd.Value)
            {
                MessageBox.Show("End date can't be earlier than the start!");
                return;
            }
            Tournament tournament = new Tournament()
            {
                Name = edTournamName.Text,
                Prize = edTournamPrize.Value,
                StartDate = edTournamStart.Value,
                EndDate = edTournamEnd.Value,
            };
            btnTournamAdd.Enabled = false;
            try
            {
                db.Tournaments.Add(tournament);
                UpdateTournamView(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnTournamAdd.Enabled = true;
            }
        }

        private void btnTournamDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTournamName.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            Tournament tournament = db.Tournaments.Where(u => u.Name == edTournamName.Text).ToArray()[0];
            if (tournament == null)
            {
                MessageBox.Show("No such tournament found!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            db.Tournaments.Remove(tournament);
            UpdateContestantsView(true);
        }

        private void btnTournamUpdate_Click(object sender, EventArgs e)
        {
            UpdateTournamView();
        }

        private void btnTournamSave_Click(object sender, EventArgs e)
        {
            if (dgvControlTournaments.SelectedRows.Count == 0)
                return;
            Tournament tournament = dgvControlTournaments.SelectedRows[0].DataBoundItem as Tournament;
            if (tournament == null)
                return;
            tournament.Name = edTournamName.Text;
            tournament.Prize = edTournamPrize.Value;
            tournament.StartDate = edTournamStart.Value;
            tournament.EndDate = edTournamEnd.Value;
            UpdateTournamView(true);
        }

        //-----------------------------------------------------------------------------------------
        private void UpdateTournContView(bool save = false)
        {
            dgvControlTournCont.DataSource = null;
            if (save) db.SaveChanges();
            dgvControlTournCont.DataSource = db.TournamentContestants.ToList();
        }
        private void dgvControlTournCont_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlTournCont.SelectedRows.Count == 0)
                return;
            TournamentContestant tc = dgvControlTournCont.SelectedRows[0].DataBoundItem as TournamentContestant;
            if (tc == null)
                return;
            edContId.Value = tc.Contestant_Id;
            edTournId.Value = tc.Tournament_Id;
        }
        private void btnTournContAdd_Click(object sender, EventArgs e)
        {
            if (db.TournamentContestants.Count(u => u.Tournament_Id == edTournId.Value && u.Contestant_Id == edContId.Value) != 0)
            {
                MessageBox.Show("Such entry already exists!");
                return;
            }
            TournamentContestant tc = new TournamentContestant()
            {
                    Tournament_Id = (int)edTournId.Value,
                    Contestant_Id = (int)edContId.Value
            };
            btnTournContAdd.Enabled = false;
            try
            {
                db.TournamentContestants.Add(tc);
                UpdateTournContView(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnTournContAdd.Enabled = true;
            }
        }

        private void btnTournContDelete_Click(object sender, EventArgs e)
        {
            TournamentContestant tc = db.TournamentContestants.Where(u=>u.Tournament_Id == edTournId.Value && u.Contestant_Id == edContId.Value).ToArray()[0];
            if (tc == null)
            {
                MessageBox.Show("No such entry found!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            db.TournamentContestants.Remove(tc);
            UpdateTournContView(true);
        }

        private void btnTournContUpdate_Click(object sender, EventArgs e)
        {
            UpdateTournContView();
        }

        private void btnTournContSave_Click(object sender, EventArgs e)
        {
            if (dgvControlTournCont.SelectedRows.Count == 0)
                return;
            TournamentContestant tc  = dgvControlTournCont.SelectedRows[0].DataBoundItem as TournamentContestant;
            if (tc == null)
                return;
            tc.Contestant_Id = (int)edContId.Value;
            tc.Tournament_Id = (int)edTournId.Value;
            UpdateTournContView(true);
        }

        //-----------------------------------------------------------------------------------------
        private void UpdateResultsView(bool save = false)
        {
            dgvControlResults.DataSource = null;
            if (save) db.SaveChanges();
            dgvControlResults.DataSource = db.Results.ToList();
        }
        private void dgvControlResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlResults.SelectedRows.Count == 0)
                return;
            Result result = dgvControlResults.SelectedRows[0].DataBoundItem as Result;
            if (result == null)
                return;
            edResultWinnerId.Value = result.WinnerId;
            edResultTournamentId.Value = result.TournamentId;
        }
        private void btnResultAdd_Click(object sender, EventArgs e)
        {
            if (db.Results.Count(u => u.TournamentId == edResultTournamentId.Value && u.WinnerId == edResultWinnerId.Value) != 0)
            {
                MessageBox.Show("Such result already exists!");
                return;
            }
            Result result = new Result()
            {
                TournamentId = (int)edResultTournamentId.Value,
                WinnerId = (int)edResultWinnerId.Value
            };
            btnResultAdd.Enabled = false;
            try
            {
                db.Results.Add(result);
                UpdateResultsView(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnResultAdd.Enabled = true;
            }
        }

        private void btnResultDelete_Click(object sender, EventArgs e)
        {
            Result result = db.Results.Where(u => u.TournamentId == edResultTournamentId.Value && u.WinnerId == edResultWinnerId.Value).ToArray()[0];
            if (result == null)
            {
                MessageBox.Show("No such result found!");
                return;
            }
            DialogResult res = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            db.Results.Remove(result);
            UpdateResultsView(true);
        }

        private void btnResultUpdate_Click(object sender, EventArgs e)
        {
            UpdateResultsView();
        }

        private void btnResultSave_Click(object sender, EventArgs e)
        {
            if (dgvControlResults.SelectedRows.Count == 0)
                return;
            Result result = dgvControlResults.SelectedRows[0].DataBoundItem as Result;
            if (result == null)
                return;
            result.WinnerId = (int)edResultWinnerId.Value;
            result.TournamentId = (int)edResultTournamentId.Value;
            UpdateResultsView(true);
        }
    }
}
