using Hybrid.DTO;
using Hybrid.GUI.Baitap.Hocsinh;
using Hybrid.GUI.Baitap.Hocvien;
using Hybrid.GUI.Baitap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrid.BUS;

namespace Hybrid.GUI.Todo
{
    public partial class TaskHomework : UserControl
    {
        private BaiTap baitap;
        private BailambaitapBUS blbtBUS;
        private Taikhoan taikhoan;
        private LopHoc lh;
        private Chuong chuong;

        public Taikhoan Taikhoan { get => taikhoan; set => taikhoan = value; }
        public LopHoc Lh { get => lh; set => lh = value; }
        public Chuong Chuong { get => chuong; set => chuong = value; }

        public TaskHomework( )
        {
            InitializeComponent();
        }

        public TaskHomework(Taikhoan taikhoan, BaiTap baitap,LopHoc lh,Chuong chuong,BailambaitapBUS blbtBUS)
        {
            InitializeComponent();
            this.baitap = baitap;
            this.Taikhoan = taikhoan;
            this.Lh =  lh;
            this.Chuong = chuong;   
            this.blbtBUS = blbtBUS;
            loadBaitap();
        }
        private void loadBaitap()
        {
            this.lblTitle.Text = baitap.Tieude;
            this.lblDeadline.Text = "Từ" + baitap.Thoigianbatdau.ToString() + "đến:" + baitap.Thoigianketthuc.ToString();
            this.btnDoHomework.Text = (this.lh.Magiangvien.Equals(this.taikhoan.Mataikhoan)) ? "Xem tiến độ" : "Làm bài tập";
            int index = blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(this.Taikhoan.Mataikhoan, this.baitap.Mabaitap);
            if (index >= 0)
                this.btnDoHomework.Text = "Xem bài làm";
            this.lophoc.Text = "Lớp học:"+lh.Tenlop;
        }

        private void baitapnDoHomework_Click(object sender, EventArgs e)
        {
            if (!this.Lh.Magiangvien.Equals(this.Taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.baitap.Thoigianbatdau)
                {
                    MessageBox.Show("Bài tập chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited

                int index = blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(this.Taikhoan.Mataikhoan, this.baitap.Mabaitap);
                if (index >= 0)
                {
                    XemBaiLamBaiTap blbtFrm = new XemBaiLamBaiTap(this.Taikhoan, this.baitap, (BaiLamBaiTap)this.blbtBUS.List[index]);
                    blbtFrm.Show();
                    return;
                }
                if (this.baitap.Thoigianketthuc < DateTime.Now)
                {
                    if (this.baitap.Nopbu == 1)
                    {
                        DialogResult confirmLamBu = MessageBox.Show("Tiến hành làm bài tập bù ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmLamBu == DialogResult.No) return;
                        LamBaiTap lambaitapbuFrm = new LamBaiTap(this.Taikhoan, this.baitap, this.blbtBUS);
                        lambaitapbuFrm.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bài tập đã kết thúc ! Không chấp nhận nộp bù !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                // do exam
                DialogResult isConfirmDoExam = MessageBox.Show("Tiến hành làm bài tập ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isConfirmDoExam == DialogResult.No) return;
                LamBaiTap lambaitapFrm = new LamBaiTap(this.Taikhoan, this.baitap, this.blbtBUS);
                lambaitapFrm.Show();
                return;
            }
            else // teacher
            {
                XemTienDoBaitap xemtiendoFrm = new XemTienDoBaitap(this.baitap, this.Lh, this.Chuong);
                xemtiendoFrm.Show();
            }
            return;
        }
    }
}
