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
    public partial class PanelGiaoDienLopHoc : UserControl
    {
        LopHoc lophoc;
        public PanelGiaoDienLopHoc(LopHoc lophoc)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            this.lblTenLop.Text = lophoc.Tenlop;
        }

        private void addFormtoPanelHomeContainer(object Form)
        {
            if (this.pnlHomeContainer.Controls.Count > 0)
                this.pnlHomeContainer.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlHomeContainer.Controls.Add(f);
            this.pnlHomeContainer.Tag = f;
            f.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new ChatFrm());
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new KhoaHocFrm(this.lophoc));
        }

        private void btnThanhTich_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new ThanhTichFrm());
        }

        private void btnTep_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new TepFrm());
        }

    }
}
