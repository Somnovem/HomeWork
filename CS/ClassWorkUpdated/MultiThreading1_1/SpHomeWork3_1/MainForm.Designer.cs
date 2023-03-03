namespace SpHomeWork3_1
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
            this.lbPrimes = new System.Windows.Forms.ListBox();
            this.btnPrimesStart = new System.Windows.Forms.Button();
            this.btnPrimesStop = new System.Windows.Forms.Button();
            this.btnPrimesUnfreeze = new System.Windows.Forms.Button();
            this.btnPrimesFreeze = new System.Windows.Forms.Button();
            this.edRangeStart = new System.Windows.Forms.NumericUpDown();
            this.edRangeEnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFibonacciUnfreeze = new System.Windows.Forms.Button();
            this.btnFibonacciFreeze = new System.Windows.Forms.Button();
            this.btnFibonacciStop = new System.Windows.Forms.Button();
            this.btnFibonacciStart = new System.Windows.Forms.Button();
            this.lbFibonacci = new System.Windows.Forms.ListBox();
            this.btnPrimesReset = new System.Windows.Forms.Button();
            this.btnFibonacciReset = new System.Windows.Forms.Button();
            this.cbRangeStart = new System.Windows.Forms.CheckBox();
            this.cbRangeEnd = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrimes
            // 
            this.lbPrimes.FormattingEnabled = true;
            this.lbPrimes.Location = new System.Drawing.Point(21, 95);
            this.lbPrimes.Name = "lbPrimes";
            this.lbPrimes.Size = new System.Drawing.Size(291, 225);
            this.lbPrimes.TabIndex = 0;
            // 
            // btnPrimesStart
            // 
            this.btnPrimesStart.Location = new System.Drawing.Point(39, 335);
            this.btnPrimesStart.Name = "btnPrimesStart";
            this.btnPrimesStart.Size = new System.Drawing.Size(125, 40);
            this.btnPrimesStart.TabIndex = 1;
            this.btnPrimesStart.Text = "Start";
            this.btnPrimesStart.UseVisualStyleBackColor = true;
            this.btnPrimesStart.Click += new System.EventHandler(this.btnPrimesStart_Click);
            // 
            // btnPrimesStop
            // 
            this.btnPrimesStop.BackColor = System.Drawing.Color.White;
            this.btnPrimesStop.Location = new System.Drawing.Point(39, 394);
            this.btnPrimesStop.Name = "btnPrimesStop";
            this.btnPrimesStop.Size = new System.Drawing.Size(125, 40);
            this.btnPrimesStop.TabIndex = 2;
            this.btnPrimesStop.Text = "Stop";
            this.btnPrimesStop.UseVisualStyleBackColor = false;
            this.btnPrimesStop.Click += new System.EventHandler(this.btnPrimesStop_Click);
            // 
            // btnPrimesUnfreeze
            // 
            this.btnPrimesUnfreeze.Location = new System.Drawing.Point(170, 394);
            this.btnPrimesUnfreeze.Name = "btnPrimesUnfreeze";
            this.btnPrimesUnfreeze.Size = new System.Drawing.Size(125, 40);
            this.btnPrimesUnfreeze.TabIndex = 4;
            this.btnPrimesUnfreeze.Text = "Unfreeze";
            this.btnPrimesUnfreeze.UseVisualStyleBackColor = true;
            this.btnPrimesUnfreeze.Click += new System.EventHandler(this.btnPrimesUnfreeze_Click);
            // 
            // btnPrimesFreeze
            // 
            this.btnPrimesFreeze.Location = new System.Drawing.Point(170, 335);
            this.btnPrimesFreeze.Name = "btnPrimesFreeze";
            this.btnPrimesFreeze.Size = new System.Drawing.Size(125, 40);
            this.btnPrimesFreeze.TabIndex = 3;
            this.btnPrimesFreeze.Text = "Freeze";
            this.btnPrimesFreeze.UseVisualStyleBackColor = true;
            this.btnPrimesFreeze.Click += new System.EventHandler(this.btnPrimesFreeze_Click);
            // 
            // edRangeStart
            // 
            this.edRangeStart.Location = new System.Drawing.Point(79, 10);
            this.edRangeStart.Name = "edRangeStart";
            this.edRangeStart.Size = new System.Drawing.Size(233, 20);
            this.edRangeStart.TabIndex = 5;
            // 
            // edRangeEnd
            // 
            this.edRangeEnd.Location = new System.Drawing.Point(79, 45);
            this.edRangeEnd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edRangeEnd.Name = "edRangeEnd";
            this.edRangeEnd.Size = new System.Drawing.Size(233, 20);
            this.edRangeEnd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Range start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Range end";
            // 
            // btnFibonacciUnfreeze
            // 
            this.btnFibonacciUnfreeze.Location = new System.Drawing.Point(574, 394);
            this.btnFibonacciUnfreeze.Name = "btnFibonacciUnfreeze";
            this.btnFibonacciUnfreeze.Size = new System.Drawing.Size(125, 40);
            this.btnFibonacciUnfreeze.TabIndex = 13;
            this.btnFibonacciUnfreeze.Text = "Unfreeze";
            this.btnFibonacciUnfreeze.UseVisualStyleBackColor = true;
            this.btnFibonacciUnfreeze.Click += new System.EventHandler(this.btnFibonacciUnfreeze_Click);
            // 
            // btnFibonacciFreeze
            // 
            this.btnFibonacciFreeze.Location = new System.Drawing.Point(574, 335);
            this.btnFibonacciFreeze.Name = "btnFibonacciFreeze";
            this.btnFibonacciFreeze.Size = new System.Drawing.Size(125, 40);
            this.btnFibonacciFreeze.TabIndex = 12;
            this.btnFibonacciFreeze.Text = "Freeze";
            this.btnFibonacciFreeze.UseVisualStyleBackColor = true;
            this.btnFibonacciFreeze.Click += new System.EventHandler(this.btnFibonacciFreeze_Click);
            // 
            // btnFibonacciStop
            // 
            this.btnFibonacciStop.BackColor = System.Drawing.Color.White;
            this.btnFibonacciStop.Location = new System.Drawing.Point(443, 394);
            this.btnFibonacciStop.Name = "btnFibonacciStop";
            this.btnFibonacciStop.Size = new System.Drawing.Size(125, 40);
            this.btnFibonacciStop.TabIndex = 11;
            this.btnFibonacciStop.Text = "Stop";
            this.btnFibonacciStop.UseVisualStyleBackColor = false;
            this.btnFibonacciStop.Click += new System.EventHandler(this.btnFibonacciStop_Click);
            // 
            // btnFibonacciStart
            // 
            this.btnFibonacciStart.Location = new System.Drawing.Point(443, 335);
            this.btnFibonacciStart.Name = "btnFibonacciStart";
            this.btnFibonacciStart.Size = new System.Drawing.Size(125, 40);
            this.btnFibonacciStart.TabIndex = 10;
            this.btnFibonacciStart.Text = "Start";
            this.btnFibonacciStart.UseVisualStyleBackColor = true;
            this.btnFibonacciStart.Click += new System.EventHandler(this.btnFibonacciStart_Click);
            // 
            // lbFibonacci
            // 
            this.lbFibonacci.FormattingEnabled = true;
            this.lbFibonacci.Location = new System.Drawing.Point(425, 95);
            this.lbFibonacci.Name = "lbFibonacci";
            this.lbFibonacci.Size = new System.Drawing.Size(291, 225);
            this.lbFibonacci.TabIndex = 9;
            // 
            // btnPrimesReset
            // 
            this.btnPrimesReset.Location = new System.Drawing.Point(452, 13);
            this.btnPrimesReset.Name = "btnPrimesReset";
            this.btnPrimesReset.Size = new System.Drawing.Size(125, 40);
            this.btnPrimesReset.TabIndex = 14;
            this.btnPrimesReset.Text = "Reset prime numbers";
            this.btnPrimesReset.UseVisualStyleBackColor = true;
            this.btnPrimesReset.Click += new System.EventHandler(this.btnPrimesReset_Click);
            // 
            // btnFibonacciReset
            // 
            this.btnFibonacciReset.Location = new System.Drawing.Point(591, 13);
            this.btnFibonacciReset.Name = "btnFibonacciReset";
            this.btnFibonacciReset.Size = new System.Drawing.Size(125, 40);
            this.btnFibonacciReset.TabIndex = 15;
            this.btnFibonacciReset.Text = "Reset Fibonacci numbers";
            this.btnFibonacciReset.UseVisualStyleBackColor = true;
            this.btnFibonacciReset.Click += new System.EventHandler(this.btnFibonacciReset_Click);
            // 
            // cbRangeStart
            // 
            this.cbRangeStart.AutoSize = true;
            this.cbRangeStart.Checked = true;
            this.cbRangeStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRangeStart.Location = new System.Drawing.Point(319, 12);
            this.cbRangeStart.Name = "cbRangeStart";
            this.cbRangeStart.Size = new System.Drawing.Size(51, 17);
            this.cbRangeStart.TabIndex = 16;
            this.cbRangeStart.Text = "Use?";
            this.cbRangeStart.UseVisualStyleBackColor = true;
            // 
            // cbRangeEnd
            // 
            this.cbRangeEnd.AutoSize = true;
            this.cbRangeEnd.Location = new System.Drawing.Point(319, 48);
            this.cbRangeEnd.Name = "cbRangeEnd";
            this.cbRangeEnd.Size = new System.Drawing.Size(51, 17);
            this.cbRangeEnd.TabIndex = 17;
            this.cbRangeEnd.Text = "Use?";
            this.cbRangeEnd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prime numbers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(502, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fibonacci numbers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRangeEnd);
            this.Controls.Add(this.cbRangeStart);
            this.Controls.Add(this.btnFibonacciReset);
            this.Controls.Add(this.btnPrimesReset);
            this.Controls.Add(this.btnFibonacciUnfreeze);
            this.Controls.Add(this.btnFibonacciFreeze);
            this.Controls.Add(this.btnFibonacciStop);
            this.Controls.Add(this.btnFibonacciStart);
            this.Controls.Add(this.lbFibonacci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edRangeEnd);
            this.Controls.Add(this.edRangeStart);
            this.Controls.Add(this.btnPrimesUnfreeze);
            this.Controls.Add(this.btnPrimesFreeze);
            this.Controls.Add(this.btnPrimesStop);
            this.Controls.Add(this.btnPrimesStart);
            this.Controls.Add(this.lbPrimes);
            this.Name = "MainForm";
            this.Text = "HomeWork3_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.edRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRangeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPrimes;
        private System.Windows.Forms.Button btnPrimesStart;
        private System.Windows.Forms.Button btnPrimesStop;
        private System.Windows.Forms.Button btnPrimesUnfreeze;
        private System.Windows.Forms.Button btnPrimesFreeze;
        private System.Windows.Forms.NumericUpDown edRangeStart;
        private System.Windows.Forms.NumericUpDown edRangeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFibonacciUnfreeze;
        private System.Windows.Forms.Button btnFibonacciFreeze;
        private System.Windows.Forms.Button btnFibonacciStop;
        private System.Windows.Forms.Button btnFibonacciStart;
        private System.Windows.Forms.ListBox lbFibonacci;
        private System.Windows.Forms.Button btnPrimesReset;
        private System.Windows.Forms.Button btnFibonacciReset;
        private System.Windows.Forms.CheckBox cbRangeStart;
        private System.Windows.Forms.CheckBox cbRangeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

