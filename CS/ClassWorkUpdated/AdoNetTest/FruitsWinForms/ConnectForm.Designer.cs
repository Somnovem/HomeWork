namespace FruitsWinForms
{
    partial class ConnectForm
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
            this.cmbProviders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateProviders = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.edConnectionSrtring = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(187, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "FruitsDb in WinForms";
            // 
            // cmbProviders
            // 
            this.cmbProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProviders.FormattingEnabled = true;
            this.cmbProviders.Location = new System.Drawing.Point(252, 219);
            this.cmbProviders.Name = "cmbProviders";
            this.cmbProviders.Size = new System.Drawing.Size(510, 21);
            this.cmbProviders.TabIndex = 1;
            this.cmbProviders.SelectedIndexChanged += new System.EventHandler(this.cmbProviders_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose data provider";
            // 
            // btnUpdateProviders
            // 
            this.btnUpdateProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateProviders.Location = new System.Drawing.Point(611, 183);
            this.btnUpdateProviders.Name = "btnUpdateProviders";
            this.btnUpdateProviders.Size = new System.Drawing.Size(151, 30);
            this.btnUpdateProviders.TabIndex = 3;
            this.btnUpdateProviders.Text = "Update list";
            this.btnUpdateProviders.UseVisualStyleBackColor = true;
            this.btnUpdateProviders.Click += new System.EventHandler(this.btnUpdateProviders_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(252, 364);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(257, 36);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect and proceed";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // edConnectionSrtring
            // 
            this.edConnectionSrtring.Location = new System.Drawing.Point(190, 295);
            this.edConnectionSrtring.Name = "edConnectionSrtring";
            this.edConnectionSrtring.ReadOnly = true;
            this.edConnectionSrtring.Size = new System.Drawing.Size(572, 20);
            this.edConnectionSrtring.TabIndex = 5;
            this.edConnectionSrtring.TextChanged += new System.EventHandler(this.edConnectionSrtring_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Connection string(readonly):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edConnectionSrtring);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnUpdateProviders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProviders);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fruits in WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProviders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateProviders;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox edConnectionSrtring;
        private System.Windows.Forms.Label label3;
    }
}

