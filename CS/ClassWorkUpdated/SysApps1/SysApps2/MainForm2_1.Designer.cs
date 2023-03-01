namespace SysApps2
{
    partial class MainForm2_1
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
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.btnGetPocesses = new System.Windows.Forms.Button();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.btnProcessRun = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcess
            // 
            this.dgvProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Location = new System.Drawing.Point(13, 13);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.Size = new System.Drawing.Size(564, 364);
            this.dgvProcess.TabIndex = 0;
            this.dgvProcess.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProcess_DataError);
            // 
            // btnGetPocesses
            // 
            this.btnGetPocesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetPocesses.Location = new System.Drawing.Point(29, 409);
            this.btnGetPocesses.Name = "btnGetPocesses";
            this.btnGetPocesses.Size = new System.Drawing.Size(75, 23);
            this.btnGetPocesses.TabIndex = 1;
            this.btnGetPocesses.Text = "Porcesses";
            this.btnGetPocesses.UseVisualStyleBackColor = true;
            this.btnGetPocesses.Click += new System.EventHandler(this.btnGetPocesses_Click);
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Location = new System.Drawing.Point(111, 409);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(75, 23);
            this.btnKillProcess.TabIndex = 2;
            this.btnKillProcess.Text = "Kill";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // btnProcessRun
            // 
            this.btnProcessRun.Location = new System.Drawing.Point(193, 409);
            this.btnProcessRun.Name = "btnProcessRun";
            this.btnProcessRun.Size = new System.Drawing.Size(75, 23);
            this.btnProcessRun.TabIndex = 3;
            this.btnProcessRun.Text = "Run";
            this.btnProcessRun.UseVisualStyleBackColor = true;
            this.btnProcessRun.Click += new System.EventHandler(this.btnProcessRun_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "exe";
            this.dlgOpen.FileName = "openFileDialog1";
            this.dlgOpen.Filter = "Application|*.exe|All files|*.*";
            this.dlgOpen.Title = "Run programm...";
            // 
            // MainForm2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 456);
            this.Controls.Add(this.btnProcessRun);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.btnGetPocesses);
            this.Controls.Add(this.dgvProcess);
            this.Name = "MainForm2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm2_1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.Button btnGetPocesses;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.Button btnProcessRun;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}

