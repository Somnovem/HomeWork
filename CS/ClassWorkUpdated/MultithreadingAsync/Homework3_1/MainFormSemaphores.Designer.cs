namespace Homework3_1
{
    partial class MainFormSemaphores
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
            this.lbWorkingThreads = new System.Windows.Forms.ListBox();
            this.lbWaitingThreads = new System.Windows.Forms.ListBox();
            this.lbCreatedThreads = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edSemaphoreSitCount = new System.Windows.Forms.NumericUpDown();
            this.btnCreateThread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edSemaphoreSitCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWorkingThreads
            // 
            this.lbWorkingThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWorkingThreads.FormattingEnabled = true;
            this.lbWorkingThreads.Location = new System.Drawing.Point(12, 33);
            this.lbWorkingThreads.Name = "lbWorkingThreads";
            this.lbWorkingThreads.Size = new System.Drawing.Size(166, 69);
            this.lbWorkingThreads.TabIndex = 0;
            this.lbWorkingThreads.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbWorkingThreads_MouseDoubleClick);
            // 
            // lbWaitingThreads
            // 
            this.lbWaitingThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWaitingThreads.FormattingEnabled = true;
            this.lbWaitingThreads.Location = new System.Drawing.Point(184, 33);
            this.lbWaitingThreads.Name = "lbWaitingThreads";
            this.lbWaitingThreads.Size = new System.Drawing.Size(166, 69);
            this.lbWaitingThreads.TabIndex = 1;
            // 
            // lbCreatedThreads
            // 
            this.lbCreatedThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCreatedThreads.FormattingEnabled = true;
            this.lbCreatedThreads.Location = new System.Drawing.Point(356, 33);
            this.lbCreatedThreads.Name = "lbCreatedThreads";
            this.lbCreatedThreads.Size = new System.Drawing.Size(166, 69);
            this.lbCreatedThreads.TabIndex = 2;
            this.lbCreatedThreads.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCreatedThreads_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Working threads";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(217, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waiting threads";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(394, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Created threads";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(70, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sits in semaphore";
            // 
            // edSemaphoreSitCount
            // 
            this.edSemaphoreSitCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSemaphoreSitCount.Location = new System.Drawing.Point(73, 132);
            this.edSemaphoreSitCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edSemaphoreSitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSemaphoreSitCount.Name = "edSemaphoreSitCount";
            this.edSemaphoreSitCount.Size = new System.Drawing.Size(120, 20);
            this.edSemaphoreSitCount.TabIndex = 7;
            this.edSemaphoreSitCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edSemaphoreSitCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.edSemaphoreSitCount.ValueChanged += new System.EventHandler(this.edSemaphoreSitCount_ValueChanged);
            // 
            // btnCreateThread
            // 
            this.btnCreateThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateThread.Location = new System.Drawing.Point(299, 129);
            this.btnCreateThread.Name = "btnCreateThread";
            this.btnCreateThread.Size = new System.Drawing.Size(113, 23);
            this.btnCreateThread.TabIndex = 8;
            this.btnCreateThread.Text = "Create thread";
            this.btnCreateThread.UseVisualStyleBackColor = true;
            this.btnCreateThread.Click += new System.EventHandler(this.btnCreateThread_Click);
            // 
            // MainFormSempahores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 169);
            this.Controls.Add(this.btnCreateThread);
            this.Controls.Add(this.edSemaphoreSitCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCreatedThreads);
            this.Controls.Add(this.lbWaitingThreads);
            this.Controls.Add(this.lbWorkingThreads);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(553, 208);
            this.Name = "MainFormSempahores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test semaphores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormSemaphores_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.edSemaphoreSitCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWorkingThreads;
        private System.Windows.Forms.ListBox lbWaitingThreads;
        private System.Windows.Forms.ListBox lbCreatedThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edSemaphoreSitCount;
        private System.Windows.Forms.Button btnCreateThread;
    }
}

