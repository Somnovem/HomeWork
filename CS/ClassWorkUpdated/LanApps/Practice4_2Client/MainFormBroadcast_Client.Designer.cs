namespace Practice4_2Client
{
    partial class MainFormBroadcast_Client
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
            this.lbMessages = new CustomControls.ListBoxMultiline();
            this.btnConnect = new System.Windows.Forms.Button();
            this.clbTypes = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edAddress = new System.Windows.Forms.TextBox();
            this.edPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessages
            // 
            this.lbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbMessages.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(13, 219);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(492, 317);
            this.lbMessages.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(361, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(144, 39);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // clbTypes
            // 
            this.clbTypes.FormattingEnabled = true;
            this.clbTypes.Location = new System.Drawing.Point(13, 87);
            this.clbTypes.Name = "clbTypes";
            this.clbTypes.Size = new System.Drawing.Size(342, 109);
            this.clbTypes.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edPort);
            this.groupBox1.Controls.Add(this.edAddress);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbConnection";
            // 
            // edAddress
            // 
            this.edAddress.Location = new System.Drawing.Point(71, 19);
            this.edAddress.Name = "edAddress";
            this.edAddress.Size = new System.Drawing.Size(265, 20);
            this.edAddress.TabIndex = 0;
            this.edAddress.Text = "224.100.0.1";
            // 
            // edPort
            // 
            this.edPort.Location = new System.Drawing.Point(71, 42);
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
            this.edPort.Size = new System.Drawing.Size(265, 20);
            this.edPort.TabIndex = 1;
            this.edPort.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // MainFormBroadcast_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clbTypes);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbMessages);
            this.MinimumSize = new System.Drawing.Size(533, 589);
            this.Name = "MainFormBroadcast_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BroadcastChatter - Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.ListBoxMultiline lbMessages;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckedListBox clbTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edPort;
        private System.Windows.Forms.TextBox edAddress;
    }
}

