using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.KiemTra;
using Hybrid.GUI.Kiemtra;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.HomeComponents
{
    public partial class ButtonBaiKT : UserControl
    {
        PanelChuongDropDown panelChuong;
        DeKiemTra dekiemtra;
        DeKiemTraBUS dktBUS = new DeKiemTraBUS();
        BailamKiemtraBUS blktBUS = new BailamKiemtraBUS();
        public ButtonBaiKT(PanelChuongDropDown panelChuong, DeKiemTra dkt)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.dekiemtra = dkt;
            this.lblTieuDeBKT.Text = dkt.Tieude;
            this.timerCapNhatTrangThai.Start();
<<<<<<< HEAD
            if(panelChuong.Khfrm.Lophoc.Daxoa == 1)
            {
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
=======
      
>>>>>>> main
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xóa đề kiểm tra?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (dktBUS.XoaDeKiemTra(this.dekiemtra))
                {
                    panelChuong.XoaChuongComponent(this);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
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
            string trangthai = XacDinhTrangThaiDeKiemTra(this.dekiemtra.Thoigianbatdau, this.dekiemtra.Thoigianketthuc);
            this.lblChiTietBKT.Text = "Bài kiểm tra (" + dekiemtra.Thoigianbatdau.ToString("dd/MM HH:mm:ss") + " - " + dekiemtra.Thoigianketthuc.ToString("dd/MM HH:mm:ss") + ") | " + trangthai;
            if (this.panelChuong.Khfrm.Taikhoan.Mataikhoan.Equals(this.panelChuong.Khfrm.Lophoc.Magiangvien) && panelChuong.Khfrm.Lophoc.Daxoa == 0)
            {
                if (this.dekiemtra.Thoigianbatdau.AddMinutes(-15) <= DateTime.Now)
                    this.btnSua.Visible = false;
            } else
            {
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
            if (trangthai == "Đã kết thúc")
                this.timerCapNhatTrangThai.Stop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new KiemTraFrm(this.dekiemtra).ShowDialog();
        }

        private void btnBaiKiemTra_Click(object sender, EventArgs e)
        {
            if (!panelChuong.Khfrm.Lophoc.Magiangvien.Equals(panelChuong.Khfrm.Taikhoan.Mataikhoan))
            {
                // Not start yet
                if (DateTime.Now < this.dekiemtra.Thoigianbatdau)
                {
                    MessageBox.Show("Bài kiểm tra chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited
                if (blktBUS.isSubmited(this.panelChuong.Khfrm.Taikhoan.Mataikhoan, this.dekiemtra.Madekiemtra) == 1)
                {
                    // TODO: mở form xem bài đã làm
                    DialogResult isConfirmSubmited =  MessageBox.Show("Bạn đã hoàn thành bài kiểm tra !\nXem lại bài đã nộp ?", "Thông báo!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (isConfirmSubmited == DialogResult.No) return;

                    BaiLamHocSinh frmBailam = new BaiLamHocSinh(this.panelChuong.Khfrm.Taikhoan, dekiemtra);
                    frmBailam.ShowDialog();
                    blktBUS.loadList();
                    return;
                }
                // do exam
                DialogResult isConfirmDoExam = MessageBox.Show("Xác nhận tiến hành làm bài kiểm tra ?", "Thông báo!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (isConfirmDoExam == DialogResult.No) return;
                LamKiemTra bailamkiemtra = new LamKiemTra(this.dekiemtra, panelChuong.Khfrm.Taikhoan);
                bailamkiemtra.ShowDialog();
            }
            else
            {
                //TODO: mở form xem bài đã nộp của giảng viên
                MessageBox.Show("Xem chi tiết đề kiểm tra");
                return;
            }
        }
    }
}
