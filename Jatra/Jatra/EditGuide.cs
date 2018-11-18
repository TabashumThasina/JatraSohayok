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
    public partial class EditGuide : Form
    {
        string id;
        Database db = new Database();
        SignUpG sg = new SignUpG();
        public EditGuide()
        {
            InitializeComponent();
        }
        public EditGuide(string i,ref SignUpG sg1)
        {
            this.id = i;
            this.sg = sg1;
            InitializeComponent();
            comboBox1.Text = sg.Lan1;
            comboBox2.Text = sg.Lan2;
            comboBox3.Text = sg.aval;
            textBox1.Text = sg.Address;
            textBox7.Text = sg.Charge;


        }

        private void EditGuide_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox7.Text.TrimEnd()!=""||textBox1.Text.TrimEnd()!="")
            {
                string s = "update Guide set  Language1 = '" + comboBox1.Text + "', Language2 = '" + comboBox2.Text+"', Avaiable = '"+comboBox3.Text+"',Address = '"+textBox1.Text.TrimEnd()+"',charge ='"+textBox7.Text.TrimEnd()+"' where Email = '" + id + "'";
                db.update(s);
                MessageBox.Show("successfully updated");
            }
            else
            {
                MessageBox.Show("Address and charge can not be nill");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Guide(id).Show();
            this.Hide();
        }
    }
}
