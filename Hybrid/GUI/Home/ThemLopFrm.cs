using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class ThemLopFrm : Form
    {
        HomeFrm homeFrm;
        LopHocBUS lophocBus;
        string filelocal_hinhlop = null;
        public static string tenhinh = "imglop1";
        public ThemLopFrm(HomeFrm homeFrm)
        {
            InitializeComponent();
            this.homeFrm = homeFrm;
            lophocBus = new LopHocBUS();
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLop.Text.Length <= 50)
                lblDemKyTuTenLop.Text = txtTenLop.Text.Length.ToString() + "/50";
            else
            {
                txtTenLop.Text = txtTenLop.Text.Substring(0, 50);
                txtTenLop.SelectionStart = txtTenLop.Text.Length;
            }
        }

        private void txtTenLop_Enter(object sender, EventArgs e)
        {
            if (txtTenLop.Text == "Vui lòng điền tên lớp(trong vòng 50 ký tự)" || txtTenLop.Text.Length == 0)
            {
                txtTenLop.Text = "";
                txtTenLop.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void txtTenLop_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLop.Text))
            {
                txtTenLop.Text = "Vui lòng điền tên lớp(trong vòng 50 ký tự)";
                lblDemKyTuTenLop.Text = "0/50";
                txtTenLop.ForeColor = SystemColors.Control; // Đặt màu chữ thành màu xám
            }
        }

        private void ThemLopFrm_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Focus();
        }

        private void btnTaoLop_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text.Length == 0 || txtTenLop.Text == "Vui lòng điền tên lớp(trong vòng 50 ký tự)")
            {
                MessageBox.Show("Tên Lớp Học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
            LopHoc lophoc = new LopHoc(Guid.NewGuid().ToString(), txtTenLop.Text, "",tenhinh, homeFrm.Tk.Mataikhoan, 0);
            if (lophocBus.ThemLopHoc(lophoc))
            {
                ButtonClass buttonClass = new ButtonClass(lophoc, this.homeFrm);
                this.homeFrm.PnlLopHocContainer.Controls.Add(buttonClass);
                MessageBox.Show("Tạo Lớp Học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo Lớp Học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Chonhinhanhlop form = new Chonhinhanhlop(1,null);
            form.sendImage = new Chonhinhanhlop.SendImage(LoadHinh);
            form.ShowDialog();
        }
        private void LoadHinh(Image image)
        {
            //ptbThumbnail.Image = null;
            pictureBox1.Image = Properties.Resources.canhan1;
            pictureBox1.Image = image;
        }
        private void ThemLopFrm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image= global::Hybrid.Properties.Resources.imglop1;
        }
    }
}
