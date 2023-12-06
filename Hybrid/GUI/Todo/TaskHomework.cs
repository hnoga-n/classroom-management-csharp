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
        public TaskHomework( )
        {
            InitializeComponent();
        }

        public TaskHomework(Taikhoan taikhoan, BaiTap baitap,LopHoc lh,Chuong chuong)
        {
            InitializeComponent();
            this.baitap = baitap;
            this.taikhoan = taikhoan;
            this.lh =  lh;
            this.chuong = chuong;   
            blbtBUS = new BailambaitapBUS();
            loadBaitap();
        }
        private void loadBaitap()
        {
            this.lblTitle.Text = baitap.Tieude;
            this.lblDeadline.Text = "Từ" + baitap.Thoigianbatdau.ToString() + "đến:" + baitap.Thoigianketthuc.ToString();
        }

        private void baitapnDoHomework_Click(object sender, EventArgs e)
        {
            if (!this.lh.Magiangvien.Equals(this.taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.baitap.Thoigianbatdau)
                {
                    MessageBox.Show("Bài tập chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited

                int index = blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(this.taikhoan.Mataikhoan, this.baitap.Mabaitap);
                if (index >= 0)
                {
                    DialogResult isConfirmSubmited = MessageBox.Show("Bạn đã hoàn thành bài tập !\nXem lại bài đã nộp ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isConfirmSubmited == DialogResult.No) return;

                    XemBaiLamBaiTap blbtFrm = new XemBaiLamBaiTap(this.taikhoan, this.baitap, (BaiLamBaiTap)this.blbtBUS.List[index]);
                    blbtFrm.Show();
                    return;
                }
                // do exam
                DialogResult isConfirmDoExam = MessageBox.Show("Tiến hành làm bài tập ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isConfirmDoExam == DialogResult.No) return;
                LamBaiTap lambaitapFrm = new LamBaiTap(this.taikhoan, this.chuong, this.baitap, this.blbtBUS);
                lambaitapFrm.Show();
                return;
            }
            else // teacher
            {
                XemTienDoBaitap xemtiendoFrm = new XemTienDoBaitap(this.baitap, this.lh, this.chuong);
                xemtiendoFrm.Show();
            }
            return;
        }
    }
}
