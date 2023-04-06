namespace Homework6_1Client
{
    partial class MainFormChat_Client
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.edPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbSending = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.gbConnection.SuspendLayout();
            this.gbSending.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnection.Controls.Add(this.btnLogin);
            this.gbConnection.Controls.Add(this.edPassword);
            this.gbConnection.Controls.Add(this.label4);
            this.gbConnection.Controls.Add(this.edLogin);
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.btnSignIn);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(680, 183);
            this.gbConnection.TabIndex = 6;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(473, 108);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 43);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(24, 107);
            this.edPassword.Name = "edPassword";
            this.edPassword.PasswordChar = '*';
            this.edPassword.Size = new System.Drawing.Size(320, 20);
            this.edPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // edLogin
            // 
            this.edLogin.Location = new System.Drawing.Point(24, 68);
            this.edLogin.Name = "edLogin";
            this.edLogin.Size = new System.Drawing.Size(320, 20);
            this.edLogin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.Location = new System.Drawing.Point(473, 45);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(153, 43);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(12, 201);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(680, 264);
            this.lbMessages.TabIndex = 7;
            // 
            // gbSending
            // 
            this.gbSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSending.Controls.Add(this.btnSend);
            this.gbSending.Controls.Add(this.edMessage);
            this.gbSending.Controls.Add(this.cbType);
            this.gbSending.Enabled = false;
            this.gbSending.Location = new System.Drawing.Point(12, 467);
            this.gbSending.Name = "gbSending";
            this.gbSending.Size = new System.Drawing.Size(680, 81);
            this.gbSending.TabIndex = 8;
            this.gbSending.TabStop = false;
            this.gbSending.Text = "Sending messages";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(482, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(192, 30);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(149, 19);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(525, 20);
            this.edMessage.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(6, 19);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(137, 21);
            this.cbType.TabIndex = 2;
            // 
            // MainFormChat_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 560);
            this.Controls.Add(this.gbSending);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormChat_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat-Client";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbSending.ResumeLayout(false);
            this.gbSending.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.GroupBox gbSending;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox edPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
    }
}

