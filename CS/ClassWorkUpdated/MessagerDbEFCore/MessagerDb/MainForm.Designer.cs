namespace MessagerDb
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edContactDescr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edContactBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.edContactEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edContactLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edContactFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContactsUpdate = new System.Windows.Forms.Button();
            this.btnContactsAdd = new System.Windows.Forms.Button();
            this.btnContactsDelete = new System.Windows.Forms.Button();
            this.btnContactsSave = new System.Windows.Forms.Button();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.colContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edMessagesText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edMessagesDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.edMessagesContactId = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMessagesUpdate = new System.Windows.Forms.Button();
            this.btnMessagesAdd = new System.Windows.Forms.Button();
            this.btnMessagesDelete = new System.Windows.Forms.Button();
            this.btnMessagesSave = new System.Windows.Forms.Button();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.colMessageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edMessagesContactId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
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
            this.tabPage1.Controls.Add(this.edContactDescr);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.edContactBirth);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.edContactEmail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.edContactLastname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.edContactFirstname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnContactsUpdate);
            this.tabPage1.Controls.Add(this.btnContactsAdd);
            this.tabPage1.Controls.Add(this.btnContactsDelete);
            this.tabPage1.Controls.Add(this.btnContactsSave);
            this.tabPage1.Controls.Add(this.dgvContacts);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ControlContacts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edContactDescr
            // 
            this.edContactDescr.Location = new System.Drawing.Point(278, 376);
            this.edContactDescr.Name = "edContactDescr";
            this.edContactDescr.Size = new System.Drawing.Size(238, 23);
            this.edContactDescr.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description";
            // 
            // edContactBirth
            // 
            this.edContactBirth.Location = new System.Drawing.Point(305, 331);
            this.edContactBirth.Name = "edContactBirth";
            this.edContactBirth.Size = new System.Drawing.Size(138, 23);
            this.edContactBirth.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday";
            // 
            // edContactEmail
            // 
            this.edContactEmail.Location = new System.Drawing.Point(57, 389);
            this.edContactEmail.Name = "edContactEmail";
            this.edContactEmail.Size = new System.Drawing.Size(158, 23);
            this.edContactEmail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // edContactLastname
            // 
            this.edContactLastname.Location = new System.Drawing.Point(57, 360);
            this.edContactLastname.Name = "edContactLastname";
            this.edContactLastname.Size = new System.Drawing.Size(158, 23);
            this.edContactLastname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lastname";
            // 
            // edContactFirstname
            // 
            this.edContactFirstname.Location = new System.Drawing.Point(57, 331);
            this.edContactFirstname.Name = "edContactFirstname";
            this.edContactFirstname.Size = new System.Drawing.Size(158, 23);
            this.edContactFirstname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname";
            // 
            // btnContactsUpdate
            // 
            this.btnContactsUpdate.Location = new System.Drawing.Point(615, 376);
            this.btnContactsUpdate.Name = "btnContactsUpdate";
            this.btnContactsUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContactsUpdate.TabIndex = 4;
            this.btnContactsUpdate.Text = "Update";
            this.btnContactsUpdate.UseVisualStyleBackColor = true;
            this.btnContactsUpdate.Click += new System.EventHandler(this.btnContactsUpdate_Click);
            // 
            // btnContactsAdd
            // 
            this.btnContactsAdd.Location = new System.Drawing.Point(615, 338);
            this.btnContactsAdd.Name = "btnContactsAdd";
            this.btnContactsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnContactsAdd.TabIndex = 3;
            this.btnContactsAdd.Text = "Add";
            this.btnContactsAdd.UseVisualStyleBackColor = true;
            this.btnContactsAdd.Click += new System.EventHandler(this.btnContactsAdd_Click);
            // 
            // btnContactsDelete
            // 
            this.btnContactsDelete.Location = new System.Drawing.Point(696, 338);
            this.btnContactsDelete.Name = "btnContactsDelete";
            this.btnContactsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContactsDelete.TabIndex = 2;
            this.btnContactsDelete.Text = "Delete";
            this.btnContactsDelete.UseVisualStyleBackColor = true;
            this.btnContactsDelete.Click += new System.EventHandler(this.btnContactsDelete_Click);
            // 
            // btnContactsSave
            // 
            this.btnContactsSave.Location = new System.Drawing.Point(696, 376);
            this.btnContactsSave.Name = "btnContactsSave";
            this.btnContactsSave.Size = new System.Drawing.Size(75, 23);
            this.btnContactsSave.TabIndex = 1;
            this.btnContactsSave.Text = "Save";
            this.btnContactsSave.UseVisualStyleBackColor = true;
            this.btnContactsSave.Click += new System.EventHandler(this.btnContactsSave_Click);
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactId,
            this.colContactFirstname,
            this.colContactLastname,
            this.colContactBirthday,
            this.colContactEmail,
            this.colContactDescr});
            this.dgvContacts.Location = new System.Drawing.Point(11, 10);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowTemplate.Height = 25;
            this.dgvContacts.Size = new System.Drawing.Size(773, 302);
            this.dgvContacts.TabIndex = 0;
            this.dgvContacts.SelectionChanged += new System.EventHandler(this.dgvContacts_SelectionChanged);
            // 
            // colContactId
            // 
            this.colContactId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactId.DataPropertyName = "Id";
            this.colContactId.FillWeight = 22F;
            this.colContactId.HeaderText = "Id";
            this.colContactId.Name = "colContactId";
            // 
            // colContactFirstname
            // 
            this.colContactFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactFirstname.DataPropertyName = "Firstname";
            this.colContactFirstname.FillWeight = 60F;
            this.colContactFirstname.HeaderText = "Firstname";
            this.colContactFirstname.Name = "colContactFirstname";
            // 
            // colContactLastname
            // 
            this.colContactLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactLastname.DataPropertyName = "Lastname";
            this.colContactLastname.FillWeight = 60F;
            this.colContactLastname.HeaderText = "Lastname";
            this.colContactLastname.Name = "colContactLastname";
            // 
            // colContactBirthday
            // 
            this.colContactBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactBirthday.DataPropertyName = "Birthday";
            this.colContactBirthday.FillWeight = 50F;
            this.colContactBirthday.HeaderText = "Birthday";
            this.colContactBirthday.Name = "colContactBirthday";
            // 
            // colContactEmail
            // 
            this.colContactEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactEmail.DataPropertyName = "Email";
            this.colContactEmail.FillWeight = 60F;
            this.colContactEmail.HeaderText = "Email";
            this.colContactEmail.Name = "colContactEmail";
            // 
            // colContactDescr
            // 
            this.colContactDescr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactDescr.DataPropertyName = "Desctiption";
            this.colContactDescr.FillWeight = 120F;
            this.colContactDescr.HeaderText = "Description";
            this.colContactDescr.Name = "colContactDescr";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edMessagesText);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.edMessagesDate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.edMessagesContactId);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnMessagesUpdate);
            this.tabPage2.Controls.Add(this.btnMessagesAdd);
            this.tabPage2.Controls.Add(this.btnMessagesDelete);
            this.tabPage2.Controls.Add(this.btnMessagesSave);
            this.tabPage2.Controls.Add(this.dgvMessages);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ControlMessages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edMessagesText
            // 
            this.edMessagesText.Location = new System.Drawing.Point(261, 350);
            this.edMessagesText.Name = "edMessagesText";
            this.edMessagesText.Size = new System.Drawing.Size(323, 23);
            this.edMessagesText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Message";
            // 
            // edMessagesDate
            // 
            this.edMessagesDate.Location = new System.Drawing.Point(59, 383);
            this.edMessagesDate.Name = "edMessagesDate";
            this.edMessagesDate.Size = new System.Drawing.Size(142, 23);
            this.edMessagesDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "DateOf";
            // 
            // edMessagesContactId
            // 
            this.edMessagesContactId.Location = new System.Drawing.Point(81, 327);
            this.edMessagesContactId.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.edMessagesContactId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edMessagesContactId.Name = "edMessagesContactId";
            this.edMessagesContactId.Size = new System.Drawing.Size(120, 23);
            this.edMessagesContactId.TabIndex = 11;
            this.edMessagesContactId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ContactId";
            // 
            // btnMessagesUpdate
            // 
            this.btnMessagesUpdate.Location = new System.Drawing.Point(614, 383);
            this.btnMessagesUpdate.Name = "btnMessagesUpdate";
            this.btnMessagesUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMessagesUpdate.TabIndex = 9;
            this.btnMessagesUpdate.Text = "Update";
            this.btnMessagesUpdate.UseVisualStyleBackColor = true;
            this.btnMessagesUpdate.Click += new System.EventHandler(this.btnMessagesUpdate_Click);
            // 
            // btnMessagesAdd
            // 
            this.btnMessagesAdd.Location = new System.Drawing.Point(614, 345);
            this.btnMessagesAdd.Name = "btnMessagesAdd";
            this.btnMessagesAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMessagesAdd.TabIndex = 8;
            this.btnMessagesAdd.Text = "Add";
            this.btnMessagesAdd.UseVisualStyleBackColor = true;
            this.btnMessagesAdd.Click += new System.EventHandler(this.btnMessagesAdd_Click);
            // 
            // btnMessagesDelete
            // 
            this.btnMessagesDelete.Location = new System.Drawing.Point(695, 345);
            this.btnMessagesDelete.Name = "btnMessagesDelete";
            this.btnMessagesDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMessagesDelete.TabIndex = 7;
            this.btnMessagesDelete.Text = "Delete";
            this.btnMessagesDelete.UseVisualStyleBackColor = true;
            this.btnMessagesDelete.Click += new System.EventHandler(this.btnMessagesDelete_Click);
            // 
            // btnMessagesSave
            // 
            this.btnMessagesSave.Location = new System.Drawing.Point(695, 383);
            this.btnMessagesSave.Name = "btnMessagesSave";
            this.btnMessagesSave.Size = new System.Drawing.Size(75, 23);
            this.btnMessagesSave.TabIndex = 6;
            this.btnMessagesSave.Text = "Save";
            this.btnMessagesSave.UseVisualStyleBackColor = true;
            this.btnMessagesSave.Click += new System.EventHandler(this.btnMessagesSave_Click);
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMessageId,
            this.colMessageContactId,
            this.colMessageDate,
            this.colMessageText});
            this.dgvMessages.Location = new System.Drawing.Point(11, 10);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.RowTemplate.Height = 25;
            this.dgvMessages.Size = new System.Drawing.Size(773, 302);
            this.dgvMessages.TabIndex = 5;
            this.dgvMessages.SelectionChanged += new System.EventHandler(this.dgvMessages_SelectionChanged);
            // 
            // colMessageId
            // 
            this.colMessageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMessageId.DataPropertyName = "Id";
            this.colMessageId.FillWeight = 17F;
            this.colMessageId.HeaderText = "Id";
            this.colMessageId.Name = "colMessageId";
            // 
            // colMessageContactId
            // 
            this.colMessageContactId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMessageContactId.DataPropertyName = "ContactId";
            this.colMessageContactId.FillWeight = 18F;
            this.colMessageContactId.HeaderText = "ContactId";
            this.colMessageContactId.Name = "colMessageContactId";
            // 
            // colMessageDate
            // 
            this.colMessageDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMessageDate.DataPropertyName = "DateOf";
            this.colMessageDate.FillWeight = 23F;
            this.colMessageDate.HeaderText = "DateOf";
            this.colMessageDate.Name = "colMessageDate";
            // 
            // colMessageText
            // 
            this.colMessageText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMessageText.DataPropertyName = "Message";
            this.colMessageText.HeaderText = "Message";
            this.colMessageText.Name = "colMessageText";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MessagerDb-CodeFirst-FluentAPI-EFCore";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edMessagesContactId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvContacts;
        private TabPage tabPage2;
        private Button btnContactsSave;
        private TextBox edContactDescr;
        private Label label5;
        private DateTimePicker edContactBirth;
        private Label label4;
        private TextBox edContactEmail;
        private Label label3;
        private TextBox edContactLastname;
        private Label label2;
        private TextBox edContactFirstname;
        private Label label1;
        private Button btnContactsUpdate;
        private Button btnContactsAdd;
        private Button btnContactsDelete;
        private Button btnMessagesUpdate;
        private Button btnMessagesAdd;
        private Button btnMessagesDelete;
        private Button btnMessagesSave;
        private DataGridView dgvMessages;
        private DataGridViewTextBoxColumn colContactId;
        private DataGridViewTextBoxColumn colContactFirstname;
        private DataGridViewTextBoxColumn colContactLastname;
        private DataGridViewTextBoxColumn colContactBirthday;
        private DataGridViewTextBoxColumn colContactEmail;
        private DataGridViewTextBoxColumn colContactDescr;
        private TextBox edMessagesText;
        private Label label8;
        private DateTimePicker edMessagesDate;
        private Label label7;
        private NumericUpDown edMessagesContactId;
        private Label label6;
        private DataGridViewTextBoxColumn colMessageId;
        private DataGridViewTextBoxColumn colMessageContactId;
        private DataGridViewTextBoxColumn colMessageDate;
        private DataGridViewTextBoxColumn colMessageText;
    }
}