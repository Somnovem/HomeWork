namespace SysApps9_1
{
    partial class MainForm9_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm9_1));
            this.btnSetHook = new System.Windows.Forms.Button();
            this.btnReleaseHook = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnReleaseMouseHook = new System.Windows.Forms.Button();
            this.btnSetMouseHook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetHook
            // 
            this.btnSetHook.Location = new System.Drawing.Point(12, 12);
            this.btnSetHook.Name = "btnSetHook";
            this.btnSetHook.Size = new System.Drawing.Size(98, 23);
            this.btnSetHook.TabIndex = 0;
            this.btnSetHook.Text = "Set hook";
            this.btnSetHook.UseVisualStyleBackColor = true;
            this.btnSetHook.Click += new System.EventHandler(this.btnSetHook_Click);
            // 
            // btnReleaseHook
            // 
            this.btnReleaseHook.Enabled = false;
            this.btnReleaseHook.Location = new System.Drawing.Point(116, 12);
            this.btnReleaseHook.Name = "btnReleaseHook";
            this.btnReleaseHook.Size = new System.Drawing.Size(98, 23);
            this.btnReleaseHook.TabIndex = 1;
            this.btnReleaseHook.Text = "Release hook";
            this.btnReleaseHook.UseVisualStyleBackColor = true;
            this.btnReleaseHook.Click += new System.EventHandler(this.btnReleaseHook_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(13, 42);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(449, 290);
            this.lbHistory.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Key Locker in progress";
            this.notifyIcon1.BalloonTipTitle = "Key Locker";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // btnReleaseMouseHook
            // 
            this.btnReleaseMouseHook.Enabled = false;
            this.btnReleaseMouseHook.Location = new System.Drawing.Point(324, 13);
            this.btnReleaseMouseHook.Name = "btnReleaseMouseHook";
            this.btnReleaseMouseHook.Size = new System.Drawing.Size(138, 23);
            this.btnReleaseMouseHook.TabIndex = 4;
            this.btnReleaseMouseHook.Text = "Release mouse hook";
            this.btnReleaseMouseHook.UseVisualStyleBackColor = true;
            this.btnReleaseMouseHook.Click += new System.EventHandler(this.btnReleaseMouseHook_Click);
            // 
            // btnSetMouseHook
            // 
            this.btnSetMouseHook.Location = new System.Drawing.Point(220, 13);
            this.btnSetMouseHook.Name = "btnSetMouseHook";
            this.btnSetMouseHook.Size = new System.Drawing.Size(98, 23);
            this.btnSetMouseHook.TabIndex = 3;
            this.btnSetMouseHook.Text = "Set mouse hook";
            this.btnSetMouseHook.UseVisualStyleBackColor = true;
            this.btnSetMouseHook.Click += new System.EventHandler(this.btnSetMouseHook_Click);
            // 
            // MainForm9_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.btnReleaseMouseHook);
            this.Controls.Add(this.btnSetMouseHook);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnReleaseHook);
            this.Controls.Add(this.btnSetHook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm9_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Hooks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetHook;
        private System.Windows.Forms.Button btnReleaseHook;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnReleaseMouseHook;
        private System.Windows.Forms.Button btnSetMouseHook;
    }
}

