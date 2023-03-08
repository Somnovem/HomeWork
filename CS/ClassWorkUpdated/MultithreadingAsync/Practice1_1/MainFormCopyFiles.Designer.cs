namespace Practice1_1
{
    partial class MainFormCopyFiles
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
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRemoveSelectedFile = new System.Windows.Forms.Button();
            this.btnClearListFiles = new System.Windows.Forms.Button();
            this.btnCopyStart = new System.Windows.Forms.Button();
            this.btnCopyFreeze = new System.Windows.Forms.Button();
            this.btnCopyAbort = new System.Windows.Forms.Button();
            this.btnCopyResume = new System.Windows.Forms.Button();
            this.edThreadsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.edDestination = new System.Windows.Forms.Label();
            this.btnDestinFolder = new System.Windows.Forms.Button();
            this.folderSearch = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSearch = new System.Windows.Forms.OpenFileDialog();
            this.edProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.cbSimulation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edThreadsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.HorizontalScrollbar = true;
            this.lbFiles.Location = new System.Drawing.Point(12, 73);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(346, 277);
            this.lbFiles.TabIndex = 0;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 44);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(124, 23);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Add file";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRemoveSelectedFile
            // 
            this.btnRemoveSelectedFile.Location = new System.Drawing.Point(234, 45);
            this.btnRemoveSelectedFile.Name = "btnRemoveSelectedFile";
            this.btnRemoveSelectedFile.Size = new System.Drawing.Size(124, 23);
            this.btnRemoveSelectedFile.TabIndex = 2;
            this.btnRemoveSelectedFile.Text = "Remove selected";
            this.btnRemoveSelectedFile.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedFile.Click += new System.EventHandler(this.btnRemoveSelectedFile_Click);
            // 
            // btnClearListFiles
            // 
            this.btnClearListFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearListFiles.Location = new System.Drawing.Point(100, 356);
            this.btnClearListFiles.Name = "btnClearListFiles";
            this.btnClearListFiles.Size = new System.Drawing.Size(124, 23);
            this.btnClearListFiles.TabIndex = 3;
            this.btnClearListFiles.Text = "Clear list";
            this.btnClearListFiles.UseVisualStyleBackColor = true;
            this.btnClearListFiles.Click += new System.EventHandler(this.btnClearListFiles_Click);
            // 
            // btnCopyStart
            // 
            this.btnCopyStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyStart.Location = new System.Drawing.Point(526, 97);
            this.btnCopyStart.Name = "btnCopyStart";
            this.btnCopyStart.Size = new System.Drawing.Size(124, 38);
            this.btnCopyStart.TabIndex = 4;
            this.btnCopyStart.Text = "Start";
            this.btnCopyStart.UseVisualStyleBackColor = true;
            this.btnCopyStart.Click += new System.EventHandler(this.btnCopyStart_Click);
            // 
            // btnCopyFreeze
            // 
            this.btnCopyFreeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFreeze.Location = new System.Drawing.Point(526, 156);
            this.btnCopyFreeze.Name = "btnCopyFreeze";
            this.btnCopyFreeze.Size = new System.Drawing.Size(124, 38);
            this.btnCopyFreeze.TabIndex = 5;
            this.btnCopyFreeze.Text = "Freeze";
            this.btnCopyFreeze.UseVisualStyleBackColor = true;
            this.btnCopyFreeze.Click += new System.EventHandler(this.btnCopyFreeze_Click);
            // 
            // btnCopyAbort
            // 
            this.btnCopyAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyAbort.Location = new System.Drawing.Point(656, 97);
            this.btnCopyAbort.Name = "btnCopyAbort";
            this.btnCopyAbort.Size = new System.Drawing.Size(124, 38);
            this.btnCopyAbort.TabIndex = 6;
            this.btnCopyAbort.Text = "Abort(Stop)";
            this.btnCopyAbort.UseVisualStyleBackColor = true;
            this.btnCopyAbort.Click += new System.EventHandler(this.btnCopyAbort_Click);
            // 
            // btnCopyResume
            // 
            this.btnCopyResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyResume.Location = new System.Drawing.Point(656, 156);
            this.btnCopyResume.Name = "btnCopyResume";
            this.btnCopyResume.Size = new System.Drawing.Size(124, 38);
            this.btnCopyResume.TabIndex = 7;
            this.btnCopyResume.Text = "Resume";
            this.btnCopyResume.UseVisualStyleBackColor = true;
            this.btnCopyResume.Click += new System.EventHandler(this.btnCopyResume_Click);
            // 
            // edThreadsCount
            // 
            this.edThreadsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edThreadsCount.Location = new System.Drawing.Point(572, 45);
            this.edThreadsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edThreadsCount.Name = "edThreadsCount";
            this.edThreadsCount.Size = new System.Drawing.Size(181, 20);
            this.edThreadsCount.TabIndex = 8;
            this.edThreadsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of threads";
            // 
            // edDestination
            // 
            this.edDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edDestination.AutoSize = true;
            this.edDestination.Location = new System.Drawing.Point(639, 293);
            this.edDestination.Name = "edDestination";
            this.edDestination.Size = new System.Drawing.Size(23, 13);
            this.edDestination.TabIndex = 10;
            this.edDestination.Text = "D:\\";
            // 
            // btnDestinFolder
            // 
            this.btnDestinFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestinFolder.Location = new System.Drawing.Point(581, 223);
            this.btnDestinFolder.Name = "btnDestinFolder";
            this.btnDestinFolder.Size = new System.Drawing.Size(153, 31);
            this.btnDestinFolder.TabIndex = 11;
            this.btnDestinFolder.Text = "Choose folder to copy to";
            this.btnDestinFolder.UseVisualStyleBackColor = true;
            this.btnDestinFolder.Click += new System.EventHandler(this.btnDestinFolder_Click);
            // 
            // fileSearch
            // 
            this.fileSearch.InitialDirectory = "C:\\";
            this.fileSearch.Multiselect = true;
            this.fileSearch.Title = "Choose file to copy...";
            // 
            // edProgress
            // 
            this.edProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edProgress.Location = new System.Drawing.Point(13, 403);
            this.edProgress.Name = "edProgress";
            this.edProgress.Size = new System.Drawing.Size(775, 35);
            this.edProgress.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Destination:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(656, 356);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(132, 23);
            this.btnOpenFolder.TabIndex = 14;
            this.btnOpenFolder.Text = "Open changed folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // cbSimulation
            // 
            this.cbSimulation.AutoSize = true;
            this.cbSimulation.BackColor = System.Drawing.Color.Bisque;
            this.cbSimulation.Checked = true;
            this.cbSimulation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSimulation.Location = new System.Drawing.Point(526, 74);
            this.cbSimulation.Name = "cbSimulation";
            this.cbSimulation.Size = new System.Drawing.Size(136, 17);
            this.cbSimulation.TabIndex = 15;
            this.cbSimulation.Text = "Simulate hard process?";
            this.cbSimulation.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Current state:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblState.Location = new System.Drawing.Point(400, 121);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(65, 16);
            this.lblState.TabIndex = 17;
            this.lblState.Text = "Unstarted";
            // 
            // MainFormCopyFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSimulation);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edProgress);
            this.Controls.Add(this.btnDestinFolder);
            this.Controls.Add(this.edDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edThreadsCount);
            this.Controls.Add(this.btnCopyResume);
            this.Controls.Add(this.btnCopyAbort);
            this.Controls.Add(this.btnCopyFreeze);
            this.Controls.Add(this.btnCopyStart);
            this.Controls.Add(this.btnClearListFiles);
            this.Controls.Add(this.btnRemoveSelectedFile);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lbFiles);
            this.MinimumSize = new System.Drawing.Size(730, 489);
            this.Name = "MainFormCopyFiles";
            this.Text = "CopyFiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormCopyFiles_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.edThreadsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnRemoveSelectedFile;
        private System.Windows.Forms.Button btnClearListFiles;
        private System.Windows.Forms.Button btnCopyStart;
        private System.Windows.Forms.Button btnCopyFreeze;
        private System.Windows.Forms.Button btnCopyAbort;
        private System.Windows.Forms.Button btnCopyResume;
        private System.Windows.Forms.NumericUpDown edThreadsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label edDestination;
        private System.Windows.Forms.Button btnDestinFolder;
        private System.Windows.Forms.FolderBrowserDialog folderSearch;
        private System.Windows.Forms.OpenFileDialog fileSearch;
        private System.Windows.Forms.ProgressBar edProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.CheckBox cbSimulation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblState;
    }
}

