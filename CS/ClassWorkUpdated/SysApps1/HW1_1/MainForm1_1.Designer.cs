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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.edTimer = new System.Windows.Forms.NumericUpDown();
            this.btnChime = new System.Windows.Forms.Button();
            this.edColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonalInMessageBoxes
            // 
            this.btnPersonalInMessageBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPersonalInMessageBoxes.Location = new System.Drawing.Point(12, 129);
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
            this.btnChangeCaption.Location = new System.Drawing.Point(12, 221);
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
            this.edCaption.Location = new System.Drawing.Point(12, 278);
            this.edCaption.Name = "edCaption";
            this.edCaption.Size = new System.Drawing.Size(137, 20);
            this.edCaption.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New caption";
            // 
            // btnSendClose
            // 
            this.btnSendClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendClose.Location = new System.Drawing.Point(675, 361);
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
            this.btnRandomNumber.Location = new System.Drawing.Point(12, 327);
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
            this.btnSetTimer.Location = new System.Drawing.Point(652, 244);
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
            this.edTimer.Location = new System.Drawing.Point(668, 301);
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
            this.btnChime.Location = new System.Drawing.Point(12, 397);
            this.btnChime.Name = "btnChime";
            this.btnChime.Size = new System.Drawing.Size(137, 38);
            this.btnChime.TabIndex = 10;
            this.btnChime.Text = "Play chime";
            this.btnChime.UseVisualStyleBackColor = true;
            this.btnChime.Click += new System.EventHandler(this.btnChime_Click);
            // 
            // edColor
            // 
            this.edColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edColor.Location = new System.Drawing.Point(620, 29);
            this.edColor.Name = "edColor";
            this.edColor.Size = new System.Drawing.Size(168, 13);
            this.edColor.TabIndex = 11;
            this.edColor.Text = "White";
            this.edColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edColor.TextChanged += new System.EventHandler(this.edColor_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Color(changed in settings)";
            // 
            // edTitle
            // 
            this.edTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edTitle.Location = new System.Drawing.Point(315, 27);
            this.edTitle.Name = "edTitle";
            this.edTitle.Size = new System.Drawing.Size(188, 19);
            this.edTitle.TabIndex = 13;
            this.edTitle.Text = "Greetings!";
            this.edTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edColor);
            this.Controls.Add(this.btnChime);
            this.Controls.Add(this.edTimer);
            this.Controls.Add(this.btnSetTimer);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.btnSendClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edCaption);
            this.Controls.Add(this.btnChangeCaption);
            this.Controls.Add(this.btnPersonalInMessageBoxes);
            this.Name = "MainForm1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SP-Homework1_1";
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRandomNumber;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.NumericUpDown edTimer;
        private System.Windows.Forms.Button btnChime;
        private System.Windows.Forms.TextBox edColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edTitle;
    }
}

