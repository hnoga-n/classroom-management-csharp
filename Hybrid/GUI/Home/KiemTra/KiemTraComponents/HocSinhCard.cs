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
        public HocSinhCard()
        {
            InitializeComponent();
        }
        public HocSinhCard(Taikhoan hs,DeKiemTra dkt,bool daNop,BailamKiemtraBUS blktBUS)
        {
            InitializeComponent();
            this.hocsinh = hs;
            this.dekiemtra = dkt;
            this.daNop = daNop;
            if (daNop)
            {
                int indexBaiLam = blktBUS.getBaiLamKiemTraWithMaTaiKhoanAndMaDeKiemTra(this.hocsinh.Mataikhoan, dekiemtra.Madekiemtra);
                this.lblSubmitAt.Text = "Nộp vào " + (blktBUS.List[indexBaiLam] as BaiLamKiemTra).Thoigiannop.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
                this.lblSubmitAt.Text = "Chưa nộp";
            loadDataIntoForm();
        }

        private void loadDataIntoForm()
        {
            this.Name.Text = this.hocsinh.Hoten;
            System.Resources.ResourceManager rm = global::Hybrid.Properties.Resources.ResourceManager;
            this.avatar.BackgroundImage = (Image)rm.GetObject(this.hocsinh.Anhdaidien);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (daNop)
                {
                    loading.ShowSplashScreen();
                    XemBaiLamHocSinh bailamhocsinhFrm = new XemBaiLamHocSinh(this.hocsinh, this.dekiemtra,true);
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
