using ComponentFactory.Krypton.Toolkit;
using Hybrid.DTO;
using Hybrid.GUI.ChatBox;
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
        HomeFrm homefrm;
        Taikhoan taikhoan;

        public HomeFrm Homefrm { get => homefrm; set => homefrm = value; }
        public LopHoc Lophoc { get => lophoc; set => lophoc = value; }

        public PanelGiaoDienLopHoc(LopHoc lophoc,HomeFrm homefrm)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            this.homefrm = homefrm;
            this.taikhoan = homefrm.Tk;
            this.lblTenLop.Text = lophoc.Tenlop;
            this.homefrm = homefrm;
            if (lophoc.Daxoa == 1)
                this.btnChinhSuaLopHoc.Visible = false;
            btnChat_Click(this, EventArgs.Empty);
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
            addFormtoPanelHomeContainer(new ChatBoxFrm());
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new KhoaHocFrm(this.lophoc,taikhoan));
        }

        private void btnThanhTich_Click(object sender, EventArgs e)
        {
            if(lophoc.Magiangvien.Equals(taikhoan.Mataikhoan))
                addFormtoPanelHomeContainer(new ThanhTichFrm_GV(this.lophoc));
            else
                addFormtoPanelHomeContainer(new ThanhTichFrm_HS(this.lophoc, this.taikhoan));
        }

        private void btnTep_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new TepFrm());
        }

        private void btnChinhSuaLopHoc_Click(object sender, EventArgs e)
        {
            new ThongTinLopHocFrm(taikhoan,this).ShowDialog();
        }


    }
}
