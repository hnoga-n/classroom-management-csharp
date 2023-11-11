using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.KiemTra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.HomeComponents
{
    public partial class ButtonBaiKT : UserControl
    {
        PanelChuongDropDown panelChuong;
        DeKiemTra dekiemtra;
        DeKiemTraBUS dktBUS = new DeKiemTraBUS();
        public ButtonBaiKT(PanelChuongDropDown panelChuong,DeKiemTra dkt)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.dekiemtra = dkt;
            this.lblTieuDeBKT.Text = dkt.Tieude;
            this.timerCapNhatTrangThai.Start();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xóa đề kiểm tra?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                if(dktBUS.XoaDeKiemTra(this.dekiemtra))
                {
                    panelChuong.XoaChuongComponent(this);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public string XacDinhTrangThaiDeKiemTra(DateTime startTime, DateTime endTime)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime < startTime)
            {
                this.lblChiTietBKT.StateCommon.ShortText.Color1 = Color.Gray;
                this.btnXoa.Visible = true;
                this.btnSua.Visible = true;
                return "Chưa mở";
            }
            else if (currentTime >= startTime && currentTime <= endTime)
            {
                this.lblChiTietBKT.StateCommon.ShortText.Color1 = Color.Green;
                this.btnXoa.Visible = false;
                this.btnSua.Visible = true;
                return "Đang diễn ra";
            }
            else
            {
                this.lblChiTietBKT.StateCommon.ShortText.Color1 = Color.Red;
                this.btnXoa.Visible = true;
                this.btnSua.Visible = false;
                return "Đã kết thúc";
            }
        }


        private void timerCapNhatTrangThai_Tick(object sender, EventArgs e)
        {
            string trangthai = XacDinhTrangThaiDeKiemTra(this.dekiemtra.Thoigianbatdau,this.dekiemtra.Thoigianketthuc);
            this.lblChiTietBKT.Text = "Bài kiểm tra (" + dekiemtra.Thoigianbatdau.ToString("dd/MM HH:mm:ss") + " - " + dekiemtra.Thoigianketthuc.ToString("dd/MM HH:mm:ss") + ") | " + trangthai;
            if (this.dekiemtra.Thoigianbatdau.AddMinutes(-15) <= DateTime.Now)
                this.btnSua.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new KiemTraFrm(this.dekiemtra).ShowDialog();
        }
    }
}
