namespace LanApp5_1UDPClient
{
    partial class MainFormUDPClient
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbSendMessages = new System.Windows.Forms.GroupBox();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edLocalPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.edRemoteAdress = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbSendMessages.SuspendLayout();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLocalPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(201, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear  History";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(391, 118);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(142, 23);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(142, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbSendMessages
            // 
            this.gbSendMessages.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbSendMessages.Controls.Add(this.edMessage);
            this.gbSendMessages.Controls.Add(this.btnSendMessage);
            this.gbSendMessages.Enabled = false;
            this.gbSendMessages.Location = new System.Drawing.Point(12, 491);
            this.gbSendMessages.Name = "gbSendMessages";
            this.gbSendMessages.Size = new System.Drawing.Size(521, 44);
            this.gbSendMessages.TabIndex = 10;
            this.gbSendMessages.TabStop = false;
            this.gbSendMessages.Text = "Send message";
            // 
            // edMessage
            // 
            this.edMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edMessage.Location = new System.Drawing.Point(10, 19);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(391, 20);
            this.edMessage.TabIndex = 5;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Location = new System.Drawing.Point(407, 15);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(108, 23);
            this.btnSendMessage.TabIndex = 6;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(12, 161);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(521, 303);
            this.lbMessages.TabIndex = 9;
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.edLocalPort);
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Controls.Add(this.edRemotePort);
            this.gbConnection.Controls.Add(this.edRemoteAdress);
            this.gbConnection.Location = new System.Drawing.Point(12, 2);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(521, 110);
            this.gbConnection.TabIndex = 6;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Local port";
            // 
            // edLocalPort
            // 
            this.edLocalPort.Location = new System.Drawing.Point(91, 84);
            this.edLocalPort.Maximum = new decimal(new int[] {
            65456,
            0,
            0,
            0});
            this.edLocalPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edLocalPort.Name = "edLocalPort";
            this.edLocalPort.Size = new System.Drawing.Size(120, 20);
            this.edLocalPort.TabIndex = 10;
            this.edLocalPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.edRemoteAdress.Size = new System.Drawing.Size(424, 20);
            this.edRemoteAdress.TabIndex = 0;
            this.edRemoteAdress.Text = "127.0.0.1";
            // 
            // MainFormUDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 555);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbSendMessages);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormUDPClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test UDP Client";
            this.gbSendMessages.ResumeLayout(false);
            this.gbSendMessages.PerformLayout();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLocalPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbSendMessages;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.TextBox edRemoteAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edLocalPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

