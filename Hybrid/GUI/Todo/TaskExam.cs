using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.KiemTra;
using Hybrid.GUI.Kiemtra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Todo
{
    public partial class TaskExam : UserControl
    {
        private DeKiemTra dkt;
        private BailamKiemtraBUS blktBUS;
        private Taikhoan taikhoan;
        private LopHoc lh;
        private Chuong chuong;
        public TaskExam()
        {
            InitializeComponent();
        }

        public TaskExam(Taikhoan taikhoan, DeKiemTra dkt, LopHoc lh, Chuong chuong)
        {
            InitializeComponent();
            this.dkt = dkt;
            this.taikhoan = taikhoan;
            this.lh = lh;
            this.chuong = chuong;
            blktBUS = new BailamKiemtraBUS();
            loadTaskExam();
        }
        public Label getLabelClass()
        {
            return this.lblClass;
        }

        public void loadTaskExam()
        {
            this.lblExamTitle.Text = this.dkt.Tieude;
            this.lblStart.Text = "Bắt đầu:"  + dkt.Thoigianbatdau.ToString();
            this.lblEnd.Text = "Kết thúc:"+dkt.Thoigianketthuc.ToString();
            if(dkt.Daxoa==1)
                this.btnDoExam.Visible= false;
            else
                this.btnDoExam.Visible = true;
        }

        private void btnDoExam_Click(object sender, EventArgs e)
        {
            if (!this.lh.Magiangvien.Equals(this.taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.dkt.Thoigianbatdau)
                {
                    MessageBox.Show("Bài kiểm tra chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited
                if (blktBUS.isSubmited(this.taikhoan.Mataikhoan, this.dkt.Madekiemtra) == 1)
                {
                    // TODO: mở form xem bài đã làm
                    DialogResult isConfirmSubmited = MessageBox.Show("Bạn đã hoàn thành bài kiểm tra !\nXem lại bài đã nộp ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isConfirmSubmited == DialogResult.No) return;

                    XemBaiLamHocSinh frmBailam = new XemBaiLamHocSinh(this.taikhoan, this.dkt, false);
                    frmBailam.Show();
                    return;
                }
                if (this.dkt.Thoigianketthuc < DateTime.Now)
                {
                    MessageBox.Show("Bài kiểm tra đã kết thúc !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // do exam
                DialogResult isConfirmDoExam = MessageBox.Show("Xác nhận tiến hành làm bài kiểm tra ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isConfirmDoExam == DialogResult.No) return;
                LamKiemTra bailamkiemtra = new LamKiemTra(this.dkt, this.taikhoan, this.blktBUS);
                bailamkiemtra.Show();
            }
            else
            {
                XemTienDoBaiKiemTra checkingFrm = new XemTienDoBaiKiemTra(this.taikhoan, this.dkt, this.lh, this.chuong);
                checkingFrm.Show();
            }
        }
    }
}
