using Hybrid.BUS;
using Hybrid.DTO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using ServiceStack.OrmLite;
using System;
using System.Collections;
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
    public partial class ThanhTichFrm_GV : Form
    {
        LopHoc lophoc;
        DeKiemTraBUS dktBUS = new DeKiemTraBUS();
        BaiTapBUS btBUS = new BaiTapBUS();
        ChuongBUS chuongBUS = new ChuongBUS();
        BailamKiemtraBUS blktBUS = new BailamKiemtraBUS();
        BailambaitapBUS blbtBUS = new BailambaitapBUS();
        Dictionary<string,string> chuongDict = new Dictionary<string, string>();
        Dictionary<string,string> dekiemtraDict;
        Dictionary<string,string> baitapDict;
        DataTable dt = new DataTable();
        public ThanhTichFrm_GV(LopHoc lophoc)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            FillComboBoxChuong();
            if(lophoc.Daxoa == 1) 
                this.btnXuatExcel.Visible = false;
        }

        public void FillDataGridViewDanhSachHocSinh_DeKiemTra(string madekiemtra)
        {
            dt = blktBUS.ThongKeDiemHocSinhTheoMaDeKiemTra(madekiemtra);
            this.dgvDanhSachHocSinh.DataSource = dt;
            this.dgvDanhSachHocSinh.Columns[0].Width = 200;
            this.dgvDanhSachHocSinh.Columns[1].Width = 80;
            this.dgvDanhSachHocSinh.Columns[2].Width = 120;
            this.dgvDanhSachHocSinh.Columns[3].Width = 80;
            this.dgvDanhSachHocSinh.Columns[4].Width = 180;
            this.dgvDanhSachHocSinh.Columns[0].HeaderText = "Học sinh";
            this.dgvDanhSachHocSinh.Columns[1].HeaderText = "Điểm";
            this.dgvDanhSachHocSinh.Columns[2].HeaderText = "Số câu đúng";
            this.dgvDanhSachHocSinh.Columns[3].HeaderText = "Nộp trễ";
            this.dgvDanhSachHocSinh.Columns[4].HeaderText = "Thời gian nộp";
        }
        public void FillDataGridViewDanhSachHocSinh_BaiTap(string mabaitap)
        {
            dt = blbtBUS.ThongKeDiemThongKeDiemHocSinhTheoMaBaiTap(mabaitap);
            this.dgvDanhSachHocSinh.DataSource = dt;
            this.dgvDanhSachHocSinh.Columns[0].Width = 250;
            this.dgvDanhSachHocSinh.Columns[1].Width = 100;
            this.dgvDanhSachHocSinh.Columns[2].Width = 300;
            this.dgvDanhSachHocSinh.Columns[0].HeaderText = "Học sinh";
            this.dgvDanhSachHocSinh.Columns[1].HeaderText = "Điểm";
            this.dgvDanhSachHocSinh.Columns[2].HeaderText = "Thời gian nộp";
        }

        public void FillComboBoxChuong() {
            foreach (Chuong c in chuongBUS.getChuongWithMaLop(lophoc.Malop))
                chuongDict.Add(c.Machuong,c.Tenchuong);
            cbChuong.Items.Clear();
            cbChuong.ValueMember = "Key";
            cbChuong.DisplayMember = "Value";
            cbChuong.DataSource = new BindingSource(chuongDict,null); 
        }

        public void FillComboBoxHoatDongWithBaiKiemTra(string machuong)
        {
            if (dktBUS.GetDanhSachDeKiemTraTheoMaChuong(machuong).Count > 0)
            {
                dekiemtraDict = new Dictionary<string, string>();
                foreach (DeKiemTra dkt in dktBUS.GetDanhSachDeKiemTraTheoMaChuong(machuong))
                    dekiemtraDict.Add(dkt.Madekiemtra, dkt.Tieude);
                cbHoatDong.ValueMember = "Key";
                cbHoatDong.DisplayMember = "Value";
                cbHoatDong.DataSource = new BindingSource(dekiemtraDict,null);
            }
            else
            {
                cbHoatDong.DataSource = null;
                cbHoatDong.DataBindings.Clear();
            }
        }
        public void FillComboBoxHoatDongWithBaiTap(string machuong)
        {
            if (btBUS.GetDanhSachBaiTapTheoMaChuong(machuong).Count > 0)
            {
                baitapDict = new Dictionary<string, string>();
                foreach (BaiTap bt in btBUS.GetDanhSachBaiTapTheoMaChuong(machuong))
                     baitapDict.Add(bt.Mabaitap, bt.Tieude);
                cbHoatDong.ValueMember = "Key";
                cbHoatDong.DisplayMember = "Value";
                cbHoatDong.DataSource = new BindingSource(baitapDict,null);
            }
            else
            {
                cbHoatDong.DataSource = null;
                cbHoatDong.DataBindings.Clear();
            }
        }


        public void FillChart2_DeKiemTra(string madekiemtra)
        {
            chart1.Series[0].Points.Clear();
            foreach(var pair in blktBUS.ThongKePhoDiemTheoMaDeKiemTra(madekiemtra))
            {
                chart1.Series[0].Points.AddXY(pair.Key,pair.Value);
            }
        }
        public void FillChart2_BaiTap(string mabaitap)
        {
            chart1.Series[0].Points.Clear();
            foreach(var pair in blbtBUS.ThongKePhoDiemTheoMaBaiTap(mabaitap))
            {
                chart1.Series[0].Points.AddXY(pair.Key,pair.Value);
            }
        }

        private void cbChuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLoaiHoatDong.SelectedIndex == 0 && cbChuong.SelectedValue != null) 
            {
                FillComboBoxHoatDongWithBaiKiemTra(cbChuong.SelectedValue.ToString());

            }
            else if(cbLoaiHoatDong.SelectedIndex == 1 && cbChuong.SelectedValue != null)
            {
                FillComboBoxHoatDongWithBaiTap(cbChuong.SelectedValue.ToString());
            }
        }

        private void cbLoaiHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHoatDong.SelectedIndex == 0 && cbChuong.SelectedValue != null)
            {
                FillComboBoxHoatDongWithBaiKiemTra(cbChuong.SelectedValue.ToString());

            }
            else if (cbLoaiHoatDong.SelectedIndex == 1 && cbChuong.SelectedValue != null)
            {
                FillComboBoxHoatDongWithBaiTap(cbChuong.SelectedValue.ToString());
            }
        }

        private void cbHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHoatDong.SelectedIndex == 0 && cbChuong.SelectedValue != null)
            {
                if (cbHoatDong.SelectedValue != null)
                {
                    FillChart2_DeKiemTra(this.cbHoatDong.SelectedValue.ToString());
                    FillDataGridViewDanhSachHocSinh_DeKiemTra(this.cbHoatDong.SelectedValue.ToString());
                }
            }
            else if (cbLoaiHoatDong.SelectedIndex == 1 && cbChuong.SelectedValue != null)
            {
                if (cbHoatDong.SelectedValue != null)
                {
                    FillChart2_BaiTap(this.cbHoatDong.SelectedValue.ToString());
                    FillDataGridViewDanhSachHocSinh_BaiTap(this.cbHoatDong.SelectedValue.ToString());
                }
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
                    //MessageBox.Show(row.Cells[2].Value.ToString());
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.Title = "Chọn nơi lưu file Excel";
                saveFileDialog.FileName = "DanhSachHocSinh.xlsx";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string excelFilePath = saveFileDialog.FileName;

                    if (cbLoaiHoatDong.SelectedIndex == 0 && cbChuong.SelectedValue != null)
                    {
                        // Gọi phương thức xuất Excel và truyền đường dẫn file Excel
                        ExportToExcel_DeKiemTra(dgvDanhSachHocSinh, excelFilePath);
                    }
                    else if (cbLoaiHoatDong.SelectedIndex == 1 && cbChuong.SelectedValue != null)
                    {
                        ExportToExcel_BaiTap(dgvDanhSachHocSinh, excelFilePath);
                    }
                }
            }
        }

        private void ExportToExcel_DeKiemTra(DataGridView dataGridView, string excelFilePath)
        {
            using (var package = new ExcelPackage())
            {
                // Tạo một Sheet trong Excel
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("DanhSachHocSinh");

                // Đổ dữ liệu từ DataGridView vào Excel
                for (int col = 1; col <= dataGridView.Columns.Count; col++)
                {
                    worksheet.Cells[2, col].Value = dataGridView.Columns[col - 1].HeaderText;
                    worksheet.Cells[2, col].Style.Font.Bold = true;
                    worksheet.Cells[2, col].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                for (int row = 3; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cells[row, col + 1].Value = dataGridView.Rows[row].Cells[col].Value;
                        if(col + 1 == 5)
                            worksheet.Cells[row, col + 1].Value = dataGridView.Rows[row].Cells[col].Value.ToString();
                        worksheet.Cells[row, col + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                }

                // Merge ô từ A1 đến C5
                using (var range = worksheet.Cells[1,1,1,5])
                {
                    range.Merge = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    range.Style.Font.Bold = true;
                    range.Value = "BẢNG ĐIỂM";
                }


                // Lưu file Excel vào đường dẫn đã chọn
                File.WriteAllBytes(excelFilePath, package.GetAsByteArray());

                MessageBox.Show("Xuất Excel thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        
        private void ExportToExcel_BaiTap(DataGridView dataGridView, string excelFilePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                // Tạo một Sheet trong Excel
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("DanhSachHocSinh");

                // Đổ dữ liệu từ DataGridView vào Excel
                for (int col = 1; col <= dataGridView.Columns.Count; col++)
                {
                    worksheet.Cells[2, col].Value = dataGridView.Columns[col - 1].HeaderText;
                    worksheet.Cells[2, col].Style.Font.Bold = true;
                    worksheet.Cells[2, col].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                for (int row = 3; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cells[row, col + 1].Value = dataGridView.Rows[row].Cells[col].Value;
                        if(col + 1 == 3)
                            worksheet.Cells[row, col + 1].Value = dataGridView.Rows[row].Cells[col].Value.ToString();
                        worksheet.Cells[row, col + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                }

                // Merge ô từ A1 đến C5
                using (var range = worksheet.Cells[1,1,1,3])
                {
                    range.Merge = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    range.Style.Font.Bold = true;
                    range.Value = "BẢNG ĐIỂM";
                }


                // Sau khi ghi dữ liệu, thực hiện AutoFit cho các cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                // Lưu file Excel vào đường dẫn đã chọn
                File.WriteAllBytes(excelFilePath, package.GetAsByteArray());

                MessageBox.Show("Xuất Excel thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        
    }
}
