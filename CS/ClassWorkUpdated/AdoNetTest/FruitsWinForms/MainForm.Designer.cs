namespace FruitsWinForms
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowAllNames = new System.Windows.Forms.Button();
            this.btnShowAllColors = new System.Windows.Forms.Button();
            this.btnYelOrRedProds = new System.Windows.Forms.Button();
            this.btnMaxCalories = new System.Windows.Forms.Button();
            this.btnMinCalories = new System.Windows.Forms.Button();
            this.btnVegNum = new System.Windows.Forms.Button();
            this.btnFruitNum = new System.Windows.Forms.Button();
            this.btnNumProdsInColor = new System.Windows.Forms.Button();
            this.btnNumProdsPerColor = new System.Windows.Forms.Button();
            this.btnProdsWithLessCalor = new System.Windows.Forms.Button();
            this.btnProdsWithMoreCalor = new System.Windows.Forms.Button();
            this.btnCaloriesRanged = new System.Windows.Forms.Button();
            this.btnAvgCalories = new System.Windows.Forms.Button();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvControl = new System.Windows.Forms.DataGridView();
            this.edName = new System.Windows.Forms.TextBox();
            this.edColor = new System.Windows.Forms.TextBox();
            this.edType = new System.Windows.Forms.ComboBox();
            this.edCalories = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.edId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edId)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.dgvQueries);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Queries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnShowAll);
            this.flowLayoutPanel1.Controls.Add(this.btnShowAllNames);
            this.flowLayoutPanel1.Controls.Add(this.btnShowAllColors);
            this.flowLayoutPanel1.Controls.Add(this.btnYelOrRedProds);
            this.flowLayoutPanel1.Controls.Add(this.btnMaxCalories);
            this.flowLayoutPanel1.Controls.Add(this.btnMinCalories);
            this.flowLayoutPanel1.Controls.Add(this.btnVegNum);
            this.flowLayoutPanel1.Controls.Add(this.btnFruitNum);
            this.flowLayoutPanel1.Controls.Add(this.btnNumProdsInColor);
            this.flowLayoutPanel1.Controls.Add(this.btnNumProdsPerColor);
            this.flowLayoutPanel1.Controls.Add(this.btnProdsWithLessCalor);
            this.flowLayoutPanel1.Controls.Add(this.btnProdsWithMoreCalor);
            this.flowLayoutPanel1.Controls.Add(this.btnCaloriesRanged);
            this.flowLayoutPanel1.Controls.Add(this.btnAvgCalories);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 405);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(3, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 50);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowAllNames
            // 
            this.btnShowAllNames.Location = new System.Drawing.Point(109, 3);
            this.btnShowAllNames.Name = "btnShowAllNames";
            this.btnShowAllNames.Size = new System.Drawing.Size(100, 50);
            this.btnShowAllNames.TabIndex = 1;
            this.btnShowAllNames.Text = "Show all names";
            this.btnShowAllNames.UseVisualStyleBackColor = true;
            this.btnShowAllNames.Click += new System.EventHandler(this.btnShowAllNames_Click);
            // 
            // btnShowAllColors
            // 
            this.btnShowAllColors.Location = new System.Drawing.Point(3, 59);
            this.btnShowAllColors.Name = "btnShowAllColors";
            this.btnShowAllColors.Size = new System.Drawing.Size(100, 50);
            this.btnShowAllColors.TabIndex = 2;
            this.btnShowAllColors.Text = "Show all colors";
            this.btnShowAllColors.UseVisualStyleBackColor = true;
            this.btnShowAllColors.Click += new System.EventHandler(this.btnShowAllColors_Click);
            // 
            // btnYelOrRedProds
            // 
            this.btnYelOrRedProds.Location = new System.Drawing.Point(109, 59);
            this.btnYelOrRedProds.Name = "btnYelOrRedProds";
            this.btnYelOrRedProds.Size = new System.Drawing.Size(100, 50);
            this.btnYelOrRedProds.TabIndex = 3;
            this.btnYelOrRedProds.Text = "Yellow or Red products";
            this.btnYelOrRedProds.UseVisualStyleBackColor = true;
            this.btnYelOrRedProds.Click += new System.EventHandler(this.btnYelOrRedProds_Click);
            // 
            // btnMaxCalories
            // 
            this.btnMaxCalories.Location = new System.Drawing.Point(3, 115);
            this.btnMaxCalories.Name = "btnMaxCalories";
            this.btnMaxCalories.Size = new System.Drawing.Size(100, 50);
            this.btnMaxCalories.TabIndex = 4;
            this.btnMaxCalories.Text = "Show Max Calories";
            this.btnMaxCalories.UseVisualStyleBackColor = true;
            this.btnMaxCalories.Click += new System.EventHandler(this.btnMaxCalories_Click);
            // 
            // btnMinCalories
            // 
            this.btnMinCalories.Location = new System.Drawing.Point(109, 115);
            this.btnMinCalories.Name = "btnMinCalories";
            this.btnMinCalories.Size = new System.Drawing.Size(100, 50);
            this.btnMinCalories.TabIndex = 5;
            this.btnMinCalories.Text = "Show Min Calories";
            this.btnMinCalories.UseVisualStyleBackColor = true;
            this.btnMinCalories.Click += new System.EventHandler(this.btnMinCalories_Click);
            // 
            // btnVegNum
            // 
            this.btnVegNum.Location = new System.Drawing.Point(3, 171);
            this.btnVegNum.Name = "btnVegNum";
            this.btnVegNum.Size = new System.Drawing.Size(100, 50);
            this.btnVegNum.TabIndex = 6;
            this.btnVegNum.Text = "Number of vegetables";
            this.btnVegNum.UseVisualStyleBackColor = true;
            this.btnVegNum.Click += new System.EventHandler(this.btnVegNum_Click);
            // 
            // btnFruitNum
            // 
            this.btnFruitNum.Location = new System.Drawing.Point(109, 171);
            this.btnFruitNum.Name = "btnFruitNum";
            this.btnFruitNum.Size = new System.Drawing.Size(100, 50);
            this.btnFruitNum.TabIndex = 7;
            this.btnFruitNum.Text = "Number of fruits";
            this.btnFruitNum.UseVisualStyleBackColor = true;
            this.btnFruitNum.Click += new System.EventHandler(this.btnFruitNum_Click);
            // 
            // btnNumProdsInColor
            // 
            this.btnNumProdsInColor.Location = new System.Drawing.Point(3, 227);
            this.btnNumProdsInColor.Name = "btnNumProdsInColor";
            this.btnNumProdsInColor.Size = new System.Drawing.Size(100, 50);
            this.btnNumProdsInColor.TabIndex = 8;
            this.btnNumProdsInColor.Text = "Number of products in color";
            this.btnNumProdsInColor.UseVisualStyleBackColor = true;
            this.btnNumProdsInColor.Click += new System.EventHandler(this.btnNumProdsInColor_Click);
            // 
            // btnNumProdsPerColor
            // 
            this.btnNumProdsPerColor.Location = new System.Drawing.Point(109, 227);
            this.btnNumProdsPerColor.Name = "btnNumProdsPerColor";
            this.btnNumProdsPerColor.Size = new System.Drawing.Size(100, 50);
            this.btnNumProdsPerColor.TabIndex = 9;
            this.btnNumProdsPerColor.Text = "Number of profucts per color";
            this.btnNumProdsPerColor.UseVisualStyleBackColor = true;
            this.btnNumProdsPerColor.Click += new System.EventHandler(this.btnNumProdsPerColor_Click);
            // 
            // btnProdsWithLessCalor
            // 
            this.btnProdsWithLessCalor.Location = new System.Drawing.Point(3, 283);
            this.btnProdsWithLessCalor.Name = "btnProdsWithLessCalor";
            this.btnProdsWithLessCalor.Size = new System.Drawing.Size(100, 50);
            this.btnProdsWithLessCalor.TabIndex = 10;
            this.btnProdsWithLessCalor.Text = "Products with less calories";
            this.btnProdsWithLessCalor.UseVisualStyleBackColor = true;
            this.btnProdsWithLessCalor.Click += new System.EventHandler(this.btnProdsWithLessCalor_Click);
            // 
            // btnProdsWithMoreCalor
            // 
            this.btnProdsWithMoreCalor.Location = new System.Drawing.Point(109, 283);
            this.btnProdsWithMoreCalor.Name = "btnProdsWithMoreCalor";
            this.btnProdsWithMoreCalor.Size = new System.Drawing.Size(100, 50);
            this.btnProdsWithMoreCalor.TabIndex = 11;
            this.btnProdsWithMoreCalor.Text = "Products with more calories";
            this.btnProdsWithMoreCalor.UseVisualStyleBackColor = true;
            this.btnProdsWithMoreCalor.Click += new System.EventHandler(this.btnProdsWithMoreCalor_Click);
            // 
            // btnCaloriesRanged
            // 
            this.btnCaloriesRanged.Location = new System.Drawing.Point(3, 339);
            this.btnCaloriesRanged.Name = "btnCaloriesRanged";
            this.btnCaloriesRanged.Size = new System.Drawing.Size(100, 50);
            this.btnCaloriesRanged.TabIndex = 12;
            this.btnCaloriesRanged.Text = "Products with calories in range";
            this.btnCaloriesRanged.UseVisualStyleBackColor = true;
            this.btnCaloriesRanged.Click += new System.EventHandler(this.btnCaloriesRanged_Click);
            // 
            // btnAvgCalories
            // 
            this.btnAvgCalories.Location = new System.Drawing.Point(109, 339);
            this.btnAvgCalories.Name = "btnAvgCalories";
            this.btnAvgCalories.Size = new System.Drawing.Size(100, 50);
            this.btnAvgCalories.TabIndex = 13;
            this.btnAvgCalories.Text = "Show average calories";
            this.btnAvgCalories.UseVisualStyleBackColor = true;
            this.btnAvgCalories.Click += new System.EventHandler(this.btnAvgCalories_Click);
            // 
            // dgvQueries
            // 
            this.dgvQueries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(228, 6);
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.ReadOnly = true;
            this.dgvQueries.Size = new System.Drawing.Size(546, 406);
            this.dgvQueries.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.edId);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.edCalories);
            this.tabPage2.Controls.Add(this.edType);
            this.tabPage2.Controls.Add(this.edColor);
            this.tabPage2.Controls.Add(this.edName);
            this.tabPage2.Controls.Add(this.dgvControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Controling data";
            // 
            // dgvControl
            // 
            this.dgvControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControl.Location = new System.Drawing.Point(346, 6);
            this.dgvControl.Name = "dgvControl";
            this.dgvControl.ReadOnly = true;
            this.dgvControl.Size = new System.Drawing.Size(428, 406);
            this.dgvControl.TabIndex = 0;
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(20, 30);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(271, 20);
            this.edName.TabIndex = 1;
            // 
            // edColor
            // 
            this.edColor.Location = new System.Drawing.Point(20, 77);
            this.edColor.Name = "edColor";
            this.edColor.Size = new System.Drawing.Size(144, 20);
            this.edColor.TabIndex = 2;
            // 
            // edType
            // 
            this.edType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edType.FormattingEnabled = true;
            this.edType.Items.AddRange(new object[] {
            "Fruit",
            "Vegetable"});
            this.edType.Location = new System.Drawing.Point(170, 76);
            this.edType.Name = "edType";
            this.edType.Size = new System.Drawing.Size(121, 21);
            this.edType.TabIndex = 3;
            // 
            // edCalories
            // 
            this.edCalories.Location = new System.Drawing.Point(20, 130);
            this.edCalories.Name = "edCalories";
            this.edCalories.Size = new System.Drawing.Size(144, 20);
            this.edCalories.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // edId
            // 
            this.edId.Location = new System.Drawing.Point(144, 323);
            this.edId.Name = "edId";
            this.edId.Size = new System.Drawing.Size(147, 20);
            this.edId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Calories";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(56, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 28);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Delete row with ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvQueries;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowAllNames;
        private System.Windows.Forms.Button btnShowAllColors;
        private System.Windows.Forms.Button btnYelOrRedProds;
        private System.Windows.Forms.Button btnMaxCalories;
        private System.Windows.Forms.Button btnMinCalories;
        private System.Windows.Forms.Button btnVegNum;
        private System.Windows.Forms.Button btnFruitNum;
        private System.Windows.Forms.Button btnNumProdsInColor;
        private System.Windows.Forms.Button btnNumProdsPerColor;
        private System.Windows.Forms.Button btnProdsWithLessCalor;
        private System.Windows.Forms.Button btnProdsWithMoreCalor;
        private System.Windows.Forms.Button btnCaloriesRanged;
        private System.Windows.Forms.Button btnAvgCalories;
        private System.Windows.Forms.DataGridView dgvControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown edCalories;
        private System.Windows.Forms.ComboBox edType;
        private System.Windows.Forms.TextBox edColor;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
    }
}