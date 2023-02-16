namespace WinForms_GamesDb
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGameDelete = new System.Windows.Forms.Button();
            this.btnGameSave = new System.Windows.Forms.Button();
            this.btnGameUpdate = new System.Windows.Forms.Button();
            this.btnGameAdd = new System.Windows.Forms.Button();
            this.cbGameSingleplayer = new System.Windows.Forms.CheckBox();
            this.edGameSold = new System.Windows.Forms.NumericUpDown();
            this.edGameRelease = new System.Windows.Forms.DateTimePicker();
            this.edGameStyle = new System.Windows.Forms.TextBox();
            this.edGameDescr = new System.Windows.Forms.TextBox();
            this.edGameName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvControlGames = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edQueriesStyle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edQueriesName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNumSinglePlayer = new System.Windows.Forms.Button();
            this.btnNumMultiPlayer = new System.Windows.Forms.Button();
            this.btnShowMaxSoldOfStyle = new System.Windows.Forms.Button();
            this.btnShowTop5MaxSoldOfStyle = new System.Windows.Forms.Button();
            this.btnShowTop5MinSoldOfStyle = new System.Windows.Forms.Button();
            this.btnSearchGame = new System.Windows.Forms.Button();
            this.btnMostProductiveStudioPerStyle = new System.Windows.Forms.Button();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvStandart = new System.Windows.Forms.DataGridView();
            this.colStandartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStandartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edGameSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlGames)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ControlStudios";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGameDelete);
            this.tabPage3.Controls.Add(this.btnGameSave);
            this.tabPage3.Controls.Add(this.btnGameUpdate);
            this.tabPage3.Controls.Add(this.btnGameAdd);
            this.tabPage3.Controls.Add(this.cbGameSingleplayer);
            this.tabPage3.Controls.Add(this.edGameSold);
            this.tabPage3.Controls.Add(this.edGameRelease);
            this.tabPage3.Controls.Add(this.edGameStyle);
            this.tabPage3.Controls.Add(this.edGameDescr);
            this.tabPage3.Controls.Add(this.edGameName);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dgvControlGames);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ControlGames";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGameDelete
            // 
            this.btnGameDelete.Location = new System.Drawing.Point(643, 301);
            this.btnGameDelete.Name = "btnGameDelete";
            this.btnGameDelete.Size = new System.Drawing.Size(100, 30);
            this.btnGameDelete.TabIndex = 16;
            this.btnGameDelete.Text = "Delete";
            this.btnGameDelete.UseVisualStyleBackColor = true;
            this.btnGameDelete.Click += new System.EventHandler(this.btnGameDelete_Click);
            // 
            // btnGameSave
            // 
            this.btnGameSave.Location = new System.Drawing.Point(643, 351);
            this.btnGameSave.Name = "btnGameSave";
            this.btnGameSave.Size = new System.Drawing.Size(100, 30);
            this.btnGameSave.TabIndex = 15;
            this.btnGameSave.Text = "Save";
            this.btnGameSave.UseVisualStyleBackColor = true;
            this.btnGameSave.Click += new System.EventHandler(this.btnGameSave_Click);
            // 
            // btnGameUpdate
            // 
            this.btnGameUpdate.Location = new System.Drawing.Point(529, 351);
            this.btnGameUpdate.Name = "btnGameUpdate";
            this.btnGameUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnGameUpdate.TabIndex = 14;
            this.btnGameUpdate.Text = "Update";
            this.btnGameUpdate.UseVisualStyleBackColor = true;
            this.btnGameUpdate.Click += new System.EventHandler(this.btnGameUpdate_Click);
            // 
            // btnGameAdd
            // 
            this.btnGameAdd.Location = new System.Drawing.Point(529, 302);
            this.btnGameAdd.Name = "btnGameAdd";
            this.btnGameAdd.Size = new System.Drawing.Size(100, 30);
            this.btnGameAdd.TabIndex = 13;
            this.btnGameAdd.Text = "Add";
            this.btnGameAdd.UseVisualStyleBackColor = true;
            this.btnGameAdd.Click += new System.EventHandler(this.btnGameAdd_Click);
            // 
            // cbGameSingleplayer
            // 
            this.cbGameSingleplayer.AutoSize = true;
            this.cbGameSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGameSingleplayer.Location = new System.Drawing.Point(329, 385);
            this.cbGameSingleplayer.Name = "cbGameSingleplayer";
            this.cbGameSingleplayer.Size = new System.Drawing.Size(109, 20);
            this.cbGameSingleplayer.TabIndex = 12;
            this.cbGameSingleplayer.Text = "Singleplayer?";
            this.cbGameSingleplayer.UseVisualStyleBackColor = true;
            // 
            // edGameSold
            // 
            this.edGameSold.Location = new System.Drawing.Point(314, 334);
            this.edGameSold.Name = "edGameSold";
            this.edGameSold.Size = new System.Drawing.Size(172, 20);
            this.edGameSold.TabIndex = 11;
            // 
            // edGameRelease
            // 
            this.edGameRelease.Location = new System.Drawing.Point(313, 285);
            this.edGameRelease.Name = "edGameRelease";
            this.edGameRelease.Size = new System.Drawing.Size(172, 20);
            this.edGameRelease.TabIndex = 10;
            // 
            // edGameStyle
            // 
            this.edGameStyle.Location = new System.Drawing.Point(50, 382);
            this.edGameStyle.Name = "edGameStyle";
            this.edGameStyle.Size = new System.Drawing.Size(215, 20);
            this.edGameStyle.TabIndex = 9;
            // 
            // edGameDescr
            // 
            this.edGameDescr.Location = new System.Drawing.Point(50, 334);
            this.edGameDescr.Name = "edGameDescr";
            this.edGameDescr.Size = new System.Drawing.Size(215, 20);
            this.edGameDescr.TabIndex = 8;
            // 
            // edGameName
            // 
            this.edGameName.Location = new System.Drawing.Point(50, 274);
            this.edGameName.Name = "edGameName";
            this.edGameName.Size = new System.Drawing.Size(215, 20);
            this.edGameName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "CopiesSold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Release";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Style";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // dgvControlGames
            // 
            this.dgvControlGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlGames.Location = new System.Drawing.Point(9, 4);
            this.dgvControlGames.Name = "dgvControlGames";
            this.dgvControlGames.Size = new System.Drawing.Size(775, 256);
            this.dgvControlGames.TabIndex = 0;
            this.dgvControlGames.SelectionChanged += new System.EventHandler(this.dgvControlGames_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edQueriesStyle);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.edQueriesName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.dgvQueries);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Queries";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edQueriesStyle
            // 
            this.edQueriesStyle.Location = new System.Drawing.Point(22, 378);
            this.edQueriesStyle.Name = "edQueriesStyle";
            this.edQueriesStyle.Size = new System.Drawing.Size(325, 20);
            this.edQueriesStyle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Style";
            // 
            // edQueriesName
            // 
            this.edQueriesName.Location = new System.Drawing.Point(22, 326);
            this.edQueriesName.Name = "edQueriesName";
            this.edQueriesName.Size = new System.Drawing.Size(325, 20);
            this.edQueriesName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNumSinglePlayer);
            this.flowLayoutPanel1.Controls.Add(this.btnNumMultiPlayer);
            this.flowLayoutPanel1.Controls.Add(this.btnShowMaxSoldOfStyle);
            this.flowLayoutPanel1.Controls.Add(this.btnShowTop5MaxSoldOfStyle);
            this.flowLayoutPanel1.Controls.Add(this.btnShowTop5MinSoldOfStyle);
            this.flowLayoutPanel1.Controls.Add(this.btnSearchGame);
            this.flowLayoutPanel1.Controls.Add(this.btnMostProductiveStudioPerStyle);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 285);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNumSinglePlayer
            // 
            this.btnNumSinglePlayer.Location = new System.Drawing.Point(3, 3);
            this.btnNumSinglePlayer.Name = "btnNumSinglePlayer";
            this.btnNumSinglePlayer.Size = new System.Drawing.Size(155, 60);
            this.btnNumSinglePlayer.TabIndex = 0;
            this.btnNumSinglePlayer.Text = "Show number of singleplayer games";
            this.btnNumSinglePlayer.UseVisualStyleBackColor = true;
            this.btnNumSinglePlayer.Click += new System.EventHandler(this.btnNumSinglePlayer_Click);
            // 
            // btnNumMultiPlayer
            // 
            this.btnNumMultiPlayer.Location = new System.Drawing.Point(164, 3);
            this.btnNumMultiPlayer.Name = "btnNumMultiPlayer";
            this.btnNumMultiPlayer.Size = new System.Drawing.Size(155, 60);
            this.btnNumMultiPlayer.TabIndex = 1;
            this.btnNumMultiPlayer.Text = "Show number of multiplayer games";
            this.btnNumMultiPlayer.UseVisualStyleBackColor = true;
            this.btnNumMultiPlayer.Click += new System.EventHandler(this.btnNumMultiPlayer_Click);
            // 
            // btnShowMaxSoldOfStyle
            // 
            this.btnShowMaxSoldOfStyle.Location = new System.Drawing.Point(3, 69);
            this.btnShowMaxSoldOfStyle.Name = "btnShowMaxSoldOfStyle";
            this.btnShowMaxSoldOfStyle.Size = new System.Drawing.Size(155, 60);
            this.btnShowMaxSoldOfStyle.TabIndex = 2;
            this.btnShowMaxSoldOfStyle.Text = "Show most sold game of input style";
            this.btnShowMaxSoldOfStyle.UseVisualStyleBackColor = true;
            this.btnShowMaxSoldOfStyle.Click += new System.EventHandler(this.btnShowMaxSoldOfStyle_Click);
            // 
            // btnShowTop5MaxSoldOfStyle
            // 
            this.btnShowTop5MaxSoldOfStyle.Location = new System.Drawing.Point(164, 69);
            this.btnShowTop5MaxSoldOfStyle.Name = "btnShowTop5MaxSoldOfStyle";
            this.btnShowTop5MaxSoldOfStyle.Size = new System.Drawing.Size(155, 60);
            this.btnShowTop5MaxSoldOfStyle.TabIndex = 3;
            this.btnShowTop5MaxSoldOfStyle.Text = "Show top 5 most sold games of input style";
            this.btnShowTop5MaxSoldOfStyle.UseVisualStyleBackColor = true;
            this.btnShowTop5MaxSoldOfStyle.Click += new System.EventHandler(this.btnShowTop5MaxSoldOfStyle_Click);
            // 
            // btnShowTop5MinSoldOfStyle
            // 
            this.btnShowTop5MinSoldOfStyle.Location = new System.Drawing.Point(3, 135);
            this.btnShowTop5MinSoldOfStyle.Name = "btnShowTop5MinSoldOfStyle";
            this.btnShowTop5MinSoldOfStyle.Size = new System.Drawing.Size(155, 60);
            this.btnShowTop5MinSoldOfStyle.TabIndex = 4;
            this.btnShowTop5MinSoldOfStyle.Text = "Show top 5 least sold games of input style";
            this.btnShowTop5MinSoldOfStyle.UseVisualStyleBackColor = true;
            this.btnShowTop5MinSoldOfStyle.Click += new System.EventHandler(this.btnShowTop5MinSoldOfStyle_Click);
            // 
            // btnSearchGame
            // 
            this.btnSearchGame.Location = new System.Drawing.Point(164, 135);
            this.btnSearchGame.Name = "btnSearchGame";
            this.btnSearchGame.Size = new System.Drawing.Size(155, 60);
            this.btnSearchGame.TabIndex = 5;
            this.btnSearchGame.Text = "Get info about a game by name";
            this.btnSearchGame.UseVisualStyleBackColor = true;
            this.btnSearchGame.Click += new System.EventHandler(this.btnSearchGame_Click);
            // 
            // btnMostProductiveStudioPerStyle
            // 
            this.btnMostProductiveStudioPerStyle.Location = new System.Drawing.Point(3, 201);
            this.btnMostProductiveStudioPerStyle.Name = "btnMostProductiveStudioPerStyle";
            this.btnMostProductiveStudioPerStyle.Size = new System.Drawing.Size(155, 60);
            this.btnMostProductiveStudioPerStyle.TabIndex = 6;
            this.btnMostProductiveStudioPerStyle.Text = "Show most productive studio per style";
            this.btnMostProductiveStudioPerStyle.UseVisualStyleBackColor = true;
            this.btnMostProductiveStudioPerStyle.Click += new System.EventHandler(this.btnMostProductiveStudioPerStyle_Click);
            // 
            // dgvQueries
            // 
            this.dgvQueries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(353, 6);
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.Size = new System.Drawing.Size(431, 410);
            this.dgvQueries.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvStandart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvStandart
            // 
            this.dgvStandart.AllowUserToAddRows = false;
            this.dgvStandart.AllowUserToDeleteRows = false;
            this.dgvStandart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStandart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStandartId,
            this.colStandartName});
            this.dgvStandart.Location = new System.Drawing.Point(3, 9);
            this.dgvStandart.Name = "dgvStandart";
            this.dgvStandart.ReadOnly = true;
            this.dgvStandart.Size = new System.Drawing.Size(775, 409);
            this.dgvStandart.TabIndex = 0;
            // 
            // colStandartId
            // 
            this.colStandartId.DataPropertyName = "Name";
            this.colStandartId.FillWeight = 30F;
            this.colStandartId.HeaderText = "Id";
            this.colStandartId.Name = "colStandartId";
            this.colStandartId.ReadOnly = true;
            // 
            // colStandartName
            // 
            this.colStandartName.DataPropertyName = "Name";
            this.colStandartName.HeaderText = "Name";
            this.colStandartName.Name = "colStandartName";
            this.colStandartName.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamesDb - EF - Control";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edGameSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlGames)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox edQueriesStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edQueriesName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNumSinglePlayer;
        private System.Windows.Forms.Button btnNumMultiPlayer;
        private System.Windows.Forms.Button btnShowMaxSoldOfStyle;
        private System.Windows.Forms.Button btnShowTop5MaxSoldOfStyle;
        private System.Windows.Forms.Button btnShowTop5MinSoldOfStyle;
        private System.Windows.Forms.Button btnSearchGame;
        private System.Windows.Forms.Button btnMostProductiveStudioPerStyle;
        private System.Windows.Forms.DataGridView dgvQueries;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvStandart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStandartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStandartName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvControlGames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbGameSingleplayer;
        private System.Windows.Forms.NumericUpDown edGameSold;
        private System.Windows.Forms.DateTimePicker edGameRelease;
        private System.Windows.Forms.TextBox edGameStyle;
        private System.Windows.Forms.TextBox edGameDescr;
        private System.Windows.Forms.TextBox edGameName;
        private System.Windows.Forms.Button btnGameDelete;
        private System.Windows.Forms.Button btnGameSave;
        private System.Windows.Forms.Button btnGameUpdate;
        private System.Windows.Forms.Button btnGameAdd;
    }
}

