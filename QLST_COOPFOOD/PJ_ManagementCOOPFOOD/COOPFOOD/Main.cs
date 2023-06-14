using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COOPFOOD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.Show();
            childForm.MdiParent = this;

        }
        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCungCap());
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHangHoa());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn đóng chương trình quản lý Siêu Thị COOP-FOOD không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
