namespace LanApp7_1Web
{
    partial class MainFormWebClient
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
            this.edFileAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownoloadFile = new System.Windows.Forms.Button();
            this.downoloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHTTPLoad = new System.Windows.Forms.Button();
            this.edHttpAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHeaders = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edContent = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // edFileAdress
            // 
            this.edFileAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edFileAdress.Location = new System.Drawing.Point(51, 21);
            this.edFileAdress.Name = "edFileAdress";
            this.edFileAdress.Size = new System.Drawing.Size(547, 20);
            this.edFileAdress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adress";
            // 
            // btnDownoloadFile
            // 
            this.btnDownoloadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownoloadFile.Location = new System.Drawing.Point(604, 19);
            this.btnDownoloadFile.Name = "btnDownoloadFile";
            this.btnDownoloadFile.Size = new System.Drawing.Size(106, 23);
            this.btnDownoloadFile.TabIndex = 2;
            this.btnDownoloadFile.Text = "Downoload";
            this.btnDownoloadFile.UseVisualStyleBackColor = true;
            this.btnDownoloadFile.Click += new System.EventHandler(this.btnDownoloadFile_Click);
            // 
            // downoloadProgressBar
            // 
            this.downoloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downoloadProgressBar.Location = new System.Drawing.Point(9, 48);
            this.downoloadProgressBar.Name = "downoloadProgressBar";
            this.downoloadProgressBar.Size = new System.Drawing.Size(695, 23);
            this.downoloadProgressBar.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDownoloadFile);
            this.groupBox1.Controls.Add(this.downoloadProgressBar);
            this.groupBox1.Controls.Add(this.edFileAdress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebClient";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.edContent);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbHeaders);
            this.groupBox2.Controls.Add(this.btnHTTPLoad);
            this.groupBox2.Controls.Add(this.edHttpAdress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 459);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTTP Test";
            // 
            // btnHTTPLoad
            // 
            this.btnHTTPLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHTTPLoad.Location = new System.Drawing.Point(604, 37);
            this.btnHTTPLoad.Name = "btnHTTPLoad";
            this.btnHTTPLoad.Size = new System.Drawing.Size(106, 23);
            this.btnHTTPLoad.TabIndex = 6;
            this.btnHTTPLoad.Text = "Downoload";
            this.btnHTTPLoad.UseVisualStyleBackColor = true;
            this.btnHTTPLoad.Click += new System.EventHandler(this.btnHTTPLoad_Click);
            // 
            // edHttpAdress
            // 
            this.edHttpAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edHttpAdress.Location = new System.Drawing.Point(51, 39);
            this.edHttpAdress.Name = "edHttpAdress";
            this.edHttpAdress.Size = new System.Drawing.Size(547, 21);
            this.edHttpAdress.TabIndex = 4;
            this.edHttpAdress.Text = "https://google.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adress";
            // 
            // lbHeaders
            // 
            this.lbHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeaders.FormattingEnabled = true;
            this.lbHeaders.ItemHeight = 15;
            this.lbHeaders.Location = new System.Drawing.Point(6, 92);
            this.lbHeaders.Name = "lbHeaders";
            this.lbHeaders.ScrollAlwaysVisible = true;
            this.lbHeaders.Size = new System.Drawing.Size(686, 184);
            this.lbHeaders.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Headers";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Content";
            // 
            // edContent
            // 
            this.edContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edContent.Location = new System.Drawing.Point(9, 314);
            this.edContent.Multiline = true;
            this.edContent.Name = "edContent";
            this.edContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edContent.Size = new System.Drawing.Size(683, 139);
            this.edContent.TabIndex = 11;
            // 
            // MainFormWebClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(764, 600);
            this.Name = "MainFormWebClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebClient Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox edFileAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownoloadFile;
        private System.Windows.Forms.ProgressBar downoloadProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbHeaders;
        private System.Windows.Forms.Button btnHTTPLoad;
        private System.Windows.Forms.TextBox edHttpAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edContent;
    }
}

