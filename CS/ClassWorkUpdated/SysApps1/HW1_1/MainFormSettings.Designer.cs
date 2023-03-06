namespace HW1_1
{
    partial class MainFormSettings
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
            this.lbClassStyles = new System.Windows.Forms.ListBox();
            this.lbStandartStyles = new System.Windows.Forms.ListBox();
            this.lbExtendedStyles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClassStyles
            // 
            this.lbClassStyles.FormattingEnabled = true;
            this.lbClassStyles.Location = new System.Drawing.Point(11, 38);
            this.lbClassStyles.Name = "lbClassStyles";
            this.lbClassStyles.Size = new System.Drawing.Size(238, 355);
            this.lbClassStyles.TabIndex = 1;
            this.lbClassStyles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbClassStyles_MouseDoubleClick);
            // 
            // lbStandartStyles
            // 
            this.lbStandartStyles.FormattingEnabled = true;
            this.lbStandartStyles.Location = new System.Drawing.Point(255, 38);
            this.lbStandartStyles.Name = "lbStandartStyles";
            this.lbStandartStyles.Size = new System.Drawing.Size(238, 355);
            this.lbStandartStyles.TabIndex = 2;
            this.lbStandartStyles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbStandartStyles_MouseDoubleClick);
            // 
            // lbExtendedStyles
            // 
            this.lbExtendedStyles.FormattingEnabled = true;
            this.lbExtendedStyles.Location = new System.Drawing.Point(499, 38);
            this.lbExtendedStyles.Name = "lbExtendedStyles";
            this.lbExtendedStyles.Size = new System.Drawing.Size(238, 355);
            this.lbExtendedStyles.TabIndex = 3;
            this.lbExtendedStyles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbExtendedStyles_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class styles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(329, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Standart styles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(575, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Extended styles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(252, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Double-clicking an item applies it";
            // 
            // MainFormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbExtendedStyles);
            this.Controls.Add(this.lbStandartStyles);
            this.Controls.Add(this.lbClassStyles);
            this.MaximumSize = new System.Drawing.Size(764, 485);
            this.MinimumSize = new System.Drawing.Size(764, 485);
            this.Name = "MainFormSettings";
            this.Text = "MainFormSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbClassStyles;
        private System.Windows.Forms.ListBox lbStandartStyles;
        private System.Windows.Forms.ListBox lbExtendedStyles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}