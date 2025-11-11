namespace Tailor_Shop_Management_Systems.UI
{
    partial class ViewCustomer
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
            this.dgv_view = new System.Windows.Forms.DataGridView();
            this.label_cusdetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_view
            // 
            this.dgv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view.Location = new System.Drawing.Point(88, 102);
            this.dgv_view.Name = "dgv_view";
            this.dgv_view.RowHeadersWidth = 62;
            this.dgv_view.RowTemplate.Height = 28;
            this.dgv_view.Size = new System.Drawing.Size(596, 336);
            this.dgv_view.TabIndex = 0;
            this.dgv_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_cusdetails
            // 
            this.label_cusdetails.AutoSize = true;
            this.label_cusdetails.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cusdetails.Location = new System.Drawing.Point(258, 46);
            this.label_cusdetails.Name = "label_cusdetails";
            this.label_cusdetails.Size = new System.Drawing.Size(226, 31);
            this.label_cusdetails.TabIndex = 1;
            this.label_cusdetails.Text = "Customer Details";
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_cusdetails);
            this.Controls.Add(this.dgv_view);
            this.Name = "ViewCustomer";
            this.Text = "View_Customer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_view;
        private System.Windows.Forms.Label label_cusdetails;
    }
}