namespace StatShopDb
{
    partial class Form1
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
            this.btnProdUpdate = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFirmsUpdate = new System.Windows.Forms.Button();
            this.btnFirmsSave = new System.Windows.Forms.Button();
            this.dgvFirms = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSellersUpdate = new System.Windows.Forms.Button();
            this.btnSellersSave = new System.Windows.Forms.Button();
            this.dgvSellers = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTypesUpdate = new System.Windows.Forms.Button();
            this.btnTypesSave = new System.Windows.Forms.Button();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnSalesUpdate = new System.Windows.Forms.Button();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.edDaysNumber = new System.Windows.Forms.NumericUpDown();
            this.edRangeEnd = new System.Windows.Forms.DateTimePicker();
            this.edRangeStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostSoldProducts = new System.Windows.Forms.Button();
            this.btnMaximalRevenue = new System.Windows.Forms.Button();
            this.btnMaximalRevenueRanged = new System.Windows.Forms.Button();
            this.btnMostExpensiveBuy = new System.Windows.Forms.Button();
            this.btnMostSoldType = new System.Windows.Forms.Button();
            this.btnMostPaidType = new System.Windows.Forms.Button();
            this.btnMostPopular = new System.Windows.Forms.Button();
            this.btnNotSoldProducts = new System.Windows.Forms.Button();
            this.dgvComplex = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirms)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDaysNumber)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplex)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnProdUpdate);
            this.tabPage1.Controls.Add(this.btnProdSave);
            this.tabPage1.Controls.Add(this.dgvProd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProdUpdate
            // 
            this.btnProdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProdUpdate.Location = new System.Drawing.Point(604, 399);
            this.btnProdUpdate.Name = "btnProdUpdate";
            this.btnProdUpdate.Size = new System.Drawing.Size(225, 35);
            this.btnProdUpdate.TabIndex = 2;
            this.btnProdUpdate.Text = "Update";
            this.btnProdUpdate.UseVisualStyleBackColor = true;
            this.btnProdUpdate.Click += new System.EventHandler(this.btnProdUpdate_Click);
            // 
            // btnProdSave
            // 
            this.btnProdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProdSave.Location = new System.Drawing.Point(7, 399);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(225, 35);
            this.btnProdSave.TabIndex = 1;
            this.btnProdSave.Text = "Commit changes";
            this.btnProdSave.UseVisualStyleBackColor = true;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(7, 7);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(822, 377);
            this.dgvProd.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFirmsUpdate);
            this.tabPage2.Controls.Add(this.btnFirmsSave);
            this.tabPage2.Controls.Add(this.dgvFirms);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Firms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFirmsUpdate
            // 
            this.btnFirmsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFirmsUpdate.Location = new System.Drawing.Point(603, 402);
            this.btnFirmsUpdate.Name = "btnFirmsUpdate";
            this.btnFirmsUpdate.Size = new System.Drawing.Size(225, 35);
            this.btnFirmsUpdate.TabIndex = 5;
            this.btnFirmsUpdate.Text = "Update";
            this.btnFirmsUpdate.UseVisualStyleBackColor = true;
            this.btnFirmsUpdate.Click += new System.EventHandler(this.btnFirmsUpdate_Click);
            // 
            // btnFirmsSave
            // 
            this.btnFirmsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFirmsSave.Location = new System.Drawing.Point(6, 402);
            this.btnFirmsSave.Name = "btnFirmsSave";
            this.btnFirmsSave.Size = new System.Drawing.Size(225, 35);
            this.btnFirmsSave.TabIndex = 4;
            this.btnFirmsSave.Text = "Commit changes";
            this.btnFirmsSave.UseVisualStyleBackColor = true;
            this.btnFirmsSave.Click += new System.EventHandler(this.btnFirmsSave_Click);
            // 
            // dgvFirms
            // 
            this.dgvFirms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirms.Location = new System.Drawing.Point(6, 10);
            this.dgvFirms.Name = "dgvFirms";
            this.dgvFirms.Size = new System.Drawing.Size(822, 377);
            this.dgvFirms.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSellersUpdate);
            this.tabPage3.Controls.Add(this.btnSellersSave);
            this.tabPage3.Controls.Add(this.dgvSellers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(835, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sellers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSellersUpdate
            // 
            this.btnSellersUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSellersUpdate.Location = new System.Drawing.Point(603, 402);
            this.btnSellersUpdate.Name = "btnSellersUpdate";
            this.btnSellersUpdate.Size = new System.Drawing.Size(225, 35);
            this.btnSellersUpdate.TabIndex = 8;
            this.btnSellersUpdate.Text = "Update";
            this.btnSellersUpdate.UseVisualStyleBackColor = true;
            this.btnSellersUpdate.Click += new System.EventHandler(this.btnSellersUpdate_Click);
            // 
            // btnSellersSave
            // 
            this.btnSellersSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSellersSave.Location = new System.Drawing.Point(6, 402);
            this.btnSellersSave.Name = "btnSellersSave";
            this.btnSellersSave.Size = new System.Drawing.Size(225, 35);
            this.btnSellersSave.TabIndex = 7;
            this.btnSellersSave.Text = "Commit changes";
            this.btnSellersSave.UseVisualStyleBackColor = true;
            this.btnSellersSave.Click += new System.EventHandler(this.btnSellersSave_Click);
            // 
            // dgvSellers
            // 
            this.dgvSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellers.Location = new System.Drawing.Point(6, 10);
            this.dgvSellers.Name = "dgvSellers";
            this.dgvSellers.Size = new System.Drawing.Size(822, 377);
            this.dgvSellers.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnTypesUpdate);
            this.tabPage4.Controls.Add(this.btnTypesSave);
            this.tabPage4.Controls.Add(this.dgvTypes);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(835, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Types";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTypesUpdate
            // 
            this.btnTypesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTypesUpdate.Location = new System.Drawing.Point(603, 402);
            this.btnTypesUpdate.Name = "btnTypesUpdate";
            this.btnTypesUpdate.Size = new System.Drawing.Size(225, 35);
            this.btnTypesUpdate.TabIndex = 11;
            this.btnTypesUpdate.Text = "Update";
            this.btnTypesUpdate.UseVisualStyleBackColor = true;
            this.btnTypesUpdate.Click += new System.EventHandler(this.btnTypesUpdate_Click);
            // 
            // btnTypesSave
            // 
            this.btnTypesSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTypesSave.Location = new System.Drawing.Point(6, 402);
            this.btnTypesSave.Name = "btnTypesSave";
            this.btnTypesSave.Size = new System.Drawing.Size(225, 35);
            this.btnTypesSave.TabIndex = 10;
            this.btnTypesSave.Text = "Commit changes";
            this.btnTypesSave.UseVisualStyleBackColor = true;
            this.btnTypesSave.Click += new System.EventHandler(this.btnTypesSave_Click);
            // 
            // dgvTypes
            // 
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Location = new System.Drawing.Point(6, 10);
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.Size = new System.Drawing.Size(822, 377);
            this.dgvTypes.TabIndex = 9;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnSalesUpdate);
            this.tabPage6.Controls.Add(this.btnSalesSave);
            this.tabPage6.Controls.Add(this.dgvSales);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(835, 447);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Sales";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnSalesUpdate
            // 
            this.btnSalesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSalesUpdate.Location = new System.Drawing.Point(603, 402);
            this.btnSalesUpdate.Name = "btnSalesUpdate";
            this.btnSalesUpdate.Size = new System.Drawing.Size(225, 35);
            this.btnSalesUpdate.TabIndex = 5;
            this.btnSalesUpdate.Text = "Update";
            this.btnSalesUpdate.UseVisualStyleBackColor = true;
            this.btnSalesUpdate.Click += new System.EventHandler(this.btnSalesUpdate_Click);
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSalesSave.Location = new System.Drawing.Point(6, 402);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(225, 35);
            this.btnSalesSave.TabIndex = 4;
            this.btnSalesSave.Text = "Commit changes";
            this.btnSalesSave.UseVisualStyleBackColor = true;
            this.btnSalesSave.Click += new System.EventHandler(this.btnSalesSave_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(6, 10);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(822, 377);
            this.dgvSales.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.edDaysNumber);
            this.tabPage5.Controls.Add(this.edRangeEnd);
            this.tabPage5.Controls.Add(this.edRangeStart);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.flowLayoutPanel1);
            this.tabPage5.Controls.Add(this.dgvComplex);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(835, 447);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ComplexQueries";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // edDaysNumber
            // 
            this.edDaysNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edDaysNumber.Location = new System.Drawing.Point(76, 420);
            this.edDaysNumber.Name = "edDaysNumber";
            this.edDaysNumber.Size = new System.Drawing.Size(120, 20);
            this.edDaysNumber.TabIndex = 7;
            // 
            // edRangeEnd
            // 
            this.edRangeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edRangeEnd.Location = new System.Drawing.Point(162, 362);
            this.edRangeEnd.Name = "edRangeEnd";
            this.edRangeEnd.Size = new System.Drawing.Size(138, 20);
            this.edRangeEnd.TabIndex = 6;
            // 
            // edRangeStart
            // 
            this.edRangeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edRangeStart.Location = new System.Drawing.Point(21, 362);
            this.edRangeStart.Name = "edRangeStart";
            this.edRangeStart.Size = new System.Drawing.Size(125, 20);
            this.edRangeStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of recent days";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End of range";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start of range";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.btnMostSoldProducts);
            this.flowLayoutPanel1.Controls.Add(this.btnMaximalRevenue);
            this.flowLayoutPanel1.Controls.Add(this.btnMaximalRevenueRanged);
            this.flowLayoutPanel1.Controls.Add(this.btnMostExpensiveBuy);
            this.flowLayoutPanel1.Controls.Add(this.btnMostSoldType);
            this.flowLayoutPanel1.Controls.Add(this.btnMostPaidType);
            this.flowLayoutPanel1.Controls.Add(this.btnMostPopular);
            this.flowLayoutPanel1.Controls.Add(this.btnNotSoldProducts);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 3);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(282, 324);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 324);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnMostSoldProducts
            // 
            this.btnMostSoldProducts.Location = new System.Drawing.Point(3, 3);
            this.btnMostSoldProducts.Name = "btnMostSoldProducts";
            this.btnMostSoldProducts.Size = new System.Drawing.Size(135, 75);
            this.btnMostSoldProducts.TabIndex = 0;
            this.btnMostSoldProducts.Text = "Manager with the most sold produts";
            this.btnMostSoldProducts.UseVisualStyleBackColor = false;
            this.btnMostSoldProducts.Click += new System.EventHandler(this.btnMostSoldProducts_Click);
            // 
            // btnMaximalRevenue
            // 
            this.btnMaximalRevenue.Location = new System.Drawing.Point(144, 3);
            this.btnMaximalRevenue.Name = "btnMaximalRevenue";
            this.btnMaximalRevenue.Size = new System.Drawing.Size(135, 75);
            this.btnMaximalRevenue.TabIndex = 1;
            this.btnMaximalRevenue.Text = "Manager with most total revenue made";
            this.btnMaximalRevenue.UseVisualStyleBackColor = true;
            this.btnMaximalRevenue.Click += new System.EventHandler(this.btnMaximalRevenue_Click);
            // 
            // btnMaximalRevenueRanged
            // 
            this.btnMaximalRevenueRanged.Location = new System.Drawing.Point(3, 84);
            this.btnMaximalRevenueRanged.Name = "btnMaximalRevenueRanged";
            this.btnMaximalRevenueRanged.Size = new System.Drawing.Size(135, 75);
            this.btnMaximalRevenueRanged.TabIndex = 2;
            this.btnMaximalRevenueRanged.Text = "Manager with most total revenue made between dates";
            this.btnMaximalRevenueRanged.UseVisualStyleBackColor = true;
            this.btnMaximalRevenueRanged.Click += new System.EventHandler(this.btnMaximalRevenueRanged_Click);
            // 
            // btnMostExpensiveBuy
            // 
            this.btnMostExpensiveBuy.Location = new System.Drawing.Point(144, 84);
            this.btnMostExpensiveBuy.Name = "btnMostExpensiveBuy";
            this.btnMostExpensiveBuy.Size = new System.Drawing.Size(135, 75);
            this.btnMostExpensiveBuy.TabIndex = 3;
            this.btnMostExpensiveBuy.Text = "Firm with the most expensive buy";
            this.btnMostExpensiveBuy.UseVisualStyleBackColor = true;
            this.btnMostExpensiveBuy.Click += new System.EventHandler(this.btnMostExpensiveBuy_Click);
            // 
            // btnMostSoldType
            // 
            this.btnMostSoldType.Location = new System.Drawing.Point(3, 165);
            this.btnMostSoldType.Name = "btnMostSoldType";
            this.btnMostSoldType.Size = new System.Drawing.Size(135, 75);
            this.btnMostSoldType.TabIndex = 4;
            this.btnMostSoldType.Text = "Most sold type";
            this.btnMostSoldType.UseVisualStyleBackColor = true;
            this.btnMostSoldType.Click += new System.EventHandler(this.btnMostSoldType_Click);
            // 
            // btnMostPaidType
            // 
            this.btnMostPaidType.Location = new System.Drawing.Point(144, 165);
            this.btnMostPaidType.Name = "btnMostPaidType";
            this.btnMostPaidType.Size = new System.Drawing.Size(135, 75);
            this.btnMostPaidType.TabIndex = 5;
            this.btnMostPaidType.Text = "Most paid for type";
            this.btnMostPaidType.UseVisualStyleBackColor = true;
            this.btnMostPaidType.Click += new System.EventHandler(this.btnMostPaidType_Click);
            // 
            // btnMostPopular
            // 
            this.btnMostPopular.Location = new System.Drawing.Point(3, 246);
            this.btnMostPopular.Name = "btnMostPopular";
            this.btnMostPopular.Size = new System.Drawing.Size(135, 75);
            this.btnMostPopular.TabIndex = 6;
            this.btnMostPopular.Text = "Most popular products";
            this.btnMostPopular.UseVisualStyleBackColor = true;
            this.btnMostPopular.Click += new System.EventHandler(this.btnMostPopular_Click);
            // 
            // btnNotSoldProducts
            // 
            this.btnNotSoldProducts.Location = new System.Drawing.Point(144, 246);
            this.btnNotSoldProducts.Name = "btnNotSoldProducts";
            this.btnNotSoldProducts.Size = new System.Drawing.Size(135, 75);
            this.btnNotSoldProducts.TabIndex = 7;
            this.btnNotSoldProducts.Text = "Products which weren\'t sold in recent * days";
            this.btnNotSoldProducts.UseVisualStyleBackColor = true;
            this.btnNotSoldProducts.Click += new System.EventHandler(this.btnNotSoldProducts_Click);
            // 
            // dgvComplex
            // 
            this.dgvComplex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComplex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvComplex.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvComplex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvComplex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvComplex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComplex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplex.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvComplex.Location = new System.Drawing.Point(326, 3);
            this.dgvComplex.Name = "dgvComplex";
            this.dgvComplex.Size = new System.Drawing.Size(504, 437);
            this.dgvComplex.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(848, 477);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(864, 516);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StatShop";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirms)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDaysNumber)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnProdUpdate;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnFirmsUpdate;
        private System.Windows.Forms.Button btnFirmsSave;
        private System.Windows.Forms.DataGridView dgvFirms;
        private System.Windows.Forms.Button btnSellersUpdate;
        private System.Windows.Forms.Button btnSellersSave;
        private System.Windows.Forms.DataGridView dgvSellers;
        private System.Windows.Forms.Button btnTypesUpdate;
        private System.Windows.Forms.Button btnTypesSave;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.DataGridView dgvComplex;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMostSoldProducts;
        private System.Windows.Forms.Button btnMaximalRevenue;
        private System.Windows.Forms.Button btnMaximalRevenueRanged;
        private System.Windows.Forms.Button btnMostExpensiveBuy;
        private System.Windows.Forms.Button btnMostSoldType;
        private System.Windows.Forms.Button btnMostPaidType;
        private System.Windows.Forms.Button btnMostPopular;
        private System.Windows.Forms.Button btnNotSoldProducts;
        private System.Windows.Forms.NumericUpDown edDaysNumber;
        private System.Windows.Forms.DateTimePicker edRangeEnd;
        private System.Windows.Forms.DateTimePicker edRangeStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnSalesUpdate;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.DataGridView dgvSales;
    }
}

