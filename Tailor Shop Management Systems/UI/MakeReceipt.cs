using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tailor_Shop_Management_Systems.Database_layer;

namespace Tailor_Shop_Management_Systems.UI
{
    public partial class MakeReceipt : Form
    {
        public MakeReceipt()
        {
            InitializeComponent();
        }
        Db_Layer db=new Db_Layer();
        private void MakeReceipt_Load(object sender, EventArgs e)
        {
            DataTable dt = db.NameAndId();
            dgv_nameid.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            re_name.Text = "";
            re_totalprice.Text = "";
            re_totalsuit.Text = "";
            re_discount.Text = "";
            re_subtotal.Text = "";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_reprice_Click(object sender, EventArgs e)
        {

        }

        private void label_rediscount_Click(object sender, EventArgs e)
        {

        }

        private void label_return_Click(object sender, EventArgs e)
        {

        }

        private void re_dicount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_cusdetails_Click(object sender, EventArgs e)
        {

        }

        private void button_subtotal_Click(object sender, EventArgs e)
        {
            if ((re_totalprice.Text.Trim() == String.Empty) && (re_discount.Text.Trim() == String.Empty))
            {
                re_subtotal.Text = String.Empty;
            }
            else if((re_totalprice.Text.Trim() != String.Empty) && (re_discount.Text.Trim() == String.Empty)){
                re_subtotal.Text = re_totalprice.Text;


            }
            else if ((re_totalprice.Text.Trim() == String.Empty) && (re_discount.Text.Trim() != String.Empty))
            {
                re_subtotal.Text = String.Empty;


            }
            else
            {
                int totalprice = Convert.ToInt32(re_totalprice.Text);
                int discount = Convert.ToInt32(re_discount.Text);
                int subtotal = totalprice - discount;
                re_subtotal.Text = Convert.ToString(subtotal);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("...WAQAR TAILORS...", new Font("Stencil", 12), Brushes.Red, new Point(10, 10));
            e.Graphics.DrawString("0311 9790110", new Font("Centuary", 10), Brushes.Black, new Point(10, 30));
            e.Graphics.DrawString("                                 Date:" +DateTime.Now.ToShortDateString(), new Font("Centuary", 10), Brushes.Red, new Point(10, 40));
            e.Graphics.DrawString("Name:"+re_name.Text, new Font("Centuary", 10), Brushes.Red, new Point(10, 60));
            e.Graphics.DrawString("Total suit:" + re_totalsuit.Text, new Font("Centuary", 10), Brushes.Red, new Point(10, 80));
            e.Graphics.DrawString("Total price:" + re_totalprice.Text, new Font("Centuary", 10), Brushes.Red, new Point(10, 100));
            e.Graphics.DrawString("Discount:" + re_discount.Text, new Font("Centuary", 10), Brushes.Red, new Point(10, 120));
            e.Graphics.DrawString("Return Date:" + re_date.Text, new Font("Centuary", 10), Brushes.Red, new Point(10, 140));
            e.Graphics.DrawString("Sub Total:" + re_subtotal .Text, new Font("Centuary", 10), Brushes.Red, new Point(10, 160));

        }
        private void button_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 285, 200);
            printPreviewDialog1.ShowDialog();
        }

       
    }
}
