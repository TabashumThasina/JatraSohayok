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
    public partial class Login : Form
    {
        Database db = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Login_Closing(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s="select * from NormalU where Email = '"+textBox1.Text.TrimEnd()+"'and Password ='"+textBox2.Text.TrimEnd()+"'";
            if(db.loginsearch(s))
            {
                if(db.DetectType(textBox1.Text.TrimEnd())==0)
                {
                    new search(textBox1.Text.TrimEnd()).Show();
                    this.Hide();
                }
                else if (db.DetectType(textBox1.Text.TrimEnd())==1)
                {
                    new Guide(textBox1.Text.TrimEnd()).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incoorect user or password");
                }


            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
