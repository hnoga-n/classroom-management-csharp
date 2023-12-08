using Hybrid.BUS;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hybrid.GUI.Home
{
    public partial class ThemChuongFrm : Form
    {
        //them chuong
        KhoaHocFrm khfrm;
        ChuongBUS chuongBUS = new ChuongBUS();

        //sua chuong
        Chuong chuong;

        public ThemChuongFrm(KhoaHocFrm khfrm)
        {
            InitializeComponent();
            this.khfrm = khfrm;
            this.btnTaoChuong.Visible = true;
            this.btnCapNhat.Visible = false;
        }
        public ThemChuongFrm(Chuong chuong, KhoaHocFrm khfrm)
        {
            InitializeComponent();
            this.chuong = chuong;
            this.khfrm = khfrm;
            this.Text = "Sửa chương";
            this.btnTaoChuong.Visible = false;
            this.btnCapNhat.Visible = true;
            this.txtTenChuong.Text = chuong.Tenchuong;
        }

        private void txtTenChuong_Enter(object sender, EventArgs e)
        {
            if (txtTenChuong.Text == "Vui lòng điền tên chương(trong vòng 50 ký tự)" ||  txtTenChuong.Text.Length == 0)
            {
                txtTenChuong.Text = "";
                txtTenChuong.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void txtTenChuong_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenChuong.Text))
            {
                txtTenChuong.Text = "Vui lòng điền tên chương(trong vòng 50 ký tự)";
                lblDemKyTuTenChuong.Text = "0/50";
                txtTenChuong.ForeColor = SystemColors.Control; // Đặt màu chữ thành màu xám
            }
        }

        private void txtTenChuong_TextChanged(object sender, EventArgs e)
        {
            if(txtTenChuong.Text.Length <= 50 )
                lblDemKyTuTenChuong.Text = txtTenChuong.Text.Length.ToString() + "/50";
            else
            {
                txtTenChuong.Text = txtTenChuong.Text.Substring(0, 50);
                txtTenChuong.SelectionStart = txtTenChuong.Text.Length;
            }
        }

        private void btnTaoChuong_Click(object sender, EventArgs e)
        {
            if(txtTenChuong.Text.Length == 0 || txtTenChuong.Text == "Vui lòng điền tên chương(trong vòng 50 ký tự)")
            {
                MessageBox.Show("Tên Chương không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuong.Focus();
                return;
            }
            Chuong chuong = new Chuong(Guid.NewGuid().ToString(),txtTenChuong.Text,DateTime.Now,khfrm.Lophoc.Malop,0);
            if (chuongBUS.ThemChuong(chuong)){ 
                PanelChuongDropDown pnlChuong = new PanelChuongDropDown(khfrm,chuong);
                this.khfrm.PnlChuongContainer.Controls.Add(pnlChuong);
                MessageBox.Show("Tạo Chương thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Tạo Chương thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemChuongFrm_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenChuong.Text.Length == 0 || txtTenChuong.Text == "Vui lòng điền tên chương(trong vòng 50 ký tự)")
            {
                MessageBox.Show("Tên Chương không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuong.Focus();
                return;
            }
            this.chuong.Tenchuong = txtTenChuong.Text;
            if(chuongBUS.SuaChuong(chuong))
            {
                MessageBox.Show("Cập nhật chương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach(PanelChuongDropDown panel in this.khfrm.PnlChuongContainer.Controls)
                {
                    if(panel.Chuong.Machuong.Equals(this.chuong.Machuong))
                    {
                        panel.LblTenChuong.Text = chuong.Tenchuong;
                        break;
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật chương thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
