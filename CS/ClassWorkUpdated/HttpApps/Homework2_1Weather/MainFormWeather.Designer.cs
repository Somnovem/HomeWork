namespace Homework2_1Weather
{
    partial class MainFormWeather
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
            this.edCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblWeather = new System.Windows.Forms.Label();
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.lbDays = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // edCity
            // 
            this.edCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edCity.Location = new System.Drawing.Point(27, 43);
            this.edCity.Name = "edCity";
            this.edCity.Size = new System.Drawing.Size(210, 22);
            this.edCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "City";
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(41, 85);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(149, 33);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "Get weather for 5 days";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblWeather
            // 
            this.lblWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeather.Location = new System.Drawing.Point(237, 237);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(0, 24);
            this.lblWeather.TabIndex = 3;
            // 
            // pbWeather
            // 
            this.pbWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWeather.Location = new System.Drawing.Point(286, 12);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(240, 203);
            this.pbWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeather.TabIndex = 4;
            this.pbWeather.TabStop = false;
            // 
            // lbDays
            // 
            this.lbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDays.FormattingEnabled = true;
            this.lbDays.ItemHeight = 20;
            this.lbDays.Location = new System.Drawing.Point(27, 164);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(103, 104);
            this.lbDays.TabIndex = 2;
            this.lbDays.SelectedIndexChanged += new System.EventHandler(this.lbDays_SelectedIndexChanged);
            // 
            // MainFormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 433);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.pbWeather);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edCity);
            this.MinimumSize = new System.Drawing.Size(567, 472);
            this.Name = "MainFormWeather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.PictureBox pbWeather;
        private System.Windows.Forms.ListBox lbDays;
    }
}

