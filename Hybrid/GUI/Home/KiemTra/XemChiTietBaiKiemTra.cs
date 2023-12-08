using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Kiemtra;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class XemBaiKiemTra : Form
    {
        private DeKiemTra dkt;
        private ChiTietDeKiemTraBUS ctbktBUS;
        private CauHoiBUS chBUS;
        private CauTraLoiBUS ctlBUS;
        public XemBaiKiemTra()
        {
            InitializeComponent();
        }
        public XemBaiKiemTra(DeKiemTra dkt, CauHoiBUS chBUS, CauTraLoiBUS ctlBUS)
        {
            InitializeComponent();
            this.dkt = dkt;
            this.chBUS = chBUS;
            this.ctlBUS = ctlBUS;
            this.ctbktBUS = new ChiTietDeKiemTraBUS();
            loadDataIntoForm();
        }
        private void loadDataIntoForm()
        {
            ArrayList listmacauhoi = this.ctbktBUS.GetDanhSachChiTietDeKiemTraWithMaDeKiemTra(this.dkt.Madekiemtra.ToLower());
            ArrayList listcautraloi;
            if (listmacauhoi.Count <= 0)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải đề kiểm tra!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            listcauhoipanel.Controls.Clear();
            int index = 0;
            foreach (ChiTietDeKiemTra ctdkt in listmacauhoi)
            {
                //cauhoi
                CauHoi tmp = this.chBUS.getCauhoiWithMaCauHoi(ctdkt.Macauhoi);
                listcautraloi = this.ctlBUS.getCauTraLoiWithMaCauHoi(tmp.Macauhoi);
                CauhoiPanel chComponent = new CauhoiPanel(tmp, listcautraloi);
                chComponent.getOrder().Text = "Câu hỏi " + (++index);
                listcauhoipanel.Controls.Add(chComponent);

                // button navigate
                CauhoiNavigate btnNav = new CauhoiNavigate();
                btnNav.getButtonNav().Text = index.ToString();
                btnNav.getButtonNav().Click += new System.EventHandler(this.btnNavigate_Cliked);
                navigatePanel.Controls.Add(btnNav);
            }
            listcauhoipanel.Refresh();
            this.lblNumberQuestion.Text = listmacauhoi.Count.ToString();
            this.lblTitleExam.Text = dkt.Tieude;
            this.timeStart.Text = dkt.Thoigianbatdau.ToString("dd/MM/yyyy HH:mm:ss");
            this.timeEnd.Text = dkt.Thoigianketthuc.ToString("dd/MM/yyyy HH:mm:ss");

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
