using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.KiemTra;
using Hybrid.GUI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.HomeComponents
{
    public partial class HocSinhCard : UserControl
    {
        private Taikhoan hocsinh;
        private DeKiemTra dekiemtra;
        private bool daNop;
        private ChiTietBaiLamKiemTraBUS ctblktBUS;
        public HocSinhCard()
        {
            InitializeComponent();
        }
        public HocSinhCard(Taikhoan hs,DeKiemTra dkt,bool daNop )
        {
            InitializeComponent();
            this.hocsinh = hs;
            this.dekiemtra = dkt;
            this.daNop = daNop;
            loadDataIntoForm();
        }

        private void loadDataIntoForm()
        {
            this.Name.Text = this.hocsinh.Hoten;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (daNop)
                {
                    loading.ShowSplashScreen();
                    XemBaiLamHocSinh bailamhocsinhFrm = new XemBaiLamHocSinh(this.hocsinh, this.dekiemtra);
                    loading.CloseForm();
                    bailamhocsinhFrm.Show();
                }
                else
                {
                    MessageBox.Show("Học sinh chưa nộp bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString()); ;
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            btnShow.PerformClick();
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            btnShow.PerformClick();
        }

    }
}
