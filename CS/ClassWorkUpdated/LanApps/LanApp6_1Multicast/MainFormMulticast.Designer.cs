namespace LanApp6_1Multicast
{
    partial class MainFormMulticast
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
            this.edNickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.edRemoteAdress = new System.Windows.Forms.TextBox();
            this.gbSendMessages.SuspendLayout();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(169, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear  History";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(299, 139);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(109, 23);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(26, 139);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbSendMessages
            // 
            this.gbSendMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSendMessages.Controls.Add(this.edMessage);
            this.gbSendMessages.Controls.Add(this.btnSendMessage);
            this.gbSendMessages.Enabled = false;
            this.gbSendMessages.Location = new System.Drawing.Point(25, 512);
            this.gbSendMessages.Name = "gbSendMessages";
            this.gbSendMessages.Size = new System.Drawing.Size(488, 44);
            this.gbSendMessages.TabIndex = 16;
            this.gbSendMessages.TabStop = false;
            this.gbSendMessages.Text = "Send message";
            // 
            // edMessage
            // 
            this.edMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edMessage.Location = new System.Drawing.Point(10, 19);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(358, 20);
            this.edMessage.TabIndex = 5;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Location = new System.Drawing.Point(374, 15);
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
            this.lbMessages.Location = new System.Drawing.Point(14, 182);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(495, 303);
            this.lbMessages.TabIndex = 15;
            // 
            // gbConnection
            // 
            this.gbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.edNickname);
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Controls.Add(this.edRemotePort);
            this.gbConnection.Controls.Add(this.edRemoteAdress);
            this.gbConnection.Location = new System.Drawing.Point(25, 23);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(488, 110);
            this.gbConnection.TabIndex = 12;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nickname";
            // 
            // edNickname
            // 
            this.edNickname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edNickname.Location = new System.Drawing.Point(91, 84);
            this.edNickname.Name = "edNickname";
            this.edNickname.Size = new System.Drawing.Size(207, 20);
            this.edNickname.TabIndex = 10;
            this.edNickname.Text = "user 1";
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
            this.edRemotePort.ReadOnly = true;
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
            this.edRemoteAdress.ReadOnly = true;
            this.edRemoteAdress.Size = new System.Drawing.Size(207, 20);
            this.edRemoteAdress.TabIndex = 0;
            this.edRemoteAdress.Text = "224.1.1.1";
            // 
            // MainFormMulticast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 579);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbSendMessages);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormMulticast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Multicast";
            this.gbSendMessages.ResumeLayout(false);
            this.gbSendMessages.PerformLayout();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
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
        private System.Windows.Forms.TextBox edNickname;
    }
}

