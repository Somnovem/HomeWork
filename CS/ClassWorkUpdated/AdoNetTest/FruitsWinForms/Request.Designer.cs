namespace FruitsWinForms
{
    partial class Request
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
            this.edRequestText = new System.Windows.Forms.Label();
            this.edAnswer = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edRequestText
            // 
            this.edRequestText.AutoSize = true;
            this.edRequestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edRequestText.Location = new System.Drawing.Point(78, 68);
            this.edRequestText.Name = "edRequestText";
            this.edRequestText.Size = new System.Drawing.Size(44, 16);
            this.edRequestText.TabIndex = 0;
            this.edRequestText.Text = "label1";
            // 
            // edAnswer
            // 
            this.edAnswer.Location = new System.Drawing.Point(71, 104);
            this.edAnswer.Name = "edAnswer";
            this.edAnswer.Size = new System.Drawing.Size(239, 20);
            this.edAnswer.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(146, 155);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(95, 35);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 240);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.edAnswer);
            this.Controls.Add(this.edRequestText);
            this.Name = "Request";
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label edRequestText;
        private System.Windows.Forms.TextBox edAnswer;
        private System.Windows.Forms.Button btnEnter;
    }
}