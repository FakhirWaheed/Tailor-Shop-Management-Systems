using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tailor_Shop_Management_Systems.Database_layer;

namespace Tailor_Shop_Management_Systems.UI
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        Db_Layer dal = new Db_Layer();
        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgv_view.DataSource = dt;
        }
    }
}
