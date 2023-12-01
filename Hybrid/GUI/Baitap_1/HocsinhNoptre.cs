using Hybrid.DTO;
using Hybrid.GUI.Baitap.Hocvien;
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

namespace Hybrid.GUI.Baitap
{
    public partial class HocsinhNoptre : UserControl
    {
        private Taikhoan taikhoan;
        private BaiTap baitap;
        private bool dachamdiem;
        private BaiLamBaiTap blbt;
        public HocsinhNoptre()
        {
            InitializeComponent();
        }
        public HocsinhNoptre(Taikhoan hocsinh)
        {
            InitializeComponent();
            this.taikhoan = hocsinh;
            this.lblHoten.Text = taikhoan.Hoten;
            this.btnChamDiem.Visible = false;
            this.lblState.Text = "Chưa nộp";
        }
        public HocsinhNoptre(Taikhoan hocsinh, bool dacham,BaiTap bt, BaiLamBaiTap blbt)
        {
            InitializeComponent();
            this.taikhoan = hocsinh;
            this.dachamdiem = dacham;
            this.blbt = blbt;   
            this.baitap = bt;   
            this.lblHoten.Text = hocsinh.Hoten;
            this.lblState.Text = "Nộp vào " + blbt.Thoigiannopbai;
            this.btnChamDiem.Visible = !dacham;
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            if(blbt==null) {
                MessageBox.Show("Học sinh chưa nộp bài tập !","Thông báo",MessageBoxButtons.OK);
                return;
            }else if (blbt.Diem != -1)
            {
                loading.ShowSplashScreen();
                XemBaiLamBaiTap xembailamFrm = new XemBaiLamBaiTap(this.taikhoan,this.baitap,this.blbt);
                loading.CloseForm();
                xembailamFrm.Show();
            }
        }

        private void btnChamDiem_Click(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            ChamDiem chamdiemFrm = new ChamDiem(this.taikhoan,this.baitap,this.blbt);
            loading.CloseForm();
            chamdiemFrm.Show();
        }
    }
}
