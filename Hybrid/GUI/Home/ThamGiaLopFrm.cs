using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
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
        HomeFrm homefrm;
        LopHocBUS lophocBUS = new LopHocBUS();
        ThamGiaBUS thamgiaBUS = new ThamGiaBUS();
        public ThamGiaLopFrm(HomeFrm homefrm)
        {
            InitializeComponent();
            this.homefrm = homefrm;
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

        private void ThamGiaLopFrm_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Focus();
        }

        private void btnThamGiaLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Length == 0 || txtMaLop.Text == "Vui lòng điền mã lớp học")
            {
                MessageBox.Show("Mã Lớp Học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            LopHoc lophocthamgia = lophocBUS.GetLopHocByMaLop(txtMaLop.Text);
            if (lophocthamgia == null)
            {
                MessageBox.Show("Lớp học không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if(lophocthamgia.Magiangvien.Equals(this.homefrm.Tk.Mataikhoan))
            {
                MessageBox.Show("Không thể tham gia lớp học. Hãy kiểm tra mã rồi thử lại.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            ThamGia thamgia = new ThamGia(txtMaLop.Text,this.homefrm.Tk.Mataikhoan);
            if (thamgiaBUS.KiemTraDaThamGia(thamgia))
            {
                if (this.homefrm.PnlGiaoDienLopHocContainer.Controls.Count > 0)
                    this.homefrm.PnlGiaoDienLopHocContainer.Controls.RemoveAt(0);
                PanelGiaoDienLopHoc panelGDLH = new PanelGiaoDienLopHoc(lophocthamgia, homefrm);
                this.homefrm.PnlGiaoDienLopHocContainer.Controls.Add(panelGDLH);
                panelGDLH.Dock = DockStyle.Fill;
                this.Close();
                return;
            }
            if (thamgiaBUS.ThemThamGia(thamgia))
            {
                if (this.homefrm.PnlGiaoDienLopHocContainer.Controls.Count > 0)
                    this.homefrm.PnlGiaoDienLopHocContainer.Controls.RemoveAt(0);
                PanelGiaoDienLopHoc panelGDLH = new PanelGiaoDienLopHoc(lophocthamgia, homefrm);
                this.homefrm.PnlGiaoDienLopHocContainer.Controls.Add(panelGDLH);
                panelGDLH.Dock = DockStyle.Fill;

                ButtonClass btn = new ButtonClass(lophocthamgia, this.homefrm);
                this.homefrm.PnlLopHocContainer.Controls.Add(btn);
                MessageBox.Show("Tham gia lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tham gia lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
