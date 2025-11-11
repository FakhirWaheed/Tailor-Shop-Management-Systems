namespace Tailor_Shop_Management_Systems.UI
{
    partial class suitdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suitdetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_pending = new System.Windows.Forms.DataGridView();
            this.dgv_ready = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pending_counter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ready_counter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ready_button = new System.Windows.Forms.Button();
            this.pending_button = new System.Windows.Forms.Button();
            this.textBox_ready = new System.Windows.Forms.TextBox();
            this.textBox_pending = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ready)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-26, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgv_pending
            // 
            this.dgv_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pending.Location = new System.Drawing.Point(54, 145);
            this.dgv_pending.Name = "dgv_pending";
            this.dgv_pending.RowHeadersWidth = 62;
            this.dgv_pending.RowTemplate.Height = 28;
            this.dgv_pending.Size = new System.Drawing.Size(252, 302);
            this.dgv_pending.TabIndex = 1;
            // 
            // dgv_ready
            // 
            this.dgv_ready.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ready.Location = new System.Drawing.Point(550, 145);
            this.dgv_ready.Name = "dgv_ready";
            this.dgv_ready.RowHeadersWidth = 62;
            this.dgv_ready.RowTemplate.Height = 28;
            this.dgv_ready.Size = new System.Drawing.Size(258, 302);
            this.dgv_ready.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pending_counter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(66, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 88);
            this.panel1.TabIndex = 3;
            // 
            // pending_counter
            // 
            this.pending_counter.AutoSize = true;
            this.pending_counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pending_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending_counter.Location = new System.Drawing.Point(89, 49);
            this.pending_counter.Name = "pending_counter";
            this.pending_counter.Size = new System.Drawing.Size(28, 31);
            this.pending_counter.TabIndex = 1;
            this.pending_counter.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pending Suits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ready_counter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(579, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 88);
            this.panel2.TabIndex = 4;
            // 
            // ready_counter
            // 
            this.ready_counter.AutoSize = true;
            this.ready_counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ready_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready_counter.Location = new System.Drawing.Point(91, 49);
            this.ready_counter.Name = "ready_counter";
            this.ready_counter.Size = new System.Drawing.Size(28, 31);
            this.ready_counter.TabIndex = 2;
            this.ready_counter.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ready Suits";
            // 
            // ready_button
            // 
            this.ready_button.BackColor = System.Drawing.Color.Maroon;
            this.ready_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ready_button.Location = new System.Drawing.Point(188, 470);
            this.ready_button.Name = "ready_button";
            this.ready_button.Size = new System.Drawing.Size(118, 43);
            this.ready_button.TabIndex = 5;
            this.ready_button.Text = "Ready +";
            this.ready_button.UseVisualStyleBackColor = false;
            this.ready_button.Click += new System.EventHandler(this.ready_button_Click);
            // 
            // pending_button
            // 
            this.pending_button.BackColor = System.Drawing.Color.Maroon;
            this.pending_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pending_button.Location = new System.Drawing.Point(687, 470);
            this.pending_button.Name = "pending_button";
            this.pending_button.Size = new System.Drawing.Size(121, 43);
            this.pending_button.TabIndex = 6;
            this.pending_button.Text = "Pending -";
            this.pending_button.UseVisualStyleBackColor = false;
            this.pending_button.Click += new System.EventHandler(this.pending_button_Click);
            // 
            // textBox_ready
            // 
            this.textBox_ready.Location = new System.Drawing.Point(54, 480);
            this.textBox_ready.Name = "textBox_ready";
            this.textBox_ready.Size = new System.Drawing.Size(100, 26);
            this.textBox_ready.TabIndex = 7;
            // 
            // textBox_pending
            // 
            this.textBox_pending.Location = new System.Drawing.Point(550, 480);
            this.textBox_pending.Name = "textBox_pending";
            this.textBox_pending.Size = new System.Drawing.Size(100, 26);
            this.textBox_pending.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 302);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // suitdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 556);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_pending);
            this.Controls.Add(this.textBox_ready);
            this.Controls.Add(this.pending_button);
            this.Controls.Add(this.ready_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_ready);
            this.Controls.Add(this.dgv_pending);
            this.Controls.Add(this.pictureBox1);
            this.Name = "suitdetails";
            this.Text = "Suit Details";
            this.Activated += new System.EventHandler(this.suitdetails_Activated);
            this.Load += new System.EventHandler(this.suitdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ready)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_pending;
        private System.Windows.Forms.DataGridView dgv_ready;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pending_counter;
        private System.Windows.Forms.Label ready_counter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ready_button;
        private System.Windows.Forms.Button pending_button;
        private System.Windows.Forms.TextBox textBox_ready;
        private System.Windows.Forms.TextBox textBox_pending;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}