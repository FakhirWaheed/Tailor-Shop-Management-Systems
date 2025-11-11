namespace Tailor_Shop_Management_Systems.UI
{
    partial class MakeReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeReceipt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_cusdetails = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_makere = new System.Windows.Forms.Label();
            this.dgv_nameid = new System.Windows.Forms.DataGridView();
            this.re_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.re_totalsuit = new System.Windows.Forms.TextBox();
            this.label_retotalsuit = new System.Windows.Forms.Label();
            this.re_totalprice = new System.Windows.Forms.TextBox();
            this.label_reprice = new System.Windows.Forms.Label();
            this.label_rediscount = new System.Windows.Forms.Label();
            this.re_discount = new System.Windows.Forms.TextBox();
            this.label_return = new System.Windows.Forms.Label();
            this.re_date = new System.Windows.Forms.DateTimePicker();
            this.re_subtotal = new System.Windows.Forms.TextBox();
            this.button_subtotal = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nameid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-31, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 440);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label_cusdetails
            // 
            this.label_cusdetails.AutoSize = true;
            this.label_cusdetails.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_cusdetails.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cusdetails.Location = new System.Drawing.Point(71, 41);
            this.label_cusdetails.Name = "label_cusdetails";
            this.label_cusdetails.Size = new System.Drawing.Size(219, 38);
            this.label_cusdetails.TabIndex = 2;
            this.label_cusdetails.Text = "Customer Details";
            this.label_cusdetails.Click += new System.EventHandler(this.label_cusdetails_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(613, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(310, 440);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label_makere
            // 
            this.label_makere.AutoSize = true;
            this.label_makere.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_makere.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_makere.Location = new System.Drawing.Point(666, 41);
            this.label_makere.Name = "label_makere";
            this.label_makere.Size = new System.Drawing.Size(179, 38);
            this.label_makere.TabIndex = 4;
            this.label_makere.Text = "Make Receipt";
            // 
            // dgv_nameid
            // 
            this.dgv_nameid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nameid.Location = new System.Drawing.Point(53, 111);
            this.dgv_nameid.Name = "dgv_nameid";
            this.dgv_nameid.RowHeadersWidth = 62;
            this.dgv_nameid.RowTemplate.Height = 28;
            this.dgv_nameid.Size = new System.Drawing.Size(282, 391);
            this.dgv_nameid.TabIndex = 5;
            // 
            // re_name
            // 
            this.re_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_name.Location = new System.Drawing.Point(772, 148);
            this.re_name.Name = "re_name";
            this.re_name.Size = new System.Drawing.Size(100, 30);
            this.re_name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // re_totalsuit
            // 
            this.re_totalsuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_totalsuit.Location = new System.Drawing.Point(772, 190);
            this.re_totalsuit.Name = "re_totalsuit";
            this.re_totalsuit.Size = new System.Drawing.Size(100, 30);
            this.re_totalsuit.TabIndex = 8;
            // 
            // label_retotalsuit
            // 
            this.label_retotalsuit.AutoSize = true;
            this.label_retotalsuit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retotalsuit.Location = new System.Drawing.Point(638, 196);
            this.label_retotalsuit.Name = "label_retotalsuit";
            this.label_retotalsuit.Size = new System.Drawing.Size(94, 24);
            this.label_retotalsuit.TabIndex = 9;
            this.label_retotalsuit.Text = "Total Suit:";
            // 
            // re_totalprice
            // 
            this.re_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_totalprice.Location = new System.Drawing.Point(772, 230);
            this.re_totalprice.Name = "re_totalprice";
            this.re_totalprice.Size = new System.Drawing.Size(100, 30);
            this.re_totalprice.TabIndex = 10;
            // 
            // label_reprice
            // 
            this.label_reprice.AutoSize = true;
            this.label_reprice.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reprice.Location = new System.Drawing.Point(638, 236);
            this.label_reprice.Name = "label_reprice";
            this.label_reprice.Size = new System.Drawing.Size(104, 24);
            this.label_reprice.TabIndex = 11;
            this.label_reprice.Text = "Total Price:";
            this.label_reprice.Click += new System.EventHandler(this.label_reprice_Click);
            // 
            // label_rediscount
            // 
            this.label_rediscount.AutoSize = true;
            this.label_rediscount.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rediscount.Location = new System.Drawing.Point(638, 280);
            this.label_rediscount.Name = "label_rediscount";
            this.label_rediscount.Size = new System.Drawing.Size(85, 24);
            this.label_rediscount.TabIndex = 12;
            this.label_rediscount.Text = "Discount:";
            this.label_rediscount.Click += new System.EventHandler(this.label_rediscount_Click);
            // 
            // re_discount
            // 
            this.re_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_discount.Location = new System.Drawing.Point(772, 274);
            this.re_discount.Name = "re_discount";
            this.re_discount.Size = new System.Drawing.Size(100, 30);
            this.re_discount.TabIndex = 13;
            this.re_discount.TextChanged += new System.EventHandler(this.re_dicount_TextChanged);
            // 
            // label_return
            // 
            this.label_return.AutoSize = true;
            this.label_return.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return.Location = new System.Drawing.Point(646, 325);
            this.label_return.Name = "label_return";
            this.label_return.Size = new System.Drawing.Size(69, 24);
            this.label_return.TabIndex = 14;
            this.label_return.Text = "Return:";
            this.label_return.Click += new System.EventHandler(this.label_return_Click);
            // 
            // re_date
            // 
            this.re_date.Location = new System.Drawing.Point(772, 325);
            this.re_date.Name = "re_date";
            this.re_date.Size = new System.Drawing.Size(100, 26);
            this.re_date.TabIndex = 15;
            // 
            // re_subtotal
            // 
            this.re_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_subtotal.Location = new System.Drawing.Point(772, 374);
            this.re_subtotal.Name = "re_subtotal";
            this.re_subtotal.Size = new System.Drawing.Size(100, 30);
            this.re_subtotal.TabIndex = 16;
            // 
            // button_subtotal
            // 
            this.button_subtotal.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_subtotal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_subtotal.Location = new System.Drawing.Point(650, 374);
            this.button_subtotal.Name = "button_subtotal";
            this.button_subtotal.Size = new System.Drawing.Size(80, 39);
            this.button_subtotal.TabIndex = 17;
            this.button_subtotal.Text = "Total";
            this.button_subtotal.UseVisualStyleBackColor = false;
            this.button_subtotal.Click += new System.EventHandler(this.button_subtotal_Click);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.Yellow;
            this.button_print.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_print.Location = new System.Drawing.Point(650, 447);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(80, 39);
            this.button_print.TabIndex = 18;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Yellow;
            this.button_clear.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_clear.Location = new System.Drawing.Point(804, 447);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(80, 39);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(347, 82);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(270, 440);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MakeReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(940, 576);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_subtotal);
            this.Controls.Add(this.re_subtotal);
            this.Controls.Add(this.re_date);
            this.Controls.Add(this.label_return);
            this.Controls.Add(this.re_discount);
            this.Controls.Add(this.label_rediscount);
            this.Controls.Add(this.label_reprice);
            this.Controls.Add(this.re_totalprice);
            this.Controls.Add(this.label_retotalsuit);
            this.Controls.Add(this.re_totalsuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.re_name);
            this.Controls.Add(this.dgv_nameid);
            this.Controls.Add(this.label_makere);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_cusdetails);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MakeReceipt";
            this.Text = "Make Receipt";
            this.Load += new System.EventHandler(this.MakeReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nameid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_cusdetails;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_makere;
        private System.Windows.Forms.DataGridView dgv_nameid;
        private System.Windows.Forms.TextBox re_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox re_totalsuit;
        private System.Windows.Forms.Label label_retotalsuit;
        private System.Windows.Forms.TextBox re_totalprice;
        private System.Windows.Forms.Label label_reprice;
        private System.Windows.Forms.Label label_rediscount;
        private System.Windows.Forms.TextBox re_discount;
        private System.Windows.Forms.Label label_return;
        private System.Windows.Forms.DateTimePicker re_date;
        private System.Windows.Forms.TextBox re_subtotal;
        private System.Windows.Forms.Button button_subtotal;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}