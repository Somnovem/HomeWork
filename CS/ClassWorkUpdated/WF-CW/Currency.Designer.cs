namespace WF_CW
{
    partial class Currency
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView2 = new System.Windows.Forms.ListView();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 345);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(293, 93);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(459, 345);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            this.listView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView2_DragDrop);
            this.listView2.DragOver += new System.Windows.Forms.DragEventHandler(this.listView2_DragOver);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(572, 26);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(179, 52);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Result.Location = new System.Drawing.Point(311, 26);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(43, 29);
            this.Label_Result.TabIndex = 3;
            this.Label_Result.Text = "0p";
            this.Label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Currency";
            this.Text = "Currency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.ImageList imageList1;
    }
}