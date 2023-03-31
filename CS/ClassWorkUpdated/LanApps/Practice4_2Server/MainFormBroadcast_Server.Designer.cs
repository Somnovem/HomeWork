namespace Practice4_2Server
{
    partial class MainFormBroadcast_Server
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
            this.gbSending = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edPort = new System.Windows.Forms.NumericUpDown();
            this.edAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSending.SuspendLayout();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSending
            // 
            this.gbSending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSending.Controls.Add(this.btnSend);
            this.gbSending.Controls.Add(this.edMessage);
            this.gbSending.Controls.Add(this.cbType);
            this.gbSending.Enabled = false;
            this.gbSending.Location = new System.Drawing.Point(13, 147);
            this.gbSending.Name = "gbSending";
            this.gbSending.Size = new System.Drawing.Size(493, 81);
            this.gbSending.TabIndex = 2;
            this.gbSending.TabStop = false;
            this.gbSending.Text = "Sending messages";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(281, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(192, 30);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(137, 19);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(350, 20);
            this.edMessage.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(6, 19);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(115, 21);
            this.cbType.TabIndex = 2;
            // 
            // gbConnection
            // 
            this.gbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.edPort);
            this.gbConnection.Controls.Add(this.edAddress);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Location = new System.Drawing.Point(13, 13);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(492, 130);
            this.gbConnection.TabIndex = 3;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(292, 81);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(153, 43);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // edPort
            // 
            this.edPort.Location = new System.Drawing.Point(20, 84);
            this.edPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edPort.Name = "edPort";
            this.edPort.Size = new System.Drawing.Size(204, 20);
            this.edPort.TabIndex = 2;
            this.edPort.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // edAddress
            // 
            this.edAddress.Location = new System.Drawing.Point(20, 37);
            this.edAddress.Name = "edAddress";
            this.edAddress.Size = new System.Drawing.Size(204, 20);
            this.edAddress.TabIndex = 1;
            this.edAddress.Text = "224.100.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adress";
            // 
            // MainFormBroadcast_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 235);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.gbSending);
            this.Name = "MainFormBroadcast_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BroadcastChatter - Server";
            this.gbSending.ResumeLayout(false);
            this.gbSending.PerformLayout();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSending;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edPort;
        private System.Windows.Forms.TextBox edAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
    }
}

