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
    public partial class changepass : Form
    {
        Database db = new Database();
        string id;
        public changepass()
        {
            InitializeComponent();
        }
        public changepass(string i)
        {
            this.id = i;
            InitializeComponent();
        }

        private void changepass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.TrimEnd().Equals(textBox2.Text.TrimEnd()))        // matching confirm and new pass
            {
                string s = "update NormalU set Password = '"+textBox1.Text+"' where Email = '"+id+"'"; // changing in database
                db.update(s);
                MessageBox.Show("Your new password has been saved");
                textBox1.Text = "";   // after changing pass form textbox is becoimg nill
                textBox2.Text = "";


            }
            else
            {
                MessageBox.Show("Not matched");
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string s = "select * from NormalU where Email = '" + id + "'";
            if (db.loginsearch(s))
            {
                if (db.DetectType(id) == 0)
                {
                    new search(id).Show();
                    this.Hide();
                }
                else if (db.DetectType(id) == 1)
                {
                    new Guide(id).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incoorect user or password");
                }


            }

        }
    }
           

}
    