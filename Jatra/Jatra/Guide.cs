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
    public partial class Guide : Form
    {
        Database db = new Database();
        string id;
        SignUpG sg = new SignUpG();
        public Guide()
        {
            InitializeComponent();
            
        }
        public Guide(string i)
        {
            InitializeComponent();
            this.id = i;
            sg = db.User_View(id, sg);
            textBox2.Text = sg.FName;
            textBox3.Text = sg.LName;
            textBox4.Text = sg.Age;
            textBox5.Text = sg.Gender;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Guide_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EditGuide(id, ref sg).Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            new changepass(id).Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
