namespace Homework2_1
{
    partial class MainFormMutexes
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
            this.btnPerformOperations = new System.Windows.Forms.Button();
            this.btnOpenInit = new System.Windows.Forms.Button();
            this.btnOpenPrimes = new System.Windows.Forms.Button();
            this.btnOpenPrimes7 = new System.Windows.Forms.Button();
            this.btnOpenAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerformOperations
            // 
            this.btnPerformOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPerformOperations.Location = new System.Drawing.Point(64, 143);
            this.btnPerformOperations.Name = "btnPerformOperations";
            this.btnPerformOperations.Size = new System.Drawing.Size(301, 140);
            this.btnPerformOperations.TabIndex = 0;
            this.btnPerformOperations.Text = "Perform file operations";
            this.btnPerformOperations.UseVisualStyleBackColor = true;
            this.btnPerformOperations.Click += new System.EventHandler(this.btnPerformOperations_Click);
            // 
            // btnOpenInit
            // 
            this.btnOpenInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenInit.Location = new System.Drawing.Point(529, 52);
            this.btnOpenInit.Name = "btnOpenInit";
            this.btnOpenInit.Size = new System.Drawing.Size(185, 58);
            this.btnOpenInit.TabIndex = 1;
            this.btnOpenInit.Text = "Open Initial File";
            this.btnOpenInit.UseVisualStyleBackColor = true;
            this.btnOpenInit.Click += new System.EventHandler(this.btnOpenInit_Click);
            // 
            // btnOpenPrimes
            // 
            this.btnOpenPrimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPrimes.Location = new System.Drawing.Point(529, 143);
            this.btnOpenPrimes.Name = "btnOpenPrimes";
            this.btnOpenPrimes.Size = new System.Drawing.Size(185, 58);
            this.btnOpenPrimes.TabIndex = 2;
            this.btnOpenPrimes.Text = "Open File with primes";
            this.btnOpenPrimes.UseVisualStyleBackColor = true;
            this.btnOpenPrimes.Click += new System.EventHandler(this.btnOpenPrimes_Click);
            // 
            // btnOpenPrimes7
            // 
            this.btnOpenPrimes7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPrimes7.Location = new System.Drawing.Point(529, 235);
            this.btnOpenPrimes7.Name = "btnOpenPrimes7";
            this.btnOpenPrimes7.Size = new System.Drawing.Size(185, 58);
            this.btnOpenPrimes7.TabIndex = 3;
            this.btnOpenPrimes7.Text = "Open File with primes ending in 7";
            this.btnOpenPrimes7.UseVisualStyleBackColor = true;
            this.btnOpenPrimes7.Click += new System.EventHandler(this.btnOpenPrimes7_Click);
            // 
            // btnOpenAnalysis
            // 
            this.btnOpenAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenAnalysis.Location = new System.Drawing.Point(529, 322);
            this.btnOpenAnalysis.Name = "btnOpenAnalysis";
            this.btnOpenAnalysis.Size = new System.Drawing.Size(185, 58);
            this.btnOpenAnalysis.TabIndex = 4;
            this.btnOpenAnalysis.Text = "Open Analysis file";
            this.btnOpenAnalysis.UseVisualStyleBackColor = true;
            this.btnOpenAnalysis.Click += new System.EventHandler(this.btnOpenAnalysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "State:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblState.Location = new System.Drawing.Point(167, 52);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(105, 25);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "Unstarted";
            // 
            // MainFormMutexes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenAnalysis);
            this.Controls.Add(this.btnOpenPrimes7);
            this.Controls.Add(this.btnOpenPrimes);
            this.Controls.Add(this.btnOpenInit);
            this.Controls.Add(this.btnPerformOperations);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainFormMutexes";
            this.Text = "Test mutexes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPerformOperations;
        private System.Windows.Forms.Button btnOpenInit;
        private System.Windows.Forms.Button btnOpenPrimes;
        private System.Windows.Forms.Button btnOpenPrimes7;
        private System.Windows.Forms.Button btnOpenAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
    }
}

