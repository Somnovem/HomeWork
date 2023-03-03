namespace SpPractice3_1WinForms
{
    partial class MainFormPractice3_1
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
            this.btnIterateStandart = new System.Windows.Forms.Button();
            this.lbIterateStandart = new System.Windows.Forms.ListBox();
            this.lbIterateRanged = new System.Windows.Forms.ListBox();
            this.btnIterateRanged = new System.Windows.Forms.Button();
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.edRangeStart = new System.Windows.Forms.NumericUpDown();
            this.edRangeEnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edThreadsCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edThreadsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIterateStandart
            // 
            this.btnIterateStandart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIterateStandart.Location = new System.Drawing.Point(42, 298);
            this.btnIterateStandart.Name = "btnIterateStandart";
            this.btnIterateStandart.Size = new System.Drawing.Size(158, 59);
            this.btnIterateStandart.TabIndex = 0;
            this.btnIterateStandart.Text = "Show numbers 0-50";
            this.btnIterateStandart.UseVisualStyleBackColor = true;
            this.btnIterateStandart.Click += new System.EventHandler(this.btnIterateStandart_Click);
            // 
            // lbIterateStandart
            // 
            this.lbIterateStandart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIterateStandart.FormattingEnabled = true;
            this.lbIterateStandart.Location = new System.Drawing.Point(12, 28);
            this.lbIterateStandart.Name = "lbIterateStandart";
            this.lbIterateStandart.Size = new System.Drawing.Size(290, 251);
            this.lbIterateStandart.TabIndex = 1;
            // 
            // lbIterateRanged
            // 
            this.lbIterateRanged.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIterateRanged.FormattingEnabled = true;
            this.lbIterateRanged.Location = new System.Drawing.Point(323, 28);
            this.lbIterateRanged.Name = "lbIterateRanged";
            this.lbIterateRanged.Size = new System.Drawing.Size(290, 251);
            this.lbIterateRanged.TabIndex = 3;
            // 
            // btnIterateRanged
            // 
            this.btnIterateRanged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIterateRanged.Location = new System.Drawing.Point(353, 298);
            this.btnIterateRanged.Name = "btnIterateRanged";
            this.btnIterateRanged.Size = new System.Drawing.Size(158, 59);
            this.btnIterateRanged.TabIndex = 2;
            this.btnIterateRanged.Text = "Show numbers in range using INPUT number of threads";
            this.btnIterateRanged.UseVisualStyleBackColor = true;
            this.btnIterateRanged.Click += new System.EventHandler(this.btnIterateRanged_Click);
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateNumbers.Location = new System.Drawing.Point(630, 298);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(158, 59);
            this.btnGenerateNumbers.TabIndex = 4;
            this.btnGenerateNumbers.Text = "Generate 10000 numbers and put them and their MAX,MIN,AVG in a file";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // edRangeStart
            // 
            this.edRangeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edRangeStart.Location = new System.Drawing.Point(342, 372);
            this.edRangeStart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edRangeStart.Name = "edRangeStart";
            this.edRangeStart.Size = new System.Drawing.Size(248, 20);
            this.edRangeStart.TabIndex = 5;
            // 
            // edRangeEnd
            // 
            this.edRangeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edRangeEnd.Location = new System.Drawing.Point(342, 409);
            this.edRangeEnd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edRangeEnd.Name = "edRangeEnd";
            this.edRangeEnd.Size = new System.Drawing.Size(248, 20);
            this.edRangeEnd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Range start";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Range end";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(690, 363);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Open the file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(656, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Multithreading";
            // 
            // edThreadsCount
            // 
            this.edThreadsCount.Location = new System.Drawing.Point(29, 392);
            this.edThreadsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edThreadsCount.Name = "edThreadsCount";
            this.edThreadsCount.Size = new System.Drawing.Size(202, 20);
            this.edThreadsCount.TabIndex = 11;
            this.edThreadsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of threads";
            // 
            // MainFormPractice3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edThreadsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edRangeEnd);
            this.Controls.Add(this.edRangeStart);
            this.Controls.Add(this.btnGenerateNumbers);
            this.Controls.Add(this.lbIterateRanged);
            this.Controls.Add(this.btnIterateRanged);
            this.Controls.Add(this.lbIterateStandart);
            this.Controls.Add(this.btnIterateStandart);
            this.Name = "MainFormPractice3_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormPractice3_1";
            ((System.ComponentModel.ISupportInitialize)(this.edRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edThreadsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIterateStandart;
        private System.Windows.Forms.ListBox lbIterateStandart;
        private System.Windows.Forms.ListBox lbIterateRanged;
        private System.Windows.Forms.Button btnIterateRanged;
        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.NumericUpDown edRangeStart;
        private System.Windows.Forms.NumericUpDown edRangeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edThreadsCount;
        private System.Windows.Forms.Label label4;
    }
}

