using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class ButtonClass : UserControl
    {
        LopHoc lophoc;
        HomeFrm homeFrm;
        public ButtonClass(LopHoc lophoc,HomeFrm homeFrm)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            this.homeFrm = homeFrm;
            this.lblTenLop.Text = lophoc.Tenlop;
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            if (this.homeFrm.PnlGiaoDienLopHocContainer.Controls.Count > 0)
                this.homeFrm.PnlGiaoDienLopHocContainer.Controls.RemoveAt(0);
            PanelGiaoDienLopHoc panelGDLH = new PanelGiaoDienLopHoc(this.lophoc,homeFrm.Tk);
            this.homeFrm.PnlGiaoDienLopHocContainer.Controls.Add(panelGDLH);
            panelGDLH.Dock = DockStyle.Fill;
        }
    }
}
