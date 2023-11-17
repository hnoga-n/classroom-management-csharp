﻿using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using ServiceStack;
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
            this.txtTimKiem.Visible = false;
            this.btnTimKiem.Visible = false;
            if (!lophoc.Magiangvien.Equals(taikhoan.Mataikhoan))
                btnTaoChuong.Visible = false;
            if(lophoc.Daxoa == 1) 
                this.BtnTaoChuong.Visible=false;
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

        private void btnTaoChuong_Click(object sender, EventArgs e)
        {
             ThemChuongFrm newForm = new ThemChuongFrm(this);
             newForm.ShowDialog();
        }

        private void cbLoaiHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm") txtTimKiem.Text = "";
            if(this.cbLoaiHoatDong.SelectedIndex == 0)
            {
                this.txtTimKiem.Visible = false;
                this.btnTimKiem.Visible = false;
            } else
            {
                this.txtTimKiem.Clear();
                this.txtTimKiem.Visible = true;
                this.btnTimKiem.Visible = true;
            }
            HienThiTimKiem(txtTimKiem.Text,this.cbLoaiHoatDong.SelectedIndex);
        }

        public void HienThiTimKiem(string tukhoa, int loaihoatdong)
        {
            if (loaihoatdong == 0)
            {
                HienThiDanhSachChuong();
                return;
            } else if(loaihoatdong == 2)
            {
                ArrayList arrPnlChuong = new ArrayList();
                /*HienThiDanhSachChuong();
                ArrayList btnArr = new ArrayList();
                ArrayList pnlArr = new ArrayList();
                foreach(PanelChuongDropDown panel in this.pnlChuongContainer.Controls)
                {
                    foreach(UserControl btn in panel.PnlChuongComponent.Controls)
                    {
                        if(!(btn is ButtonBaiKT) || !(btn as ButtonBaiKT).LblTieuDeBKT.Text.Contains(tukhoa))
                        {
                            btnArr.Add(btn);
                        }
                    }
                    foreach(UserControl btn in btnArr)
                        panel.PnlChuongComponent.Controls.Remove(btn);
                    if (panel.PnlChuongComponent.Controls.Count == 0)
                        pnlArr.Add(panel);
                }
                foreach (PanelChuongDropDown panel in pnlArr)
                    this.pnlChuongContainer.Controls.Remove(panel);*/
                foreach (PanelChuongDropDown pnl in this.pnlChuongContainer.Controls)
                {
                    PanelChuongDropDown pnlchuong = new PanelChuongDropDown(this,pnl.Chuong,2,tukhoa);
                    arrPnlChuong.Add(pnlchuong);
                }
                this.pnlChuongContainer.Controls.Clear();
                foreach(PanelChuongDropDown pnl in arrPnlChuong)
                {
                    pnl.btnMoRong_Click(this,EventArgs.Empty);
                    this.pnlChuongContainer.Controls.Add(pnl);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm") txtTimKiem.Text = "";
            HienThiTimKiem(txtTimKiem.Text, this.cbLoaiHoatDong.SelectedIndex);
        }
    }
}