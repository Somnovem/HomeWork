namespace Homework2_1Server
{
    partial class MainFormTCPServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbSending = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbSending.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start the server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(295, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 48);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear history";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbSending
            // 
            this.gbSending.Controls.Add(this.btnSend);
            this.gbSending.Controls.Add(this.edMessage);
            this.gbSending.Enabled = false;
            this.gbSending.Location = new System.Drawing.Point(13, 415);
            this.gbSending.Name = "gbSending";
            this.gbSending.Size = new System.Drawing.Size(439, 89);
            this.gbSending.TabIndex = 2;
            this.gbSending.TabStop = false;
            this.gbSending.Text = "Sending messages";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
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
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(13, 86);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(439, 316);
            this.lbMessages.TabIndex = 3;
            // 
            // MainFormTCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 511);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbSending);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormTCPServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Chatter Server";
            this.gbSending.ResumeLayout(false);
            this.gbSending.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbSending;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.ListBox lbMessages;
    }
}

