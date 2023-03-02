namespace HW2_1Child
{
    partial class MainFormChild
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.edFilesResult = new System.Windows.Forms.TextBox();
            this.edMathResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of appearences:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Math result: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // edFilesResult
            // 
            this.edFilesResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edFilesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edFilesResult.Location = new System.Drawing.Point(328, 116);
            this.edFilesResult.Name = "edFilesResult";
            this.edFilesResult.ReadOnly = true;
            this.edFilesResult.Size = new System.Drawing.Size(177, 19);
            this.edFilesResult.TabIndex = 6;
            this.edFilesResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edMathResult
            // 
            this.edMathResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edMathResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edMathResult.Location = new System.Drawing.Point(53, 116);
            this.edMathResult.Name = "edMathResult";
            this.edMathResult.ReadOnly = true;
            this.edMathResult.Size = new System.Drawing.Size(177, 19);
            this.edMathResult.TabIndex = 5;
            this.edMathResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainFormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.edFilesResult);
            this.Controls.Add(this.edMathResult);
            this.MaximumSize = new System.Drawing.Size(574, 369);
            this.MinimumSize = new System.Drawing.Size(574, 369);
            this.Name = "MainFormChild";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox edFilesResult;
        private System.Windows.Forms.TextBox edMathResult;
    }
}

