namespace Ado2_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grSql = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSql = new System.Windows.Forms.RadioButton();
            this.rbWIndows = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbAsync = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adress(Data Source)";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(123, 6);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(481, 20);
            this.txtAdress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAsync);
            this.groupBox1.Controls.Add(this.grSql);
            this.groupBox1.Controls.Add(this.rbSql);
            this.groupBox1.Controls.Add(this.rbWIndows);
            this.groupBox1.Location = new System.Drawing.Point(19, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 267);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Auth";
            // 
            // grSql
            // 
            this.grSql.Controls.Add(this.txtPass);
            this.grSql.Controls.Add(this.txtLogin);
            this.grSql.Controls.Add(this.label3);
            this.grSql.Controls.Add(this.label2);
            this.grSql.Enabled = false;
            this.grSql.Location = new System.Drawing.Point(34, 87);
            this.grSql.Name = "grSql";
            this.grSql.Size = new System.Drawing.Size(504, 130);
            this.grSql.TabIndex = 2;
            this.grSql.TabStop = false;
            this.grSql.Text = "User Info";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(96, 72);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(391, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(96, 34);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(391, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserId(Login)";
            // 
            // rbSql
            // 
            this.rbSql.AutoSize = true;
            this.rbSql.Location = new System.Drawing.Point(34, 55);
            this.rbSql.Name = "rbSql";
            this.rbSql.Size = new System.Drawing.Size(80, 17);
            this.rbSql.TabIndex = 1;
            this.rbSql.Text = "SQL Server";
            this.rbSql.UseVisualStyleBackColor = true;
            this.rbSql.CheckedChanged += new System.EventHandler(this.rbWIndows_CheckedChanged);
            // 
            // rbWIndows
            // 
            this.rbWIndows.AutoSize = true;
            this.rbWIndows.Checked = true;
            this.rbWIndows.Location = new System.Drawing.Point(34, 32);
            this.rbWIndows.Name = "rbWIndows";
            this.rbWIndows.Size = new System.Drawing.Size(69, 17);
            this.rbWIndows.TabIndex = 0;
            this.rbWIndows.TabStop = true;
            this.rbWIndows.Text = "Windows";
            this.rbWIndows.UseVisualStyleBackColor = true;
            this.rbWIndows.CheckedChanged += new System.EventHandler(this.rbWIndows_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(33, 329);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 32);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(455, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAsync
            // 
            this.cbAsync.AutoSize = true;
            this.cbAsync.Location = new System.Drawing.Point(43, 234);
            this.cbAsync.Name = "cbAsync";
            this.cbAsync.Size = new System.Drawing.Size(170, 17);
            this.cbAsync.TabIndex = 3;
            this.cbAsync.Text = "Use Asynchronous Processing";
            this.cbAsync.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 373);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test SqlBuilder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grSql.ResumeLayout(false);
            this.grSql.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grSql;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSql;
        private System.Windows.Forms.RadioButton rbWIndows;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbAsync;
    }
}

