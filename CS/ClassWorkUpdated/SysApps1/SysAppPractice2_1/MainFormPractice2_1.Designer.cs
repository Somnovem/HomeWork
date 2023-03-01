namespace SysAppPractice2_1
{
    partial class MainFormPractice2_1
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
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.edTimerSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnChangeUpdate = new System.Windows.Forms.Button();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRunPersonal = new System.Windows.Forms.Button();
            this.btnRunCalc = new System.Windows.Forms.Button();
            this.btnRunNotepad = new System.Windows.Forms.Button();
            this.btnRunPaint = new System.Windows.Forms.Button();
            this.FileDialogProcess = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTimerSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnKillProcess);
            this.tabPage1.Controls.Add(this.edTimerSeconds);
            this.tabPage1.Controls.Add(this.btnChangeUpdate);
            this.tabPage1.Controls.Add(this.dgvProcess);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKillProcess.Location = new System.Drawing.Point(468, 390);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(128, 23);
            this.btnKillProcess.TabIndex = 7;
            this.btnKillProcess.Text = "Kill selected process";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // edTimerSeconds
            // 
            this.edTimerSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edTimerSeconds.Location = new System.Drawing.Point(127, 390);
            this.edTimerSeconds.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.edTimerSeconds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edTimerSeconds.Name = "edTimerSeconds";
            this.edTimerSeconds.Size = new System.Drawing.Size(120, 20);
            this.edTimerSeconds.TabIndex = 6;
            this.edTimerSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnChangeUpdate
            // 
            this.btnChangeUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeUpdate.Location = new System.Drawing.Point(8, 390);
            this.btnChangeUpdate.Name = "btnChangeUpdate";
            this.btnChangeUpdate.Size = new System.Drawing.Size(113, 23);
            this.btnChangeUpdate.TabIndex = 5;
            this.btnChangeUpdate.Text = "Update every";
            this.btnChangeUpdate.UseVisualStyleBackColor = true;
            this.btnChangeUpdate.Click += new System.EventHandler(this.btnChangeUpdate_Click);
            // 
            // dgvProcess
            // 
            this.dgvProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Location = new System.Drawing.Point(9, 4);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.Size = new System.Drawing.Size(775, 368);
            this.dgvProcess.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRunPersonal);
            this.tabPage2.Controls.Add(this.btnRunCalc);
            this.tabPage2.Controls.Add(this.btnRunNotepad);
            this.tabPage2.Controls.Add(this.btnRunPaint);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRunPersonal
            // 
            this.btnRunPersonal.Location = new System.Drawing.Point(426, 207);
            this.btnRunPersonal.Name = "btnRunPersonal";
            this.btnRunPersonal.Size = new System.Drawing.Size(135, 57);
            this.btnRunPersonal.TabIndex = 3;
            this.btnRunPersonal.Text = "Run your exe";
            this.btnRunPersonal.UseVisualStyleBackColor = true;
            this.btnRunPersonal.Click += new System.EventHandler(this.btnRunPersonal_Click);
            // 
            // btnRunCalc
            // 
            this.btnRunCalc.Location = new System.Drawing.Point(426, 56);
            this.btnRunCalc.Name = "btnRunCalc";
            this.btnRunCalc.Size = new System.Drawing.Size(135, 57);
            this.btnRunCalc.TabIndex = 2;
            this.btnRunCalc.Text = "Run calculator";
            this.btnRunCalc.UseVisualStyleBackColor = true;
            this.btnRunCalc.Click += new System.EventHandler(this.btnRunCalc_Click);
            // 
            // btnRunNotepad
            // 
            this.btnRunNotepad.Location = new System.Drawing.Point(121, 207);
            this.btnRunNotepad.Name = "btnRunNotepad";
            this.btnRunNotepad.Size = new System.Drawing.Size(135, 57);
            this.btnRunNotepad.TabIndex = 1;
            this.btnRunNotepad.Text = "Run notepad";
            this.btnRunNotepad.UseVisualStyleBackColor = true;
            this.btnRunNotepad.Click += new System.EventHandler(this.btnRunNotepad_Click);
            // 
            // btnRunPaint
            // 
            this.btnRunPaint.Location = new System.Drawing.Point(121, 56);
            this.btnRunPaint.Name = "btnRunPaint";
            this.btnRunPaint.Size = new System.Drawing.Size(135, 57);
            this.btnRunPaint.TabIndex = 0;
            this.btnRunPaint.Text = "Run paint";
            this.btnRunPaint.UseVisualStyleBackColor = true;
            this.btnRunPaint.Click += new System.EventHandler(this.btnRunPaint_Click);
            // 
            // FileDialogProcess
            // 
            this.FileDialogProcess.FileName = "openFileDialog1";
            // 
            // MainFormPractice2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFormPractice2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice2_1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edTimerSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerProcess;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.NumericUpDown edTimerSeconds;
        private System.Windows.Forms.Button btnChangeUpdate;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRunPersonal;
        private System.Windows.Forms.Button btnRunCalc;
        private System.Windows.Forms.Button btnRunNotepad;
        private System.Windows.Forms.Button btnRunPaint;
        private System.Windows.Forms.OpenFileDialog FileDialogProcess;
    }
}

