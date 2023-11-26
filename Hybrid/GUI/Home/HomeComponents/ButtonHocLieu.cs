using Hybrid.DTO;
using Hybrid.GUI.Home.Tailieu;
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
    public partial class ButtonHocLieu : UserControl
    {
        PanelChuongDropDown panelChuong;
        HocLieu hoclieu;

        public PanelChuongDropDown PanelChuong { get => panelChuong; set => panelChuong = value; }
        public HocLieu Hoclieu { get => hoclieu; set => hoclieu = value; }

        public ButtonHocLieu(PanelChuongDropDown panelChuong,HocLieu hoclieu)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.hoclieu = hoclieu;
            this.lblTieuDeHocLieu.Text = hoclieu.Tieude;
            this.lblChiTietHocLieu.Text = hoclieu.Thoigiantao.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panelChuong.XoaChuongComponent(this);
        }

        private void btnHocLieu_Click(object sender, EventArgs e)
        {
            Hienthitailieufrm htfrm = new Hienthitailieufrm(this);
            htfrm.ShowDialog();
        }
    }
}
