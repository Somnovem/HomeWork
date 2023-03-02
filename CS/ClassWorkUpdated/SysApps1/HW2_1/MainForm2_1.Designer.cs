namespace HW2_1
{
    partial class MainForm2_1
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
            this.btnStartEmpty = new System.Windows.Forms.Button();
            this.btnStartMath = new System.Windows.Forms.Button();
            this.btnStartFile = new System.Windows.Forms.Button();
            this.edPath = new System.Windows.Forms.TextBox();
            this.edFileName = new System.Windows.Forms.TextBox();
            this.edMathFirst = new System.Windows.Forms.NumericUpDown();
            this.edMathSecond = new System.Windows.Forms.NumericUpDown();
            this.cbMathSign = new System.Windows.Forms.ComboBox();
            this.btnKillChild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edMathFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMathSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartEmpty
            // 
            this.btnStartEmpty.Location = new System.Drawing.Point(12, 31);
            this.btnStartEmpty.Name = "btnStartEmpty";
            this.btnStartEmpty.Size = new System.Drawing.Size(150, 60);
            this.btnStartEmpty.TabIndex = 0;
            this.btnStartEmpty.Text = "Start empty form";
            this.btnStartEmpty.UseVisualStyleBackColor = true;
            this.btnStartEmpty.Click += new System.EventHandler(this.btnStartEmpty_Click);
            // 
            // btnStartMath
            // 
            this.btnStartMath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartMath.Location = new System.Drawing.Point(195, 378);
            this.btnStartMath.Name = "btnStartMath";
            this.btnStartMath.Size = new System.Drawing.Size(150, 60);
            this.btnStartMath.TabIndex = 2;
            this.btnStartMath.Text = "Start Math form";
            this.btnStartMath.UseVisualStyleBackColor = true;
            this.btnStartMath.Click += new System.EventHandler(this.btnStartMath_Click);
            // 
            // btnStartFile
            // 
            this.btnStartFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartFile.Location = new System.Drawing.Point(388, 378);
            this.btnStartFile.Name = "btnStartFile";
            this.btnStartFile.Size = new System.Drawing.Size(150, 60);
            this.btnStartFile.TabIndex = 3;
            this.btnStartFile.Text = "Start File form";
            this.btnStartFile.UseVisualStyleBackColor = true;
            this.btnStartFile.Click += new System.EventHandler(this.btnStartFile_Click);
            // 
            // edPath
            // 
            this.edPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edPath.Location = new System.Drawing.Point(388, 204);
            this.edPath.Name = "edPath";
            this.edPath.ReadOnly = true;
            this.edPath.Size = new System.Drawing.Size(150, 20);
            this.edPath.TabIndex = 7;
            this.edPath.Text = "C:\\";
            // 
            // edFileName
            // 
            this.edFileName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edFileName.Location = new System.Drawing.Point(388, 300);
            this.edFileName.Name = "edFileName";
            this.edFileName.Size = new System.Drawing.Size(150, 20);
            this.edFileName.TabIndex = 6;
            // 
            // edMathFirst
            // 
            this.edMathFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edMathFirst.Location = new System.Drawing.Point(195, 120);
            this.edMathFirst.Name = "edMathFirst";
            this.edMathFirst.Size = new System.Drawing.Size(150, 20);
            this.edMathFirst.TabIndex = 8;
            // 
            // edMathSecond
            // 
            this.edMathSecond.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edMathSecond.Location = new System.Drawing.Point(195, 204);
            this.edMathSecond.Name = "edMathSecond";
            this.edMathSecond.Size = new System.Drawing.Size(150, 20);
            this.edMathSecond.TabIndex = 9;
            // 
            // cbMathSign
            // 
            this.cbMathSign.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMathSign.FormattingEnabled = true;
            this.cbMathSign.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^"});
            this.cbMathSign.Location = new System.Drawing.Point(195, 300);
            this.cbMathSign.Name = "cbMathSign";
            this.cbMathSign.Size = new System.Drawing.Size(150, 21);
            this.cbMathSign.TabIndex = 10;
            // 
            // btnKillChild
            // 
            this.btnKillChild.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKillChild.Location = new System.Drawing.Point(626, 215);
            this.btnKillChild.Name = "btnKillChild";
            this.btnKillChild.Size = new System.Drawing.Size(150, 60);
            this.btnKillChild.TabIndex = 11;
            this.btnKillChild.Text = "KILL child form";
            this.btnKillChild.UseVisualStyleBackColor = true;
            this.btnKillChild.Click += new System.EventHandler(this.btnKillChild_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Second number";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sign";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Path to directory";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filter(extension or name)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(224, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Starting a child process with parameters";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(388, 173);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(150, 23);
            this.btnChooseFolder.TabIndex = 18;
            this.btnChooseFolder.Text = "Choose folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // MainForm2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKillChild);
            this.Controls.Add(this.cbMathSign);
            this.Controls.Add(this.edMathSecond);
            this.Controls.Add(this.edMathFirst);
            this.Controls.Add(this.edPath);
            this.Controls.Add(this.edFileName);
            this.Controls.Add(this.btnStartFile);
            this.Controls.Add(this.btnStartMath);
            this.Controls.Add(this.btnStartEmpty);
            this.MinimumSize = new System.Drawing.Size(650, 489);
            this.Name = "MainForm2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HW2_2";
            ((System.ComponentModel.ISupportInitialize)(this.edMathFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMathSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartEmpty;
        private System.Windows.Forms.Button btnStartMath;
        private System.Windows.Forms.Button btnStartFile;
        private System.Windows.Forms.TextBox edPath;
        private System.Windows.Forms.TextBox edFileName;
        private System.Windows.Forms.NumericUpDown edMathFirst;
        private System.Windows.Forms.NumericUpDown edMathSecond;
        private System.Windows.Forms.ComboBox cbMathSign;
        private System.Windows.Forms.Button btnKillChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btnChooseFolder;
    }
}

