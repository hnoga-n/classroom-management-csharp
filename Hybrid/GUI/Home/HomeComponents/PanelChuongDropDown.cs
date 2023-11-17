using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.GUI.Home.KiemTra;
using System;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class PanelChuongDropDown : UserControl
    {
        private bool isExpanded = false;
        private int demTaiLieuChuong;
        Chuong chuong;
        KhoaHocFrm khfrm;
        ChuongBUS chuongBUS = new ChuongBUS();
        DeKiemTraBUS dekiemtraBUS = new DeKiemTraBUS();

        public bool IsExpanded { get => isExpanded; set => isExpanded = value; }
        public int DemTaiLieuChuong { get => demTaiLieuChuong; set => demTaiLieuChuong = value; }
        public Chuong Chuong { get => chuong; set => chuong = value; }
        public KhoaHocFrm Khfrm { get => khfrm; set => khfrm = value; }

        public PanelChuongDropDown(KhoaHocFrm khfrm,Chuong chuong, int loaihoatdong = 0, string tukhoa = "")
        {
            InitializeComponent();
            this.chuong = chuong;
            this.khfrm = khfrm;
            if(!this.khfrm.Lophoc.Magiangvien.Equals(this.khfrm.Taikhoan.Mataikhoan) || khfrm.Lophoc.Daxoa == 1)
            {
                this.btnThem.Visible = false;
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
                //this.lblDemTaiLieuChuong.Location = this.PointToClient(new System.Drawing.Point(844, 19));
            }
            this.lblTenChuong.Text = chuong.Tenchuong;
            demTaiLieuChuong = 0;
            lblDemTaiLieuChuong.Text = "(0)";
            this.kryptonContextMenuItem1.Click += ThemTaiLieuChuong;
            this.kryptonContextMenuItem2.Click += ThemTaiLieuChuong;
            this.kryptonContextMenuItem3.Click += ThemTaiLieuChuong;
            if(loaihoatdong == 0)
            {
                HienThiDanhSachBaiKiemTra(chuong.Machuong);
            } else if(loaihoatdong == 1)
            {

            } else if(loaihoatdong == 2)
            {
                if(!HienThiDanhSachBaiKiemTra(chuong.Machuong,tukhoa))
                    this.Visible = false;
            }
            else if(loaihoatdong == 3)
            {

            }

        }

        public bool HienThiDanhSachBaiKiemTra(string machuong, string tukhoa = "")
        {
            if (dekiemtraBUS.GetDanhSachDeKiemTraTheoMaChuong(machuong, tukhoa).Count == 0) return false;
            foreach(DeKiemTra dkt in dekiemtraBUS.GetDanhSachDeKiemTraTheoMaChuong(machuong,tukhoa))
            {
                if(dkt.Daxoa == 0)
                {

                    ButtonBaiKT btn = new ButtonBaiKT(this,dkt);
                    this.pnlChuongComponent.Controls.Add(btn);
                    this.lblDemTaiLieuChuong.Text = "(" + ++demTaiLieuChuong + ")";
                }
            }
            return true;
        }

        public void btnMoRong_Click(object sender, EventArgs e)
        {
            timerHieuUngDropDown.Start();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            menuThem.Show(btnThem);
        }

        public void XoaChuongComponent(UserControl button)
        {
           if(this.pnlChuongComponent.Controls.Count <= 1)
           {
                isExpanded = true;
                btnMoRong_Click(this, EventArgs.Empty);
           }
           this.pnlChuongComponent.Controls.Remove(button);
           demTaiLieuChuong--;
           this.lblDemTaiLieuChuong.Text = "(" + demTaiLieuChuong + ")";
        }

        private void ThemTaiLieuChuong(object sender, System.EventArgs e)
        {
            switch ((sender as KryptonContextMenuItem).Text)
            {
                case "Bài tập":
                    ButtonBaiTap btnBT = new ButtonBaiTap(this);
                    this.pnlChuongComponent.Controls.Add(btnBT);
                    break;
                case "Bài kiểm tra":
                    KiemTraFrm ktfrm = new KiemTraFrm(this);
                    //ktfrm.ShowDialog();
                    ktfrm.ShowDialog();
                    break;
                case "Học liệu":
                    ButtonHocLieu btnHL = new ButtonHocLieu(this);
                    this.pnlChuongComponent.Controls.Add(btnHL);
                    break;
            }
            /*isExpanded = false;
            btnMoRong_Click(this, EventArgs.Empty);
            demTaiLieuChuong++;
            this.lblDemTaiLieuChuong.Text = "(" + demTaiLieuChuong + ")";*/
        }

        private void timerHieuUngDropDown_Tick(object sender, EventArgs e)
        {
            if (this.pnlChuongComponent.Controls.Count <= 0) return;
            if (isExpanded)
            {
                while (this.Height != 65)
                    this.Height -= 5;
                isExpanded = false;
                btnMoRong.Text = "▼";
                timerHieuUngDropDown.Stop();
            }
            else
            {
                while (this.Height != 250)
                    this.Height += 5;
                isExpanded = true;
                btnMoRong.Text = "▲";
                timerHieuUngDropDown.Stop();
            }        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Xác nhận xóa chương?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ds == DialogResult.Yes)
            {
                if (chuongBUS.XoaChuong(chuong))
                {
                    this.Khfrm.PnlChuongContainer.Controls.Remove(this);
                    MessageBox.Show("Xóa chương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa chương thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new ThemChuongFrm(chuong).ShowDialog();
            this.Khfrm.HienThiDanhSachChuong();
        }
    }
}
