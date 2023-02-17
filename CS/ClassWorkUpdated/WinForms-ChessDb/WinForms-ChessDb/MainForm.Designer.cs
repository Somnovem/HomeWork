namespace WinForms_ChessDb
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.edTournamentQueryName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFutureTournaments = new System.Windows.Forms.Button();
            this.btnShowChampions = new System.Windows.Forms.Button();
            this.btnShowCurrentTournaments = new System.Windows.Forms.Button();
            this.btnWinnerOfTournament = new System.Windows.Forms.Button();
            this.btnShowMaxContestants = new System.Windows.Forms.Button();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvControlContestants = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnContestantsSave = new System.Windows.Forms.Button();
            this.btnContestantsUpdate = new System.Windows.Forms.Button();
            this.btnContestantsDelete = new System.Windows.Forms.Button();
            this.btnContestantsAdd = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.edContestantFirstname = new System.Windows.Forms.TextBox();
            this.edContestantLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edContestantCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edContestantRank = new System.Windows.Forms.NumericUpDown();
            this.edContestantBirth = new System.Windows.Forms.DateTimePicker();
            this.btnTournamSave = new System.Windows.Forms.Button();
            this.btnTournamUpdate = new System.Windows.Forms.Button();
            this.btnTournamDelete = new System.Windows.Forms.Button();
            this.btnTournamAdd = new System.Windows.Forms.Button();
            this.dgvControlTournaments = new System.Windows.Forms.DataGridView();
            this.btnTournContSave = new System.Windows.Forms.Button();
            this.btnTournContUpdate = new System.Windows.Forms.Button();
            this.btnTournContDelete = new System.Windows.Forms.Button();
            this.btnTournContAdd = new System.Windows.Forms.Button();
            this.dgvControlTournCont = new System.Windows.Forms.DataGridView();
            this.btnResultSave = new System.Windows.Forms.Button();
            this.btnResultUpdate = new System.Windows.Forms.Button();
            this.btnResultDelete = new System.Windows.Forms.Button();
            this.btnResultAdd = new System.Windows.Forms.Button();
            this.dgvControlResults = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edTournamName = new System.Windows.Forms.TextBox();
            this.edTournamPrize = new System.Windows.Forms.NumericUpDown();
            this.edTournamStart = new System.Windows.Forms.DateTimePicker();
            this.edTournamEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTournamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTournamPrize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTournamStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTournamEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.edTournId = new System.Windows.Forms.NumericUpDown();
            this.edContId = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultTournId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultWinnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edResultWinnerId = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.edResultTournamentId = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.colContestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourConId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlContestants)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edContestantRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlTournaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlTournCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTournamPrize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTournId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edContId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edResultWinnerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edResultTournamentId)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.edTournamentQueryName);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.dgvQueries);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Queries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name of the tournament";
            // 
            // edTournamentQueryName
            // 
            this.edTournamentQueryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.edTournamentQueryName.Location = new System.Drawing.Point(609, 372);
            this.edTournamentQueryName.Name = "edTournamentQueryName";
            this.edTournamentQueryName.Size = new System.Drawing.Size(176, 20);
            this.edTournamentQueryName.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.Controls.Add(this.btnFutureTournaments);
            this.flowLayoutPanel1.Controls.Add(this.btnShowChampions);
            this.flowLayoutPanel1.Controls.Add(this.btnShowCurrentTournaments);
            this.flowLayoutPanel1.Controls.Add(this.btnWinnerOfTournament);
            this.flowLayoutPanel1.Controls.Add(this.btnShowMaxContestants);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(609, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(177, 335);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnFutureTournaments
            // 
            this.btnFutureTournaments.Location = new System.Drawing.Point(18, 3);
            this.btnFutureTournaments.Name = "btnFutureTournaments";
            this.btnFutureTournaments.Size = new System.Drawing.Size(145, 60);
            this.btnFutureTournaments.TabIndex = 0;
            this.btnFutureTournaments.Text = "Show future tournaments";
            this.btnFutureTournaments.UseVisualStyleBackColor = true;
            this.btnFutureTournaments.Click += new System.EventHandler(this.btnFutureTournaments_Click);
            // 
            // btnShowChampions
            // 
            this.btnShowChampions.Location = new System.Drawing.Point(18, 69);
            this.btnShowChampions.Name = "btnShowChampions";
            this.btnShowChampions.Size = new System.Drawing.Size(145, 60);
            this.btnShowChampions.TabIndex = 1;
            this.btnShowChampions.Text = "Show champions";
            this.btnShowChampions.UseVisualStyleBackColor = true;
            this.btnShowChampions.Click += new System.EventHandler(this.btnShowChampions_Click);
            // 
            // btnShowCurrentTournaments
            // 
            this.btnShowCurrentTournaments.Location = new System.Drawing.Point(18, 135);
            this.btnShowCurrentTournaments.Name = "btnShowCurrentTournaments";
            this.btnShowCurrentTournaments.Size = new System.Drawing.Size(145, 60);
            this.btnShowCurrentTournaments.TabIndex = 2;
            this.btnShowCurrentTournaments.Text = "Show ongoing tournaments";
            this.btnShowCurrentTournaments.UseVisualStyleBackColor = true;
            this.btnShowCurrentTournaments.Click += new System.EventHandler(this.btnShowCurrentTournaments_Click);
            // 
            // btnWinnerOfTournament
            // 
            this.btnWinnerOfTournament.Location = new System.Drawing.Point(18, 201);
            this.btnWinnerOfTournament.Name = "btnWinnerOfTournament";
            this.btnWinnerOfTournament.Size = new System.Drawing.Size(145, 60);
            this.btnWinnerOfTournament.TabIndex = 3;
            this.btnWinnerOfTournament.Text = "Show winner of INPUT tournament";
            this.btnWinnerOfTournament.UseVisualStyleBackColor = true;
            this.btnWinnerOfTournament.Click += new System.EventHandler(this.btnWinnerOfTournament_Click);
            // 
            // btnShowMaxContestants
            // 
            this.btnShowMaxContestants.Location = new System.Drawing.Point(18, 267);
            this.btnShowMaxContestants.Name = "btnShowMaxContestants";
            this.btnShowMaxContestants.Size = new System.Drawing.Size(145, 60);
            this.btnShowMaxContestants.TabIndex = 4;
            this.btnShowMaxContestants.Text = "Show tournament with the most of contestants";
            this.btnShowMaxContestants.UseVisualStyleBackColor = true;
            this.btnShowMaxContestants.Click += new System.EventHandler(this.btnShowMaxContestants_Click);
            // 
            // dgvQueries
            // 
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(8, 6);
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.Size = new System.Drawing.Size(595, 410);
            this.dgvQueries.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edContestantBirth);
            this.tabPage2.Controls.Add(this.edContestantRank);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.edContestantCountry);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.edContestantLastname);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.edContestantFirstname);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnContestantsSave);
            this.tabPage2.Controls.Add(this.btnContestantsUpdate);
            this.tabPage2.Controls.Add(this.btnContestantsDelete);
            this.tabPage2.Controls.Add(this.btnContestantsAdd);
            this.tabPage2.Controls.Add(this.dgvControlContestants);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ControlContestants";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvControlContestants
            // 
            this.dgvControlContestants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlContestants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlContestants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContestId,
            this.colContestFirstname,
            this.colContestLastname,
            this.colContestCountry,
            this.colContestRank,
            this.colContestBirthdate});
            this.dgvControlContestants.Location = new System.Drawing.Point(11, 6);
            this.dgvControlContestants.Name = "dgvControlContestants";
            this.dgvControlContestants.Size = new System.Drawing.Size(775, 278);
            this.dgvControlContestants.TabIndex = 0;
            this.dgvControlContestants.SelectionChanged += new System.EventHandler(this.dgvControlContestants_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.edTournamEnd);
            this.tabPage3.Controls.Add(this.edTournamStart);
            this.tabPage3.Controls.Add(this.edTournamPrize);
            this.tabPage3.Controls.Add(this.edTournamName);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnTournamSave);
            this.tabPage3.Controls.Add(this.btnTournamUpdate);
            this.tabPage3.Controls.Add(this.btnTournamDelete);
            this.tabPage3.Controls.Add(this.btnTournamAdd);
            this.tabPage3.Controls.Add(this.dgvControlTournaments);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ControlTournaments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.edResultWinnerId);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.edResultTournamentId);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.btnResultSave);
            this.tabPage4.Controls.Add(this.btnResultUpdate);
            this.tabPage4.Controls.Add(this.btnResultDelete);
            this.tabPage4.Controls.Add(this.btnResultAdd);
            this.tabPage4.Controls.Add(this.dgvControlResults);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ControlResults";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnContestantsSave
            // 
            this.btnContestantsSave.Location = new System.Drawing.Point(665, 345);
            this.btnContestantsSave.Name = "btnContestantsSave";
            this.btnContestantsSave.Size = new System.Drawing.Size(75, 23);
            this.btnContestantsSave.TabIndex = 8;
            this.btnContestantsSave.Text = "Save";
            this.btnContestantsSave.UseVisualStyleBackColor = true;
            this.btnContestantsSave.Click += new System.EventHandler(this.btnContestantsSave_Click);
            // 
            // btnContestantsUpdate
            // 
            this.btnContestantsUpdate.Location = new System.Drawing.Point(584, 345);
            this.btnContestantsUpdate.Name = "btnContestantsUpdate";
            this.btnContestantsUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContestantsUpdate.TabIndex = 7;
            this.btnContestantsUpdate.Text = "Update";
            this.btnContestantsUpdate.UseVisualStyleBackColor = true;
            this.btnContestantsUpdate.Click += new System.EventHandler(this.btnContestantsUpdate_Click);
            // 
            // btnContestantsDelete
            // 
            this.btnContestantsDelete.Location = new System.Drawing.Point(665, 316);
            this.btnContestantsDelete.Name = "btnContestantsDelete";
            this.btnContestantsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContestantsDelete.TabIndex = 6;
            this.btnContestantsDelete.Text = "Delete";
            this.btnContestantsDelete.UseVisualStyleBackColor = true;
            this.btnContestantsDelete.Click += new System.EventHandler(this.btnContestantsDelete_Click);
            // 
            // btnContestantsAdd
            // 
            this.btnContestantsAdd.Location = new System.Drawing.Point(584, 316);
            this.btnContestantsAdd.Name = "btnContestantsAdd";
            this.btnContestantsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnContestantsAdd.TabIndex = 5;
            this.btnContestantsAdd.Text = "Add";
            this.btnContestantsAdd.UseVisualStyleBackColor = true;
            this.btnContestantsAdd.Click += new System.EventHandler(this.btnContestantsAdd_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.edContId);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.edTournId);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.btnTournContSave);
            this.tabPage5.Controls.Add(this.btnTournContUpdate);
            this.tabPage5.Controls.Add(this.btnTournContDelete);
            this.tabPage5.Controls.Add(this.btnTournContAdd);
            this.tabPage5.Controls.Add(this.dgvControlTournCont);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "TournamentsContestants";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Firstname";
            // 
            // edContestantFirstname
            // 
            this.edContestantFirstname.Location = new System.Drawing.Point(53, 318);
            this.edContestantFirstname.Name = "edContestantFirstname";
            this.edContestantFirstname.Size = new System.Drawing.Size(219, 20);
            this.edContestantFirstname.TabIndex = 10;
            // 
            // edContestantLastname
            // 
            this.edContestantLastname.Location = new System.Drawing.Point(53, 359);
            this.edContestantLastname.Name = "edContestantLastname";
            this.edContestantLastname.Size = new System.Drawing.Size(219, 20);
            this.edContestantLastname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lastname";
            // 
            // edContestantCountry
            // 
            this.edContestantCountry.Location = new System.Drawing.Point(53, 396);
            this.edContestantCountry.Name = "edContestantCountry";
            this.edContestantCountry.Size = new System.Drawing.Size(219, 20);
            this.edContestantCountry.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rank";
            // 
            // edContestantRank
            // 
            this.edContestantRank.Location = new System.Drawing.Point(320, 319);
            this.edContestantRank.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edContestantRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edContestantRank.Name = "edContestantRank";
            this.edContestantRank.Size = new System.Drawing.Size(127, 20);
            this.edContestantRank.TabIndex = 17;
            this.edContestantRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edContestantBirth
            // 
            this.edContestantBirth.Location = new System.Drawing.Point(320, 360);
            this.edContestantBirth.Name = "edContestantBirth";
            this.edContestantBirth.Size = new System.Drawing.Size(127, 20);
            this.edContestantBirth.TabIndex = 18;
            // 
            // btnTournamSave
            // 
            this.btnTournamSave.Location = new System.Drawing.Point(662, 342);
            this.btnTournamSave.Name = "btnTournamSave";
            this.btnTournamSave.Size = new System.Drawing.Size(75, 23);
            this.btnTournamSave.TabIndex = 13;
            this.btnTournamSave.Text = "Save";
            this.btnTournamSave.UseVisualStyleBackColor = true;
            this.btnTournamSave.Click += new System.EventHandler(this.btnTournamSave_Click);
            // 
            // btnTournamUpdate
            // 
            this.btnTournamUpdate.Location = new System.Drawing.Point(581, 342);
            this.btnTournamUpdate.Name = "btnTournamUpdate";
            this.btnTournamUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTournamUpdate.TabIndex = 12;
            this.btnTournamUpdate.Text = "Update";
            this.btnTournamUpdate.UseVisualStyleBackColor = true;
            this.btnTournamUpdate.Click += new System.EventHandler(this.btnTournamUpdate_Click);
            // 
            // btnTournamDelete
            // 
            this.btnTournamDelete.Location = new System.Drawing.Point(662, 313);
            this.btnTournamDelete.Name = "btnTournamDelete";
            this.btnTournamDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTournamDelete.TabIndex = 11;
            this.btnTournamDelete.Text = "Delete";
            this.btnTournamDelete.UseVisualStyleBackColor = true;
            this.btnTournamDelete.Click += new System.EventHandler(this.btnTournamDelete_Click);
            // 
            // btnTournamAdd
            // 
            this.btnTournamAdd.Location = new System.Drawing.Point(581, 313);
            this.btnTournamAdd.Name = "btnTournamAdd";
            this.btnTournamAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTournamAdd.TabIndex = 10;
            this.btnTournamAdd.Text = "Add";
            this.btnTournamAdd.UseVisualStyleBackColor = true;
            this.btnTournamAdd.Click += new System.EventHandler(this.btnTournamAdd_Click);
            // 
            // dgvControlTournaments
            // 
            this.dgvControlTournaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlTournaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colTournamName,
            this.colTournamPrize,
            this.colTournamStartDate,
            this.colTournamEndDate});
            this.dgvControlTournaments.Location = new System.Drawing.Point(11, 6);
            this.dgvControlTournaments.Name = "dgvControlTournaments";
            this.dgvControlTournaments.Size = new System.Drawing.Size(775, 278);
            this.dgvControlTournaments.TabIndex = 9;
            this.dgvControlTournaments.SelectionChanged += new System.EventHandler(this.dgvControlTournaments_SelectionChanged);
            // 
            // btnTournContSave
            // 
            this.btnTournContSave.Location = new System.Drawing.Point(663, 342);
            this.btnTournContSave.Name = "btnTournContSave";
            this.btnTournContSave.Size = new System.Drawing.Size(75, 23);
            this.btnTournContSave.TabIndex = 13;
            this.btnTournContSave.Text = "Save";
            this.btnTournContSave.UseVisualStyleBackColor = true;
            this.btnTournContSave.Click += new System.EventHandler(this.btnTournContSave_Click);
            // 
            // btnTournContUpdate
            // 
            this.btnTournContUpdate.Location = new System.Drawing.Point(582, 342);
            this.btnTournContUpdate.Name = "btnTournContUpdate";
            this.btnTournContUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTournContUpdate.TabIndex = 12;
            this.btnTournContUpdate.Text = "Update";
            this.btnTournContUpdate.UseVisualStyleBackColor = true;
            this.btnTournContUpdate.Click += new System.EventHandler(this.btnTournContUpdate_Click);
            // 
            // btnTournContDelete
            // 
            this.btnTournContDelete.Location = new System.Drawing.Point(663, 313);
            this.btnTournContDelete.Name = "btnTournContDelete";
            this.btnTournContDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTournContDelete.TabIndex = 11;
            this.btnTournContDelete.Text = "Delete";
            this.btnTournContDelete.UseVisualStyleBackColor = true;
            this.btnTournContDelete.Click += new System.EventHandler(this.btnTournContDelete_Click);
            // 
            // btnTournContAdd
            // 
            this.btnTournContAdd.Location = new System.Drawing.Point(582, 313);
            this.btnTournContAdd.Name = "btnTournContAdd";
            this.btnTournContAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTournContAdd.TabIndex = 10;
            this.btnTournContAdd.Text = "Add";
            this.btnTournContAdd.UseVisualStyleBackColor = true;
            this.btnTournContAdd.Click += new System.EventHandler(this.btnTournContAdd_Click);
            // 
            // dgvControlTournCont
            // 
            this.dgvControlTournCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlTournCont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlTournCont.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTourConId,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn12});
            this.dgvControlTournCont.Location = new System.Drawing.Point(11, 6);
            this.dgvControlTournCont.Name = "dgvControlTournCont";
            this.dgvControlTournCont.Size = new System.Drawing.Size(775, 278);
            this.dgvControlTournCont.TabIndex = 9;
            this.dgvControlTournCont.SelectionChanged += new System.EventHandler(this.dgvControlTournCont_SelectionChanged);
            // 
            // btnResultSave
            // 
            this.btnResultSave.Location = new System.Drawing.Point(663, 342);
            this.btnResultSave.Name = "btnResultSave";
            this.btnResultSave.Size = new System.Drawing.Size(75, 23);
            this.btnResultSave.TabIndex = 13;
            this.btnResultSave.Text = "Save";
            this.btnResultSave.UseVisualStyleBackColor = true;
            this.btnResultSave.Click += new System.EventHandler(this.btnResultSave_Click);
            // 
            // btnResultUpdate
            // 
            this.btnResultUpdate.Location = new System.Drawing.Point(582, 342);
            this.btnResultUpdate.Name = "btnResultUpdate";
            this.btnResultUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnResultUpdate.TabIndex = 12;
            this.btnResultUpdate.Text = "Update";
            this.btnResultUpdate.UseVisualStyleBackColor = true;
            this.btnResultUpdate.Click += new System.EventHandler(this.btnResultUpdate_Click);
            // 
            // btnResultDelete
            // 
            this.btnResultDelete.Location = new System.Drawing.Point(663, 313);
            this.btnResultDelete.Name = "btnResultDelete";
            this.btnResultDelete.Size = new System.Drawing.Size(75, 23);
            this.btnResultDelete.TabIndex = 11;
            this.btnResultDelete.Text = "Delete";
            this.btnResultDelete.UseVisualStyleBackColor = true;
            this.btnResultDelete.Click += new System.EventHandler(this.btnResultDelete_Click);
            // 
            // btnResultAdd
            // 
            this.btnResultAdd.Location = new System.Drawing.Point(582, 313);
            this.btnResultAdd.Name = "btnResultAdd";
            this.btnResultAdd.Size = new System.Drawing.Size(75, 23);
            this.btnResultAdd.TabIndex = 10;
            this.btnResultAdd.Text = "Add";
            this.btnResultAdd.UseVisualStyleBackColor = true;
            this.btnResultAdd.Click += new System.EventHandler(this.btnResultAdd_Click);
            // 
            // dgvControlResults
            // 
            this.dgvControlResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.colResultTournId,
            this.colResultWinnerId});
            this.dgvControlResults.Location = new System.Drawing.Point(11, 6);
            this.dgvControlResults.Name = "dgvControlResults";
            this.dgvControlResults.Size = new System.Drawing.Size(775, 278);
            this.dgvControlResults.TabIndex = 9;
            this.dgvControlResults.SelectionChanged += new System.EventHandler(this.dgvControlResults_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Prize";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "StartDate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "EndDate";
            // 
            // edTournamName
            // 
            this.edTournamName.Location = new System.Drawing.Point(79, 313);
            this.edTournamName.Name = "edTournamName";
            this.edTournamName.Size = new System.Drawing.Size(181, 20);
            this.edTournamName.TabIndex = 18;
            // 
            // edTournamPrize
            // 
            this.edTournamPrize.Location = new System.Drawing.Point(79, 369);
            this.edTournamPrize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.edTournamPrize.Name = "edTournamPrize";
            this.edTournamPrize.Size = new System.Drawing.Size(181, 20);
            this.edTournamPrize.TabIndex = 19;
            // 
            // edTournamStart
            // 
            this.edTournamStart.Location = new System.Drawing.Point(337, 312);
            this.edTournamStart.Name = "edTournamStart";
            this.edTournamStart.Size = new System.Drawing.Size(200, 20);
            this.edTournamStart.TabIndex = 20;
            // 
            // edTournamEnd
            // 
            this.edTournamEnd.Location = new System.Drawing.Point(337, 369);
            this.edTournamEnd.Name = "edTournamEnd";
            this.edTournamEnd.Size = new System.Drawing.Size(200, 20);
            this.edTournamEnd.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colTournamName
            // 
            this.colTournamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTournamName.DataPropertyName = "Name";
            this.colTournamName.HeaderText = "Name";
            this.colTournamName.Name = "colTournamName";
            // 
            // colTournamPrize
            // 
            this.colTournamPrize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTournamPrize.DataPropertyName = "Prize";
            this.colTournamPrize.FillWeight = 50F;
            this.colTournamPrize.HeaderText = "Prize";
            this.colTournamPrize.Name = "colTournamPrize";
            // 
            // colTournamStartDate
            // 
            this.colTournamStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTournamStartDate.DataPropertyName = "StartDate";
            this.colTournamStartDate.HeaderText = "StartDate";
            this.colTournamStartDate.Name = "colTournamStartDate";
            // 
            // colTournamEndDate
            // 
            this.colTournamEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTournamEndDate.DataPropertyName = "EndDate";
            this.colTournamEndDate.HeaderText = "EndDate";
            this.colTournamEndDate.Name = "colTournamEndDate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "TournamentId";
            // 
            // edTournId
            // 
            this.edTournId.Location = new System.Drawing.Point(40, 342);
            this.edTournId.Name = "edTournId";
            this.edTournId.Size = new System.Drawing.Size(174, 20);
            this.edTournId.TabIndex = 15;
            // 
            // edContId
            // 
            this.edContId.Location = new System.Drawing.Point(295, 342);
            this.edContId.Name = "edContId";
            this.edContId.Size = new System.Drawing.Size(174, 20);
            this.edContId.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "ContestantId";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.FillWeight = 20F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // colResultTournId
            // 
            this.colResultTournId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colResultTournId.DataPropertyName = "TournamentId";
            this.colResultTournId.HeaderText = "TournamentId";
            this.colResultTournId.Name = "colResultTournId";
            // 
            // colResultWinnerId
            // 
            this.colResultWinnerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colResultWinnerId.DataPropertyName = "WinnerId";
            this.colResultWinnerId.HeaderText = "WinnerId";
            this.colResultWinnerId.Name = "colResultWinnerId";
            // 
            // edResultWinnerId
            // 
            this.edResultWinnerId.Location = new System.Drawing.Point(313, 342);
            this.edResultWinnerId.Name = "edResultWinnerId";
            this.edResultWinnerId.Size = new System.Drawing.Size(174, 20);
            this.edResultWinnerId.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "WinnerId";
            // 
            // edResultTournamentId
            // 
            this.edResultTournamentId.Location = new System.Drawing.Point(58, 342);
            this.edResultTournamentId.Name = "edResultTournamentId";
            this.edResultTournamentId.Size = new System.Drawing.Size(174, 20);
            this.edResultTournamentId.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "TournamentId";
            // 
            // colContestId
            // 
            this.colContestId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestId.DataPropertyName = "Id";
            this.colContestId.FillWeight = 20F;
            this.colContestId.HeaderText = "Id";
            this.colContestId.Name = "colContestId";
            // 
            // colContestFirstname
            // 
            this.colContestFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestFirstname.DataPropertyName = "Firtsname";
            this.colContestFirstname.HeaderText = "Firstname";
            this.colContestFirstname.Name = "colContestFirstname";
            // 
            // colContestLastname
            // 
            this.colContestLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestLastname.DataPropertyName = "Lastname";
            this.colContestLastname.HeaderText = "Lastname";
            this.colContestLastname.Name = "colContestLastname";
            // 
            // colContestCountry
            // 
            this.colContestCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestCountry.DataPropertyName = "Country";
            this.colContestCountry.FillWeight = 50F;
            this.colContestCountry.HeaderText = "Country";
            this.colContestCountry.Name = "colContestCountry";
            // 
            // colContestRank
            // 
            this.colContestRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestRank.DataPropertyName = "Rank";
            this.colContestRank.FillWeight = 20F;
            this.colContestRank.HeaderText = "Rank";
            this.colContestRank.Name = "colContestRank";
            // 
            // colContestBirthdate
            // 
            this.colContestBirthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestBirthdate.DataPropertyName = "Birthdate";
            this.colContestBirthdate.FillWeight = 80F;
            this.colContestBirthdate.HeaderText = "Birthdate";
            this.colContestBirthdate.Name = "colContestBirthdate";
            // 
            // colTourConId
            // 
            this.colTourConId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTourConId.DataPropertyName = "Id";
            this.colTourConId.FillWeight = 20F;
            this.colTourConId.HeaderText = "Id";
            this.colTourConId.Name = "colTourConId";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Tournament_Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "TournamentId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Contestant_Id";
            this.dataGridViewTextBoxColumn12.HeaderText = "ContestantId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChessChampionshipDb - EF - WinForms - CodeFirst - FluentAPI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlContestants)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edContestantRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlTournaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlTournCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTournamPrize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTournId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edContId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edResultWinnerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edResultTournamentId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvQueries;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFutureTournaments;
        private System.Windows.Forms.Button btnShowChampions;
        private System.Windows.Forms.Button btnShowCurrentTournaments;
        private System.Windows.Forms.Button btnWinnerOfTournament;
        private System.Windows.Forms.Button btnShowMaxContestants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edTournamentQueryName;
        private System.Windows.Forms.DataGridView dgvControlContestants;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnContestantsSave;
        private System.Windows.Forms.Button btnContestantsUpdate;
        private System.Windows.Forms.Button btnContestantsDelete;
        private System.Windows.Forms.Button btnContestantsAdd;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox edContestantLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edContestantFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edContestantCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker edContestantBirth;
        private System.Windows.Forms.NumericUpDown edContestantRank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTournamSave;
        private System.Windows.Forms.Button btnTournamUpdate;
        private System.Windows.Forms.Button btnTournamDelete;
        private System.Windows.Forms.Button btnTournamAdd;
        private System.Windows.Forms.DataGridView dgvControlTournaments;
        private System.Windows.Forms.Button btnTournContSave;
        private System.Windows.Forms.Button btnTournContUpdate;
        private System.Windows.Forms.Button btnTournContDelete;
        private System.Windows.Forms.Button btnTournContAdd;
        private System.Windows.Forms.DataGridView dgvControlTournCont;
        private System.Windows.Forms.Button btnResultSave;
        private System.Windows.Forms.Button btnResultUpdate;
        private System.Windows.Forms.Button btnResultDelete;
        private System.Windows.Forms.Button btnResultAdd;
        private System.Windows.Forms.DataGridView dgvControlResults;
        private System.Windows.Forms.DateTimePicker edTournamEnd;
        private System.Windows.Forms.DateTimePicker edTournamStart;
        private System.Windows.Forms.NumericUpDown edTournamPrize;
        private System.Windows.Forms.TextBox edTournamName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournamPrize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournamStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournamEndDate;
        private System.Windows.Forms.NumericUpDown edContId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown edTournId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultTournId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultWinnerId;
        private System.Windows.Forms.NumericUpDown edResultWinnerId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown edResultTournamentId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourConId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

