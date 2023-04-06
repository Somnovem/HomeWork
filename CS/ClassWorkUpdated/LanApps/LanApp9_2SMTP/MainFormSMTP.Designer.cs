namespace LanApp9_2SMTP
{
    partial class MainFormSMTP
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
            this.edServerMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edServerPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edSenderMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edSenderPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edReceiverMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edSubject = new System.Windows.Forms.TextBox();
            this.cbIsHtml = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // edServerMail
            // 
            this.edServerMail.Location = new System.Drawing.Point(71, 6);
            this.edServerMail.Name = "edServerMail";
            this.edServerMail.Size = new System.Drawing.Size(404, 20);
            this.edServerMail.TabIndex = 0;
            this.edServerMail.Text = "smtp.gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail";
            // 
            // edServerPort
            // 
            this.edServerPort.Location = new System.Drawing.Point(71, 36);
            this.edServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edServerPort.Name = "edServerPort";
            this.edServerPort.Size = new System.Drawing.Size(131, 20);
            this.edServerPort.TabIndex = 2;
            this.edServerPort.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // edSenderMail
            // 
            this.edSenderMail.Location = new System.Drawing.Point(71, 62);
            this.edSenderMail.Name = "edSenderMail";
            this.edSenderMail.Size = new System.Drawing.Size(404, 20);
            this.edSenderMail.TabIndex = 4;
            this.edSenderMail.Text = "kolindolin66@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // edSenderPassword
            // 
            this.edSenderPassword.Location = new System.Drawing.Point(71, 88);
            this.edSenderPassword.Name = "edSenderPassword";
            this.edSenderPassword.PasswordChar = '*';
            this.edSenderPassword.Size = new System.Drawing.Size(404, 20);
            this.edSenderPassword.TabIndex = 6;
            this.edSenderPassword.Text = "Srulnet12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "To:";
            // 
            // edReceiverMail
            // 
            this.edReceiverMail.Location = new System.Drawing.Point(71, 152);
            this.edReceiverMail.Name = "edReceiverMail";
            this.edReceiverMail.Size = new System.Drawing.Size(404, 20);
            this.edReceiverMail.TabIndex = 8;
            this.edReceiverMail.Text = "artemzhmuraa@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subject";
            // 
            // edSubject
            // 
            this.edSubject.Location = new System.Drawing.Point(71, 178);
            this.edSubject.Name = "edSubject";
            this.edSubject.Size = new System.Drawing.Size(404, 20);
            this.edSubject.TabIndex = 10;
            this.edSubject.Text = "Test SMTP";
            // 
            // cbIsHtml
            // 
            this.cbIsHtml.AutoSize = true;
            this.cbIsHtml.Location = new System.Drawing.Point(135, 129);
            this.cbIsHtml.Name = "cbIsHtml";
            this.cbIsHtml.Size = new System.Drawing.Size(67, 17);
            this.cbIsHtml.TabIndex = 12;
            this.cbIsHtml.Text = "Is HTML";
            this.cbIsHtml.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Content";
            // 
            // edContent
            // 
            this.edContent.Location = new System.Drawing.Point(71, 204);
            this.edContent.Multiline = true;
            this.edContent.Name = "edContent";
            this.edContent.Size = new System.Drawing.Size(511, 234);
            this.edContent.TabIndex = 13;
            this.edContent.Text = "Test SMTP message. Pleasy reply!";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(599, 365);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(189, 36);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainFormSMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edContent);
            this.Controls.Add(this.cbIsHtml);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edReceiverMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edSenderPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edSenderMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edServerPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edServerMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormSMTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test SMTP";
            ((System.ComponentModel.ISupportInitialize)(this.edServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edServerMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edSenderMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edSenderPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edReceiverMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edSubject;
        private System.Windows.Forms.CheckBox cbIsHtml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edContent;
        private System.Windows.Forms.Button btnSend;
    }
}

