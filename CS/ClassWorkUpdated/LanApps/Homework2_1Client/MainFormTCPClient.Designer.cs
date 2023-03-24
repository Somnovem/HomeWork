namespace Homework2_1Client
{
    partial class MainFormTCPClient
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
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.edRemoteAdress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbSending = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            this.gbSending.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Controls.Add(this.edRemotePort);
            this.gbConnection.Controls.Add(this.edRemoteAdress);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(440, 84);
            this.gbConnection.TabIndex = 1;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remote port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Remote adress";
            // 
            // edRemotePort
            // 
            this.edRemotePort.Location = new System.Drawing.Point(91, 56);
            this.edRemotePort.Maximum = new decimal(new int[] {
            65456,
            0,
            0,
            0});
            this.edRemotePort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edRemotePort.Name = "edRemotePort";
            this.edRemotePort.Size = new System.Drawing.Size(120, 20);
            this.edRemotePort.TabIndex = 2;
            this.edRemotePort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // edRemoteAdress
            // 
            this.edRemoteAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edRemoteAdress.Location = new System.Drawing.Point(91, 30);
            this.edRemoteAdress.Name = "edRemoteAdress";
            this.edRemoteAdress.Size = new System.Drawing.Size(343, 20);
            this.edRemoteAdress.TabIndex = 0;
            this.edRemoteAdress.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(43, 102);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(142, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(265, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear  History";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(12, 140);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(439, 251);
            this.lbMessages.TabIndex = 8;
            // 
            // gbSending
            // 
            this.gbSending.Controls.Add(this.btnSend);
            this.gbSending.Controls.Add(this.edMessage);
            this.gbSending.Enabled = false;
            this.gbSending.Location = new System.Drawing.Point(12, 404);
            this.gbSending.Name = "gbSending";
            this.gbSending.Size = new System.Drawing.Size(439, 89);
            this.gbSending.TabIndex = 7;
            this.gbSending.TabStop = false;
            this.gbSending.Text = "Sending messages";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(320, 30);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 39);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(6, 40);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(308, 20);
            this.edMessage.TabIndex = 0;
            // 
            // MainFormTCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 511);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbSending);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormTCPClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Chatter Client";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).EndInit();
            this.gbSending.ResumeLayout(false);
            this.gbSending.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.TextBox edRemoteAdress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.GroupBox gbSending;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edMessage;
    }
}

