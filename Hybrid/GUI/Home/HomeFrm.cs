﻿using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class HomeFrm : Form
    {
        private Taikhoan tk;
        private LopHocBUS lophocBUS = new LopHocBUS();
        Chucnang cn=new Chucnang();
        public Taikhoan Tk { get => tk; set => tk = value; }
        public LopHocBUS LophocBUS { get => lophocBUS; set => lophocBUS = value; }

        public HomeFrm(Taikhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            HienThiDanhSachLopHoc();
        }

        public void HienThiDanhSachLopHoc()
        {
            pnlLopHocContainer.Controls.Clear();
            if(lophocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(tk.Mataikhoan)!=null)
            {
                foreach (LopHoc lophoc in lophocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(tk.Mataikhoan))
                {

                    ButtonClass btnClass = new ButtonClass(lophoc, this);
                    pnlLopHocContainer.Controls.Add(btnClass);
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

        }
    }
}
