using Hybrid.BUS;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra.KiemTraComponents
{
    public partial class PanelChiTietCauHoi : UserControl
    {
        CauHoi cauhoi;
        CauTraLoiBUS cautraloiBUS = new CauTraLoiBUS();
        public PanelChiTietCauHoi(CauHoi cauhoi)
        {
            InitializeComponent();
            this.cauhoi = cauhoi;
            HienThiChiTietCauHoi();
        }

        public void HienThiChiTietCauHoi()
        {
            this.lblNoiDung.Text = cauhoi.Noidung;
            char kytu = 'A';
            string dapandung = "";
            foreach (CauTraLoi cautraloi in cautraloiBUS.GetDanhSachCauTraLoiByMaCauHoi(this.cauhoi.Macauhoi))
            {
                Label lblctl = new Label();
                lblctl.BackColor = System.Drawing.Color.White;
                lblctl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                if (cautraloi.Ladapan == 1)
                {
                    lblctl.ForeColor = System.Drawing.Color.FromArgb(0,146,101);
                    dapandung = kytu.ToString();
                }
                else
                    lblctl.ForeColor = System.Drawing.Color.Black;
                lblctl.Location = new System.Drawing.Point(33, 0);
                lblctl.MaximumSize = new System.Drawing.Size(600, 100);
                lblctl.Size = new System.Drawing.Size(426, 50);
                lblctl.TabIndex = 14;
                lblctl.Text = kytu.ToString() + ". " + cautraloi.Noidung;
                lblctl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblctl.AutoSize = false;
                this.pnlChiTietCauHoiContainer.Controls.Add(lblctl);
                kytu++;
            }
            this.lblDapAnDung.Text = "Đáp án đúng: " + dapandung;
        }
    }
}
