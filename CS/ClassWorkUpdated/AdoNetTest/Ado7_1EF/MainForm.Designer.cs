namespace Ado7_1EF
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Departments = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.colDepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherBitrhDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherDepartmentId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepAdd = new System.Windows.Forms.Button();
            this.btnDepDelete = new System.Windows.Forms.Button();
            this.btnDepSave = new System.Windows.Forms.Button();
            this.btnDepUpdate = new System.Windows.Forms.Button();
            this.edDepName = new System.Windows.Forms.TextBox();
            this.edDepPhone = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edTeacherFirstname = new System.Windows.Forms.TextBox();
            this.edTeacherLastname = new System.Windows.Forms.TextBox();
            this.edTeacherBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbTeacherDep = new System.Windows.Forms.ComboBox();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Departments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Departments);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Departments
            // 
            this.Departments.Controls.Add(this.edDepPhone);
            this.Departments.Controls.Add(this.edDepName);
            this.Departments.Controls.Add(this.btnDepUpdate);
            this.Departments.Controls.Add(this.btnDepSave);
            this.Departments.Controls.Add(this.btnDepDelete);
            this.Departments.Controls.Add(this.btnDepAdd);
            this.Departments.Controls.Add(this.label2);
            this.Departments.Controls.Add(this.label1);
            this.Departments.Controls.Add(this.dgvDepartments);
            this.Departments.Location = new System.Drawing.Point(4, 22);
            this.Departments.Name = "Departments";
            this.Departments.Padding = new System.Windows.Forms.Padding(3);
            this.Departments.Size = new System.Drawing.Size(792, 424);
            this.Departments.TabIndex = 0;
            this.Departments.Text = "Departments";
            this.Departments.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepId,
            this.colDepName,
            this.colDepPhone});
            this.dgvDepartments.Location = new System.Drawing.Point(6, 6);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(775, 315);
            this.dgvDepartments.TabIndex = 0;
            this.dgvDepartments.SelectionChanged += new System.EventHandler(this.dgvDepartments_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTeacherAdd);
            this.tabPage2.Controls.Add(this.cmbTeacherDep);
            this.tabPage2.Controls.Add(this.edTeacherBirth);
            this.tabPage2.Controls.Add(this.edTeacherLastname);
            this.tabPage2.Controls.Add(this.edTeacherFirstname);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvTeachers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teachers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeacherId,
            this.colTeacherFirstname,
            this.colTeacherLastname,
            this.colTeacherBitrhDate,
            this.colTeacherDepartmentId});
            this.dgvTeachers.Location = new System.Drawing.Point(6, 6);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(775, 315);
            this.dgvTeachers.TabIndex = 1;
            // 
            // colDepId
            // 
            this.colDepId.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDepId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDepId.HeaderText = "Id";
            this.colDepId.Name = "colDepId";
            this.colDepId.ReadOnly = true;
            this.colDepId.Width = 60;
            // 
            // colDepName
            // 
            this.colDepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepName.DataPropertyName = "Name";
            this.colDepName.HeaderText = "Name";
            this.colDepName.Name = "colDepName";
            this.colDepName.ReadOnly = true;
            // 
            // colDepPhone
            // 
            this.colDepPhone.DataPropertyName = "Phone";
            this.colDepPhone.HeaderText = "Phone";
            this.colDepPhone.Name = "colDepPhone";
            this.colDepPhone.ReadOnly = true;
            // 
            // colTeacherId
            // 
            this.colTeacherId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTeacherId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTeacherId.HeaderText = "Id";
            this.colTeacherId.Name = "colTeacherId";
            this.colTeacherId.ReadOnly = true;
            this.colTeacherId.Width = 50;
            // 
            // colTeacherFirstname
            // 
            this.colTeacherFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacherFirstname.DataPropertyName = "Firstname";
            this.colTeacherFirstname.HeaderText = "Firstname";
            this.colTeacherFirstname.Name = "colTeacherFirstname";
            this.colTeacherFirstname.ReadOnly = true;
            // 
            // colTeacherLastname
            // 
            this.colTeacherLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacherLastname.DataPropertyName = "Lastname";
            this.colTeacherLastname.HeaderText = "Lastname";
            this.colTeacherLastname.Name = "colTeacherLastname";
            this.colTeacherLastname.ReadOnly = true;
            // 
            // colTeacherBitrhDate
            // 
            this.colTeacherBitrhDate.DataPropertyName = "BirthDate";
            this.colTeacherBitrhDate.HeaderText = "BitrhDate";
            this.colTeacherBitrhDate.Name = "colTeacherBitrhDate";
            this.colTeacherBitrhDate.ReadOnly = true;
            // 
            // colTeacherDepartmentId
            // 
            this.colTeacherDepartmentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacherDepartmentId.HeaderText = "DepartmentId";
            this.colTeacherDepartmentId.Name = "colTeacherDepartmentId";
            this.colTeacherDepartmentId.ReadOnly = true;
            this.colTeacherDepartmentId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTeacherDepartmentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // btnDepAdd
            // 
            this.btnDepAdd.Location = new System.Drawing.Point(292, 349);
            this.btnDepAdd.Name = "btnDepAdd";
            this.btnDepAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDepAdd.TabIndex = 3;
            this.btnDepAdd.Text = "Add";
            this.btnDepAdd.UseVisualStyleBackColor = true;
            this.btnDepAdd.Click += new System.EventHandler(this.btnDepAdd_Click);
            // 
            // btnDepDelete
            // 
            this.btnDepDelete.Location = new System.Drawing.Point(292, 383);
            this.btnDepDelete.Name = "btnDepDelete";
            this.btnDepDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDepDelete.TabIndex = 4;
            this.btnDepDelete.Text = "Delete";
            this.btnDepDelete.UseVisualStyleBackColor = true;
            this.btnDepDelete.Click += new System.EventHandler(this.btnDepDelete_Click);
            // 
            // btnDepSave
            // 
            this.btnDepSave.Location = new System.Drawing.Point(387, 349);
            this.btnDepSave.Name = "btnDepSave";
            this.btnDepSave.Size = new System.Drawing.Size(75, 23);
            this.btnDepSave.TabIndex = 5;
            this.btnDepSave.Text = "Save";
            this.btnDepSave.UseVisualStyleBackColor = true;
            this.btnDepSave.Click += new System.EventHandler(this.btnDepSave_Click);
            // 
            // btnDepUpdate
            // 
            this.btnDepUpdate.Location = new System.Drawing.Point(387, 383);
            this.btnDepUpdate.Name = "btnDepUpdate";
            this.btnDepUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDepUpdate.TabIndex = 6;
            this.btnDepUpdate.Text = "Update";
            this.btnDepUpdate.UseVisualStyleBackColor = true;
            this.btnDepUpdate.Click += new System.EventHandler(this.btnDepUpdate_Click);
            // 
            // edDepName
            // 
            this.edDepName.Location = new System.Drawing.Point(71, 349);
            this.edDepName.Name = "edDepName";
            this.edDepName.Size = new System.Drawing.Size(196, 20);
            this.edDepName.TabIndex = 7;
            // 
            // edDepPhone
            // 
            this.edDepPhone.Location = new System.Drawing.Point(71, 383);
            this.edDepPhone.Name = "edDepPhone";
            this.edDepPhone.Size = new System.Drawing.Size(196, 20);
            this.edDepPhone.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DepId";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Birthdate";
            // 
            // edTeacherFirstname
            // 
            this.edTeacherFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTeacherFirstname.Location = new System.Drawing.Point(66, 352);
            this.edTeacherFirstname.Name = "edTeacherFirstname";
            this.edTeacherFirstname.Size = new System.Drawing.Size(132, 20);
            this.edTeacherFirstname.TabIndex = 6;
            // 
            // edTeacherLastname
            // 
            this.edTeacherLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTeacherLastname.Location = new System.Drawing.Point(67, 390);
            this.edTeacherLastname.Name = "edTeacherLastname";
            this.edTeacherLastname.Size = new System.Drawing.Size(131, 20);
            this.edTeacherLastname.TabIndex = 7;
            // 
            // edTeacherBirth
            // 
            this.edTeacherBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTeacherBirth.Location = new System.Drawing.Point(255, 352);
            this.edTeacherBirth.Name = "edTeacherBirth";
            this.edTeacherBirth.Size = new System.Drawing.Size(200, 20);
            this.edTeacherBirth.TabIndex = 8;
            // 
            // cmbTeacherDep
            // 
            this.cmbTeacherDep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTeacherDep.FormattingEnabled = true;
            this.cmbTeacherDep.Location = new System.Drawing.Point(255, 388);
            this.cmbTeacherDep.Name = "cmbTeacherDep";
            this.cmbTeacherDep.Size = new System.Drawing.Size(200, 21);
            this.cmbTeacherDep.TabIndex = 9;
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeacherAdd.Location = new System.Drawing.Point(488, 352);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(125, 23);
            this.btnTeacherAdd.TabIndex = 10;
            this.btnTeacherAdd.Text = "Add";
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EF - DatabaseFirst";
            this.tabControl1.ResumeLayout(false);
            this.Departments.ResumeLayout(false);
            this.Departments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Departments;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherBitrhDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTeacherDepartmentId;
        private System.Windows.Forms.TextBox edDepPhone;
        private System.Windows.Forms.TextBox edDepName;
        private System.Windows.Forms.Button btnDepUpdate;
        private System.Windows.Forms.Button btnDepSave;
        private System.Windows.Forms.Button btnDepDelete;
        private System.Windows.Forms.Button btnDepAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.ComboBox cmbTeacherDep;
        private System.Windows.Forms.DateTimePicker edTeacherBirth;
        private System.Windows.Forms.TextBox edTeacherLastname;
        private System.Windows.Forms.TextBox edTeacherFirstname;
    }
}

