namespace WF_CW
{
    partial class BestOil
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
            this.Cafe = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FoodPrice = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Station = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SumText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.PriceOptions = new System.Windows.Forms.GroupBox();
            this.OilSum = new System.Windows.Forms.RadioButton();
            this.Quantity = new System.Windows.Forms.RadioButton();
            this.FoodPrice2 = new System.Windows.Forms.GroupBox();
            this.Price1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FinalPrice = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Cafe.SuspendLayout();
            this.FoodPrice.SuspendLayout();
            this.Station.SuspendLayout();
            this.PriceOptions.SuspendLayout();
            this.FoodPrice2.SuspendLayout();
            this.FinalPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Cafe
            // 
            this.Cafe.Controls.Add(this.label8);
            this.Cafe.Controls.Add(this.panel1);
            this.Cafe.Controls.Add(this.FoodPrice);
            this.Cafe.Controls.Add(this.label7);
            this.Cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cafe.ForeColor = System.Drawing.Color.IndianRed;
            this.Cafe.Location = new System.Drawing.Point(338, 22);
            this.Cafe.Name = "Cafe";
            this.Cafe.Size = new System.Drawing.Size(334, 368);
            this.Cafe.TabIndex = 0;
            this.Cafe.TabStop = false;
            this.Cafe.Text = "Міні-Кафе";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(196, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Кількість";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(7, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 165);
            this.panel1.TabIndex = 13;
            // 
            // FoodPrice
            // 
            this.FoodPrice.Controls.Add(this.label6);
            this.FoodPrice.Controls.Add(this.Price2);
            this.FoodPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.FoodPrice.Location = new System.Drawing.Point(7, 239);
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.Size = new System.Drawing.Size(321, 118);
            this.FoodPrice.TabIndex = 0;
            this.FoodPrice.TabStop = false;
            this.FoodPrice.Text = "До оплати:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "грн.";
            // 
            // Price2
            // 
            this.Price2.AutoSize = true;
            this.Price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price2.ForeColor = System.Drawing.Color.Tomato;
            this.Price2.Location = new System.Drawing.Point(125, 60);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(0, 29);
            this.Price2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(134, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ціна";
            // 
            // Station
            // 
            this.Station.Controls.Add(this.label4);
            this.Station.Controls.Add(this.label3);
            this.Station.Controls.Add(this.comboBox1);
            this.Station.Controls.Add(this.textBox1);
            this.Station.Controls.Add(this.label2);
            this.Station.Controls.Add(this.label1);
            this.Station.Controls.Add(this.SumText);
            this.Station.Controls.Add(this.QuantityText);
            this.Station.Controls.Add(this.PriceOptions);
            this.Station.Controls.Add(this.FoodPrice2);
            this.Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Station.ForeColor = System.Drawing.Color.Lime;
            this.Station.Location = new System.Drawing.Point(28, 22);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(265, 368);
            this.Station.TabIndex = 1;
            this.Station.TabStop = false;
            this.Station.Tag = "Кількість";
            this.Station.Text = "Автозаправка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Бензин";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBox1.Location = new System.Drawing.Point(66, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(233, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "л.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(233, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "грн.";
            // 
            // SumText
            // 
            this.SumText.ForeColor = System.Drawing.Color.ForestGreen;
            this.SumText.Location = new System.Drawing.Point(140, 209);
            this.SumText.Name = "SumText";
            this.SumText.Size = new System.Drawing.Size(91, 22);
            this.SumText.TabIndex = 4;
            this.SumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SumText.TextChanged += new System.EventHandler(this.SumText_TextChanged);
            // 
            // QuantityText
            // 
            this.QuantityText.ForeColor = System.Drawing.Color.ForestGreen;
            this.QuantityText.Location = new System.Drawing.Point(140, 181);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(91, 22);
            this.QuantityText.TabIndex = 3;
            this.QuantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            // 
            // PriceOptions
            // 
            this.PriceOptions.Controls.Add(this.OilSum);
            this.PriceOptions.Controls.Add(this.Quantity);
            this.PriceOptions.Location = new System.Drawing.Point(6, 171);
            this.PriceOptions.Name = "PriceOptions";
            this.PriceOptions.Size = new System.Drawing.Size(121, 62);
            this.PriceOptions.TabIndex = 2;
            this.PriceOptions.TabStop = false;
            // 
            // OilSum
            // 
            this.OilSum.AutoSize = true;
            this.OilSum.Location = new System.Drawing.Point(6, 36);
            this.OilSum.Name = "OilSum";
            this.OilSum.Size = new System.Drawing.Size(63, 20);
            this.OilSum.TabIndex = 3;
            this.OilSum.TabStop = true;
            this.OilSum.Text = "Сума";
            this.OilSum.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(6, 12);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(91, 20);
            this.Quantity.TabIndex = 0;
            this.Quantity.TabStop = true;
            this.Quantity.Text = "Кількість";
            this.Quantity.UseVisualStyleBackColor = true;
            // 
            // FoodPrice2
            // 
            this.FoodPrice2.Controls.Add(this.Price1);
            this.FoodPrice2.Controls.Add(this.label5);
            this.FoodPrice2.ForeColor = System.Drawing.Color.Lime;
            this.FoodPrice2.Location = new System.Drawing.Point(6, 239);
            this.FoodPrice2.Name = "FoodPrice2";
            this.FoodPrice2.Size = new System.Drawing.Size(238, 118);
            this.FoodPrice2.TabIndex = 1;
            this.FoodPrice2.TabStop = false;
            this.FoodPrice2.Text = "До оплати:";
            // 
            // Price1
            // 
            this.Price1.AutoSize = true;
            this.Price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price1.ForeColor = System.Drawing.Color.ForestGreen;
            this.Price1.Location = new System.Drawing.Point(69, 60);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(0, 29);
            this.Price1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "грн.";
            // 
            // FinalPrice
            // 
            this.FinalPrice.Controls.Add(this.label9);
            this.FinalPrice.Controls.Add(this.label10);
            this.FinalPrice.Controls.Add(this.Btn_Calculate);
            this.FinalPrice.Controls.Add(this.Picture);
            this.FinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalPrice.ForeColor = System.Drawing.Color.Yellow;
            this.FinalPrice.Location = new System.Drawing.Point(28, 417);
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Size = new System.Drawing.Size(644, 117);
            this.FinalPrice.TabIndex = 2;
            this.FinalPrice.TabStop = false;
            this.FinalPrice.Text = "Всього до сплати:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(405, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 37);
            this.label9.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(568, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "грн.";
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.BackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Calculate.Location = new System.Drawing.Point(100, 30);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(221, 70);
            this.Btn_Calculate.TabIndex = 1;
            this.Btn_Calculate.Text = "Прорахувати";
            this.Btn_Calculate.UseVisualStyleBackColor = false;
            // 
            // Picture
            // 
            this.Picture.ErrorImage = global::WF_CW.Properties.Resources.scrudge;
            this.Picture.Image = global::WF_CW.Properties.Resources.scrudge;
            this.Picture.Location = new System.Drawing.Point(12, 30);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(77, 72);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 583);
            this.Controls.Add(this.FinalPrice);
            this.Controls.Add(this.Station);
            this.Controls.Add(this.Cafe);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(700, 622);
            this.MinimumSize = new System.Drawing.Size(700, 622);
            this.Name = "BestOil";
            this.Text = "BestOil";
            this.Cafe.ResumeLayout(false);
            this.Cafe.PerformLayout();
            this.FoodPrice.ResumeLayout(false);
            this.FoodPrice.PerformLayout();
            this.Station.ResumeLayout(false);
            this.Station.PerformLayout();
            this.PriceOptions.ResumeLayout(false);
            this.PriceOptions.PerformLayout();
            this.FoodPrice2.ResumeLayout(false);
            this.FoodPrice2.PerformLayout();
            this.FinalPrice.ResumeLayout(false);
            this.FinalPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Cafe;
        private System.Windows.Forms.GroupBox Station;
        private System.Windows.Forms.GroupBox FoodPrice;
        private System.Windows.Forms.GroupBox FoodPrice2;
        private System.Windows.Forms.GroupBox PriceOptions;
        private System.Windows.Forms.RadioButton Quantity;
        private System.Windows.Forms.RadioButton OilSum;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Price2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox FinalPrice;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}