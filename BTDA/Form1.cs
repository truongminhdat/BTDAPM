﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDA
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 pf = new Form2();
           
            pf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu pf = new TrangChu();
            pf.Show();
        }
    }
}
