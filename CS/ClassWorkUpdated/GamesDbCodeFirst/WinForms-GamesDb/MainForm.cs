using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCodeFirstGamesDb;
namespace WinForms_GamesDb
{
    public partial class MainForm : Form
    {
        GamesDb db;
        public MainForm()
        {
            InitializeComponent();
            db = new GamesDb();
            ApplyDataGridSettings();
            UpdateStandart();
            UpdateGamesView();
            UpdateStudiosView();
        }
        private void UpdateStandart()
        {
            dgvStandart.DataSource = null;
            dgvStandart.DataSource = db.Games.ToList();
        }
        private void ApplyDataGridSettings()
        {
            dgvStandart.ReadOnly = true;
            dgvStandart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStandart.AutoGenerateColumns = false;

            dgvQueries.ReadOnly = true;
            dgvQueries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvControlGames.ReadOnly = true;
            dgvControlGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlGames.AutoGenerateColumns = false;
            dgvControlGames.MultiSelect = false;

            dgvControlStudios.ReadOnly = true;
            dgvControlStudios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlStudios.AutoGenerateColumns = false;
            dgvControlStudios.MultiSelect = false;
        }
        //---------------------------------------------------------------------------------------
        private void ClearDgv()
        {
            dgvQueries.Columns.Clear();
            dgvQueries.DataSource = null;
        }
        private void btnNumSinglePlayer_Click(object sender, EventArgs e)
        {
            int num = db.Games.Where(x => x.SinglePlayer).Count();
            ClearDgv();
            dgvQueries.ColumnCount = 1;
            dgvQueries.Columns[0].Name = "Number";
            dgvQueries.Rows.Add($"{num}");
        }
        private void btnNumMultiPlayer_Click(object sender, EventArgs e)
        {
            int num = db.Games.Where(x => !x.SinglePlayer).Count();
            ClearDgv();
            dgvQueries.ColumnCount = 1;
            dgvQueries.Columns[0].Name = "Number";
            dgvQueries.Rows.Add($"{num}");
        }

        private void btnShowMaxSoldOfStyle_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvQueries.DataSource = db.Games.Where(x => x.Style == edQueriesStyle.Text)
                                    .OrderByDescending(x => x.CopiesSold).Take(1).ToList();
        }

