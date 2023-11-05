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

namespace Hybrid.GUI.Home
{
    public partial class KhoaHocFrm : Form
    {
        LopHoc lophoc;
        ChuongBUS chuongBUS = new ChuongBUS();

        public LopHoc Lophoc { get => lophoc; set => lophoc = value; }
        public ChuongBUS ChuongBUS { get => chuongBUS; set => chuongBUS = value; }

        public KhoaHocFrm(LopHoc lophoc)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            HienThiDanhSachChuong();
        }

        public void HienThiDanhSachChuong()
        {
            foreach(Chuong chuong in chuongBUS.getChuongWithMaLop(lophoc.Malop))
            {
                PanelChuongDropDown pnlChuong = new PanelChuongDropDown(chuong);
                pnlChuong.BtnXoa.Click += new EventHandler((s, e) =>
                {
                    DialogResult ds = MessageBox.Show("Xác nhận xóa chương?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ds == DialogResult.Yes)
                    {
                        if (chuongBUS.XoaChuong(chuong))
                        {
                            this.pnlChuongContainer.Controls.Remove(this);
                        }
                        else
                        {
                            MessageBox.Show("Xóa chương thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                });
                this.PnlChuongContainer.Controls.Add(pnlChuong);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lblTimKiem.Hide();
            if (txtTimKiem.Text.Length == 0)
                lblTimKiem.Show();
        }

        private void btnTaoChuong_Click(object sender, EventArgs e)
        {
             ThemChuongFrm newForm = new ThemChuongFrm(this);
             newForm.ShowDialog();
        }
    }
}
