namespace Homework3__
{
    partial class MainFormARE
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
            this.btnRunFileOperation = new System.Windows.Forms.Button();
            this.btnOpenPairsFile = new System.Windows.Forms.Button();
            this.btnOpenSumFile = new System.Windows.Forms.Button();
            this.btnOpenProductFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.edPairsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edPairsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunFileOperation
            // 
            this.btnRunFileOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRunFileOperation.Location = new System.Drawing.Point(44, 197);
            this.btnRunFileOperation.Name = "btnRunFileOperation";
            this.btnRunFileOperation.Size = new System.Drawing.Size(335, 170);
            this.btnRunFileOperation.TabIndex = 0;
            this.btnRunFileOperation.Text = "Run File Operation";
            this.btnRunFileOperation.UseVisualStyleBackColor = true;
            this.btnRunFileOperation.Click += new System.EventHandler(this.btnRunFileOperation_Click);
            // 
            // btnOpenPairsFile
            // 
            this.btnOpenPairsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPairsFile.Location = new System.Drawing.Point(538, 42);
            this.btnOpenPairsFile.Name = "btnOpenPairsFile";
            this.btnOpenPairsFile.Size = new System.Drawing.Size(204, 77);
            this.btnOpenPairsFile.TabIndex = 1;
            this.btnOpenPairsFile.Text = "Open the file wih paires";
            this.btnOpenPairsFile.UseVisualStyleBackColor = true;
            this.btnOpenPairsFile.Click += new System.EventHandler(this.btnOpenPairsFile_Click);
            // 
            // btnOpenSumFile
            // 
            this.btnOpenSumFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenSumFile.Location = new System.Drawing.Point(538, 197);
            this.btnOpenSumFile.Name = "btnOpenSumFile";
            this.btnOpenSumFile.Size = new System.Drawing.Size(204, 77);
            this.btnOpenSumFile.TabIndex = 2;
            this.btnOpenSumFile.Text = "Open the file with sums";
            this.btnOpenSumFile.UseVisualStyleBackColor = true;
            this.btnOpenSumFile.Click += new System.EventHandler(this.btnOpenSumFile_Click);
            // 
            // btnOpenProductFile
            // 
            this.btnOpenProductFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenProductFile.Location = new System.Drawing.Point(538, 338);
            this.btnOpenProductFile.Name = "btnOpenProductFile";
            this.btnOpenProductFile.Size = new System.Drawing.Size(204, 77);
            this.btnOpenProductFile.TabIndex = 3;
            this.btnOpenProductFile.Text = "Open the file with products";
            this.btnOpenProductFile.UseVisualStyleBackColor = true;
            this.btnOpenProductFile.Click += new System.EventHandler(this.btnOpenProductFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many pairs to generate?";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(332, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current state:";
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblState.Location = new System.Drawing.Point(317, 42);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(114, 25);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "Unstarted";
            // 
            // edPairsCount
            // 
            this.edPairsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edPairsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edPairsCount.Location = new System.Drawing.Point(61, 150);
            this.edPairsCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edPairsCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edPairsCount.Name = "edPairsCount";
            this.edPairsCount.Size = new System.Drawing.Size(293, 26);
            this.edPairsCount.TabIndex = 8;
            this.edPairsCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MainFormARE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edPairsCount);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenProductFile);
            this.Controls.Add(this.btnOpenSumFile);
            this.Controls.Add(this.btnOpenPairsFile);
            this.Controls.Add(this.btnRunFileOperation);
            this.MinimumSize = new System.Drawing.Size(712, 425);
            this.Name = "MainFormARE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test ARE";
            ((System.ComponentModel.ISupportInitialize)(this.edPairsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunFileOperation;
        private System.Windows.Forms.Button btnOpenPairsFile;
        private System.Windows.Forms.Button btnOpenSumFile;
        private System.Windows.Forms.Button btnOpenProductFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.NumericUpDown edPairsCount;
    }
}

