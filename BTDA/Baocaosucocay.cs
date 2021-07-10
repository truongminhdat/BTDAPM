using System;
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
    public partial class Baocaosucocay : Form
    {
        public Baocaosucocay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlinguoidung pf = new Quanlinguoidung();
            pf.Show();
        }

        private void quảnLýThôngTinCâyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlicay ql = new quanlicay();
            ql.Show();
        }
    }
}
