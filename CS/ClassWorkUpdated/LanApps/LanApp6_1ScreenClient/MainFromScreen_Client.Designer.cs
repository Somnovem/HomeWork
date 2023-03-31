namespace LanApp6_1ScreenClient
{
    partial class MainFromScreen_Client
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
            this.btnGetScreen = new System.Windows.Forms.Button();
            this.edScreen = new System.Windows.Forms.PictureBox();
            this.edAdress = new System.Windows.Forms.TextBox();
            this.edPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetScreen
            // 
            this.btnGetScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetScreen.Location = new System.Drawing.Point(788, 127);
            this.btnGetScreen.Name = "btnGetScreen";
            this.btnGetScreen.Size = new System.Drawing.Size(75, 23);
            this.btnGetScreen.TabIndex = 1;
            this.btnGetScreen.Text = "Get Screen";
            this.btnGetScreen.UseVisualStyleBackColor = true;
            this.btnGetScreen.Click += new System.EventHandler(this.btnGetScreen_Click);
            // 
            // edScreen
            // 
            this.edScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edScreen.Location = new System.Drawing.Point(12, 12);
            this.edScreen.Name = "edScreen";
            this.edScreen.Size = new System.Drawing.Size(730, 426);
            this.edScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edScreen.TabIndex = 2;
            this.edScreen.TabStop = false;
            // 
            // edAdress
            // 
            this.edAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edAdress.Location = new System.Drawing.Point(748, 32);
            this.edAdress.Name = "edAdress";
            this.edAdress.Size = new System.Drawing.Size(126, 20);
            this.edAdress.TabIndex = 3;
            this.edAdress.Text = "127.0.0.1";
            // 
            // edPort
            // 
            this.edPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edPort.Location = new System.Drawing.Point(754, 77);
            this.edPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edPort.Name = "edPort";
            this.edPort.Size = new System.Drawing.Size(120, 20);
            this.edPort.TabIndex = 4;
            this.edPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IPadress:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // MainFromScreen_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edPort);
            this.Controls.Add(this.edAdress);
            this.Controls.Add(this.edScreen);
            this.Controls.Add(this.btnGetScreen);
            this.Name = "MainFromScreen_Client";
            this.Text = "Get Remote Screen";
            ((System.ComponentModel.ISupportInitialize)(this.edScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetScreen;
        private System.Windows.Forms.PictureBox edScreen;
        private System.Windows.Forms.TextBox edAdress;
        private System.Windows.Forms.NumericUpDown edPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

