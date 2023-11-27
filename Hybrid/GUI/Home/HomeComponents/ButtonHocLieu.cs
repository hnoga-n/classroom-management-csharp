using Hybrid.GUI.Baitap.Giaovien;
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
        public ButtonHocLieu(PanelChuongDropDown panelChuong)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panelChuong.XoaChuongComponent(this);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
