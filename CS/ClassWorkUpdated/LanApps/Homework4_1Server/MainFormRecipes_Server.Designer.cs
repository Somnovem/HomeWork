namespace Homework4_1Server
{
    partial class MainFormRecipes_Server
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
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.edRequestsPerHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edMaxClients = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbMessages = new CustomControls.ListBoxMultiline();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRequestsPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxClients)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btnStop);
            this.gbSettings.Controls.Add(this.btnStart);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.edMaxClients);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.edRequestsPerHour);
            this.gbSettings.Location = new System.Drawing.Point(13, 13);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(517, 148);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // edRequestsPerHour
            // 
            this.edRequestsPerHour.Location = new System.Drawing.Point(26, 41);
            this.edRequestsPerHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edRequestsPerHour.Name = "edRequestsPerHour";
            this.edRequestsPerHour.Size = new System.Drawing.Size(192, 20);
            this.edRequestsPerHour.TabIndex = 0;
            this.edRequestsPerHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requests per hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Concurrent clients";
            // 
            // edMaxClients
            // 
            this.edMaxClients.Location = new System.Drawing.Point(26, 90);
            this.edMaxClients.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edMaxClients.Name = "edMaxClients";
            this.edMaxClients.Size = new System.Drawing.Size(192, 20);
            this.edMaxClients.TabIndex = 2;
            this.edMaxClients.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(284, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(176, 44);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start the server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbMessages.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(13, 178);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(517, 460);
            this.lbMessages.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(284, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(176, 44);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop the server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainFormRecipes_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 660);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.gbSettings);
            this.Name = "MainFormRecipes_Server";
            this.Text = "Recipes - Server";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRequestsPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRequestsPerHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edMaxClients;
        private System.Windows.Forms.Button btnStart;
        private CustomControls.ListBoxMultiline lbMessages;
        private System.Windows.Forms.Button btnStop;
    }
}

