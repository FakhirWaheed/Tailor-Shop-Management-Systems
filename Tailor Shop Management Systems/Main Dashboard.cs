using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tailor_Shop_Management_Systems.UI;

namespace Tailor_Shop_Management_Systems
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void main_border_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Add_Customers ad = new Add_Customers();
            ad.Show();
        }

        private void main_viewcustumer_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.Show();
        }

        private void pic_suitdetail_Click(object sender, EventArgs e)
        {

        }

        private void pic_makereceipts_Click(object sender, EventArgs e)
        {

        }

        private void main_makereceipts_Click(object sender, EventArgs e)
        {
            MakeReceipt ms = new MakeReceipt();
            ms.Show();

        }

        private void main_suitdetail_Click(object sender, EventArgs e)
        {
            suitdetails sd = new suitdetails();
            sd.Show();
        }
    }
}
