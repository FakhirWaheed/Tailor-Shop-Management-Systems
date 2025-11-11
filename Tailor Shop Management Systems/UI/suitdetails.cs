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
using Tailor_Shop_Management_Systems.SetterandGetters;

namespace Tailor_Shop_Management_Systems.UI
{
    public partial class suitdetails : Form
    {
        public suitdetails()
        {
            InitializeComponent();
        }
        Db_Layer d = new Db_Layer();
        Setterandgetter bll = new Setterandgetter();    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void countPensuit()
        {
            pending_counter.Text = d.countPenSuit();
        }

        public void countReasuit()
        {
            ready_counter.Text = d.countredSuit();
        }
        private void pending_button_Click(object sender, EventArgs e)
         {
            if (textBox_pending.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Enter an ID");
            }
            else
            {
                bll.pending_id = int.Parse(textBox_pending.Text);

              
                if (!d.IdExistsInReady(bll.pending_id))
                {
                    MessageBox.Show("No record found with this ID in Ready list!");
                    return; 
                }

                
                bool success = d.Ready_Delete(bll);
                if (success)
                {
                    MessageBox.Show("Customer moved to pending successfully!");

                    DataTable dt2 = d.ready();
                    dgv_ready.DataSource = dt2;

                    DataTable dt = d.Pending();
                    dgv_pending.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Customer could not be moved to pending!");
                }
            }
            //if (textBox_pending.Text.Trim() == String.Empty)
            //{
            //    MessageBox.Show("Enter an id ");
            //  }
            // else
            // {
            // bll.pending_id = int.Parse(textBox_pending.Text);
            // bool success = d.Ready_Delete(bll);
            //        if (success = true)
            // {
            // MessageBox.Show(" ...Customer moved to pending Successfully...");

            // DataTable dt2 = d.ready();
            // dgv_ready.DataSource = dt2;

            // DataTable dt = d.Pending();
            // dgv_pending.DataSource = dt;



            // }
            //else
            //  {
            //MessageBox.Show("..Not moved to ready ..");
            //}
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void suitdetails_Load(object sender, EventArgs e)
        {
            DataTable dt = d.Pending();
            dgv_pending.DataSource = dt;

            DataTable dt2 = d.ready();
            dgv_ready.DataSource = dt2;
        }

        private void ready_button_Click(object sender, EventArgs e)
        {
            if (textBox_ready.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Enter an ID");
            }
            else
            {
                bll.pending_id = int.Parse(textBox_ready.Text);

                
                if (!d.IdExistsInPending(bll.pending_id))
                {
                    MessageBox.Show("No record found with this ID in Pending list!");
                    return; 
                }

                
                bool success = d.Pending_Delete(bll);

                if (success)
                {
                    MessageBox.Show("Customer moved to ready successfully!");

                    
                    DataTable dt = d.Pending();
                    dgv_pending.DataSource = dt;

                    DataTable dt2 = d.ready();
                    dgv_ready.DataSource = dt2;
                }
                else
                {
                    MessageBox.Show("Customer could not be moved to ready!");
                }
            }

            //   if(textBox_ready.Text.Trim() == String.Empty)
            //   {
            //       MessageBox.Show("Enter an id ");
            // }

            //  else
            // {
            //  bll.pending_id = int.Parse(textBox_ready.Text);
            //  bool success = d.Pending_Delete(bll);
            //  if (success = true)
            //  {
            //  MessageBox.Show(" ...Customer moved to ready Successfully...");
            //  DataTable dt = d.Pending();
            //    dgv_pending.DataSource = dt;

            //    DataTable dt2 = d.ready();
            //////        dgv_ready.DataSource = dt2;

            //    }
            //    else
            //   {
            //MessageBox.Show("..Not moved to ready ..");
            //    }
            //}

        }

        private void suitdetails_Activated(object sender, EventArgs e)
        {
            countPensuit();
            countReasuit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
