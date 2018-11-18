using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Jatra
{
    class Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Jatra.mdf;Integrated Security=True;Connect Timeout=30");
        public bool loginsearch(string s) // login search for user
        {

            SqlDataAdapter sdf = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            sdf.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;


        }
        public void insertMember(string query)//inserting 
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public int DetectType(string id) // detecting admin
        {
            con.Open();
            string s = " select Type from NormalU where email ='" + id + "';";
            SqlCommand com = new SqlCommand(s, con);

            try
            {
                string s1 = com.ExecuteScalar().ToString();
                //MessageBox.Show(s1);

                if (s1.TrimEnd().Equals("1"))
                {
                    con.Close();
                    return 1;
                }
                else
                {
                    con.Close();
                    return 0;
                }


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return 0;
        }
        public void update(string query) //updating
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public SignUpG User_View(string ID, SignUpG u)// userprofile collecting information from database
        {
            try
            {
                // string s = "select FistName ,LastName , IEEE_ID , Dept , Gender , DOB,Password, Contact , MembershipType,Email from Member where AIUB_ID ='" +AIUB_ID + "';";
                string s1 = "select * from Guide where email='" + ID + "';";
                SqlCommand newCmd = new SqlCommand(s1, con);
                newCmd.Parameters.Add("@email", SqlDbType.Char).Value = ID;
                con.Open();
                SqlDataReader rdr = newCmd.ExecuteReader();
                rdr.Read();
                u.Gender = rdr.GetString(1);
                u.Age = rdr.GetString(2);
                u.Country = rdr.GetString(3);
                u.State = rdr.GetString(4);
                u.Address = rdr.GetString(5);
                u.RefPersonName = rdr.GetString(6);
                u.RefPersonContact = rdr.GetString(7);
                u.RefPersonContact = rdr.GetString(8);
                u.Area = rdr.GetString(9);
                u.Food = rdr.GetString(10);
                u.Charge = rdr.GetString(11);
                u.Lan1 = rdr.GetString(13);
                u.Lan2 = rdr.GetString(14);
                u.aval = rdr.GetString(15);
                con.Close();
                string s2 = "select * from NormalU where email='" + ID + "';";
                SqlCommand newCmd1 = new SqlCommand(s2, con);
                newCmd1.Parameters.Add("@email", SqlDbType.Char).Value = ID;
                con.Open();
                SqlDataReader rdr1 = newCmd1.ExecuteReader();
                rdr1.Read();
                u.FName = rdr1.GetString(1);
                u.LName = rdr1.GetString(2);
                u.Type = rdr1.GetString(6);
                u.Contact = rdr1.GetString(5);
                con.Close();
                return u;
              
                // return rdr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return u;
            }
        }
        public SignUpG Guide_View(string ID, SignUpG u)// userprofile collecting information from database
        {
            try
            {
                // string s = "select FistName ,LastName , IEEE_ID , Dept , Gender , DOB,Password, Contact , MembershipType,Email from Member where AIUB_ID ='" +AIUB_ID + "';";
                string s1 = "select * from Guide where id='" + ID + "';";
                SqlCommand newCmd = new SqlCommand(s1, con);
                newCmd.Parameters.Add("@id", SqlDbType.Char).Value = ID;
                con.Open();
                SqlDataReader rdr = newCmd.ExecuteReader();
                rdr.Read();
                u.Gender = rdr.GetString(1);
                u.Age = rdr.GetString(2);
                u.Country = rdr.GetString(3);
                u.State = rdr.GetString(4);
                u.Address = rdr.GetString(5);
                u.RefPersonName = rdr.GetString(6);
                u.RefPersonContact = rdr.GetString(7);
                u.RefPersonContact = rdr.GetString(8);
                u.Area = rdr.GetString(9);
                u.Food = rdr.GetString(10);
                u.Charge = rdr.GetString(11);
                u.Lan1 = rdr.GetString(13);
                u.Lan2 = rdr.GetString(14);
                u.aval = rdr.GetString(15);
                con.Close();
                string s2 = "select * from NormalU where email='" + ID + "';";
                SqlCommand newCmd1 = new SqlCommand(s2, con);
                newCmd1.Parameters.Add("@email", SqlDbType.Char).Value = ID;
                con.Open();
                SqlDataReader rdr1 = newCmd1.ExecuteReader();
                rdr1.Read();
                u.FName = rdr1.GetString(1);
                u.LName = rdr1.GetString(2);
                u.Type = rdr1.GetString(6);
                u.Contact = rdr1.GetString(5);
                con.Close();
                return u;

                // return rdr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return u;
            }
        }
        public DataGridView Eventview(DataGridView dataGridView1, string q) // gridview 
        {
            SqlCommand com = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = com;
            DataTable db = new DataTable();
            sda.Fill(db);
            BindingSource b = new BindingSource();
            b.DataSource = db;
            dataGridView1.DataSource = b;
            sda.Update(db);
            return dataGridView1;

        }
    }
    }
