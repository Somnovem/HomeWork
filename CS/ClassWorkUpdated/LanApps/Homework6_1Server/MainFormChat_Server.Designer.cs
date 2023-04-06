namespace Homework6_1Server
{
    partial class MainFormChat_Server
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbSending = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.gbConnection.SuspendLayout();
            this.gbSending.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(605, 130);
            this.gbConnection.TabIndex = 5;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(213, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(153, 43);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbSending
            // 
            this.gbSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSending.Controls.Add(this.btnSend);
            this.gbSending.Controls.Add(this.edMessage);
            this.gbSending.Controls.Add(this.cbType);
            this.gbSending.Enabled = false;
            this.gbSending.Location = new System.Drawing.Point(12, 158);
            this.gbSending.Name = "gbSending";
            this.gbSending.Size = new System.Drawing.Size(605, 81);
            this.gbSending.TabIndex = 7;
            this.gbSending.TabStop = false;
            this.gbSending.Text = "Sending messages";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(407, 45);
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
            this.edMessage.Size = new System.Drawing.Size(462, 20);
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
            // MainFormChat_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 272);
            this.Controls.Add(this.gbSending);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormChat_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat-Server";
            this.gbConnection.ResumeLayout(false);
            this.gbSending.ResumeLayout(false);
            this.gbSending.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbSending;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.ComboBox cbType;
    }
}

