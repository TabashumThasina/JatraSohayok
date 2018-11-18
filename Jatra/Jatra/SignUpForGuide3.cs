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
    public partial class SignUpForGuide3 : Form
    {
        string id;
        SignUpG sg = new SignUpG();
        Database db = new Database();
        public SignUpForGuide3()
        {
            InitializeComponent();
        }
        public SignUpForGuide3(string i,ref SignUpG sg1)
        {
            this.id = i;
            this.sg = sg1;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.TrimEnd()!=""||comboBox1.Text!=""||comboBox2.Text!="")
            {
                sg.Area = comboBox1.Text.TrimEnd();
                sg.Food = comboBox2.Text.TrimEnd();
                sg.Charge = textBox1.Text.TrimEnd();
                string s1= "select * from Guide where Email ='" + this.id + "'";
                if (db.loginsearch(s1) == false)
                {
                    string s = "insert into Guide (Gender, Age, Country, devision, Address, RefName, RefContact, RefRelation, Area, Food, Charge, email,Language1,Language2) values ('" + sg.Gender + "','" + sg.Age + "','" + sg.Country + "','" + sg.State + "','" + sg.Address + "','" + sg.RefPersonName + "','" + sg.RefPersonContact + "','" + sg.RefPersonRelation + "','" + sg.Area + "','" + sg.Charge + "','" + sg.Area + "','" + this.id + "','"+comboBox4.Text+"','"+comboBox3.Text+"')";
                    db.insertMember(s);
                    string s2 = "update NormalU set Type = '1' where Email = '" + id + "'";
                    db.update(s2);
                    MessageBox.Show("Done");
                    new Login().Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Already exist email address; ");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForGuide3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
