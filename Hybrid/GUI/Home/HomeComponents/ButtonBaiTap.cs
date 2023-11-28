using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Baitap;
using Hybrid.GUI.Baitap.Hocsinh;
using Hybrid.GUI.Baitap.Hocvien;
using System;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.HomeComponents
{
    public partial class ButtonBaiTap : UserControl
    {
        PanelChuongDropDown panelChuong;
        private BaiTap baitap;
        private BailambaitapBUS blbtBUS;
        public ButtonBaiTap(PanelChuongDropDown panelChuong, BaiTap bt)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.baitap = bt;
            this.blbtBUS = new BailambaitapBUS();
            this.lblTieuDeBT.Text = bt.Tieude;
            //this.lblChiTietBT.Text = bt.Thoihan.ToString();
            if (panelChuong.Khfrm.Lophoc.Daxoa == 1)
            {
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panelChuong.XoaChuongComponent(this);
        }

        private void btnBaiTap_Click(object sender, EventArgs e)
        {
            if (!panelChuong.Khfrm.Lophoc.Magiangvien.Equals(panelChuong.Khfrm.Taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.baitap.Thoigianbatdau)
                {
                    MessageBox.Show("Bài tập chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited

                int index = blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(this.panelChuong.Khfrm.Taikhoan.Mataikhoan, this.baitap.Mabaitap);
                if (index >=0)
                {
                    DialogResult isConfirmSubmited = MessageBox.Show("Bạn đã hoàn thành bài tập !\nXem lại bài đã nộp ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isConfirmSubmited == DialogResult.No) return;

                    XemBaiLamBaiTap blbtFrm = new XemBaiLamBaiTap(this.panelChuong.Khfrm.Taikhoan, this.baitap, (BaiLamBaiTap) this.blbtBUS.List[index]);
                    blbtFrm.Show();
                    return;
                }
                // do exam
                DialogResult isConfirmDoExam = MessageBox.Show("Tiến hành làm bài tập ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isConfirmDoExam == DialogResult.No) return;
                LamBaiTap lambaitapFrm = new LamBaiTap(this.panelChuong.Khfrm.Taikhoan,this.panelChuong.Chuong,this.baitap);
                lambaitapFrm.Show();
                return;
            }
            else // teacher
            {
                XemTienDoBaitap xemtiendoFrm = new XemTienDoBaitap(this.baitap,this.panelChuong.Khfrm.Lophoc,this.panelChuong.Chuong);
                xemtiendoFrm.Show();
            }
            blbtBUS.loadList();
                return;
        }
    }
}
