namespace WarehouseDb
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.edDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnTypeMin = new System.Windows.Forms.Button();
            this.btnTypeMax = new System.Windows.Forms.Button();
            this.btnManMin = new System.Windows.Forms.Button();
            this.btnManMax = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edManId = new System.Windows.Forms.NumericUpDown();
            this.edTypeId = new System.Windows.Forms.NumericUpDown();
            this.edStock = new System.Windows.Forms.NumericUpDown();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.edPrimeCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edDate = new System.Windows.Forms.DateTimePicker();
            this.edProdName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.edTypeName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnManDelete = new System.Windows.Forms.Button();
            this.btnManAdd = new System.Windows.Forms.Button();
            this.edManName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMans = new System.Windows.Forms.DataGridView();
            this.btnShowProd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edManId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStock)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMans)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowProd);
            this.tabPage1.Controls.Add(this.btnProdDelete);
            this.tabPage1.Controls.Add(this.edDays);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRecent);
            this.tabPage1.Controls.Add(this.btnTypeMin);
            this.tabPage1.Controls.Add(this.btnTypeMax);
            this.tabPage1.Controls.Add(this.btnManMin);
            this.tabPage1.Controls.Add(this.btnManMax);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TableView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProdDelete
            // 
            this.btnProdDelete.Location = new System.Drawing.Point(29, 371);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(148, 23);
            this.btnProdDelete.TabIndex = 8;
            this.btnProdDelete.Text = "Delete selected row";
            this.btnProdDelete.UseVisualStyleBackColor = true;
            this.btnProdDelete.Click += new System.EventHandler(this.btnProdDelete_Click);
            // 
            // edDays
            // 
            this.edDays.Location = new System.Drawing.Point(87, 222);
            this.edDays.Name = "edDays";
            this.edDays.Size = new System.Drawing.Size(115, 20);
            this.edDays.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of days:";
            // 
            // btnRecent
            // 
            this.btnRecent.Location = new System.Drawing.Point(6, 197);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(75, 58);
            this.btnRecent.TabIndex = 5;
            this.btnRecent.Text = "Prods in recent * days";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // btnTypeMin
            // 
            this.btnTypeMin.Location = new System.Drawing.Point(107, 90);
            this.btnTypeMin.Name = "btnTypeMin";
            this.btnTypeMin.Size = new System.Drawing.Size(95, 64);
            this.btnTypeMin.TabIndex = 4;
            this.btnTypeMin.Text = "Show Type with minimal stock";
            this.btnTypeMin.UseVisualStyleBackColor = true;
            this.btnTypeMin.Click += new System.EventHandler(this.btnTypeMin_Click);
            // 
            // btnTypeMax
            // 
            this.btnTypeMax.Location = new System.Drawing.Point(6, 90);
            this.btnTypeMax.Name = "btnTypeMax";
            this.btnTypeMax.Size = new System.Drawing.Size(95, 64);
            this.btnTypeMax.TabIndex = 3;
            this.btnTypeMax.Text = "Show Type with maximal stock";
            this.btnTypeMax.UseVisualStyleBackColor = true;
            this.btnTypeMax.Click += new System.EventHandler(this.btnTypeMax_Click);
            // 
            // btnManMin
            // 
            this.btnManMin.Location = new System.Drawing.Point(107, 20);
            this.btnManMin.Name = "btnManMin";
            this.btnManMin.Size = new System.Drawing.Size(95, 64);
            this.btnManMin.TabIndex = 2;
            this.btnManMin.Text = "Show Manufacturer with minimal stock";
            this.btnManMin.UseVisualStyleBackColor = true;
            this.btnManMin.Click += new System.EventHandler(this.btnManMin_Click);
            // 
            // btnManMax
            // 
            this.btnManMax.Location = new System.Drawing.Point(6, 20);
            this.btnManMax.Name = "btnManMax";
            this.btnManMax.Size = new System.Drawing.Size(95, 64);
            this.btnManMax.TabIndex = 1;
            this.btnManMax.Text = "Show Manufacturer with maximal stock";
            this.btnManMax.UseVisualStyleBackColor = true;
            this.btnManMax.Click += new System.EventHandler(this.btnManMax_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(226, 20);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(741, 374);
            this.dgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edManId);
            this.tabPage2.Controls.Add(this.edTypeId);
            this.tabPage2.Controls.Add(this.edStock);
            this.tabPage2.Controls.Add(this.btnProdAdd);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.edPrimeCost);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.edDate);
            this.tabPage2.Controls.Add(this.edProdName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edManId
            // 
            this.edManId.Location = new System.Drawing.Point(408, 159);
            this.edManId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edManId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edManId.Name = "edManId";
            this.edManId.Size = new System.Drawing.Size(524, 20);
            this.edManId.TabIndex = 15;
            this.edManId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edTypeId
            // 
            this.edTypeId.Location = new System.Drawing.Point(408, 112);
            this.edTypeId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edTypeId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edTypeId.Name = "edTypeId";
            this.edTypeId.Size = new System.Drawing.Size(524, 20);
            this.edTypeId.TabIndex = 14;
            this.edTypeId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edStock
            // 
            this.edStock.Location = new System.Drawing.Point(408, 214);
            this.edStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edStock.Name = "edStock";
            this.edStock.Size = new System.Drawing.Size(524, 20);
            this.edStock.TabIndex = 13;
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.Location = new System.Drawing.Point(267, 338);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(124, 33);
            this.btnProdAdd.TabIndex = 12;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = true;
            this.btnProdAdd.Click += new System.EventHandler(this.btnProdAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prime cost";
            // 
            // edPrimeCost
            // 
            this.edPrimeCost.Location = new System.Drawing.Point(408, 252);
            this.edPrimeCost.Name = "edPrimeCost";
            this.edPrimeCost.Size = new System.Drawing.Size(524, 20);
            this.edPrimeCost.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date of arrival";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ManufacturerId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TypeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // edDate
            // 
            this.edDate.Location = new System.Drawing.Point(408, 300);
            this.edDate.Name = "edDate";
            this.edDate.Size = new System.Drawing.Size(524, 20);
            this.edDate.TabIndex = 4;
            // 
            // edProdName
            // 
            this.edProdName.Location = new System.Drawing.Point(408, 62);
            this.edProdName.Name = "edProdName";
            this.edProdName.Size = new System.Drawing.Size(524, 20);
            this.edProdName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnDeleteType);
            this.tabPage3.Controls.Add(this.btnAddType);
            this.tabPage3.Controls.Add(this.edTypeName);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dgvTypes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(978, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Types";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(153, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 39);
            this.label9.TabIndex = 5;
            this.label9.Text = "Types";
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Location = new System.Drawing.Point(38, 268);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteType.TabIndex = 4;
            this.btnDeleteType.Text = "Delete selected";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(129, 150);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(161, 23);
            this.btnAddType.TabIndex = 3;
            this.btnAddType.Text = "Add type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // edTypeName
            // 
            this.edTypeName.Location = new System.Drawing.Point(104, 105);
            this.edTypeName.Name = "edTypeName";
            this.edTypeName.Size = new System.Drawing.Size(219, 20);
            this.edTypeName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(34, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            // 
            // dgvTypes
            // 
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Location = new System.Drawing.Point(478, 13);
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.Size = new System.Drawing.Size(480, 372);
            this.dgvTypes.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnManDelete);
            this.tabPage4.Controls.Add(this.btnManAdd);
            this.tabPage4.Controls.Add(this.edManName);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.dgvMans);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(978, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manufecturers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnManDelete
            // 
            this.btnManDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManDelete.Location = new System.Drawing.Point(29, 290);
            this.btnManDelete.Name = "btnManDelete";
            this.btnManDelete.Size = new System.Drawing.Size(206, 28);
            this.btnManDelete.TabIndex = 5;
            this.btnManDelete.Text = "Delete selected";
            this.btnManDelete.UseVisualStyleBackColor = true;
            this.btnManDelete.Click += new System.EventHandler(this.btnManDelete_Click);
            // 
            // btnManAdd
            // 
            this.btnManAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManAdd.Location = new System.Drawing.Point(189, 146);
            this.btnManAdd.Name = "btnManAdd";
            this.btnManAdd.Size = new System.Drawing.Size(151, 28);
            this.btnManAdd.TabIndex = 4;
            this.btnManAdd.Text = "Add";
            this.btnManAdd.UseVisualStyleBackColor = true;
            this.btnManAdd.Click += new System.EventHandler(this.btnManAdd_Click);
            // 
            // edManName
            // 
            this.edManName.Location = new System.Drawing.Point(166, 107);
            this.edManName.Name = "edManName";
            this.edManName.Size = new System.Drawing.Size(219, 20);
            this.edManName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(83, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(78, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 54);
            this.label10.TabIndex = 1;
            this.label10.Text = "Manufacturers";
            // 
            // dgvMans
            // 
            this.dgvMans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMans.Location = new System.Drawing.Point(525, 12);
            this.dgvMans.Name = "dgvMans";
            this.dgvMans.Size = new System.Drawing.Size(445, 374);
            this.dgvMans.TabIndex = 0;
            // 
            // btnShowProd
            // 
            this.btnShowProd.Location = new System.Drawing.Point(56, 291);
            this.btnShowProd.Name = "btnShowProd";
            this.btnShowProd.Size = new System.Drawing.Size(91, 23);
            this.btnShowProd.TabIndex = 9;
            this.btnShowProd.Text = "Show all";
            this.btnShowProd.UseVisualStyleBackColor = true;
            this.btnShowProd.Click += new System.EventHandler(this.btnShowProd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Warehouse";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edManId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStock)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnTypeMin;
        private System.Windows.Forms.Button btnTypeMax;
        private System.Windows.Forms.Button btnManMin;
        private System.Windows.Forms.Button btnManMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edDays;
        private System.Windows.Forms.Button btnProdAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edPrimeCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker edDate;
        private System.Windows.Forms.TextBox edProdName;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.DataGridView dgvMans;
        private System.Windows.Forms.NumericUpDown edStock;
        private System.Windows.Forms.NumericUpDown edManId;
        private System.Windows.Forms.NumericUpDown edTypeId;
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox edTypeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnManDelete;
        private System.Windows.Forms.Button btnManAdd;
        private System.Windows.Forms.TextBox edManName;
        private System.Windows.Forms.Button btnShowProd;
    }
}

