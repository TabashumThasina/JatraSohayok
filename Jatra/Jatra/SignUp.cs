using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jatra
{
    public partial class SignUp : Form
        
    {
        Database db=new Database();
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text.TrimEnd().Equals(textBox6.Text.TrimEnd()))
            {
                if(textBox1.Text.TrimEnd()!=""&&textBox2.Text.TrimEnd()!=""&&textBox3.Text.TrimEnd()!=""&&textBox4.Text.TrimEnd()!="")
                {
                    string s = "select * from NormalU where Email ='" + textBox3.Text.TrimEnd() + "'";
                    string s1 = "select * from  NormalU where Contact='" + textBox4.Text.TrimEnd() + "'";
                    if (db.loginsearch(s)==true || db.loginsearch(s1)==true)
                    {
                        MessageBox.Show("Email or Contact Number already exist ");
                    }
                    else
                    {
                        string s2 = "insert into NormalU (FirstName,Lastname,Email,Contact,Password) values ('" + textBox1.Text.TrimEnd() + "','" + textBox2.Text.TrimEnd() + "','" + textBox3.Text.TrimEnd() + "','" + textBox4.Text.TrimEnd() + "','" + textBox5.Text.TrimEnd() + "');";
                        db.insertMember(s2);
                        MessageBox.Show("You will soon recieve a code enter the code then login");
                        new Form1().Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("properly fill the form");
                }
            }
            else
            {
                MessageBox.Show("Please in correct password");
                textBox5.Text = "";
                textBox6.Text = "";
            }
           
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
