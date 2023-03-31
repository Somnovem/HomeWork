namespace Homework5_1Client
{
    partial class MainFormRPS_Client
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
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.rbPCPC = new System.Windows.Forms.RadioButton();
            this.rbPlayerPC = new System.Windows.Forms.RadioButton();
            this.rbPlayerPlayer = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.edRemoteAddress = new System.Windows.Forms.TextBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.btnLose = new System.Windows.Forms.Button();
            this.btnOfferTie = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.lbMessages = new CustomControls.ListBoxMultiline();
            this.lblState = new System.Windows.Forms.Label();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            this.gbGame.SuspendLayout();
            this.gbChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.rbPCPC);
            this.gbConnection.Controls.Add(this.rbPlayerPC);
            this.gbConnection.Controls.Add(this.rbPlayerPlayer);
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Controls.Add(this.edRemotePort);
            this.gbConnection.Controls.Add(this.edRemoteAddress);
            this.gbConnection.Location = new System.Drawing.Point(12, 49);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(578, 146);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // rbPCPC
            // 
            this.rbPCPC.AutoSize = true;
            this.rbPCPC.Location = new System.Drawing.Point(233, 123);
            this.rbPCPC.Name = "rbPCPC";
            this.rbPCPC.Size = new System.Drawing.Size(62, 17);
            this.rbPCPC.TabIndex = 7;
            this.rbPCPC.Text = "PC - PC";
            this.rbPCPC.UseVisualStyleBackColor = true;
            // 
            // rbPlayerPC
            // 
            this.rbPlayerPC.AutoSize = true;
            this.rbPlayerPC.Checked = true;
            this.rbPlayerPC.Location = new System.Drawing.Point(129, 123);
            this.rbPlayerPC.Name = "rbPlayerPC";
            this.rbPlayerPC.Size = new System.Drawing.Size(77, 17);
            this.rbPlayerPC.TabIndex = 6;
            this.rbPlayerPC.TabStop = true;
            this.rbPlayerPC.Text = "Player - PC";
            this.rbPlayerPC.UseVisualStyleBackColor = true;
            // 
            // rbPlayerPlayer
            // 
            this.rbPlayerPlayer.AutoSize = true;
            this.rbPlayerPlayer.Location = new System.Drawing.Point(18, 123);
            this.rbPlayerPlayer.Name = "rbPlayerPlayer";
            this.rbPlayerPlayer.Size = new System.Drawing.Size(92, 17);
            this.rbPlayerPlayer.TabIndex = 5;
            this.rbPlayerPlayer.Text = "Player - Player";
            this.rbPlayerPlayer.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(373, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 47);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Enter queue";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server IP Adress:";
            // 
            // edRemotePort
            // 
            this.edRemotePort.Location = new System.Drawing.Point(18, 84);
            this.edRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edRemotePort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edRemotePort.Name = "edRemotePort";
            this.edRemotePort.Size = new System.Drawing.Size(253, 20);
            this.edRemotePort.TabIndex = 1;
            this.edRemotePort.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // edRemoteAddress
            // 
            this.edRemoteAddress.Location = new System.Drawing.Point(18, 42);
            this.edRemoteAddress.Name = "edRemoteAddress";
            this.edRemoteAddress.Size = new System.Drawing.Size(253, 20);
            this.edRemoteAddress.TabIndex = 0;
            this.edRemoteAddress.Text = "127.0.0.1";
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.label6);
            this.gbGame.Controls.Add(this.lblRound);
            this.gbGame.Controls.Add(this.label4);
            this.gbGame.Controls.Add(this.lblLosses);
            this.gbGame.Controls.Add(this.label5);
            this.gbGame.Controls.Add(this.lblWins);
            this.gbGame.Controls.Add(this.label3);
            this.gbGame.Controls.Add(this.gbChoice);
            this.gbGame.Enabled = false;
            this.gbGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGame.Location = new System.Drawing.Point(12, 201);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(578, 227);
            this.gbGame.TabIndex = 1;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "/ 5";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(441, 53);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(17, 18);
            this.lblRound.TabIndex = 7;
            this.lblRound.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Round:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(271, 53);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(17, 18);
            this.lblLosses.TabIndex = 5;
            this.lblLosses.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Losses:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(108, 53);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(17, 18);
            this.lblWins.TabIndex = 3;
            this.lblWins.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wins:";
            // 
            // gbChoice
            // 
            this.gbChoice.Controls.Add(this.btnLose);
            this.gbChoice.Controls.Add(this.btnOfferTie);
            this.gbChoice.Controls.Add(this.btnSend);
            this.gbChoice.Controls.Add(this.cbOptions);
            this.gbChoice.Location = new System.Drawing.Point(18, 74);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(536, 148);
            this.gbChoice.TabIndex = 0;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "Choice";
            // 
            // btnLose
            // 
            this.btnLose.Location = new System.Drawing.Point(281, 91);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(159, 53);
            this.btnLose.TabIndex = 3;
            this.btnLose.Text = "Admit defeat";
            this.btnLose.UseVisualStyleBackColor = true;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // btnOfferTie
            // 
            this.btnOfferTie.Location = new System.Drawing.Point(55, 91);
            this.btnOfferTie.Name = "btnOfferTie";
            this.btnOfferTie.Size = new System.Drawing.Size(159, 53);
            this.btnOfferTie.TabIndex = 2;
            this.btnOfferTie.Text = "Offer a tie";
            this.btnOfferTie.UseVisualStyleBackColor = true;
            this.btnOfferTie.Click += new System.EventHandler(this.btnOfferTie_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(341, 23);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(159, 53);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Location = new System.Drawing.Point(27, 37);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(243, 26);
            this.cbOptions.TabIndex = 0;
            // 
            // lbMessages
            // 
            this.lbMessages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbMessages.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(31, 434);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(536, 278);
            this.lbMessages.TabIndex = 2;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblState.Location = new System.Drawing.Point(182, 21);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(152, 25);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "Connecting...";
            // 
            // MainFormRPS_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 713);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormRPS_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scisssors - Client";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).EndInit();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.gbChoice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.TextBox edRemoteAddress;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.Button btnOfferTie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPlayerPC;
        private System.Windows.Forms.RadioButton rbPlayerPlayer;
        private System.Windows.Forms.RadioButton rbPCPC;
        private CustomControls.ListBoxMultiline lbMessages;
        private System.Windows.Forms.Label lblState;
    }
}

