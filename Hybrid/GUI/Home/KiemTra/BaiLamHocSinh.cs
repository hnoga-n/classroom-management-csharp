using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Kiemtra;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class BaiLamHocSinh : Form
    {
        private Taikhoan taikhoanhienhanh;
        private DeKiemTra dekiemtra;
        private BaiLamKiemTra blkt;
        private BailamKiemtraBUS blktBUS;
        private ChiTietBaiLamKiemTraBUS ctblktBUS;
        private CauHoiBUS chBUS;
        private CauTraLoiBUS ctlBUS;
        public BaiLamHocSinh()
        {
            InitializeComponent();
        }
        public BaiLamHocSinh(Taikhoan taikhoanhienhanh, DeKiemTra dkt)
        {
            InitializeComponent();
            loading.ShowSplashScreen();
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.dekiemtra = dkt;
            this.blktBUS = new BailamKiemtraBUS();
            int index = blktBUS.getBaiLamKiemTraWithMaTaiKhoanAndMaDeKiemTra(taikhoanhienhanh.Mataikhoan, dekiemtra.Madekiemtra);
            this.blkt = (BaiLamKiemTra)blktBUS.List[index];
            this.ctblktBUS = new ChiTietBaiLamKiemTraBUS();
            this.chBUS = new CauHoiBUS();
            this.ctlBUS = new CauTraLoiBUS();
            loadDataIntoForm();
            loading.CloseForm();
        }

        private void loadDataIntoForm()
        {
            ArrayList listctblkt = this.ctblktBUS.getChiTietBaiLamKiemTraWithMaBaiLam(this.blkt.Mabailam);
            ArrayList listcautraloi;
            if (listctblkt.Count <= 0)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải đề kiểm tra!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            listcauhoipanel.SuspendLayout();
            listcauhoipanel.Controls.Clear();
            int index = 0;
            foreach (ChiTietBaiLamKiemTra ctblkt in listctblkt)
            {
                //cauhoi
                CauHoi tmp = this.chBUS.getCauhoiWithMaCauHoi(ctblkt.Macauhoi);
                listcautraloi = this.ctlBUS.getCauTraLoiWithMaCauHoi(tmp.Macauhoi);
                CauhoiPanel chComponent = new CauhoiPanel(tmp, listcautraloi, ctblkt.Dapanchon, (dekiemtra.Xemdapan == 1));
                chComponent.getOrder().Text = "Câu hỏi " + (++index);
                listcauhoipanel.Controls.Add(chComponent);

                // button navigate
                CauhoiNavigate btnNav = new CauhoiNavigate();
                btnNav.getButtonNav().Text = index.ToString();
                btnNav.getButtonNav().Click += new System.EventHandler(this.btnNavigate_Cliked);
                navigatePanel.Controls.Add(btnNav);
            }
            listcauhoipanel.ResumeLayout();
            listcauhoipanel.Refresh();
            this.lblNumberQuestion.Text = "/"+listctblkt.Count.ToString();
            this.lblTitleExam.Text = this.dekiemtra.Tieude;
            this.rightAnswer.Text = this.blkt.Socaudung.ToString();
            this.timeSubmit.Text = this.blkt.Thoigiannop.ToString();
            this.score.Text = this.blkt.Diem.ToString();
            this.studentName.Text = this.taikhoanhienhanh.Hoten;
            this.timeSubmit.Text = "Nộp vào: " + this.blkt.Thoigiannop.ToString();
        }

        public void btnNavigate_Cliked(object sender, EventArgs e)
        {
            int targetChildIndex;
            int.TryParse((sender as KryptonButton).Text, out targetChildIndex);

            if (targetChildIndex >= 0 && targetChildIndex < navigatePanel.Controls.Count)
            {
                Control targetControl = listcauhoipanel.Controls[targetChildIndex - 1];
                // Calculate the scroll position
                int scrollX = targetControl.Left - listcauhoipanel.AutoScrollPosition.X;
                int scrollY = targetControl.Top - listcauhoipanel.AutoScrollPosition.Y;

                // Set the AutoScrollPosition to scroll to the desired position
                listcauhoipanel.AutoScrollPosition = new Point(scrollX, scrollY);
            }
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
