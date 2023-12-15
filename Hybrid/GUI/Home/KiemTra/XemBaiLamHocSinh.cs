using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Kiemtra;
using Hybrid.GUI.Utilities;
using ServiceStack;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class XemBaiLamHocSinh : Form
    {
        private Taikhoan taikhoanhienhanh;
        private DeKiemTra dekiemtra;
        private BaiLamKiemTra blkt;
        private BailamKiemtraBUS blktBUS;
        private ChiTietBaiLamKiemTraBUS ctblktBUS;
        private CauHoiBUS chBUS;
        private CauTraLoiBUS ctlBUS;
        private bool isTeacher;
        public XemBaiLamHocSinh()
        {
            InitializeComponent();
        }
        public XemBaiLamHocSinh(Taikhoan taikhoanhienhanh, DeKiemTra dkt, bool isTeacher)
        {
            InitializeComponent();
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.dekiemtra = dkt;
            this.isTeacher = isTeacher;
        }

        private void XemBaiLamHocSinh_Load(object sender, EventArgs e)
        {
            this.blktBUS = new BailamKiemtraBUS();
            int index = blktBUS.getBaiLamKiemTraWithMaTaiKhoanAndMaDeKiemTra(taikhoanhienhanh.Mataikhoan, dekiemtra.Madekiemtra);
            this.blkt = (BaiLamKiemTra)blktBUS.List[index];
            this.ctblktBUS = new ChiTietBaiLamKiemTraBUS();
            this.chBUS = new CauHoiBUS();
            this.ctlBUS = new CauTraLoiBUS();
            loadDataIntoForm();
            
        }
        private void loadDataIntoForm()
        {
            ArrayList listctblkt = this.ctblktBUS.GetChiTietBaiLamKiemTraWithMaBaiLam(this.blkt.Mabailam);
            ArrayList listcautraloi;
            if (listctblkt.Count <= 0)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải đề kiểm tra!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            listcauhoipanel.Controls.Clear();
            int index = 0;
            foreach (ChiTietBaiLamKiemTra ctblkt in listctblkt)
            {
                //cauhoi
                CauHoi tmp = this.chBUS.getCauhoiWithMaCauHoi(ctblkt.Macauhoi);
                listcautraloi = this.ctlBUS.getCauTraLoiWithMaCauHoi(tmp.Macauhoi);
                CauhoiPanel chComponent = new CauhoiPanel(tmp, listcautraloi, ctblkt.Dapanchon, true, (this.dekiemtra.Xemdapan) == 1);
                chComponent.getOrder().Text = "Câu hỏi " + (++index);
                listcauhoipanel.Controls.Add(chComponent);

                // button navigate
                CauhoiNavigate btnNav = new CauhoiNavigate();
                btnNav.getButtonNav().Text = index.ToString();
                btnNav.getButtonNav().Click += new System.EventHandler(this.btnNavigate_Cliked);
                navigatePanel.Controls.Add(btnNav);
            }
            listcauhoipanel.Refresh();
            this.lblNumberQuestion.Text = "/" + listctblkt.Count.ToString();
            this.lblTitleExam.Text = this.dekiemtra.Tieude;
            this.timeSubmit.Text = this.blkt.Thoigiannop.ToString("dd/MM/yyyy HH:mm:ss");
            if (this.isTeacher || this.dekiemtra.Xemdapan == 1)
            {
                this.rightAnswer.Text = this.blkt.Socaudung.ToString();
                this.score.Text = this.blkt.Diem.ToString();
                if (Convert.ToDouble(score.Text) > 5)
                {
                    this.score.ForeColor = System.Drawing.Color.Green;
                    this.rightAnswer.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    this.score.ForeColor = System.Drawing.Color.Red;
                    this.rightAnswer.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                this.rightAnswer.Text ="--";
                this.score.Text ="--";
            }
            
            this.studentName.Text = this.taikhoanhienhanh.Hoten;
            this.timeSubmit.Text = "Nộp vào: " + this.blkt.Thoigiannop.ToString();
            if (this.blkt.Noptre == 1)
            {
                this.state.Text = "Nộp trễ";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.state.Text = "Nộp đúng hạn";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Green;
            }
            System.Resources.ResourceManager rm = global::Hybrid.Properties.Resources.ResourceManager;
            this.avatar.BackgroundImage = (Image)rm.GetObject(this.taikhoanhienhanh.Anhdaidien);
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

    }
}
