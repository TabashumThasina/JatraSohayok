﻿using System;
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
    public partial class search : Form
    {
        string id;
        public search()
        {
            InitializeComponent();
        }
        public search(string email)
        {
            this.id = email;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new guidesearch(id,comboBox1.Text.TrimEnd()).Show();
            this.Hide();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            new changepass(id).Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            new SignUpForGuide(id).Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
