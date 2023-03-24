namespace Homework2_3Client
{
    partial class MainFormTcpDialogClient
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
            this.rbPCPC = new System.Windows.Forms.RadioButton();
            this.rbPCHuman = new System.Windows.Forms.RadioButton();
            this.rbHumanPC = new System.Windows.Forms.RadioButton();
            this.rbHumanHuman = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.edRemoteAdress = new System.Windows.Forms.TextBox();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbSending = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            this.gbSending.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.rbPCPC);
            this.gbConnection.Controls.Add(this.rbPCHuman);
            this.gbConnection.Controls.Add(this.rbHumanPC);
            this.gbConnection.Controls.Add(this.rbHumanHuman);
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Controls.Add(this.edRemotePort);
            this.gbConnection.Controls.Add(this.edRemoteAdress);
            this.gbConnection.Location = new System.Drawing.Point(13, 13);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(509, 178);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose the mode:";
            // 
            // rbPCPC
            // 
            this.rbPCPC.AutoSize = true;
            this.rbPCPC.Location = new System.Drawing.Point(125, 148);
            this.rbPCPC.Name = "rbPCPC";
            this.rbPCPC.Size = new System.Drawing.Size(68, 17);
            this.rbPCPC.TabIndex = 8;
            this.rbPCPC.Text = "PC -> PC";
            this.rbPCPC.UseVisualStyleBackColor = true;
            // 
            // rbPCHuman
            // 
            this.rbPCHuman.AutoSize = true;
            this.rbPCHuman.Location = new System.Drawing.Point(125, 111);
            this.rbPCHuman.Name = "rbPCHuman";
            this.rbPCHuman.Size = new System.Drawing.Size(88, 17);
            this.rbPCHuman.TabIndex = 7;
            this.rbPCHuman.Text = "PC -> Human";
            this.rbPCHuman.UseVisualStyleBackColor = true;
            // 
            // rbHumanPC
            // 
            this.rbHumanPC.AutoSize = true;
            this.rbHumanPC.Location = new System.Drawing.Point(10, 148);
            this.rbHumanPC.Name = "rbHumanPC";
            this.rbHumanPC.Size = new System.Drawing.Size(88, 17);
            this.rbHumanPC.TabIndex = 6;
            this.rbHumanPC.Text = "Human -> PC";
            this.rbHumanPC.UseVisualStyleBackColor = true;
            // 
            // rbHumanHuman
            // 
            this.rbHumanHuman.AutoSize = true;
            this.rbHumanHuman.Checked = true;
            this.rbHumanHuman.Location = new System.Drawing.Point(10, 111);
            this.rbHumanHuman.Name = "rbHumanHuman";
            this.rbHumanHuman.Size = new System.Drawing.Size(108, 17);
            this.rbHumanHuman.TabIndex = 5;
            this.rbHumanHuman.TabStop = true;
            this.rbHumanHuman.Text = "Human -> Human";
            this.rbHumanHuman.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(352, 39);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(129, 35);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remote Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remote Adress";
            // 
            // edRemotePort
            // 
            this.edRemotePort.Location = new System.Drawing.Point(90, 54);
            this.edRemotePort.Maximum = new decimal(new int[] {
            65535,
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
            this.edRemotePort.TabIndex = 1;
            this.edRemotePort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // edRemoteAdress
            // 
            this.edRemoteAdress.Location = new System.Drawing.Point(90, 20);
            this.edRemoteAdress.Name = "edRemoteAdress";
            this.edRemoteAdress.Size = new System.Drawing.Size(233, 20);
            this.edRemoteAdress.TabIndex = 0;
            this.edRemoteAdress.Text = "127.0.0.1";
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(13, 197);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(509, 264);
            this.lbMessages.TabIndex = 1;
            // 
            // gbSending
            // 
            this.gbSending.Controls.Add(this.btnSendMessage);
            this.gbSending.Controls.Add(this.label4);
            this.gbSending.Controls.Add(this.edMessage);
            this.gbSending.Enabled = false;
            this.gbSending.Location = new System.Drawing.Point(13, 496);
            this.gbSending.Name = "gbSending";
            this.gbSending.Size = new System.Drawing.Size(509, 83);
            this.gbSending.TabIndex = 2;
            this.gbSending.TabStop = false;
            this.gbSending.Text = "Sending messages";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 467);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear history";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(337, 43);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(144, 23);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Message(\'bye\' to exit):";
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(13, 48);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(263, 20);
            this.edMessage.TabIndex = 0;
            // 
            // MainFormTcpDialogClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbSending);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormTcpDialogClient";
            this.Text = "Tcp Chat using independent libraries - Client";
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
        private System.Windows.Forms.RadioButton rbPCPC;
        private System.Windows.Forms.RadioButton rbPCHuman;
        private System.Windows.Forms.RadioButton rbHumanPC;
        private System.Windows.Forms.RadioButton rbHumanHuman;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.TextBox edRemoteAdress;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.GroupBox gbSending;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edMessage;
    }
}

