namespace LanApp9_1
{
    partial class FormHTTPWindow
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHeaders = new System.Windows.Forms.ListBox();
            this.btnHTTPLoad = new System.Windows.Forms.Button();
            this.edHttpAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDownoloadFile = new System.Windows.Forms.Button();
            this.edFileAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edCurrencyDate = new System.Windows.Forms.DateTimePicker();
            this.btnCurrencyLoad = new System.Windows.Forms.Button();
            this.btnCurrencySave = new System.Windows.Forms.Button();
            this.rbXml = new System.Windows.Forms.RadioButton();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 460);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTTP Test";
            // 
            // edContent
            // 
            this.edContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edContent.Location = new System.Drawing.Point(9, 247);
            this.edContent.Multiline = true;
            this.edContent.Name = "edContent";
            this.edContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edContent.Size = new System.Drawing.Size(742, 204);
            this.edContent.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Content";
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
            // lbHeaders
            // 
            this.lbHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeaders.FormattingEnabled = true;
            this.lbHeaders.ItemHeight = 15;
            this.lbHeaders.Location = new System.Drawing.Point(6, 92);
            this.lbHeaders.Name = "lbHeaders";
            this.lbHeaders.ScrollAlwaysVisible = true;
            this.lbHeaders.Size = new System.Drawing.Size(745, 124);
            this.lbHeaders.TabIndex = 7;
            // 
            // btnHTTPLoad
            // 
            this.btnHTTPLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHTTPLoad.Location = new System.Drawing.Point(663, 37);
            this.btnHTTPLoad.Name = "btnHTTPLoad";
            this.btnHTTPLoad.Size = new System.Drawing.Size(106, 23);
            this.btnHTTPLoad.TabIndex = 6;
            this.btnHTTPLoad.Text = "Load";
            this.btnHTTPLoad.UseVisualStyleBackColor = true;
            this.btnHTTPLoad.Click += new System.EventHandler(this.btnHTTPLoad_Click);
            // 
            // edHttpAdress
            // 
            this.edHttpAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edHttpAdress.Location = new System.Drawing.Point(51, 39);
            this.edHttpAdress.Name = "edHttpAdress";
            this.edHttpAdress.Size = new System.Drawing.Size(606, 21);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbJson);
            this.groupBox1.Controls.Add(this.rbXml);
            this.groupBox1.Controls.Add(this.btnCurrencySave);
            this.groupBox1.Controls.Add(this.btnCurrencyLoad);
            this.groupBox1.Controls.Add(this.edCurrencyDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDownoloadFile);
            this.groupBox1.Controls.Add(this.edFileAdress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebClient";
            // 
            // btnDownoloadFile
            // 
            this.btnDownoloadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownoloadFile.Location = new System.Drawing.Point(660, 19);
            this.btnDownoloadFile.Name = "btnDownoloadFile";
            this.btnDownoloadFile.Size = new System.Drawing.Size(106, 23);
            this.btnDownoloadFile.TabIndex = 2;
            this.btnDownoloadFile.Text = "Downoload";
            this.btnDownoloadFile.UseVisualStyleBackColor = true;
            // 
            // edFileAdress
            // 
            this.edFileAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edFileAdress.Location = new System.Drawing.Point(51, 21);
            this.edFileAdress.Name = "edFileAdress";
            this.edFileAdress.Size = new System.Drawing.Size(603, 20);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Course UAH";
            // 
            // edCurrencyDate
            // 
            this.edCurrencyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edCurrencyDate.Location = new System.Drawing.Point(51, 54);
            this.edCurrencyDate.Name = "edCurrencyDate";
            this.edCurrencyDate.Size = new System.Drawing.Size(505, 20);
            this.edCurrencyDate.TabIndex = 4;
            // 
            // btnCurrencyLoad
            // 
            this.btnCurrencyLoad.Location = new System.Drawing.Point(562, 51);
            this.btnCurrencyLoad.Name = "btnCurrencyLoad";
            this.btnCurrencyLoad.Size = new System.Drawing.Size(83, 23);
            this.btnCurrencyLoad.TabIndex = 5;
            this.btnCurrencyLoad.Text = "Load";
            this.btnCurrencyLoad.UseVisualStyleBackColor = true;
            this.btnCurrencyLoad.Click += new System.EventHandler(this.btnCurrencyLoad_Click);
            // 
            // btnCurrencySave
            // 
            this.btnCurrencySave.Location = new System.Drawing.Point(651, 51);
            this.btnCurrencySave.Name = "btnCurrencySave";
            this.btnCurrencySave.Size = new System.Drawing.Size(83, 23);
            this.btnCurrencySave.TabIndex = 6;
            this.btnCurrencySave.Text = "Save";
            this.btnCurrencySave.UseVisualStyleBackColor = true;
            this.btnCurrencySave.Click += new System.EventHandler(this.btnCurrencySave_Click);
            // 
            // rbXml
            // 
            this.rbXml.AutoSize = true;
            this.rbXml.Checked = true;
            this.rbXml.Location = new System.Drawing.Point(168, 80);
            this.rbXml.Name = "rbXml";
            this.rbXml.Size = new System.Drawing.Size(42, 17);
            this.rbXml.TabIndex = 7;
            this.rbXml.TabStop = true;
            this.rbXml.Text = "Xml";
            this.rbXml.UseVisualStyleBackColor = true;
            this.rbXml.CheckedChanged += new System.EventHandler(this.rbXml_CheckedChanged);
            // 
            // rbJson
            // 
            this.rbJson.AutoSize = true;
            this.rbJson.Location = new System.Drawing.Point(271, 80);
            this.rbJson.Name = "rbJson";
            this.rbJson.Size = new System.Drawing.Size(47, 17);
            this.rbJson.TabIndex = 8;
            this.rbJson.Text = "Json";
            this.rbJson.UseVisualStyleBackColor = true;
            this.rbJson.CheckedChanged += new System.EventHandler(this.rbXml_CheckedChanged);
            // 
            // FormHTTPWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHTTPWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web test";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbHeaders;
        private System.Windows.Forms.Button btnHTTPLoad;
        private System.Windows.Forms.TextBox edHttpAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDownoloadFile;
        private System.Windows.Forms.TextBox edFileAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.RadioButton rbXml;
        private System.Windows.Forms.Button btnCurrencySave;
        private System.Windows.Forms.Button btnCurrencyLoad;
        private System.Windows.Forms.DateTimePicker edCurrencyDate;
        private System.Windows.Forms.Label label5;
    }
}

