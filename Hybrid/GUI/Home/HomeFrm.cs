using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class HomeFrm : Form
    {
        private Form1 form;
        private Taikhoan tk;
        private LopHocBUS lophocBUS = new LopHocBUS();

        public Taikhoan Tk { get => tk; set => tk = value; }
        public LopHocBUS LophocBUS { get => lophocBUS; set => lophocBUS = value; }
        public Form1 Form { get => form; set => form = value; }

        public HomeFrm(Form1 frm)
        {
            InitializeComponent();
            this.form = frm;
            this.tk = frm.Tk;
            HienThiDanhSachLopHoc(lophocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(tk.Mataikhoan));
        }

        public void HienThiDanhSachLopHoc(ArrayList list)
        {
            pnlLopHocContainer.Controls.Clear();
            foreach(LopHoc lophoc in list)
            {
                ButtonClass btnClass = new ButtonClass(lophoc,this);
                pnlLopHocContainer.Controls.Add(btnClass);
            }

        }
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm tên lớp học";
                txtTimKiem.ForeColor = SystemColors.Control; // Đặt màu chữ thành màu xám
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm tên lớp học")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void btnTaoLop_Click(object sender, EventArgs e)
        {
             ThemLopFrm newForm = new ThemLopFrm(this);
             newForm.ShowDialog();
        }

        private void btnThamGia_Click(object sender, EventArgs e)
        {
              ThamGiaLopFrm newForm = new ThamGiaLopFrm(this);
              newForm.ShowDialog();         
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm tên lớp học") return;
            ArrayList rslist = new ArrayList();
            foreach (LopHoc l in lophocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(tk.Mataikhoan))
            {
                if (l.Tenlop.ToLower().Contains(txtTimKiem.Text.ToLower())) 
                    rslist.Add(l);
            }
            HienThiDanhSachLopHoc(rslist);
        }
    }
}
