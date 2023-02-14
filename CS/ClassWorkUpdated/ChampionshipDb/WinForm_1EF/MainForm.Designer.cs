namespace WinForm_1EF
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
            this.btnSearchNameCity = new System.Windows.Forms.Button();
            this.btnSearchCity = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.edSearchCity = new System.Windows.Forms.TextBox();
            this.edSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowMaxGoalsMissed = new System.Windows.Forms.Button();
            this.btnShowMaxGoalsScored = new System.Windows.Forms.Button();
            this.btnShowMaxTies = new System.Windows.Forms.Button();
            this.btnShowMaxLosses = new System.Windows.Forms.Button();
            this.btnShowMaxWins = new System.Windows.Forms.Button();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTeamSave = new System.Windows.Forms.Button();
            this.btnTeamUpdate = new System.Windows.Forms.Button();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.btnTeamAdd = new System.Windows.Forms.Button();
            this.edNumGoalsMissed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.edNumGoalsScored = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.edNumTies = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.edNumLosses = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.edNumWins = new System.Windows.Forms.NumericUpDown();
            this.edTeamCity = new System.Windows.Forms.TextBox();
            this.edTeamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvControls = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edNumGoalsMissed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumGoalsScored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumTies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumLosses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumWins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControls)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.btnSearchNameCity);
            this.tabPage1.Controls.Add(this.btnSearchCity);
            this.tabPage1.Controls.Add(this.btnSearchName);
            this.tabPage1.Controls.Add(this.edSearchCity);
            this.tabPage1.Controls.Add(this.edSearchName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Searching";
            // 
            // btnSearchNameCity
            // 
            this.btnSearchNameCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchNameCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchNameCity.Location = new System.Drawing.Point(98, 322);
            this.btnSearchNameCity.Name = "btnSearchNameCity";
            this.btnSearchNameCity.Size = new System.Drawing.Size(129, 49);
            this.btnSearchNameCity.TabIndex = 7;
            this.btnSearchNameCity.Text = "Search by name AND city";
            this.btnSearchNameCity.UseVisualStyleBackColor = true;
            this.btnSearchNameCity.Click += new System.EventHandler(this.btnSearchNameCity_Click);
            // 
            // btnSearchCity
            // 
            this.btnSearchCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCity.Location = new System.Drawing.Point(163, 266);
            this.btnSearchCity.Name = "btnSearchCity";
            this.btnSearchCity.Size = new System.Drawing.Size(129, 34);
            this.btnSearchCity.TabIndex = 6;
            this.btnSearchCity.Text = "Search by city";
            this.btnSearchCity.UseVisualStyleBackColor = true;
            this.btnSearchCity.Click += new System.EventHandler(this.btnSearchCity_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchName.Location = new System.Drawing.Point(28, 266);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(129, 34);
            this.btnSearchName.TabIndex = 5;
            this.btnSearchName.Text = "Search by name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // edSearchCity
            // 
            this.edSearchCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSearchCity.Location = new System.Drawing.Point(76, 159);
            this.edSearchCity.Name = "edSearchCity";
            this.edSearchCity.Size = new System.Drawing.Size(233, 20);
            this.edSearchCity.TabIndex = 4;
            // 
            // edSearchName
            // 
            this.edSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSearchName.Location = new System.Drawing.Point(76, 69);
            this.edSearchName.Name = "edSearchName";
            this.edSearchName.Size = new System.Drawing.Size(233, 20);
            this.edSearchName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // dgvSearch
            // 
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(366, 6);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(418, 410);
            this.dgvSearch.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.btnShowMaxGoalsMissed);
            this.tabPage2.Controls.Add(this.btnShowMaxGoalsScored);
            this.tabPage2.Controls.Add(this.btnShowMaxTies);
            this.tabPage2.Controls.Add(this.btnShowMaxLosses);
            this.tabPage2.Controls.Add(this.btnShowMaxWins);
            this.tabPage2.Controls.Add(this.dgvQueries);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Queries";
            // 
            // btnShowMaxGoalsMissed
            // 
            this.btnShowMaxGoalsMissed.Location = new System.Drawing.Point(85, 219);
            this.btnShowMaxGoalsMissed.Name = "btnShowMaxGoalsMissed";
            this.btnShowMaxGoalsMissed.Size = new System.Drawing.Size(130, 64);
            this.btnShowMaxGoalsMissed.TabIndex = 5;
            this.btnShowMaxGoalsMissed.Text = "Show team with max goals missed";
            this.btnShowMaxGoalsMissed.UseVisualStyleBackColor = true;
            this.btnShowMaxGoalsMissed.Click += new System.EventHandler(this.btnShowMaxGoalsMissed_Click);
            // 
            // btnShowMaxGoalsScored
            // 
            this.btnShowMaxGoalsScored.Location = new System.Drawing.Point(155, 149);
            this.btnShowMaxGoalsScored.Name = "btnShowMaxGoalsScored";
            this.btnShowMaxGoalsScored.Size = new System.Drawing.Size(130, 64);
            this.btnShowMaxGoalsScored.TabIndex = 4;
            this.btnShowMaxGoalsScored.Text = "Show team with max goals scored";
            this.btnShowMaxGoalsScored.UseVisualStyleBackColor = true;
            this.btnShowMaxGoalsScored.Click += new System.EventHandler(this.btnShowMaxGoalsScored_Click);
            // 
            // btnShowMaxTies
            // 
            this.btnShowMaxTies.Location = new System.Drawing.Point(19, 149);
            this.btnShowMaxTies.Name = "btnShowMaxTies";
            this.btnShowMaxTies.Size = new System.Drawing.Size(130, 64);
            this.btnShowMaxTies.TabIndex = 3;
            this.btnShowMaxTies.Text = "Show team with max ties";
            this.btnShowMaxTies.UseVisualStyleBackColor = true;
            this.btnShowMaxTies.Click += new System.EventHandler(this.btnShowMaxTies_Click);
            // 
            // btnShowMaxLosses
            // 
            this.btnShowMaxLosses.Location = new System.Drawing.Point(155, 79);
            this.btnShowMaxLosses.Name = "btnShowMaxLosses";
            this.btnShowMaxLosses.Size = new System.Drawing.Size(130, 64);
            this.btnShowMaxLosses.TabIndex = 2;
            this.btnShowMaxLosses.Text = "Show team with max losses";
            this.btnShowMaxLosses.UseVisualStyleBackColor = true;
            this.btnShowMaxLosses.Click += new System.EventHandler(this.btnShowMaxLosses_Click);
            // 
            // btnShowMaxWins
            // 
            this.btnShowMaxWins.Location = new System.Drawing.Point(19, 79);
            this.btnShowMaxWins.Name = "btnShowMaxWins";
            this.btnShowMaxWins.Size = new System.Drawing.Size(130, 64);
            this.btnShowMaxWins.TabIndex = 1;
            this.btnShowMaxWins.Text = "Show team with max wins";
            this.btnShowMaxWins.UseVisualStyleBackColor = true;
            this.btnShowMaxWins.Click += new System.EventHandler(this.btnShowMaxWins_Click);
            // 
            // dgvQueries
            // 
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(336, 6);
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.Size = new System.Drawing.Size(448, 410);
            this.dgvQueries.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage3.Controls.Add(this.btnTeamSave);
            this.tabPage3.Controls.Add(this.btnTeamUpdate);
            this.tabPage3.Controls.Add(this.btnTeamDelete);
            this.tabPage3.Controls.Add(this.btnTeamAdd);
            this.tabPage3.Controls.Add(this.edNumGoalsMissed);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.edNumGoalsScored);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.edNumTies);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.edNumLosses);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.edNumWins);
            this.tabPage3.Controls.Add(this.edTeamCity);
            this.tabPage3.Controls.Add(this.edTeamName);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dgvControls);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Controls";
            // 
            // btnTeamSave
            // 
            this.btnTeamSave.Location = new System.Drawing.Point(642, 375);
            this.btnTeamSave.Name = "btnTeamSave";
            this.btnTeamSave.Size = new System.Drawing.Size(120, 41);
            this.btnTeamSave.TabIndex = 18;
            this.btnTeamSave.Text = "Save changes";
            this.btnTeamSave.UseVisualStyleBackColor = true;
            this.btnTeamSave.Click += new System.EventHandler(this.btnTeamSave_Click);
            // 
            // btnTeamUpdate
            // 
            this.btnTeamUpdate.Location = new System.Drawing.Point(516, 375);
            this.btnTeamUpdate.Name = "btnTeamUpdate";
            this.btnTeamUpdate.Size = new System.Drawing.Size(120, 41);
            this.btnTeamUpdate.TabIndex = 17;
            this.btnTeamUpdate.Text = "Update";
            this.btnTeamUpdate.UseVisualStyleBackColor = true;
            this.btnTeamUpdate.Click += new System.EventHandler(this.btnTeamUpdate_Click);
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.Location = new System.Drawing.Point(642, 323);
            this.btnTeamDelete.Name = "btnTeamDelete";
            this.btnTeamDelete.Size = new System.Drawing.Size(120, 41);
            this.btnTeamDelete.TabIndex = 16;
            this.btnTeamDelete.Text = "Delete";
            this.btnTeamDelete.UseVisualStyleBackColor = true;
            this.btnTeamDelete.Click += new System.EventHandler(this.btnTeamDelete_Click);
            // 
            // btnTeamAdd
            // 
            this.btnTeamAdd.Location = new System.Drawing.Point(516, 323);
            this.btnTeamAdd.Name = "btnTeamAdd";
            this.btnTeamAdd.Size = new System.Drawing.Size(120, 41);
            this.btnTeamAdd.TabIndex = 15;
            this.btnTeamAdd.Text = "Add";
            this.btnTeamAdd.UseVisualStyleBackColor = true;
            this.btnTeamAdd.Click += new System.EventHandler(this.btnTeamAdd_Click);
            // 
            // edNumGoalsMissed
            // 
            this.edNumGoalsMissed.Location = new System.Drawing.Point(460, 294);
            this.edNumGoalsMissed.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.edNumGoalsMissed.Name = "edNumGoalsMissed";
            this.edNumGoalsMissed.Size = new System.Drawing.Size(120, 20);
            this.edNumGoalsMissed.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Goals missed";
            // 
            // edNumGoalsScored
            // 
            this.edNumGoalsScored.Location = new System.Drawing.Point(272, 375);
            this.edNumGoalsScored.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.edNumGoalsScored.Name = "edNumGoalsScored";
            this.edNumGoalsScored.Size = new System.Drawing.Size(120, 20);
            this.edNumGoalsScored.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Goals scored";
            // 
            // edNumTies
            // 
            this.edNumTies.Location = new System.Drawing.Point(272, 335);
            this.edNumTies.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.edNumTies.Name = "edNumTies";
            this.edNumTies.Size = new System.Drawing.Size(120, 20);
            this.edNumTies.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ties";
            // 
            // edNumLosses
            // 
            this.edNumLosses.Location = new System.Drawing.Point(272, 294);
            this.edNumLosses.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.edNumLosses.Name = "edNumLosses";
            this.edNumLosses.Size = new System.Drawing.Size(120, 20);
            this.edNumLosses.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Losses";
            // 
            // edNumWins
            // 
            this.edNumWins.Location = new System.Drawing.Point(60, 375);
            this.edNumWins.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.edNumWins.Name = "edNumWins";
            this.edNumWins.Size = new System.Drawing.Size(120, 20);
            this.edNumWins.TabIndex = 6;
            // 
            // edTeamCity
            // 
            this.edTeamCity.Location = new System.Drawing.Point(60, 334);
            this.edTeamCity.Name = "edTeamCity";
            this.edTeamCity.Size = new System.Drawing.Size(118, 20);
            this.edTeamCity.TabIndex = 5;
            // 
            // edTeamName
            // 
            this.edTeamName.Location = new System.Drawing.Point(60, 293);
            this.edTeamName.Name = "edTeamName";
            this.edTeamName.Size = new System.Drawing.Size(118, 20);
            this.edTeamName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // dgvControls
            // 
            this.dgvControls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControls.Location = new System.Drawing.Point(4, 7);
            this.dgvControls.Name = "dgvControls";
            this.dgvControls.Size = new System.Drawing.Size(780, 264);
            this.dgvControls.TabIndex = 0;
            this.dgvControls.SelectionChanged += new System.EventHandler(this.dgvControls_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Championship Entity Framework Usage";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edNumGoalsMissed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumGoalsScored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumTies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumLosses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumWins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox edSearchCity;
        private System.Windows.Forms.TextBox edSearchName;
        private System.Windows.Forms.Button btnSearchNameCity;
        private System.Windows.Forms.Button btnSearchCity;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnShowMaxGoalsMissed;
        private System.Windows.Forms.Button btnShowMaxGoalsScored;
        private System.Windows.Forms.Button btnShowMaxTies;
        private System.Windows.Forms.Button btnShowMaxLosses;
        private System.Windows.Forms.Button btnShowMaxWins;
        private System.Windows.Forms.DataGridView dgvQueries;
        private System.Windows.Forms.DataGridView dgvControls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edNumWins;
        private System.Windows.Forms.TextBox edTeamCity;
        private System.Windows.Forms.TextBox edTeamName;
        private System.Windows.Forms.Button btnTeamSave;
        private System.Windows.Forms.Button btnTeamUpdate;
        private System.Windows.Forms.Button btnTeamDelete;
        private System.Windows.Forms.Button btnTeamAdd;
        private System.Windows.Forms.NumericUpDown edNumGoalsMissed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown edNumGoalsScored;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown edNumTies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edNumLosses;
        private System.Windows.Forms.Label label6;
    }
}

