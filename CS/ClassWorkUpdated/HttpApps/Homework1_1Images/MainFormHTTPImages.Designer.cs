namespace Homework1_1Images
{
    partial class MainFormHTTPImages
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
            this.googleImages = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUseBing = new System.Windows.Forms.CheckBox();
            this.cbUseGoogle = new System.Windows.Forms.CheckBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edRequest = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGoogleNext = new System.Windows.Forms.Button();
            this.btnGoogleBack = new System.Windows.Forms.Button();
            this.pbGoogle = new System.Windows.Forms.PictureBox();
            this.browserGoogle = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBingNext = new System.Windows.Forms.Button();
            this.btnBingBack = new System.Windows.Forms.Button();
            this.pbBing = new System.Windows.Forms.PictureBox();
            this.browserBing = new System.Windows.Forms.WebBrowser();
            this.bingImages = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoogle)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBing)).BeginInit();
            this.SuspendLayout();
            // 
            // googleImages
            // 
            this.googleImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.googleImages.ImageSize = new System.Drawing.Size(16, 16);
            this.googleImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSendRequest);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.edRequest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUseBing);
            this.groupBox1.Controls.Add(this.cbUseGoogle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(158, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 238);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search engines";
            // 
            // cbUseBing
            // 
            this.cbUseBing.AutoSize = true;
            this.cbUseBing.Location = new System.Drawing.Point(22, 59);
            this.cbUseBing.Name = "cbUseBing";
            this.cbUseBing.Size = new System.Drawing.Size(64, 24);
            this.cbUseBing.TabIndex = 10;
            this.cbUseBing.Text = "Bing";
            this.cbUseBing.UseVisualStyleBackColor = true;
            // 
            // cbUseGoogle
            // 
            this.cbUseGoogle.AutoSize = true;
            this.cbUseGoogle.Location = new System.Drawing.Point(22, 33);
            this.cbUseGoogle.Name = "cbUseGoogle";
            this.cbUseGoogle.Size = new System.Drawing.Size(86, 24);
            this.cbUseGoogle.TabIndex = 9;
            this.cbUseGoogle.Text = "Google";
            this.cbUseGoogle.UseVisualStyleBackColor = true;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendRequest.Location = new System.Drawing.Point(429, 385);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(181, 43);
            this.btnSendRequest.TabIndex = 8;
            this.btnSendRequest.Text = "Send request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Request";
            // 
            // edRequest
            // 
            this.edRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edRequest.Location = new System.Drawing.Point(158, 355);
            this.edRequest.Name = "edRequest";
            this.edRequest.Size = new System.Drawing.Size(522, 24);
            this.edRequest.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGoogleNext);
            this.tabPage2.Controls.Add(this.btnGoogleBack);
            this.tabPage2.Controls.Add(this.pbGoogle);
            this.tabPage2.Controls.Add(this.browserGoogle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Google";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGoogleNext
            // 
            this.btnGoogleNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoogleNext.Location = new System.Drawing.Point(943, 209);
            this.btnGoogleNext.Name = "btnGoogleNext";
            this.btnGoogleNext.Size = new System.Drawing.Size(30, 30);
            this.btnGoogleNext.TabIndex = 14;
            this.btnGoogleNext.Text = ">";
            this.btnGoogleNext.UseVisualStyleBackColor = true;
            this.btnGoogleNext.Click += new System.EventHandler(this.btnGoogleNext_Click);
            // 
            // btnGoogleBack
            // 
            this.btnGoogleBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoogleBack.Location = new System.Drawing.Point(850, 209);
            this.btnGoogleBack.Name = "btnGoogleBack";
            this.btnGoogleBack.Size = new System.Drawing.Size(30, 30);
            this.btnGoogleBack.TabIndex = 13;
            this.btnGoogleBack.Text = "<";
            this.btnGoogleBack.UseVisualStyleBackColor = true;
            this.btnGoogleBack.Click += new System.EventHandler(this.btnGoogleBack_Click);
            // 
            // pbGoogle
            // 
            this.pbGoogle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbGoogle.Location = new System.Drawing.Point(816, 245);
            this.pbGoogle.Name = "pbGoogle";
            this.pbGoogle.Size = new System.Drawing.Size(205, 200);
            this.pbGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGoogle.TabIndex = 12;
            this.pbGoogle.TabStop = false;
            // 
            // browserGoogle
            // 
            this.browserGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserGoogle.IsWebBrowserContextMenuEnabled = false;
            this.browserGoogle.Location = new System.Drawing.Point(3, 3);
            this.browserGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserGoogle.Name = "browserGoogle";
            this.browserGoogle.ScriptErrorsSuppressed = true;
            this.browserGoogle.Size = new System.Drawing.Size(807, 572);
            this.browserGoogle.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBingNext);
            this.tabPage3.Controls.Add(this.btnBingBack);
            this.tabPage3.Controls.Add(this.pbBing);
            this.tabPage3.Controls.Add(this.browserBing);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1027, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBingNext
            // 
            this.btnBingNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBingNext.Location = new System.Drawing.Point(943, 209);
            this.btnBingNext.Name = "btnBingNext";
            this.btnBingNext.Size = new System.Drawing.Size(30, 30);
            this.btnBingNext.TabIndex = 18;
            this.btnBingNext.Text = ">";
            this.btnBingNext.UseVisualStyleBackColor = true;
            this.btnBingNext.Click += new System.EventHandler(this.btnBingNext_Click);
            // 
            // btnBingBack
            // 
            this.btnBingBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBingBack.Location = new System.Drawing.Point(850, 209);
            this.btnBingBack.Name = "btnBingBack";
            this.btnBingBack.Size = new System.Drawing.Size(30, 30);
            this.btnBingBack.TabIndex = 17;
            this.btnBingBack.Text = "<";
            this.btnBingBack.UseVisualStyleBackColor = true;
            this.btnBingBack.Click += new System.EventHandler(this.btnBingBack_Click);
            // 
            // pbBing
            // 
            this.pbBing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbBing.Location = new System.Drawing.Point(816, 245);
            this.pbBing.Name = "pbBing";
            this.pbBing.Size = new System.Drawing.Size(205, 200);
            this.pbBing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBing.TabIndex = 16;
            this.pbBing.TabStop = false;
            // 
            // browserBing
            // 
            this.browserBing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserBing.IsWebBrowserContextMenuEnabled = false;
            this.browserBing.Location = new System.Drawing.Point(4, 4);
            this.browserBing.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserBing.Name = "browserBing";
            this.browserBing.ScriptErrorsSuppressed = true;
            this.browserBing.Size = new System.Drawing.Size(806, 572);
            this.browserBing.TabIndex = 15;
            // 
            // bingImages
            // 
            this.bingImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.bingImages.ImageSize = new System.Drawing.Size(16, 16);
            this.bingImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainFormHTTPImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 607);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(900, 644);
            this.Name = "MainFormHTTPImages";
            this.Text = "HTTP requests";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGoogle)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList googleImages;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edRequest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser browserGoogle;
        private System.Windows.Forms.Button btnGoogleNext;
        private System.Windows.Forms.Button btnGoogleBack;
        private System.Windows.Forms.PictureBox pbGoogle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUseGoogle;
        private System.Windows.Forms.CheckBox cbUseBing;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList bingImages;
        private System.Windows.Forms.Button btnBingNext;
        private System.Windows.Forms.Button btnBingBack;
        private System.Windows.Forms.PictureBox pbBing;
        private System.Windows.Forms.WebBrowser browserBing;
    }
}

