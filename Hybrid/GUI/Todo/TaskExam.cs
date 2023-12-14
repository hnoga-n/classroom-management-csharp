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

        public TaskExam(Taikhoan taikhoan, DeKiemTra dkt, LopHoc lh, Chuong chuong,BailamKiemtraBUS blktBUS)
        {
            InitializeComponent();
            this.Dkt = dkt;
            this.Taikhoan = taikhoan;
            this.Lh = lh;
            this.Chuong = chuong;
            BlktBUS = blktBUS;
            loadTaskExam();
        }

        public DeKiemTra Dkt { get => dkt; set => dkt = value; }
        public BailamKiemtraBUS BlktBUS { get => blktBUS; set => blktBUS = value; }
        public Taikhoan Taikhoan { get => taikhoan; set => taikhoan = value; }
        public LopHoc Lh { get => lh; set => lh = value; }
        public Chuong Chuong { get => chuong; set => chuong = value; }

        public Label getLabelClass()
        {
            return this.lblClass;
        }

        public void loadTaskExam()
        {
            this.lblExamTitle.Text = this.Dkt.Tieude;
            this.lblStart.Text = "Bắt đầu:"  + Dkt.Thoigianbatdau.ToString();
            this.lblEnd.Text = "Kết thúc:"+Dkt.Thoigianketthuc.ToString();
            if(Dkt.Daxoa==1)
                this.btnDoExam.Visible= false;
            else
                this.btnDoExam.Visible = true;

            if (this.lh.Magiangvien.Equals(this.taikhoan.Mataikhoan))
            {
                this.btnDoExam.Text = "Xem tiến độ";
            }else if(BlktBUS.isSubmited(this.Taikhoan.Mataikhoan, this.Dkt.Madekiemtra) == 1)
            {
                this.btnDoExam.Text = "Xem bài làm";
            }else
            {
                this.btnDoExam.Text = "Làm kiểm tra";
            }

        }

        private void btnDoExam_Click(object sender, EventArgs e)
        {
            if (!this.Lh.Magiangvien.Equals(this.Taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.Dkt.Thoigianbatdau)
                {
                    MessageBox.Show("Bài kiểm tra chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited
                if (BlktBUS.isSubmited(this.Taikhoan.Mataikhoan, this.Dkt.Madekiemtra) == 1)
                {
                    XemBaiLamHocSinh frmBailam = new XemBaiLamHocSinh(this.Taikhoan, this.Dkt, false);
                    frmBailam.Show();
                    return;
                }
                LamKiemTra bailamkiemtra = new LamKiemTra(this.Dkt, this.Taikhoan, this.BlktBUS);
                bailamkiemtra.Show();
            }
            else
            {
                XemTienDoBaiKiemTra checkingFrm = new XemTienDoBaiKiemTra(this.Taikhoan, this.Dkt, this.Lh, this.Chuong);
                checkingFrm.Show();
            }
        }
    }
}
