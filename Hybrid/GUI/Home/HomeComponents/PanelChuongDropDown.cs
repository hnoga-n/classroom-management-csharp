using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.GUI.Home.KiemTra;
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
    public partial class PanelChuongDropDown : UserControl
    {
        private bool isExpanded = false;
        private int demTaiLieuChuong;
        Chuong chuong;
        ChuongBUS chuongBUS;

        public bool IsExpanded { get => isExpanded; set => isExpanded = value; }
        public int DemTaiLieuChuong { get => demTaiLieuChuong; set => demTaiLieuChuong = value; }
        public Chuong Chuong { get => chuong; set => chuong = value; }

        public PanelChuongDropDown(Chuong chuong)
        {
            InitializeComponent();
            this.chuong = chuong;
            chuongBUS = new ChuongBUS();
            this.lblTenChuong.Text = chuong.Tenchuong;
            demTaiLieuChuong = 0;
            lblDemTaiLieuChuong.Text = "(0)";
            this.kryptonContextMenuItem1.Click += ThemTaiLieuChuong;
            this.kryptonContextMenuItem2.Click += ThemTaiLieuChuong;
            this.kryptonContextMenuItem3.Click += ThemTaiLieuChuong;
        }


        public void btnMoRong_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count <= 0) return;
            if (isExpanded)
            {
                this.Height = 65;
                isExpanded = false;
                btnMoRong.Text = "▼";
            }
            else
            {
                this.Height = 250;
                isExpanded = true;
                btnMoRong.Text = "▲";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            menuThem.Show(btnThem);
        }

        public void XoaChuongComponent(UserControl button)
        {
           if(this.flowLayoutPanel1.Controls.Count <= 1)
           {
                isExpanded = true;
                btnMoRong_Click(this, EventArgs.Empty);
           }
           this.flowLayoutPanel1.Controls.Remove(button);
           demTaiLieuChuong--;
           this.lblDemTaiLieuChuong.Text = "(" + demTaiLieuChuong + ")";
        }

        private void ThemTaiLieuChuong(object sender, System.EventArgs e)
        {
            switch ((sender as KryptonContextMenuItem).Text)
            {
                case "Bài tập":
                    ButtonBaiTap btnBT = new ButtonBaiTap(this);
                    this.flowLayoutPanel1.Controls.Add(btnBT);
                    break;
                case "Bài kiểm tra":
                    KiemTraFrm ktfrm = new KiemTraFrm(chuong);
                    ktfrm.ShowDialog();
                    /*ButtonBaiKT btnBKT = new ButtonBaiKT(this);
                    this.flowLayoutPanel1.Controls.Add(btnBKT);*/
                    break;
                case "Học liệu":
                    ButtonHocLieu btnHL = new ButtonHocLieu(this);
                    this.flowLayoutPanel1.Controls.Add(btnHL);
                    break;
            }
            /*isExpanded = false;
            btnMoRong_Click(this, EventArgs.Empty);
            demTaiLieuChuong++;
            this.lblDemTaiLieuChuong.Text = "(" + demTaiLieuChuong + ")";*/
        }
    }
}
