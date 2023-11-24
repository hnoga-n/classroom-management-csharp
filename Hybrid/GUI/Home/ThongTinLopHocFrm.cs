using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class ThongTinLopHocFrm : Form
    {
        DataTable dt = new DataTable();
        LopHoc lophoc;
        Taikhoan taikhoan;
        PanelGiaoDienLopHoc panelgdlh;
        string tenlop;

        ThamGiaBUS tgBUS = new ThamGiaBUS();
        TaikhoanBUS taikhoanBUS = new TaikhoanBUS();
        LopHocBUS lophocBUS = new LopHocBUS();
        public ThongTinLopHocFrm(Taikhoan taikhoan,PanelGiaoDienLopHoc panel)
        {
            InitializeComponent();
            this.panelgdlh = panel;
            this.lophoc = panel.Lophoc;
            this.taikhoan = taikhoan;
            this.txtTenLop.Text = lophoc.Tenlop;
            this.tenlop = lophoc.Tenlop;
            this.txtMaLop.Text = lophoc.Malop;
            this.rtbNoiDung.Text = lophoc.Mota;
            this.btnRoiLop.Visible = false;
            this.btnXoaLop.Visible = true;
            this.lblTenGiaoVien.Text = taikhoanBUS.list[taikhoanBUS.GetTaiKhoanByMaTaiKhoan(lophoc.Magiangvien)].ToString();
            dt = tgBUS.DanhSachHocSinhTheoMaLop(lophoc.Malop);
            this.dgvDanhSachHocSinh.DataSource = dt;
            this.dgvDanhSachHocSinh.Columns[0].Visible = false;
            this.dgvDanhSachHocSinh.Columns[1].Width = 370;
            this.dgvDanhSachHocSinh.Columns[1].HeaderText = "Học sinh";
            this.dgvDanhSachHocSinh.Columns.Insert(2, btnXoaHocSinh);
            this.dgvDanhSachHocSinh.Columns[2].Width = 80;
            if (!this.lophoc.Magiangvien.Equals(this.taikhoan.Mataikhoan))
            {
                this.txtTenLop.Enabled = false;
                this.rtbNoiDung.Enabled = false;
                this.pnlMaLop.Visible = false;
                this.dgvDanhSachHocSinh.Columns[1].Width = 450;
                this.dgvDanhSachHocSinh.Columns[2].Visible = false;
                this.btnXacNhan.Visible = false;
                this.btnRoiLop.Visible = true;
                this.btnXoaLop.Visible = false;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMaLop.Text);
        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            new HienThiMaLopHocFrm(lophoc.Malop).ShowDialog();
        }

        private void txtTenLop_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.tenlop.Equals(txtTenLop.Text.Trim())) return;
            if(e.KeyCode == Keys.Enter)
            {
                this.lophoc.Tenlop = txtTenLop.Text;
                this.tenlop = txtTenLop.Text;
                panelgdlh.LblTenLop.Text = txtTenLop.Text;
                foreach(ButtonClass btn in panelgdlh.Homefrm.PnlLopHocContainer.Controls)
                {
                    if(btn.Lophoc.Malop.Equals(this.lophoc.Malop))
                    {
                        btn.LblTenLop.Text = txtTenLop.Text;
                        break;
                    }
                }
                lophocBUS.SuaLopHoc(this.lophoc);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.lophoc.Mota = rtbNoiDung.Text;
            lophocBUS.SuaLopHoc(this.lophoc);
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
                    if (row.Cells[2].Value.ToString().Contains(searchValue))
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

        private void dgvDanhSachHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                if (dgvDanhSachHocSinh.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvDanhSachHocSinh.SelectedRows[0];
                    DialogResult dr = MessageBox.Show("Xác nhận xóa học sinh khỏi lớp học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        if(tgBUS.XoaThamGia(new ThamGia(this.lophoc.Malop, row.Cells[1].Value.ToString())))
                        {
                            this.dgvDanhSachHocSinh.Rows.Remove(row);
                            MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                            MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận giải tán lớp học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (lophocBUS.XoaLopHoc(this.lophoc.Malop))
                {
                    //this.panelgdlh.BtnChinhSuaLopHoc.Visible = false;
                    foreach(ButtonClass btn in this.panelgdlh.Homefrm.PnlLopHocContainer.Controls)
                    {
                        if(btn.Lophoc.Malop.Equals(this.lophoc.Malop))
                        {
                            btn.LblChiTiet.Text = "Lớp học đã giải tán";
                            btn.BtnLopHoc.StateCommon.Back.Color1 = Color.LightGray;
                            btn.BtnLopHoc.StateCommon.Back.Color2 = Color.LightGray;
                            btn.BtnLopHoc.OverrideDefault.Back.Color1 = Color.LightGray;
                            btn.BtnLopHoc.OverrideDefault.Back.Color2 = Color.LightGray;
                            btn.LblTenLop.BackColor = Color.LightGray;
                            btn.LblChiTiet.BackColor = Color.LightGray;
                            btn.btnLopHocClick();
                            break;
                        }
                    }
                    /*foreach (Form frm in this.panelgdlh.PnlHomeContainer.Controls)
                    {
                        if(frm is KhoaHocFrm)
                        {
                            MessageBox.Show("Hello");
                            (frm as KhoaHocFrm).BtnTaoChuong.Visible = false;
                            foreach(PanelChuongDropDown pnl in (frm as KhoaHocFrm).PnlChuongContainer.Controls)
                            {
                                pnl.BtnThem.Visible = false;
                                pnl.BtnXoa.Visible = false;
                                pnl.BtnSua.Visible = false;
                            }
                            break;
                        }
                    }*/
                    this.Close();
                }
            }
        }

        private void btnRoiLop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận ròi khỏi lớp học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(tgBUS.XoaThamGia(new ThamGia(this.lophoc.Malop, taikhoan.Mataikhoan)))
                {
                    MessageBox.Show("Đã rời khỏi lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    panelgdlh.Controls.Clear();
                    foreach (ButtonClass btn in panelgdlh.Homefrm.PnlLopHocContainer.Controls)
                    {
                        if(btn.Lophoc.Malop.Equals(this.lophoc.Malop))
                        {
                            panelgdlh.Homefrm.PnlLopHocContainer.Controls.Remove(btn);
                            break;
                        }
                    }
                }
            }
        }
    }
}
