using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.KiemTra.KiemTraComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class KiemTraFrm : Form
    {
        Chuong chuong;
        CauHoiBUS cauhoiBUS = new CauHoiBUS();
        LopHocBUS lophocBUS = new LopHocBUS();

        public Chuong Chuong { get => chuong; set => chuong = value; }

        public KiemTraFrm(Chuong chuong)
        {
            InitializeComponent();
            this.chuong = chuong;
            HienThiDanhSachCauHoiTheoMaTaiKhoan(lophocBUS.GetLopHocByMaLop(this.chuong.Malop).Magiangvien);
        }

        public void HienThiDanhSachCauHoiTheoMaTaiKhoan(string matk)
        {
            foreach (CauHoi cauhoi in cauhoiBUS.GetDanhSachCauHoiByMaTaiKhoan(matk))
            {
                ButtonCauHoi btnCauHoi = new ButtonCauHoi(cauhoi,this);
                this.pnlCauHoiContainer.Controls.Add(btnCauHoi);
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        { 
             ThemCauHoiFrm newForm = new ThemCauHoiFrm(this);
             newForm.ShowDialog();
        }
    }
}
