using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Plus = new System.Windows.Forms.Button();
            this.Btn_Equals = new System.Windows.Forms.Button();
            this.Btn_Substract = new System.Windows.Forms.Button();
            this.Btn_Multiply = new System.Windows.Forms.Button();
            this.Btn_Divide = new System.Windows.Forms.Button();
            this.Btn_Root = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Plus
            // 
            this.Btn_Plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Plus.Location = new System.Drawing.Point(393, 365);
            this.Btn_Plus.Name = "Btn_Plus";
            this.Btn_Plus.Size = new System.Drawing.Size(80, 70);
            this.Btn_Plus.TabIndex = 0;
            this.Btn_Plus.Text = "+";
            // 
            // Btn_Equals
            // 
            this.Btn_Equals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Equals.Location = new System.Drawing.Point(393, 441);
            this.Btn_Equals.Name = "Btn_Equals";
            this.Btn_Equals.Size = new System.Drawing.Size(80, 70);
            this.Btn_Equals.TabIndex = 1;
            this.Btn_Equals.Text = "=";
            // 
            // Btn_Substract
            // 
            this.Btn_Substract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Substract.Location = new System.Drawing.Point(393, 289);
            this.Btn_Substract.Name = "Btn_Substract";
            this.Btn_Substract.Size = new System.Drawing.Size(80, 70);
            this.Btn_Substract.TabIndex = 2;
            this.Btn_Substract.Text = "-";
            // 
            // Btn_Multiply
            // 
            this.Btn_Multiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Multiply.Location = new System.Drawing.Point(393, 213);
            this.Btn_Multiply.Name = "Btn_Multiply";
            this.Btn_Multiply.Size = new System.Drawing.Size(80, 70);
            this.Btn_Multiply.TabIndex = 3;
            this.Btn_Multiply.Text = "*";
            // 
            // Btn_Divide
            // 
            this.Btn_Divide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Divide.Location = new System.Drawing.Point(393, 137);
            this.Btn_Divide.Name = "Btn_Divide";
            this.Btn_Divide.Size = new System.Drawing.Size(80, 70);
            this.Btn_Divide.TabIndex = 4;
            this.Btn_Divide.Text = "/";
            // 
            // Btn_Root
            // 
            this.Btn_Root.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Root.Image")));
            this.Btn_Root.Location = new System.Drawing.Point(307, 138);
            this.Btn_Root.Name = "Btn_Root";
            this.Btn_Root.Size = new System.Drawing.Size(80, 68);
            this.Btn_Root.TabIndex = 5;
            this.Btn_Root.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 513);
            this.Controls.Add(this.Btn_Root);
            this.Controls.Add(this.Btn_Divide);
            this.Controls.Add(this.Btn_Multiply);
            this.Controls.Add(this.Btn_Substract);
            this.Controls.Add(this.Btn_Plus);
            this.Controls.Add(this.Btn_Equals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_Plus;
        private Button Btn_Equals;
        private Button Btn_Substract;
        private Button Btn_Multiply;
        private Button Btn_Divide;
        private Button Btn_Root;
    }
}

