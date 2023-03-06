namespace HW1_1
{
    partial class MainForm1_1
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
            this.btnPersonalInMessageBoxes = new System.Windows.Forms.Button();
            this.btnChangeCaption = new System.Windows.Forms.Button();
            this.edCaption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendClose = new System.Windows.Forms.Button();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.edTimer = new System.Windows.Forms.NumericUpDown();
            this.btnChime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonalInMessageBoxes
            // 
            this.btnPersonalInMessageBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPersonalInMessageBoxes.Location = new System.Drawing.Point(12, 83);
            this.btnPersonalInMessageBoxes.Name = "btnPersonalInMessageBoxes";
            this.btnPersonalInMessageBoxes.Size = new System.Drawing.Size(137, 58);
            this.btnPersonalInMessageBoxes.TabIndex = 0;
            this.btnPersonalInMessageBoxes.Text = "Show personal info in MessageBoxes";
            this.btnPersonalInMessageBoxes.UseVisualStyleBackColor = true;
            this.btnPersonalInMessageBoxes.Click += new System.EventHandler(this.btnPersonalInMessageBoxes_Click);
            // 
            // btnChangeCaption
            // 
            this.btnChangeCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeCaption.Location = new System.Drawing.Point(12, 175);
            this.btnChangeCaption.Name = "btnChangeCaption";
            this.btnChangeCaption.Size = new System.Drawing.Size(137, 42);
            this.btnChangeCaption.TabIndex = 1;
            this.btnChangeCaption.Text = "Change caption to INPUT";
            this.btnChangeCaption.UseVisualStyleBackColor = true;
            this.btnChangeCaption.Click += new System.EventHandler(this.btnChangeCaption_Click);
            // 
            // edCaption
            // 
            this.edCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edCaption.Location = new System.Drawing.Point(12, 232);
            this.edCaption.Name = "edCaption";
            this.edCaption.Size = new System.Drawing.Size(137, 20);
            this.edCaption.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New caption";
            // 
            // btnSendClose
            // 
            this.btnSendClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendClose.Location = new System.Drawing.Point(543, 315);
            this.btnSendClose.Name = "btnSendClose";
            this.btnSendClose.Size = new System.Drawing.Size(113, 58);
            this.btnSendClose.TabIndex = 4;
            this.btnSendClose.Text = "Send Close";
            this.btnSendClose.UseVisualStyleBackColor = true;
            this.btnSendClose.Click += new System.EventHandler(this.btnSendClose_Click);
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandomNumber.Location = new System.Drawing.Point(12, 281);
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.Size = new System.Drawing.Size(137, 54);
            this.btnRandomNumber.TabIndex = 6;
            this.btnRandomNumber.Text = "Set caption to random number";
            this.btnRandomNumber.UseVisualStyleBackColor = true;
            this.btnRandomNumber.Click += new System.EventHandler(this.btnRandomNumber_Click);
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetTimer.Location = new System.Drawing.Point(520, 198);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(136, 54);
            this.btnSetTimer.TabIndex = 7;
            this.btnSetTimer.Text = "Set timer in seconds";
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // edTimer
            // 
            this.edTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edTimer.Location = new System.Drawing.Point(536, 255);
            this.edTimer.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.edTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edTimer.Name = "edTimer";
            this.edTimer.Size = new System.Drawing.Size(120, 20);
            this.edTimer.TabIndex = 8;
            this.edTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnChime
            // 
            this.btnChime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChime.Location = new System.Drawing.Point(12, 351);
            this.btnChime.Name = "btnChime";
            this.btnChime.Size = new System.Drawing.Size(137, 38);
            this.btnChime.TabIndex = 10;
            this.btnChime.Text = "Play chime";
            this.btnChime.UseVisualStyleBackColor = true;
            this.btnChime.Click += new System.EventHandler(this.btnChime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Try changing style in settings!";
            // 
            // MainForm1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChime);
            this.Controls.Add(this.edTimer);
            this.Controls.Add(this.btnSetTimer);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.btnSendClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edCaption);
            this.Controls.Add(this.btnChangeCaption);
            this.Controls.Add(this.btnPersonalInMessageBoxes);
            this.MinimumSize = new System.Drawing.Size(430, 370);
            this.Name = "MainForm1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SP-Homework1_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm1_1_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm1_1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.edTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonalInMessageBoxes;
        private System.Windows.Forms.Button btnChangeCaption;
        private System.Windows.Forms.TextBox edCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendClose;
        private System.Windows.Forms.Button btnRandomNumber;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.NumericUpDown edTimer;
        private System.Windows.Forms.Button btnChime;
        private System.Windows.Forms.Label label2;
    }
}

