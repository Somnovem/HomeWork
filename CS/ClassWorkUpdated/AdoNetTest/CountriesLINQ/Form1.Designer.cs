namespace CountriesLINQ
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.edAreaBigger = new System.Windows.Forms.NumericUpDown();
            this.edPopultaionBigger = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edRangeStart = new System.Windows.Forms.NumericUpDown();
            this.edRangeEnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowAllNames = new System.Windows.Forms.Button();
            this.btnShowAllCapitals = new System.Windows.Forms.Button();
            this.btnShowEuropeNames = new System.Windows.Forms.Button();
            this.btnAreaBigger = new System.Windows.Forms.Button();
            this.btnShowCountriesAU = new System.Windows.Forms.Button();
            this.btnShowCountriesA = new System.Windows.Forms.Button();
            this.btnShowCountriesRanged = new System.Windows.Forms.Button();
            this.btnShowCountriesPopulationMore = new System.Windows.Forms.Button();
            this.btnTop5Area = new System.Windows.Forms.Button();
            this.btnTop5Population = new System.Windows.Forms.Button();
            this.btnMaxArea = new System.Windows.Forms.Button();
            this.btnMaxPopulation = new System.Windows.Forms.Button();
            this.btnMinAreaAfrica = new System.Windows.Forms.Button();
            this.btnAvgAreaAsia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAreaBigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPopultaionBigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeEnd)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(279, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(509, 426);
            this.dgv.TabIndex = 0;
            // 
            // edAreaBigger
            // 
            this.edAreaBigger.Location = new System.Drawing.Point(12, 418);
            this.edAreaBigger.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.edAreaBigger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edAreaBigger.Name = "edAreaBigger";
            this.edAreaBigger.Size = new System.Drawing.Size(120, 20);
            this.edAreaBigger.TabIndex = 2;
            this.edAreaBigger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edPopultaionBigger
            // 
            this.edPopultaionBigger.Location = new System.Drawing.Point(139, 418);
            this.edPopultaionBigger.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.edPopultaionBigger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edPopultaionBigger.Name = "edPopultaionBigger";
            this.edPopultaionBigger.Size = new System.Drawing.Size(120, 20);
            this.edPopultaionBigger.TabIndex = 3;
            this.edPopultaionBigger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area greater than:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Population greater than:";
            // 
            // edRangeStart
            // 
            this.edRangeStart.Location = new System.Drawing.Point(12, 365);
            this.edRangeStart.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.edRangeStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edRangeStart.Name = "edRangeStart";
            this.edRangeStart.Size = new System.Drawing.Size(120, 20);
            this.edRangeStart.TabIndex = 6;
            this.edRangeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edRangeEnd
            // 
            this.edRangeEnd.Location = new System.Drawing.Point(142, 364);
            this.edRangeEnd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.edRangeEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edRangeEnd.Name = "edRangeEnd";
            this.edRangeEnd.Size = new System.Drawing.Size(120, 20);
            this.edRangeEnd.TabIndex = 7;
            this.edRangeEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Area in range(start):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area in range(end):";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnShowAll);
            this.flowLayoutPanel1.Controls.Add(this.btnShowAllNames);
            this.flowLayoutPanel1.Controls.Add(this.btnShowAllCapitals);
            this.flowLayoutPanel1.Controls.Add(this.btnShowEuropeNames);
            this.flowLayoutPanel1.Controls.Add(this.btnAreaBigger);
            this.flowLayoutPanel1.Controls.Add(this.btnShowCountriesAU);
            this.flowLayoutPanel1.Controls.Add(this.btnShowCountriesA);
            this.flowLayoutPanel1.Controls.Add(this.btnShowCountriesRanged);
            this.flowLayoutPanel1.Controls.Add(this.btnShowCountriesPopulationMore);
            this.flowLayoutPanel1.Controls.Add(this.btnTop5Area);
            this.flowLayoutPanel1.Controls.Add(this.btnTop5Population);
            this.flowLayoutPanel1.Controls.Add(this.btnMaxArea);
            this.flowLayoutPanel1.Controls.Add(this.btnMaxPopulation);
            this.flowLayoutPanel1.Controls.Add(this.btnMinAreaAfrica);
            this.flowLayoutPanel1.Controls.Add(this.btnAvgAreaAsia);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(261, 329);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(3, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 60);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowAllNames
            // 
            this.btnShowAllNames.Location = new System.Drawing.Point(89, 3);
            this.btnShowAllNames.Name = "btnShowAllNames";
            this.btnShowAllNames.Size = new System.Drawing.Size(80, 60);
            this.btnShowAllNames.TabIndex = 1;
            this.btnShowAllNames.Text = "Show All Names";
            this.btnShowAllNames.UseVisualStyleBackColor = true;
            this.btnShowAllNames.Click += new System.EventHandler(this.btnShowAllNames_Click);
            // 
            // btnShowAllCapitals
            // 
            this.btnShowAllCapitals.Location = new System.Drawing.Point(175, 3);
            this.btnShowAllCapitals.Name = "btnShowAllCapitals";
            this.btnShowAllCapitals.Size = new System.Drawing.Size(80, 60);
            this.btnShowAllCapitals.TabIndex = 2;
            this.btnShowAllCapitals.Text = "Show All Capitals";
            this.btnShowAllCapitals.UseVisualStyleBackColor = true;
            this.btnShowAllCapitals.Click += new System.EventHandler(this.btnShowAllCapitals_Click);
            // 
            // btnShowEuropeNames
            // 
            this.btnShowEuropeNames.Location = new System.Drawing.Point(3, 69);
            this.btnShowEuropeNames.Name = "btnShowEuropeNames";
            this.btnShowEuropeNames.Size = new System.Drawing.Size(80, 60);
            this.btnShowEuropeNames.TabIndex = 3;
            this.btnShowEuropeNames.Text = "Show Names of European countries";
            this.btnShowEuropeNames.UseVisualStyleBackColor = true;
            this.btnShowEuropeNames.Click += new System.EventHandler(this.btnShowEuropeNames_Click);
            // 
            // btnAreaBigger
            // 
            this.btnAreaBigger.Location = new System.Drawing.Point(89, 69);
            this.btnAreaBigger.Name = "btnAreaBigger";
            this.btnAreaBigger.Size = new System.Drawing.Size(80, 60);
            this.btnAreaBigger.TabIndex = 4;
            this.btnAreaBigger.Text = "Show countries with area bigger than";
            this.btnAreaBigger.UseVisualStyleBackColor = true;
            this.btnAreaBigger.Click += new System.EventHandler(this.btnAreaBigger_Click);
            // 
            // btnShowCountriesAU
            // 
            this.btnShowCountriesAU.Location = new System.Drawing.Point(175, 69);
            this.btnShowCountriesAU.Name = "btnShowCountriesAU";
            this.btnShowCountriesAU.Size = new System.Drawing.Size(80, 60);
            this.btnShowCountriesAU.TabIndex = 5;
            this.btnShowCountriesAU.Text = "Show Countries with A and U in name";
            this.btnShowCountriesAU.UseVisualStyleBackColor = true;
            this.btnShowCountriesAU.Click += new System.EventHandler(this.btnShowCountriesAU_Click);
            // 
            // btnShowCountriesA
            // 
            this.btnShowCountriesA.Location = new System.Drawing.Point(3, 135);
            this.btnShowCountriesA.Name = "btnShowCountriesA";
            this.btnShowCountriesA.Size = new System.Drawing.Size(80, 60);
            this.btnShowCountriesA.TabIndex = 6;
            this.btnShowCountriesA.Text = "Show Countries with A in name";
            this.btnShowCountriesA.UseVisualStyleBackColor = true;
            this.btnShowCountriesA.Click += new System.EventHandler(this.btnShowCountriesA_Click);
            // 
            // btnShowCountriesRanged
            // 
            this.btnShowCountriesRanged.Location = new System.Drawing.Point(89, 135);
            this.btnShowCountriesRanged.Name = "btnShowCountriesRanged";
            this.btnShowCountriesRanged.Size = new System.Drawing.Size(80, 60);
            this.btnShowCountriesRanged.TabIndex = 7;
            this.btnShowCountriesRanged.Text = "Show Countries with ranged Area";
            this.btnShowCountriesRanged.UseVisualStyleBackColor = true;
            this.btnShowCountriesRanged.Click += new System.EventHandler(this.btnShowCountriesRanged_Click);
            // 
            // btnShowCountriesPopulationMore
            // 
            this.btnShowCountriesPopulationMore.Location = new System.Drawing.Point(175, 135);
            this.btnShowCountriesPopulationMore.Name = "btnShowCountriesPopulationMore";
            this.btnShowCountriesPopulationMore.Size = new System.Drawing.Size(80, 60);
            this.btnShowCountriesPopulationMore.TabIndex = 8;
            this.btnShowCountriesPopulationMore.Text = "Show Countries,Popultaion more than";
            this.btnShowCountriesPopulationMore.UseVisualStyleBackColor = true;
            this.btnShowCountriesPopulationMore.Click += new System.EventHandler(this.btnShowCountriesPopulationMore_Click);
            // 
            // btnTop5Area
            // 
            this.btnTop5Area.Location = new System.Drawing.Point(3, 201);
            this.btnTop5Area.Name = "btnTop5Area";
            this.btnTop5Area.Size = new System.Drawing.Size(80, 60);
            this.btnTop5Area.TabIndex = 9;
            this.btnTop5Area.Text = "Show Top 5 Countries by Area";
            this.btnTop5Area.UseVisualStyleBackColor = true;
            this.btnTop5Area.Click += new System.EventHandler(this.btnTop5Area_Click);
            // 
            // btnTop5Population
            // 
            this.btnTop5Population.Location = new System.Drawing.Point(89, 201);
            this.btnTop5Population.Name = "btnTop5Population";
            this.btnTop5Population.Size = new System.Drawing.Size(80, 60);
            this.btnTop5Population.TabIndex = 10;
            this.btnTop5Population.Text = "Show Top 5 Countries by popultaion";
            this.btnTop5Population.UseVisualStyleBackColor = true;
            this.btnTop5Population.Click += new System.EventHandler(this.btnTop5Population_Click);
            // 
            // btnMaxArea
            // 
            this.btnMaxArea.Location = new System.Drawing.Point(175, 201);
            this.btnMaxArea.Name = "btnMaxArea";
            this.btnMaxArea.Size = new System.Drawing.Size(80, 60);
            this.btnMaxArea.TabIndex = 11;
            this.btnMaxArea.Text = "Show max Area Country";
            this.btnMaxArea.UseVisualStyleBackColor = true;
            this.btnMaxArea.Click += new System.EventHandler(this.btnMaxArea_Click);
            // 
            // btnMaxPopulation
            // 
            this.btnMaxPopulation.Location = new System.Drawing.Point(3, 267);
            this.btnMaxPopulation.Name = "btnMaxPopulation";
            this.btnMaxPopulation.Size = new System.Drawing.Size(80, 60);
            this.btnMaxPopulation.TabIndex = 12;
            this.btnMaxPopulation.Text = "Show max Population Country";
            this.btnMaxPopulation.UseVisualStyleBackColor = true;
            this.btnMaxPopulation.Click += new System.EventHandler(this.btnMaxPopulation_Click);
            // 
            // btnMinAreaAfrica
            // 
            this.btnMinAreaAfrica.Location = new System.Drawing.Point(89, 267);
            this.btnMinAreaAfrica.Name = "btnMinAreaAfrica";
            this.btnMinAreaAfrica.Size = new System.Drawing.Size(80, 60);
            this.btnMinAreaAfrica.TabIndex = 13;
            this.btnMinAreaAfrica.Text = "Show Min Area in Africa";
            this.btnMinAreaAfrica.UseVisualStyleBackColor = true;
            this.btnMinAreaAfrica.Click += new System.EventHandler(this.btnMinAreaAfrica_Click);
            // 
            // btnAvgAreaAsia
            // 
            this.btnAvgAreaAsia.Location = new System.Drawing.Point(175, 267);
            this.btnAvgAreaAsia.Name = "btnAvgAreaAsia";
            this.btnAvgAreaAsia.Size = new System.Drawing.Size(80, 60);
            this.btnAvgAreaAsia.TabIndex = 14;
            this.btnAvgAreaAsia.Text = "Show avg Area in Asia";
            this.btnAvgAreaAsia.UseVisualStyleBackColor = true;
            this.btnAvgAreaAsia.Click += new System.EventHandler(this.btnAvgAreaAsia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edRangeEnd);
            this.Controls.Add(this.edRangeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edPopultaionBigger);
            this.Controls.Add(this.edAreaBigger);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countries by LINQ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAreaBigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPopultaionBigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeEnd)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.NumericUpDown edAreaBigger;
        private System.Windows.Forms.NumericUpDown edPopultaionBigger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edRangeStart;
        private System.Windows.Forms.NumericUpDown edRangeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowAllNames;
        private System.Windows.Forms.Button btnShowAllCapitals;
        private System.Windows.Forms.Button btnShowEuropeNames;
        private System.Windows.Forms.Button btnAreaBigger;
        private System.Windows.Forms.Button btnShowCountriesAU;
        private System.Windows.Forms.Button btnShowCountriesA;
        private System.Windows.Forms.Button btnShowCountriesRanged;
        private System.Windows.Forms.Button btnShowCountriesPopulationMore;
        private System.Windows.Forms.Button btnTop5Area;
        private System.Windows.Forms.Button btnTop5Population;
        private System.Windows.Forms.Button btnMaxArea;
        private System.Windows.Forms.Button btnMaxPopulation;
        private System.Windows.Forms.Button btnMinAreaAfrica;
        private System.Windows.Forms.Button btnAvgAreaAsia;
    }
}

