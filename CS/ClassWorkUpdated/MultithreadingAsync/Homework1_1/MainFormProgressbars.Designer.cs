namespace Homework1_1
{
    partial class MainFormProgressbars
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
            this.flpBars = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edProgressbarsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edProgressbarsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBars
            // 
            this.flpBars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBars.AutoScroll = true;
            this.flpBars.Location = new System.Drawing.Point(13, 13);
            this.flpBars.Name = "flpBars";
            this.flpBars.Size = new System.Drawing.Size(549, 425);
            this.flpBars.TabIndex = 0;
            this.flpBars.SizeChanged += new System.EventHandler(this.flpBars_SizeChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(589, 174);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start the party!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of progressbars:";
            // 
            // edProgressbarsCount
            // 
            this.edProgressbarsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edProgressbarsCount.Location = new System.Drawing.Point(589, 44);
            this.edProgressbarsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edProgressbarsCount.Name = "edProgressbarsCount";
            this.edProgressbarsCount.Size = new System.Drawing.Size(180, 20);
            this.edProgressbarsCount.TabIndex = 3;
            this.edProgressbarsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainFormProgressbars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edProgressbarsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flpBars);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainFormProgressbars";
            this.Text = "Dancing progressbars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormProgressbars_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.edProgressbarsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBars;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edProgressbarsCount;
    }
}

