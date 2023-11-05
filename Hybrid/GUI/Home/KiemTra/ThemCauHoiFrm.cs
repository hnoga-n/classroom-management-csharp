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
    public partial class ThemCauHoiFrm : Form
    {
        KiemTraFrm kiemTraFrm;
        LopHocBUS lophocBUS = new LopHocBUS();
        CauHoiBUS cauhoiBUS = new CauHoiBUS();
        CauTraLoiBUS cautraloiBUS = new CauTraLoiBUS();

        public ThemCauHoiFrm(KiemTraFrm kiemTraFrm)
        {
            InitializeComponent();
            InitPanelCauTraLoiContainer();
            this.kiemTraFrm = kiemTraFrm;
        }
        
        private void InitPanelCauTraLoiContainer()
        {
            for(char c = 'A'; c <= 'D'; c++) {
                PanelChiTietCauTraLoi pnl = new PanelChiTietCauTraLoi();
                pnl.LblKyTu.Text = c.ToString();
                pnl.ChkLaDapAn.CheckedChanged += new EventHandler(this.ChkLaDapAnCheckedChanged);
                this.pnlCauTraLoiContainer.Controls.Add(pnl);
            }
        }

        private void ChkLaDapAnCheckedChanged(object sender, EventArgs e)
        {
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (pnl.ChkLaDapAn != sender)
                {
                    pnl.ChkLaDapAn.Checked = false;
                }
            }
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            if(rtbNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbNoiDung.Focus();
                return;
            }
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (pnl.RtbCauTraLoi.Text == "")
                {
                    MessageBox.Show("Nội dung câu trả lời không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnl.RtbCauTraLoi.Focus();
                    return;
                }
            }
            bool flagKiemTraChonDapAn = true;
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (!pnl.ChkLaDapAn.Checked)
                    flagKiemTraChonDapAn = false;
                else
                {
                    flagKiemTraChonDapAn = true;
                    break;
                }
            }
            if(!flagKiemTraChonDapAn)
            {
                MessageBox.Show("Vui lòng chọn một câu trả lời là đáp án đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CauHoi cauhoi = new CauHoi(Guid.NewGuid().ToString(), rtbNoiDung.Text, rtbGiaiThich.Text, lophocBUS.GetLopHocByMaLop(kiemTraFrm.Chuong.Malop).Magiangvien,1);
            if(cauhoiBUS.ThemCauHoi(cauhoi))
            {
                int ladapan;
                foreach(PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
                {
                    if (!pnl.ChkLaDapAn.Checked)
                        ladapan = 0;
                    else
                        ladapan = 1;
                    CauTraLoi cautraloi = new CauTraLoi(Guid.NewGuid().ToString(), pnl.RtbCauTraLoi.Text,ladapan, cauhoi.Macauhoi);
                    cautraloiBUS.ThemCauTraLoi(cautraloi);
                }
                ButtonCauHoi btnCauHoi = new ButtonCauHoi(cauhoi,this.kiemTraFrm);
                kiemTraFrm.PnlCauHoiContainer.Controls.Add(btnCauHoi);
                MessageBox.Show("Thêm câu hỏi thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Thêm câu hỏi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
