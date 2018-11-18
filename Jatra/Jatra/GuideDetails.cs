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
    public partial class GuideDetails : Form
    {
        string id;
        Database db = new Database();
        SignUpG sg = new SignUpG();
        public GuideDetails()
        {
            InitializeComponent();
        }
        public GuideDetails(string i,string s)
        {
            this.id = i;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new search(id).Show();
            this.Close();
        }

        private void GuideDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
