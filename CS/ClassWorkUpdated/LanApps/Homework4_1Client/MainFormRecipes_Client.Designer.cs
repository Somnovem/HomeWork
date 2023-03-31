namespace Homework4_1Client
{
    partial class MainFormRecipes_Client
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
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edLocalPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edRemotePort = new System.Windows.Forms.NumericUpDown();
            this.edRemoteAdress = new System.Windows.Forms.TextBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbRecipes = new CustomControls.ListBoxMultiline();
            this.imgRecipe = new System.Windows.Forms.PictureBox();
            this.gbSending = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edNewProduct = new System.Windows.Forms.TextBox();
            this.btnRemoveSelectedProduct = new System.Windows.Forms.Button();
            this.btlClearHistory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLocalPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecipe)).BeginInit();
            this.gbSending.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.edLocalPort);
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Controls.Add(this.edRemotePort);
            this.gbConnection.Controls.Add(this.edRemoteAdress);
            this.gbConnection.Location = new System.Drawing.Point(9, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(521, 110);
            this.gbConnection.TabIndex = 7;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Local port";
            // 
            // edLocalPort
            // 
            this.edLocalPort.Location = new System.Drawing.Point(91, 84);
            this.edLocalPort.Maximum = new decimal(new int[] {
            65456,
            0,
            0,
            0});
            this.edLocalPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edLocalPort.Name = "edLocalPort";
            this.edLocalPort.Size = new System.Drawing.Size(120, 20);
            this.edLocalPort.TabIndex = 10;
            this.edLocalPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remote port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Remote adress";
            // 
            // edRemotePort
            // 
            this.edRemotePort.Location = new System.Drawing.Point(91, 56);
            this.edRemotePort.Maximum = new decimal(new int[] {
            65456,
            0,
            0,
            0});
            this.edRemotePort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edRemotePort.Name = "edRemotePort";
            this.edRemotePort.ReadOnly = true;
            this.edRemotePort.Size = new System.Drawing.Size(120, 20);
            this.edRemotePort.TabIndex = 2;
            this.edRemotePort.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // edRemoteAdress
            // 
            this.edRemoteAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edRemoteAdress.Location = new System.Drawing.Point(91, 30);
            this.edRemoteAdress.Name = "edRemoteAdress";
            this.edRemoteAdress.ReadOnly = true;
            this.edRemoteAdress.Size = new System.Drawing.Size(424, 20);
            this.edRemoteAdress.TabIndex = 0;
            this.edRemoteAdress.Text = "127.0.0.1";
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 20;
            this.lbProducts.Location = new System.Drawing.Point(10, 161);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(277, 144);
            this.lbProducts.TabIndex = 8;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(320, 132);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(142, 23);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(48, 132);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(142, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(39, 102);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(168, 30);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send request";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbRecipes
            // 
            this.lbRecipes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbRecipes.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbRecipes.FormattingEnabled = true;
            this.lbRecipes.Location = new System.Drawing.Point(9, 357);
            this.lbRecipes.Name = "lbRecipes";
            this.lbRecipes.Size = new System.Drawing.Size(278, 291);
            this.lbRecipes.TabIndex = 15;
            // 
            // imgRecipe
            // 
            this.imgRecipe.Location = new System.Drawing.Point(304, 397);
            this.imgRecipe.Name = "imgRecipe";
            this.imgRecipe.Size = new System.Drawing.Size(226, 202);
            this.imgRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRecipe.TabIndex = 16;
            this.imgRecipe.TabStop = false;
            // 
            // gbSending
            // 
            this.gbSending.Controls.Add(this.btnAddProduct);
            this.gbSending.Controls.Add(this.label4);
            this.gbSending.Controls.Add(this.edNewProduct);
            this.gbSending.Controls.Add(this.btnSend);
            this.gbSending.Enabled = false;
            this.gbSending.Location = new System.Drawing.Point(304, 161);
            this.gbSending.Name = "gbSending";
            this.gbSending.Size = new System.Drawing.Size(220, 140);
            this.gbSending.TabIndex = 17;
            this.gbSending.TabStop = false;
            this.gbSending.Text = "Sending";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(39, 66);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(168, 30);
            this.btnAddProduct.TabIndex = 14;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product:";
            // 
            // edNewProduct
            // 
            this.edNewProduct.Location = new System.Drawing.Point(12, 40);
            this.edNewProduct.Name = "edNewProduct";
            this.edNewProduct.Size = new System.Drawing.Size(202, 20);
            this.edNewProduct.TabIndex = 12;
            // 
            // btnRemoveSelectedProduct
            // 
            this.btnRemoveSelectedProduct.Location = new System.Drawing.Point(147, 312);
            this.btnRemoveSelectedProduct.Name = "btnRemoveSelectedProduct";
            this.btnRemoveSelectedProduct.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveSelectedProduct.TabIndex = 18;
            this.btnRemoveSelectedProduct.Text = "Remove selected";
            this.btnRemoveSelectedProduct.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedProduct.Click += new System.EventHandler(this.btnRemoveSelectedProduct_Click);
            // 
            // btlClearHistory
            // 
            this.btlClearHistory.Location = new System.Drawing.Point(19, 328);
            this.btlClearHistory.Name = "btlClearHistory";
            this.btlClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btlClearHistory.TabIndex = 19;
            this.btlClearHistory.Text = "Clear list";
            this.btlClearHistory.UseVisualStyleBackColor = true;
            this.btlClearHistory.Click += new System.EventHandler(this.btlClearHistory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "(If there is no image, there was an error in sending)";
            // 
            // MainFormRecipes_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 660);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btlClearHistory);
            this.Controls.Add(this.btnRemoveSelectedProduct);
            this.Controls.Add(this.gbSending);
            this.Controls.Add(this.imgRecipe);
            this.Controls.Add(this.lbRecipes);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormRecipes_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipes - UDP";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLocalPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRemotePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecipe)).EndInit();
            this.gbSending.ResumeLayout(false);
            this.gbSending.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRemotePort;
        private System.Windows.Forms.TextBox edRemoteAdress;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private CustomControls.ListBoxMultiline lbRecipes;
        private System.Windows.Forms.PictureBox imgRecipe;
        private System.Windows.Forms.GroupBox gbSending;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edNewProduct;
        private System.Windows.Forms.Button btnRemoveSelectedProduct;
        private System.Windows.Forms.Button btlClearHistory;
        private System.Windows.Forms.Label label5;
    }
}

