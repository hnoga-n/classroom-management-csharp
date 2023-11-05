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
    public partial class ButtonBaiKT : UserControl
    {
        PanelChuongDropDown panelChuong;
        public ButtonBaiKT(PanelChuongDropDown panelChuong)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panelChuong.XoaChuongComponent(this);
        }
    }
}
