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
    public partial class PanelChiTietCauTraLoi : UserControl
    {
        CauTraLoi cautraloi;
        public PanelChiTietCauTraLoi()
        {
            InitializeComponent();
        }

        public PanelChiTietCauTraLoi(CauTraLoi cautraloi)
        {
            InitializeComponent();
            this.cautraloi = cautraloi;
            this.rtbCauTraLoi.Text = cautraloi.Noidung;
            this.chkLaDapAn.Checked = cautraloi.Ladapan == 1;
        }

        public CauTraLoi Cautraloi { get => cautraloi; set => cautraloi = value; }

        /*private void chkLaDapAn_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkLaDapAn.Checked)
                this.cautraloi.Ladapan = 1;
            else
                this.cautraloi.Ladapan = 0;
        }*/
    }
}
