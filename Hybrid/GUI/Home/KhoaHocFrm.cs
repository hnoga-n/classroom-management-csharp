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
        Taikhoan taikhoan;
        ChuongBUS chuongBUS = new ChuongBUS();

        public LopHoc Lophoc { get => lophoc; set => lophoc = value; }
        public ChuongBUS ChuongBUS { get => chuongBUS; set => chuongBUS = value; }
        public Taikhoan Taikhoan { get => taikhoan; set => taikhoan = value; }

        public KhoaHocFrm(LopHoc lophoc, Taikhoan taikhoan)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            this.taikhoan = taikhoan;
            HienThiDanhSachChuong();
            if(!lophoc.Magiangvien.Equals(taikhoan.Mataikhoan))
                btnTaoChuong.Visible = false;
        }

        public void HienThiDanhSachChuong()
        {
            this.pnlChuongContainer.Controls.Clear();
            foreach (Chuong chuong in chuongBUS.getChuongWithMaLop(lophoc.Malop).Cast<Chuong>().OrderBy(item => item.Thoigiantao))
            {
                if(chuong.Daxoa == 0)
                {
                    PanelChuongDropDown pnlChuong = new PanelChuongDropDown(this,chuong);
                    this.PnlChuongContainer.Controls.Add(pnlChuong);
                }
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
