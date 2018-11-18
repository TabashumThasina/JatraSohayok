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
    public partial class UserViewOfGuide : Form
    {
        public UserViewOfGuide()
        {
            InitializeComponent();
        }

        private void UserViewOfGuide_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }
    }
}
