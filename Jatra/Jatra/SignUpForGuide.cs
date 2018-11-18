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
    public partial class SignUpForGuide : Form
    {
        string id;
        SignUpG sg = new SignUpG();
        public SignUpForGuide()
        {
            InitializeComponent();
        }
        public SignUpForGuide(string i)
        {
            this.id = i;
            InitializeComponent();
        }
        public SignUpForGuide(string i,SignUpG s)
        {
            this.id = i;
            this.sg = s;
            InitializeComponent();
        }

        private void SignUpForGuide_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.TrimEnd()!=""|| textBox2.Text.TrimEnd() != ""||comboBox1.Text!=""||comboBox2.Text!=""||comboBox3.Text!=""||comboBox5.Text!="")
            {
                sg.Nid = textBox1.Text.TrimEnd();
                sg.Address = textBox2.Text.TrimEnd();
                sg.Gender = comboBox1.Text.TrimEnd();
                sg.Country = comboBox3.Text.TrimEnd();
                sg.State = comboBox5.Text.TrimEnd();
                string s = comboBox1.Text.TrimEnd();
                sg.Age=comboBox2.Text;
                new SignUpOfGuide2(id,ref sg).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill the form properly");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