        private void btnShowTop5MaxSoldOfStyle_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvQueries.DataSource = db.Games.Where(x => x.Style == edQueriesStyle.Text)
                                    .OrderByDescending(x => x.CopiesSold).Take(5).ToList();
        }

        private void btnShowTop5MinSoldOfStyle_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvQueries.DataSource = db.Games.Where(x => x.Style == edQueriesStyle.Text)
                                    .OrderBy(x => x.CopiesSold).Take(5).ToList();
        }

        private void btnSearchGame_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvQueries.DataSource = db.Games.Where(x => x.Name == edQueriesName.Text)
                                    .ToList();
        }

        private void btnMostProductiveStudioPerStyle_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvQueries.ColumnCount = 3;
            dgvQueries.Columns[0].Name = "Studio";
            dgvQueries.Columns[1].Name = "Style";
            dgvQueries.Columns[2].Name = "Count";
            foreach (Studio studio in db.Studios)
            {
                IGrouping<string, Game> temp = db.Games.Where(s => s.StudioId == studio.Id).GroupBy(s => s.Style).OrderByDescending(s => s.Count()).Take(1).ToArray()[0];
                dgvQueries.Rows.Add(studio.Name,temp.Key,temp.Count());
            }
        }


        //---------------------------------------------------------------------------------------

        private void UpdateGamesView(bool save = false)
        {
            dgvControlGames.DataSource = null;
            if(save) db.SaveChanges();
            dgvControlGames.DataSource = db.Games.ToList();
        }
        private void dgvControlGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlGames.SelectedRows.Count == 0)
                return;
            Game game = dgvControlGames.SelectedRows[0].DataBoundItem as Game;
            if (game == null)
                return;
            edGameDescr.Text = game.Description;
            edGameName.Text = game.Name;
            edGameRelease.Value = game.Release;
            edGameSold.Value = game.CopiesSold;
            edGameStyle.Text = game.Style;
            cbGameSingleplayer.Checked = game.SinglePlayer;
        }
        private void btnGameAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edGameName.Text) || string.IsNullOrEmpty(edGameStyle.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            if (db.Games.Count(u => u.Name == edGameName.Text && u.Style == edGameStyle.Text) != 0)
            {
                MessageBox.Show("Such game already exists!");
                return;
            }

            Studio studio = db.Studios.Where(s => s.Id == (int)edGameStudioId.Value).ToArray()[0];

            if(studio == null)
            {
                MessageBox.Show("No such studio found!");
                return;
            }
            Game game = new Game()
            {
                Name = edGameName.Text,
                Style = edGameStyle.Text,
                Description = edGameDescr.Text,
                CopiesSold = (int)edGameSold.Value,
                Release = edGameRelease.Value,
                SinglePlayer = cbGameSingleplayer.Checked,
                Studio = studio
            };
            btnGameAdd.Enabled = false;
            try
            {
                db.Games.Add(game);
                UpdateGamesView(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnGameAdd.Enabled = true;
            }

        }

        private void btnGameDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edGameName.Text) || string.IsNullOrEmpty(edGameStyle.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            Game game = db.Games.Where(u => u.Name == edGameName.Text && u.Style == edGameStyle.Text).ToArray()[0];
            if (game == null)
            {
                MessageBox.Show("No such game found!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            db.Games.Remove(game);
        }

        private void btnGameUpdate_Click(object sender, EventArgs e)
        {
            UpdateGamesView();
        }

        private void btnGameSave_Click(object sender, EventArgs e)
        {
            if (dgvControlGames.SelectedRows.Count == 0)
                return;
            Game game = dgvControlGames.SelectedRows[0].DataBoundItem as Game;
            if (game == null)
                return;
            Studio studio = db.Studios.Where(s => s.Id == (int)edGameStudioId.Value).ToArray()[0];
            if (studio == null)
            {
                MessageBox.Show("No such studio found!");
                return;
            }
            game.Name = edGameName.Text;
            game.Release = edGameRelease.Value;
            game.Style = edGameStyle.Text;
            game.Studio = studio;
            game.Description = edGameDescr.Text;
            game.CopiesSold = (int)edGameSold.Value;
            game.SinglePlayer = cbGameSingleplayer.Checked;
            UpdateGamesView(true);
        }
        //---------------------------------------------------------------------------------------
        private void UpdateStudiosView(bool save = false)
        {
            dgvControlStudios.DataSource = null;
            if (save) db.SaveChanges();
            dgvControlStudios.DataSource = db.Studios.ToList();
        }
        private void btnStudiosAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edStudioName.Text) || string.IsNullOrEmpty(edStudioCity.Text) || string.IsNullOrEmpty(edStudioCountry.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            if (db.Studios.Count(u => u.Name == edStudioName.Text) != 0)
            {
                MessageBox.Show("Such studio already exists!");
                return;
            }
            Studio studio = new Studio()
            {
                Name = edStudioName.Text,
                Country = edStudioCountry.Text,
                City = edStudioCity.Text
            };
            btnStudiosAdd.Enabled = false;
            try
            {
                db.Studios.Add(studio);
                UpdateStudiosView(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                btnStudiosAdd.Enabled = true;
            }
        }

        private void btnStudiosDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edStudioName.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            Studio studio = db.Studios.Where(u => u.Name == edStudioName.Text).ToArray()[0];
            if (studio == null)
            {
                MessageBox.Show("No such studio found!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            db.Studios.Remove(studio);
            UpdateStudiosView(true);
        }

        private void btnStudiosUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudiosView();
        }

        private void btnStudiosSave_Click(object sender, EventArgs e)
        {
            if (dgvControlStudios.SelectedRows.Count == 0)
                return;
            Studio studio = dgvControlStudios.SelectedRows[0].DataBoundItem as Studio;
            if (studio == null)
                return;
            studio.City = edStudioCity.Text;
            studio.Country = edStudioCountry.Text;
            studio.Name = edStudioName.Text;
            UpdateStudiosView(true);
        }

        private void dgvControlStudios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvControlStudios.SelectedRows.Count == 0)
                return;
            Studio studio = dgvControlStudios.SelectedRows[0].DataBoundItem as Studio;
            if (studio == null)
                return;
            edStudioCity.Text = studio.City;
            edStudioCountry.Text = studio.Country;
            edStudioName.Text = studio.Name;
        }

    }
}
