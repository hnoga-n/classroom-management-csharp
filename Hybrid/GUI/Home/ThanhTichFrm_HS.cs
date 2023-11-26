using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Danhba;
using ServiceStack;
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
    public partial class ThanhTichFrm_HS : Form
    {
        Taikhoan taikhoan;
        LopHoc lophoc;
        DataTable dt;
        ChuongBUS chuongBUS = new ChuongBUS();
        DeKiemTraBUS dktBUS = new DeKiemTraBUS();
        BailamKiemtraBUS blktBUS = new BailamKiemtraBUS();
        BailambaitapBUS blbtBUS = new BailambaitapBUS();
        BaiTapBUS btBUS = new BaiTapBUS();
        Dictionary<string, string> chuongDict = new Dictionary<string, string>();
        public ThanhTichFrm_HS(LopHoc l,Taikhoan tk)
        {
            InitializeComponent();
            this.taikhoan = tk;
            this.lophoc = l;
            FillComboBoxChuong();
        }

        public void FillComboBoxChuong()
        {
            foreach (Chuong c in chuongBUS.getChuongWithMaLop(lophoc.Malop))
                chuongDict.Add(c.Machuong, c.Tenchuong);
            cbChuong.Items.Clear();
            cbChuong.ValueMember = "Key";
            cbChuong.DisplayMember = "Value";
            cbChuong.DataSource = new BindingSource(chuongDict, null);
        }

        public void FillDataGridViewDanhSachDeKiemTra(string mataikhoan,string machuong)
        {

            dt = blktBUS.ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(mataikhoan, machuong).Clone();
            dt.Columns[0].DataType = typeof(string);
            foreach (DataRow row in blktBUS.ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(mataikhoan, machuong).Rows)
            {
                dt.ImportRow(row);
            }
            foreach (DataRow dr in dt.Rows)
            {
                string ma = dr[0].ToString();
                if (dktBUS.GetDeKiemTraByMaDe(ma) != null)
                {
                    string tieude = dktBUS.GetDeKiemTraByMaDe(ma).Tieude;
                    dr[0] = tieude;
                }
                else
                {
                    MessageBox.Show("De kiem tra null");
                    break;
                }
            }
            this.dgvDanhSachHocSinh.DataSource = dt;
            this.dgvDanhSachHocSinh.Columns[0].Width = 200;
            this.dgvDanhSachHocSinh.Columns[1].Width = 80;
            this.dgvDanhSachHocSinh.Columns[2].Width = 120;
            this.dgvDanhSachHocSinh.Columns[3].Width = 80;
            this.dgvDanhSachHocSinh.Columns[4].Width = 180;
            this.dgvDanhSachHocSinh.Columns[0].HeaderText = "Đề kiểm tra";
            this.dgvDanhSachHocSinh.Columns[1].HeaderText = "Điểm";
            this.dgvDanhSachHocSinh.Columns[2].HeaderText = "Số câu đúng";
            this.dgvDanhSachHocSinh.Columns[3].HeaderText = "Nộp trễ";
            this.dgvDanhSachHocSinh.Columns[4].HeaderText = "Thời gian nộp";
        }
        
        public void FillDataGridViewDanhSachBaiTap(string mataikhoan,string machuong)
        {
            dt = blbtBUS.ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(mataikhoan, machuong);
            this.dgvDanhSachHocSinh.DataSource = dt;
            this.dgvDanhSachHocSinh.Columns[0].Width = 400;
            this.dgvDanhSachHocSinh.Columns[1].Width = 50;
            this.dgvDanhSachHocSinh.Columns[2].Width = 250;
            this.dgvDanhSachHocSinh.Columns[0].HeaderText = "Bài tập";
            this.dgvDanhSachHocSinh.Columns[1].HeaderText = "Điểm";
            this.dgvDanhSachHocSinh.Columns[2].HeaderText = "Thời gian nộp";
        }

        private void cbLoaiHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHoatDong.SelectedIndex == 0 && cbChuong.SelectedValue != null)
            {
                FillChart1_DeKiemTra(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
                FillDataGridViewDanhSachDeKiemTra(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
            }
            else if (cbLoaiHoatDong.SelectedIndex == 1 && cbChuong.SelectedValue != null)
            {
                FillChart1_BaiTap(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
                FillDataGridViewDanhSachBaiTap(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
            }
        }

        public void FillChart1_DeKiemTra(string mataikhoan,string machuong)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].Axes[0].Title = "Đề kiểm tra";
            foreach (var pair in blktBUS.ThongKePhoDiemTheoMaTaiKhoan(mataikhoan))
            {
                if(dktBUS.GetDeKiemTraByMaDe(pair.Key).Machuong.Equals(machuong))
                    chart1.Series[0].Points.AddXY(dktBUS.GetDeKiemTraByMaDe(pair.Key).Tieude, pair.Value);
            }
        }
        public void FillChart1_BaiTap(string mataikhoan,string machuong)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].Axes[0].Title = "Bài Tập";
            foreach (var pair in blbtBUS.ThongKePhoDiemTheoMaTaiKhoan(mataikhoan))
            {
                if(btBUS.GetBaiTapByMaBaiTap(pair.Key).Machuong.Equals(machuong))
                    chart1.Series[0].Points.AddXY(btBUS.GetBaiTapByMaBaiTap(pair.Key).Tieude, pair.Value);
            }
        }

        private void cbChuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHoatDong.SelectedIndex == 0 && cbChuong.SelectedValue != null)
            {
                FillChart1_DeKiemTra(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
                FillDataGridViewDanhSachDeKiemTra(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
            }
            else if (cbLoaiHoatDong.SelectedIndex == 1 && cbChuong.SelectedValue != null)
            {
                FillChart1_BaiTap(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
                FillDataGridViewDanhSachBaiTap(this.taikhoan.Mataikhoan, cbChuong.SelectedValue.ToString());
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = SystemColors.Control; // Đặt màu chữ thành màu xám
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text;

            dgvDanhSachHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDanhSachHocSinh.Rows)
                {
                    if (row.Cells[0].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        row.Selected = true;
                        dgvDanhSachHocSinh.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
