namespace Ado4_1
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
            this.cmbProviderList = new System.Windows.Forms.ComboBox();
            this.btnGetProvider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edConStr = new System.Windows.Forms.TextBox();
            this.edSqlQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnAsyncExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select provider";
            // 
            // cmbProviderList
            // 
            this.cmbProviderList.FormattingEnabled = true;
            this.cmbProviderList.Location = new System.Drawing.Point(137, 37);
            this.cmbProviderList.Name = "cmbProviderList";
            this.cmbProviderList.Size = new System.Drawing.Size(230, 21);
            this.cmbProviderList.TabIndex = 1;
            this.cmbProviderList.SelectedIndexChanged += new System.EventHandler(this.cmbProviderList_SelectedIndexChanged);
            // 
            // btnGetProvider
            // 
            this.btnGetProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetProvider.Location = new System.Drawing.Point(388, 34);
            this.btnGetProvider.Name = "btnGetProvider";
            this.btnGetProvider.Size = new System.Drawing.Size(105, 25);
            this.btnGetProvider.TabIndex = 2;
            this.btnGetProvider.Text = "Get providers";
            this.btnGetProvider.UseVisualStyleBackColor = true;
            this.btnGetProvider.Click += new System.EventHandler(this.btnGetProvider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection string";
            // 
            // edConStr
            // 
            this.edConStr.Location = new System.Drawing.Point(36, 118);
            this.edConStr.Name = "edConStr";
            this.edConStr.ReadOnly = true;
            this.edConStr.Size = new System.Drawing.Size(733, 20);
            this.edConStr.TabIndex = 4;
            // 
            // edSqlQuery
            // 
            this.edSqlQuery.Enabled = false;
            this.edSqlQuery.Location = new System.Drawing.Point(36, 176);
            this.edSqlQuery.Name = "edSqlQuery";
            this.edSqlQuery.Size = new System.Drawing.Size(586, 20);
            this.edSqlQuery.TabIndex = 5;
            this.edSqlQuery.TextChanged += new System.EventHandler(this.edSqlQuery_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Query:";
            // 
            // btnExec
            // 
            this.btnExec.Enabled = false;
            this.btnExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExec.Location = new System.Drawing.Point(637, 179);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(132, 33);
            this.btnExec.TabIndex = 7;
            this.btnExec.Text = "Execute query";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(36, 226);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(733, 149);
            this.dgvView.TabIndex = 8;
            // 
            // btnAsyncExecute
            // 
            this.btnAsyncExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAsyncExecute.Location = new System.Drawing.Point(637, 144);
            this.btnAsyncExecute.Name = "btnAsyncExecute";
            this.btnAsyncExecute.Size = new System.Drawing.Size(132, 33);
            this.btnAsyncExecute.TabIndex = 11;
            this.btnAsyncExecute.Text = "Execute async query";
            this.btnAsyncExecute.UseVisualStyleBackColor = true;
            this.btnAsyncExecute.Click += new System.EventHandler(this.btnAsyncExecute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsyncExecute);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edSqlQuery);
            this.Controls.Add(this.edConStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetProvider);
            this.Controls.Add(this.cmbProviderList);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ado - Test DbProviderFactory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProviderList;
        private System.Windows.Forms.Button btnGetProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edConStr;
        private System.Windows.Forms.TextBox edSqlQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnAsyncExecute;
    }
}

