namespace Homework2_1Films
{
    partial class MainFormFilms
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
            this.label1 = new System.Windows.Forms.Label();
            this.edTitle = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edSenderMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edReceiverEmail = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.edBody = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the film";
            // 
            // edTitle
            // 
            this.edTitle.Location = new System.Drawing.Point(40, 70);
            this.edTitle.Name = "edTitle";
            this.edTitle.Size = new System.Drawing.Size(299, 20);
            this.edTitle.TabIndex = 1;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(170, 96);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(131, 23);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "Get info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(36, 229);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 24);
            this.lblInfo.TabIndex = 3;
            // 
            // pbPoster
            // 
            this.pbPoster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbPoster.Location = new System.Drawing.Point(382, 12);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(255, 262);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 4;
            this.pbPoster.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.edBody);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edSenderMail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edReceiverEmail);
            this.groupBox1.Location = new System.Drawing.Point(643, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send info via email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sender password";
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(6, 135);
            this.edPassword.Name = "edPassword";
            this.edPassword.PasswordChar = '*';
            this.edPassword.Size = new System.Drawing.Size(302, 20);
            this.edPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sender mail";
            // 
            // edSenderMail
            // 
            this.edSenderMail.Location = new System.Drawing.Point(7, 86);
            this.edSenderMail.Name = "edSenderMail";
            this.edSenderMail.Size = new System.Drawing.Size(302, 20);
            this.edSenderMail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiver mail";
            // 
            // edReceiverEmail
            // 
            this.edReceiverEmail.Location = new System.Drawing.Point(7, 37);
            this.edReceiverEmail.Name = "edReceiverEmail";
            this.edReceiverEmail.Size = new System.Drawing.Size(302, 20);
            this.edReceiverEmail.TabIndex = 0;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMail.Enabled = false;
            this.btnSendMail.Location = new System.Drawing.Point(822, 301);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(136, 40);
            this.btnSendMail.TabIndex = 6;
            this.btnSendMail.Text = "Send results to mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Body";
            // 
            // edBody
            // 
            this.edBody.Location = new System.Drawing.Point(7, 186);
            this.edBody.Multiline = true;
            this.edBody.Name = "edBody";
            this.edBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edBody.Size = new System.Drawing.Size(301, 70);
            this.edBody.TabIndex = 7;
            // 
            // MainFormFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 521);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.edTitle);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(984, 560);
            this.Name = "MainFormFilms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Films stats";
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edTitle;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edSenderMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edReceiverEmail;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox edBody;
        private System.Windows.Forms.Label label5;
    }
}

