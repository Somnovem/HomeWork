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
            this.edSettingColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettingColor = new System.Windows.Forms.Button();
            this.btnSettingTitle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edSettingTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edSettingColor
            // 
            this.edSettingColor.Location = new System.Drawing.Point(12, 35);
            this.edSettingColor.Name = "edSettingColor";
            this.edSettingColor.Size = new System.Drawing.Size(233, 20);
            this.edSettingColor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter color: ";
            // 
            // btnSettingColor
            // 
            this.btnSettingColor.Location = new System.Drawing.Point(47, 61);
            this.btnSettingColor.Name = "btnSettingColor";
            this.btnSettingColor.Size = new System.Drawing.Size(165, 23);
            this.btnSettingColor.TabIndex = 2;
            this.btnSettingColor.Text = "Send";
            this.btnSettingColor.UseVisualStyleBackColor = true;
            this.btnSettingColor.Click += new System.EventHandler(this.btnSettingColor_Click);
            // 
            // btnSettingTitle
            // 
            this.btnSettingTitle.Location = new System.Drawing.Point(47, 157);
            this.btnSettingTitle.Name = "btnSettingTitle";
            this.btnSettingTitle.Size = new System.Drawing.Size(165, 23);
            this.btnSettingTitle.TabIndex = 5;
            this.btnSettingTitle.Text = "Send";
            this.btnSettingTitle.UseVisualStyleBackColor = true;
            this.btnSettingTitle.Click += new System.EventHandler(this.btnSettingTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter new title: ";
            // 
            // edSettingTitle
            // 
            this.edSettingTitle.Location = new System.Drawing.Point(12, 131);
            this.edSettingTitle.Name = "edSettingTitle";
            this.edSettingTitle.Size = new System.Drawing.Size(233, 20);
            this.edSettingTitle.TabIndex = 3;
            // 
            // MainFormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.btnSettingTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edSettingTitle);
            this.Controls.Add(this.btnSettingColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edSettingColor);
            this.Name = "MainFormSettings";
            this.Text = "MainFormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edSettingColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettingColor;
        private System.Windows.Forms.Button btnSettingTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edSettingTitle;
    }
}