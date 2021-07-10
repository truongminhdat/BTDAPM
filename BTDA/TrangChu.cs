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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinchamsoccay tt = new thongtinchamsoccay();
            tt.Show();
        }

        private void quảnLýThôngTinCâyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlicay quanlicay = new quanlicay();
            quanlicay.Show();
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlinguoidung quanlinguoidung = new Quanlinguoidung();
            quanlinguoidung.Show();
        }

        private void cậpNhậtThôngTinCâyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capnhatthongtincay cp = new Capnhatthongtincay();
            cp.Show();
        }

        private void cậpNhậtChămSócCâyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capnhatchamsoccay cp = new Capnhatchamsoccay();
            cp.Show();
        }

        private void danhMụcSựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Danhmucsuco dm = new Danhmucsuco();
            dm.Show();
        }

        private void báoCáoSựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocaosuco baocaosuco = new Baocaosuco();
            baocaosuco.Show();
        }

        private void xemThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinhnhanvien tt = new thongtinhnhanvien();
            tt.Show();
        }

        private void xemThôngBáoSựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongbaosucocay tt = new thongbaosucocay();
            tt.Show();
        }
    }
}
