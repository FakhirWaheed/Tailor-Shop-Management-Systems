using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tailor_Shop_Management_Systems.SetterandGetters;

namespace Tailor_Shop_Management_Systems.Database_layer
{
    internal class Db_Layer
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["OurConnstring"].ConnectionString;


        public DataTable NameAndId()
        {
            DataTable dt=new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Select id,Fullname from AddCustomers";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        public String countPenSuit()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            String count = "0";
            try
            {
                String sql = "Select count(*) from Pendingsuit";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                count = Convert.ToString(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return count;
        }
        public String countredSuit()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            String count = "0";
            try
            {
                String sql = "Select count(*) from Readysuit";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                count = Convert.ToString(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        public DataTable Pending()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Select ID,Fullname from Pendingsuit";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable ready()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Select ID,Fullname from  Readysuit";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Select * from AddCustomers";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Pending_Delete(Setterandgetter bll)
        {
            bool issuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Delete  from Pendingsuit where ID = @Pending_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pending_id", bll.pending_id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    issuccess = true;
                }
                else { 
                issuccess=false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return issuccess;
        }


        public bool Ready_Delete(Setterandgetter bll)
        {
            bool issuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Delete from Readysuit where ID = @Pending_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pending_id", bll.pending_id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return issuccess;
        }

        public bool IdExistsInPending(int id)
        {
            bool exists = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT COUNT(*) FROM Pendingsuit WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                exists = (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return exists;
        }

        public bool IdExistsInReady(int id)
        {
            bool exists = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT COUNT(*) FROM Readysuit WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                exists = (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return exists;
        }

        public bool Insert(Setterandgetter bll)
        {
            bool isSuccess = false;

            using (SqlConnection conn = new SqlConnection(myconnstring))
            {
                try
                {
                    
                    string sql = @"INSERT INTO AddCustomers
                                   (id, Fullname, Contact, C_Length, Bazo, Tera, Ban, Upper_waist, Waist, Shalwar, Pancha, Noofsuit)
                                   VALUES
                                   (@id, @Fullname, @Contact, @C_Length, @Bazo, @Tera, @Ban, @Upper_waist, @Waist, @Shalwar, @Pancha, @Noofsuit)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                   
                    cmd.Parameters.AddWithValue("@id", bll.id);
                    cmd.Parameters.AddWithValue("@Fullname", bll.Fullname);
                    cmd.Parameters.AddWithValue("@Contact", bll.Contact);
                    cmd.Parameters.AddWithValue("@C_Length", bll.C_Length); 
                    cmd.Parameters.AddWithValue("@Bazo", bll.Bazo);
                    cmd.Parameters.AddWithValue("@Tera", bll.Tera);
                    cmd.Parameters.AddWithValue("@Ban", bll.Ban);
                    cmd.Parameters.AddWithValue("@Upper_waist", bll.Upper_waist);
                    cmd.Parameters.AddWithValue("@Waist", bll.Waist);
                    cmd.Parameters.AddWithValue("@Shalwar", bll.Shalwar);
                    cmd.Parameters.AddWithValue("@Pancha", bll.Pancha);
                    cmd.Parameters.AddWithValue("@Noofsuit", bll.Noofsuit);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    isSuccess = rows > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }

            return isSuccess;
        }
    }
}
