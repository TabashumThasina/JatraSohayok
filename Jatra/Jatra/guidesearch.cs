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
    public partial class guidesearch : Form
    {
        string id;
        Database db = new Database();
        public guidesearch()
        {
            InitializeComponent();
        }
        public guidesearch(string ID,string area)
        {
            InitializeComponent();
            this.id = ID;
            dataGridView1 = db.Eventview(dataGridView1, "select * from Guide where Area = '"+area+"' and Avaiable = 'Yes'");
        }

        private void guidesearch_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new search(id).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GuideDetails(id,textBox1.Text.TrimEnd()).Show();
            this.Close();
        }
    }
}
