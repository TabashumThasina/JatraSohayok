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
    public partial class SignUpOfGuide2 : Form
    {
        string id;
        SignUpG sg = new SignUpG();
        public SignUpOfGuide2()
        {
            InitializeComponent();
        }
        public SignUpOfGuide2(string i,ref SignUpG sg1)
        {
            this.id = i;
            this.sg = sg1;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.TrimEnd()!=""||textBox4.Text.TrimEnd()!=""||comboBox4.Text!="")
            {
                sg.RefPersonName = textBox3.Text.TrimEnd();
                sg.RefPersonContact = textBox4.Text.TrimEnd();
                sg.RefPersonRelation = comboBox4.Text.TrimEnd();
                new SignUpForGuide3(id,ref sg).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill up the form Properly");
            }
           
        }

        private void SignUpOfGuide2_Load(object sender, EventArgs e)
        {

        }
    }
}
