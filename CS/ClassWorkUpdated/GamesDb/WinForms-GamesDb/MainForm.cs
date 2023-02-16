using GamesDbEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_GamesDb
{
    public partial class MainForm : Form
    {
        GamesDb db;
        public MainForm()
        {
            InitializeComponent();
            db = new GamesDb();
            dgvStandart.ReadOnly = true;
            dgvStandart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStandart.AutoGenerateColumns = false;
            UpdateStandart();
        }
        private void UpdateStandart()
        {
            dgvStandart.DataSource = null;
            dgvStandart.DataSource = db.Games.ToList();

        }
        //---------------------------------------------------------------------------------------
        private void btnNumSinglePlayer_Click(object sender, EventArgs e)
        {
            int num = db.Games.Where(x => x.SinglePlayer == true).Count();
            dgvQueries.DataSource = null;
        }
        private void btnNumMultiPlayer_Click(object sender, EventArgs e)
        {
            int num = db.Games.Where(x => x.SinglePlayer == false).Count();
            dgvQueries.DataSource = null;
        }

        private void btnShowMaxSoldOfStyle_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = db.Games.Where(x => x.Style == edQueriesStyle.Text)
                                    .OrderByDescending(x => x.CopiesSold).Take(1).ToList();
        }

        private void btnShowTop5MaxSoldOfStyle_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = db.Games.Where(x => x.Style == edQueriesStyle.Text)
                                    .OrderByDescending(x => x.CopiesSold).Take(5).ToList();
        }

        private void btnShowTop5MinSoldOfStyle_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = db.Games.Where(x => x.Style == edQueriesStyle.Text)
                                    .OrderBy(x => x.CopiesSold).Take(5).ToList();
        }

        private void btnSearchGame_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = db.Games.Where(x => x.Name == edQueriesName.Text)
                                    .ToList();
        }

        private void btnMostProductiveStudioPerStyle_Click(object sender, EventArgs e)
        {
            dgvQueries.DataSource = null;
            dgvQueries.DataSource = db.Games.GroupBy(x => x.Style).Count();
        }


        //---------------------------------------------------------------------------------------


        private void dgvControlGames_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnGameAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnGameDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnGameUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnGameSave_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------
    }
}
