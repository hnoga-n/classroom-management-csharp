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

namespace Hybrid.GUI.Home.HomeComponents
{
    public partial class ButtonBaiTap : UserControl
    {
        PanelChuongDropDown panelChuong;
        public ButtonBaiTap(PanelChuongDropDown panelChuong,BaiTap bt)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.lblTieuDeBT.Text = bt.Tieude;
            this.lblChiTietBT.Text = bt.Thoihan.ToString();
            if (panelChuong.Khfrm.Lophoc.Daxoa == 1)
            {
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panelChuong.XoaChuongComponent(this);
        }
    }
}
