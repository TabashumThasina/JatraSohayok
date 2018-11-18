using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Jatra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
        private void Form1_Closing(object sender , EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://visitbangladesh.gov.bd/");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/groups/mail.tob/");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/tbangladesh");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCQgLXhL3EGycbFxJbqqpGZg/featured");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://wikitravel.org/en/Bangladesh");
        }
    }
}
