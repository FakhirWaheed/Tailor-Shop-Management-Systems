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
    public partial class Add_Customers : Form
    {
        Setterandgetter bll = new Setterandgetter();
        Db_Layer db = new Db_Layer();
        public Add_Customers()
        {
            InitializeComponent();
            Setterandgetter bll = new Setterandgetter();
            Db_Layer db = new Db_Layer();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pic_border_Click(object sender, EventArgs e)
        {

        }

        private void pic_addcus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int temp = 0;


            bll.id = int.Parse(txt_add_id.Text);
            bll.Fullname = (txt_add_fullname.Text);
            bll.Contact = (txt_add_contact.Text);
            bll.C_Length = (txt_add_length.Text);
            bll.Bazo = (txt_add_bazu.Text);
            bll.Tera = (txt_add_tera.Text);
            bll.Ban = (txt_add_ban.Text);
            bll.Upper_waist=(txt_add_upper.Text);
            bll.Waist = (txt_add_waist.Text);
            bll.Shalwar = (txt_add_shalwar.Text);
            bll.Pancha = (txt_add_pancha.Text);
            if (txt_add_nosuits.Text.Trim() == String.Empty)
            {
                bll.Noofsuit = temp;
            }
            else
            {
                {
                    bll.Noofsuit = int.Parse(txt_add_nosuits.Text);
                }
            }

                bool success = db.Insert(bll);
            if (success == true) {
                MessageBox.Show("Customer Added");

            }
            else
            {
                MessageBox.Show("Not added");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_add_id.Text = "";
            txt_add_fullname.Text = "";
            txt_add_contact.Text = "";
            txt_add_length.Text = "";
            txt_add_bazu.Text = "";
            txt_add_ban.Text = "";
            txt_add_tera.Text = "";
            txt_add_upper.Text = "";
            txt_add_waist.Text = "";
            txt_add_shalwar.Text = "";
            txt_add_nosuits.Text = "";
            txt_add_pancha.Text = "";

        }

        private void txt_add_contact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
