using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class ThamGiaLopFrm : Form
    {
        public ThamGiaLopFrm()
        {
            InitializeComponent();
        }

        private void txtMaLop_Enter(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "Vui lòng điền mã lớp học" || txtMaLop.Text.Length == 0)
            {
                txtMaLop.Text = "";
                txtMaLop.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void txtMaLop_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                txtMaLop.Text = "Vui lòng điền mã lớp học";
                txtMaLop.ForeColor = SystemColors.Control; // Đặt màu chữ thành màu xám
            }
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtMaLop.Text)
            {
                if(!Char.IsDigit(c))
                {
                    MessageBox.Show("Mã lớp là số nguyên!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLop.Clear();
                    return;
                }
            }
        }

        private void ThamGiaLopFrm_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Focus();
        }

        private void btnTaoThamGiaLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Length == 0 || txtMaLop.Text == "Vui lòng điền mã lớp học")
            {
                MessageBox.Show("Mã Lớp Học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
        }
    }
}
