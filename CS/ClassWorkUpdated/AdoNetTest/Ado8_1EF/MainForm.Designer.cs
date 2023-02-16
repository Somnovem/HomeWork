namespace Ado8_1EF
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.colPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactTypeInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edPersonFirstname = new System.Windows.Forms.TextBox();
            this.edPersonLastname = new System.Windows.Forms.TextBox();
            this.edPersonBirth = new System.Windows.Forms.DateTimePicker();
            this.btnPersonAdd = new System.Windows.Forms.Button();
            this.edContactValue = new System.Windows.Forms.TextBox();
            this.edContactType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnContactAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersonId,
            this.colPersonFirstname,
            this.colPersonLastname,
            this.colPersonBirth});
            this.dgvPeople.Location = new System.Drawing.Point(12, 12);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.Size = new System.Drawing.Size(479, 387);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.SelectionChanged += new System.EventHandler(this.dgvPeople_SelectionChanged);
            // 
            // dgvContacts
            // 
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactId,
            this.colContactTypeInfo,
            this.colContactValue});
            this.dgvContacts.Location = new System.Drawing.Point(497, 12);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.Size = new System.Drawing.Size(275, 387);
            this.dgvContacts.TabIndex = 1;
            // 
            // colPersonId
            // 
            this.colPersonId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPersonId.DataPropertyName = "Id";
            this.colPersonId.HeaderText = "Id";
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.ReadOnly = true;
            this.colPersonId.Visible = false;
            this.colPersonId.Width = 60;
            // 
            // colPersonFirstname
            // 
            this.colPersonFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersonFirstname.DataPropertyName = "Firstname";
            this.colPersonFirstname.FillWeight = 104.3147F;
            this.colPersonFirstname.HeaderText = "Firstname";
            this.colPersonFirstname.Name = "colPersonFirstname";
            this.colPersonFirstname.ReadOnly = true;
            // 
            // colPersonLastname
            // 
            this.colPersonLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersonLastname.DataPropertyName = "Lastname";
            this.colPersonLastname.FillWeight = 104.3147F;
            this.colPersonLastname.HeaderText = "Lastname";
            this.colPersonLastname.Name = "colPersonLastname";
            this.colPersonLastname.ReadOnly = true;
            // 
            // colPersonBirth
            // 
            this.colPersonBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPersonBirth.DataPropertyName = "Birthdate";
            this.colPersonBirth.FillWeight = 91.37056F;
            this.colPersonBirth.HeaderText = "Birthdate";
            this.colPersonBirth.Name = "colPersonBirth";
            this.colPersonBirth.ReadOnly = true;
            // 
            // colContactId
            // 
            this.colContactId.DataPropertyName = "Id";
            this.colContactId.HeaderText = "Id";
            this.colContactId.Name = "colContactId";
            this.colContactId.ReadOnly = true;
            this.colContactId.Visible = false;
            // 
            // colContactTypeInfo
            // 
            this.colContactTypeInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactTypeInfo.DataPropertyName = "TypeInfo";
            this.colContactTypeInfo.HeaderText = "TypeInfo";
            this.colContactTypeInfo.Name = "colContactTypeInfo";
            this.colContactTypeInfo.ReadOnly = true;
            // 
            // colContactValue
            // 
            this.colContactValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactValue.DataPropertyName = "Value";
            this.colContactValue.FillWeight = 200F;
            this.colContactValue.HeaderText = "Value";
            this.colContactValue.Name = "colContactValue";
            this.colContactValue.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth";
            // 
            // edPersonFirstname
            // 
            this.edPersonFirstname.Location = new System.Drawing.Point(55, 406);
            this.edPersonFirstname.Name = "edPersonFirstname";
            this.edPersonFirstname.Size = new System.Drawing.Size(170, 20);
            this.edPersonFirstname.TabIndex = 5;
            // 
            // edPersonLastname
            // 
            this.edPersonLastname.Location = new System.Drawing.Point(55, 436);
            this.edPersonLastname.Name = "edPersonLastname";
            this.edPersonLastname.Size = new System.Drawing.Size(170, 20);
            this.edPersonLastname.TabIndex = 6;
            // 
            // edPersonBirth
            // 
            this.edPersonBirth.Location = new System.Drawing.Point(273, 406);
            this.edPersonBirth.Name = "edPersonBirth";
            this.edPersonBirth.Size = new System.Drawing.Size(126, 20);
            this.edPersonBirth.TabIndex = 7;
            // 
            // btnPersonAdd
            // 
            this.btnPersonAdd.Location = new System.Drawing.Point(253, 431);
            this.btnPersonAdd.Name = "btnPersonAdd";
            this.btnPersonAdd.Size = new System.Drawing.Size(132, 23);
            this.btnPersonAdd.TabIndex = 8;
            this.btnPersonAdd.Text = "Add";
            this.btnPersonAdd.UseVisualStyleBackColor = true;
            this.btnPersonAdd.Click += new System.EventHandler(this.btnPersonAdd_Click);
            // 
            // edContactValue
            // 
            this.edContactValue.Location = new System.Drawing.Point(515, 439);
            this.edContactValue.Name = "edContactValue";
            this.edContactValue.Size = new System.Drawing.Size(170, 20);
            this.edContactValue.TabIndex = 12;
            // 
            // edContactType
            // 
            this.edContactType.Location = new System.Drawing.Point(515, 409);
            this.edContactType.Name = "edContactType";
            this.edContactType.Size = new System.Drawing.Size(170, 20);
            this.edContactType.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TypeInfo";
            // 
            // btnContactAdd
            // 
            this.btnContactAdd.Location = new System.Drawing.Point(697, 426);
            this.btnContactAdd.Name = "btnContactAdd";
            this.btnContactAdd.Size = new System.Drawing.Size(75, 23);
            this.btnContactAdd.TabIndex = 13;
            this.btnContactAdd.Text = "Add";
            this.btnContactAdd.UseVisualStyleBackColor = true;
            this.btnContactAdd.Click += new System.EventHandler(this.btnContactAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnContactAdd);
            this.Controls.Add(this.edContactValue);
            this.Controls.Add(this.edContactType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPersonAdd);
            this.Controls.Add(this.edPersonBirth);
            this.Controls.Add(this.edPersonLastname);
            this.Controls.Add(this.edPersonFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.dgvPeople);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EF - ModelFirst";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edPersonFirstname;
        private System.Windows.Forms.TextBox edPersonLastname;
        private System.Windows.Forms.DateTimePicker edPersonBirth;
        private System.Windows.Forms.Button btnPersonAdd;
        private System.Windows.Forms.TextBox edContactValue;
        private System.Windows.Forms.TextBox edContactType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnContactAdd;
    }
}

