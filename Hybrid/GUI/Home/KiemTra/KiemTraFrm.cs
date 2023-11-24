using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.GUI.Home.KiemTra.KiemTraComponents;
using ServiceStack.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class KiemTraFrm : Form
    {
        private bool isCloseFormNoAction;
        // them de kiem tra
        Chuong chuong;
        CauHoiBUS cauhoiBUS = new CauHoiBUS();
        LopHocBUS lophocBUS = new LopHocBUS();
        DeKiemTraBUS dekiemtraBUS = new DeKiemTraBUS();
        ChiTietDeKiemTraBUS ctdktBUS = new ChiTietDeKiemTraBUS();
        PanelChuongDropDown panelchuong;

        public Chuong Chuong { get => chuong; set => chuong = value; }

        // sua de kiem tra
        DeKiemTra dekiemtra;
        public KiemTraFrm(PanelChuongDropDown panelchuong)
        {
            InitializeComponent();
            this.panelchuong = panelchuong;
            this.chuong = panelchuong.Chuong;
            HienThiDanhSachCauHoi(cauhoiBUS.GetDanhSachCauHoiByMaTaiKhoan(lophocBUS.GetLopHocByMaLop(this.chuong.Malop).Magiangvien));
            this.dtpThoiGianBatDau.MinDate = DateTime.Now;
            this.dtpThoiGianKetThuc.MinDate = this.dtpThoiGianBatDau.Value.AddMinutes(15);
            this.btnDang.Visible = true;
            this.btnCapNhat.Visible = false;
            this.isCloseFormNoAction = true;
        }

        public KiemTraFrm(DeKiemTra dkt) { 
            InitializeComponent();
            this.dtpThoiGianBatDau.MinDate = DateTime.Now;
            this.dekiemtra = dkt;
            this.txtTieuDeBaiKT.Enabled = false;
            this.txtTimKiem.Enabled = false;
            this.btnTimKiem.Enabled = false;
            this.btnTaiLai.Enabled = false;
            this.btnThemCauHoi.Enabled = false;
            this.btnXoaCauHoi.Enabled = false;
            this.chkXoaToanBoCauHoi.Enabled = false;
            this.chkCongKhaiDapAn.Enabled = false;
            this.chkDaoCauHoi.Enabled= false;
            this.numHinhPhat.Enabled= false;
            this.btnDang.Visible = false;
            this.btnCapNhat.Visible = true;
            this.txtTieuDeBaiKT.Text = dkt.Tieude;
            this.dtpThoiGianBatDau.Value = dekiemtra.Thoigianbatdau;
            this.dtpThoiGianKetThuc.Value = dekiemtra.Thoigianketthuc;
            this.numHinhPhat.Value = Convert.ToDecimal(dekiemtra.Hinhphat);
            this.chkCongKhaiDapAn.Checked = dekiemtra.Xemdapan == 1;
            this.chkDaoCauHoi.Checked = dekiemtra.Troncauhoi == 1;
            this.isCloseFormNoAction = true;
            this.FormClosing -= this.KiemTraFrm_FormClosing;
            HienThiDanhSachChiTietCauHoi();
        }
        public void HienThiDanhSachChiTietCauHoi()
        {
            foreach(ChiTietDeKiemTra ctdkt in ctdktBUS.GetDanhSachChiTietDeKiemTraWithMaDeKiemTra(this.dekiemtra.Madekiemtra))
            {
                PanelChiTietCauHoi panel = new PanelChiTietCauHoi(cauhoiBUS.GetCauHoiByMaCauHoi(ctdkt.Macauhoi));
                panel.LblNoiDung.Text = ctdkt.Thutu + ". " + panel.LblNoiDung.Text;
                panel.BtnXoaCauHoi.Visible = false;
                this.pnlChiTietCauHoiContainer.Controls.Add(panel);
            }
        }
        public void HienThiDanhSachCauHoi(ArrayList listcauhoi)
        {
            pnlCauHoiContainer.Controls.Clear();
            foreach (CauHoi cauhoi in listcauhoi)
            {
                if (cauhoi.Daxoa == 0)
                {
                    ButtonCauHoi btnCauHoi = new ButtonCauHoi(cauhoi, this);
                    if (KiemTraCauHoiTonTaiTrongDe(cauhoi.Macauhoi))
                    {
                        btnCauHoi.BtnChon.Checked = true;
                        btnCauHoi.BtnChon.Enabled = false;
                    }
                    this.pnlCauHoiContainer.Controls.Add(btnCauHoi);
                }
            }
        }

        public bool KiemTraCauHoiTonTaiTrongDe(string macauhoi)
        {
            if (this.pnlChiTietCauHoiContainer.Controls.Count == 0) return false;
            foreach(PanelChiTietCauHoi panel in this.pnlChiTietCauHoiContainer.Controls)
            {
                if(panel.Cauhoi.Macauhoi.Equals(macauhoi))
                    return true;
            }
            return false;
        }


        private void btnThemCauHoi_Click(object sender, EventArgs e)
        { 
             ThemCauHoiFrm newForm = new ThemCauHoiFrm(this);
             newForm.ShowDialog();
        }

        private void btnXoaCauHoi_Click(object sender, EventArgs e)
        {
            if(this.pnlCauHoiContainer.Controls.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn các câu hỏi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool flag = true;
            foreach (ButtonCauHoi btncauhoi in this.pnlCauHoiContainer.Controls)
            {
                if(btncauhoi.ChkXoaCauHoi.Checked == false)
                    flag = false;
                else
                {
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                MessageBox.Show("Vui lòng chọn các câu hỏi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Xác nhận xóa các câu hỏi!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                ArrayList danhsachcauhoicanxoa = new ArrayList(); 
                foreach (ButtonCauHoi btncauhoi in this.pnlCauHoiContainer.Controls)
                {
                    if (btncauhoi.ChkXoaCauHoi.Checked == true && btncauhoi.BtnChon.Checked == false) 
                        danhsachcauhoicanxoa.Add(btncauhoi);
                    else if(btncauhoi.ChkXoaCauHoi.Checked == true && btncauhoi.BtnChon.Checked == true)
                    {
                        MessageBox.Show("Tồn tại các câu hỏi được chọn trong đề kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        danhsachcauhoicanxoa.Clear();
                        return;
                    }
                }
                foreach(ButtonCauHoi btncauhoi in danhsachcauhoicanxoa)
                {
                    cauhoiBUS.XoaCauHoi(btncauhoi.Cauhoi);
                    this.pnlCauHoiContainer.Controls.Remove(btncauhoi);
                    btncauhoi.Dispose();
                }
                MessageBox.Show("Các câu hỏi được chọn đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkXoaToanBoCauHoi_CheckedChanged(object sender, EventArgs e)
        {
            if(chkXoaToanBoCauHoi.Checked)
            {
                foreach (ButtonCauHoi btncauhoi in this.pnlCauHoiContainer.Controls)
                    btncauhoi.ChkXoaCauHoi.Checked = true;
            } else
            {
                foreach (ButtonCauHoi btncauhoi in this.pnlCauHoiContainer.Controls)         
                    btncauhoi.ChkXoaCauHoi.Checked = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm câu hỏi";
                txtTimKiem.ForeColor = Color.Silver; // Đặt màu chữ thành màu xám
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm câu hỏi")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm câu hỏi") return;
            string magiangvien = lophocBUS.GetLopHocByMaLop(this.chuong.Malop).Magiangvien;
            HienThiDanhSachCauHoi(cauhoiBUS.TimKiemCauHoiThuocTaiKhoan(txtTimKiem.Text, magiangvien));
        }

        public void TaiLaiDanhSachCauHoi()
        {
            txtTimKiem.Text = "Tìm kiếm câu hỏi";
            chkXoaToanBoCauHoi.Checked = false;
            HienThiDanhSachCauHoi(cauhoiBUS.GetDanhSachCauHoiByMaTaiKhoan(lophocBUS.GetLopHocByMaLop(this.chuong.Malop).Magiangvien));
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiLaiDanhSachCauHoi();
        }

        private void txtTieuDeBaiKT_Enter(object sender, EventArgs e)
        {
            if (txtTieuDeBaiKT.Text == "Vui lòng điền tiêu đề(trong vòng 50 ký tự)")
            {
                txtTieuDeBaiKT.Text = "";
                txtTieuDeBaiKT.ForeColor = Color.Black; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void txtTieuDeBaiKT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTieuDeBaiKT.Text))
            {
                txtTieuDeBaiKT.Text = "Vui lòng điền tiêu đề(trong vòng 50 ký tự)";
                lblDemKyTuTieuDeBaiKT.Text = "0/50";
                txtTieuDeBaiKT.ForeColor = Color.Silver; // Đặt màu chữ thành màu xám
            }
        }

        private void txtTieuDeBaiKT_TextChanged(object sender, EventArgs e)
        {
            isCloseFormNoAction = false;
            if (txtTieuDeBaiKT.Text.Length <= 50)
                lblDemKyTuTieuDeBaiKT.Text = txtTieuDeBaiKT.Text.Length.ToString() + "/50";
            else
            {
                txtTieuDeBaiKT.Text = txtTieuDeBaiKT.Text.Substring(0, 50);
                txtTieuDeBaiKT.SelectionStart = txtTieuDeBaiKT.Text.Length;
            }
        }

        private void dtpThoiGianBatDau_Leave(object sender, EventArgs e)
        {
            
        }

        private void dtpThoiGianKetThuc_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnDang_Click(object sender, EventArgs e)
        {
            if(txtTieuDeBaiKT.Text == "" || txtTieuDeBaiKT.Text == "Vui lòng điền tiêu đề(trong vòng 50 ký tự)")
            {
                MessageBox.Show("Tiêu đề bài kiểm tra không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTieuDeBaiKT.Focus();
                return;
            }
            if(pnlChiTietCauHoiContainer.Controls.Count <= 0)
            {
                MessageBox.Show("Đề kiểm tra chưa có câu hỏi. Vui lòng thêm câu hỏi vào đề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dtpThoiGianBatDau.Value <= DateTime.Now)
            {
                MessageBox.Show("Thời gian bắt đầu phải lớn hơn thời gian hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpThoiGianBatDau.Focus();
                return;
            }
            if (dtpThoiGianBatDau.Value >= dtpThoiGianKetThuc.Value)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpThoiGianBatDau.Focus();
                return;
            }
            if (dtpThoiGianKetThuc.Value <= dtpThoiGianBatDau.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpThoiGianKetThuc.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("Vui lòng kiểm tra kĩ các thông tin trước khi đăng! Sau khi đăng, bài kiểm tra sẽ thông thể chỉnh sửa ngoại trừ thời gian có thể chỉnh sửa trước 15 phút bắt đầu thời gian làm bài.\n\nXác nhận tạo bài kiểm tra ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                DeKiemTra dekiemtra = new DeKiemTra(Guid.NewGuid().ToString(),txtTieuDeBaiKT.Text,DateTime.Now,dtpThoiGianBatDau.Value,dtpThoiGianKetThuc.Value,Convert.ToInt32(numHinhPhat.Value),chkCongKhaiDapAn.Checked ? 1 : 0,chkDaoCauHoi.Checked ? 1 : 0,chuong.Machuong,0);
                if(dekiemtraBUS.ThemDeKiemTra(dekiemtra))
                {
                    int thutu = 1;
                    foreach(PanelChiTietCauHoi panel in this.pnlChiTietCauHoiContainer.Controls)
                    {
                        ChiTietDeKiemTra ctdkt = new ChiTietDeKiemTra(dekiemtra.Madekiemtra,panel.Cauhoi.Macauhoi,thutu);
                        if (ctdktBUS.ThemChiTietDeKiemTra(ctdkt))
                        {
                            thutu++;
                        } else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết đề kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    ButtonBaiKT btn = new ButtonBaiKT(this.panelchuong,dekiemtra);
                    this.panelchuong.PnlChuongComponent.Controls.Add(btn);
                    MessageBox.Show("Tạo đề kiểm tra thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FormClosing -= this.KiemTraFrm_FormClosing;
                    this.Close();
                    this.panelchuong.IsExpanded = false;
                    this.panelchuong.btnMoRong_Click(this, EventArgs.Empty);
                    this.panelchuong.DemTaiLieuChuong++;
                    this.panelchuong.LblDemTaiLieuChuong.Text = "(" + this.panelchuong.DemTaiLieuChuong + ")";
                }
                else
                {
                    MessageBox.Show("Tạo đề kiểm tra thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void KiemTraFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.pnlChiTietCauHoiContainer.Controls.Count > 0 || !isCloseFormNoAction)
            {
                DialogResult dr = MessageBox.Show("Sau khi thoát, nội dung chỉnh sửa này sẽ bị mất, bạn có chắc muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(DateTime.Now >= dekiemtra.Thoigianbatdau.AddMinutes(-15))
            {
                MessageBox.Show("Quá thời gian cho phép cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (dtpThoiGianBatDau.Value >= dtpThoiGianKetThuc.Value)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpThoiGianBatDau.Focus();
                return;
            }
            if (dtpThoiGianKetThuc.Value <= dtpThoiGianBatDau.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpThoiGianKetThuc.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("Xác nhận cập nhật bài kiểm tra ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.dekiemtra.Thoigianbatdau = dtpThoiGianBatDau.Value;
                this.dekiemtra.Thoigianketthuc = dtpThoiGianKetThuc.Value;
                if(dekiemtraBUS.SuaDeKiemTra(dekiemtra))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    this.Close();
                } else
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void dtpThoiGianBatDau_ValueChanged(object sender, EventArgs e)
        {
            isCloseFormNoAction = false;
        }

        private void dtpThoiGianKetThuc_ValueChanged(object sender, EventArgs e)
        {
            isCloseFormNoAction = false;
        }

        private void numHinhPhat_ValueChanged(object sender, EventArgs e)
        {
            isCloseFormNoAction=false;
        }

        private void chkCongKhaiDapAn_CheckedChanged(object sender, EventArgs e)
        {
            isCloseFormNoAction = false;
        }

        private void chkDaoCauHoi_CheckedChanged(object sender, EventArgs e)
        {
            isCloseFormNoAction = false;
        }
    }
}
