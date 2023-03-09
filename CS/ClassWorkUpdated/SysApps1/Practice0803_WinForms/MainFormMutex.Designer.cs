namespace Practice0803_WinForms
{
    partial class MainFormMutex
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
            this.lbCounter = new System.Windows.Forms.ListBox();
            this.lbArray = new System.Windows.Forms.ListBox();
            this.edMax = new System.Windows.Forms.NumericUpDown();
            this.btnOperationGenerate = new System.Windows.Forms.Button();
            this.btnOperationArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCounter
            // 
            this.lbCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCounter.FormattingEnabled = true;
            this.lbCounter.Location = new System.Drawing.Point(12, 73);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(286, 303);
            this.lbCounter.TabIndex = 0;
            // 
            // lbArray
            // 
            this.lbArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbArray.FormattingEnabled = true;
            this.lbArray.Location = new System.Drawing.Point(342, 73);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(286, 303);
            this.lbArray.TabIndex = 1;
            // 
            // edMax
            // 
            this.edMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edMax.Location = new System.Drawing.Point(654, 209);
            this.edMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edMax.Name = "edMax";
            this.edMax.ReadOnly = true;
            this.edMax.Size = new System.Drawing.Size(120, 20);
            this.edMax.TabIndex = 2;
            // 
            // btnOperationGenerate
            // 
            this.btnOperationGenerate.Location = new System.Drawing.Point(50, 12);
            this.btnOperationGenerate.Name = "btnOperationGenerate";
            this.btnOperationGenerate.Size = new System.Drawing.Size(198, 55);
            this.btnOperationGenerate.TabIndex = 3;
            this.btnOperationGenerate.Text = "Generate numbers from 0 to 20 and then from 10 to 0";
            this.btnOperationGenerate.UseVisualStyleBackColor = true;
            this.btnOperationGenerate.Click += new System.EventHandler(this.btnOperationGenerate_Click);
            // 
            // btnOperationArray
            // 
            this.btnOperationArray.Location = new System.Drawing.Point(386, 12);
            this.btnOperationArray.Name = "btnOperationArray";
            this.btnOperationArray.Size = new System.Drawing.Size(198, 55);
            this.btnOperationArray.TabIndex = 4;
            this.btnOperationArray.Text = "Fill an array, increase items by  random amount, show it and find the max";
            this.btnOperationArray.UseVisualStyleBackColor = true;
            this.btnOperationArray.Click += new System.EventHandler(this.brnOperationArray_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Maximum:";
            // 
            // MainFormMutex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOperationArray);
            this.Controls.Add(this.btnOperationGenerate);
            this.Controls.Add(this.edMax);
            this.Controls.Add(this.lbArray);
            this.Controls.Add(this.lbCounter);
            this.Name = "MainFormMutex";
            this.Text = "Multithreading";
            ((System.ComponentModel.ISupportInitialize)(this.edMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCounter;
        private System.Windows.Forms.ListBox lbArray;
        private System.Windows.Forms.NumericUpDown edMax;
        private System.Windows.Forms.Button btnOperationGenerate;
        private System.Windows.Forms.Button btnOperationArray;
        private System.Windows.Forms.Label label1;
    }
}

