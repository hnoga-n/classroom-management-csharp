using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Hybrid.GUI;
using Hybrid.GUI.Danhba;
using Hybrid.GUI.Home;
//using Hybrid.GUI.Todo;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.DTO;
using Hybrid.BUS;
using System.Drawing.Drawing2D;
using Hybrid.GUI.Todo;
using Hybrid.GUI.Utilities;

namespace Hybrid
{
    public partial class Form1 : KryptonForm
    {
        private BaiTapBUS btBUS = new BaiTapBUS();
        private DeKiemTraBUS dktBUS = new DeKiemTraBUS();
        private HocLieuBUS hlBUS ;
        private ChuongBUS chuongBUS ;
        private LopHocBUS lopBUS;
        TaikhoanBUS taikhoanBUS = new TaikhoanBUS();

        private Taikhoan tk ;

        public Taikhoan Tk { get => tk; set => tk = value; }

        public Form1(string email)
        {
            InitializeComponent();
            loading.ShowSplashScreen();
            this.tk = taikhoanBUS.GetTaiKhoanByEmail(email);
            hlBUS = new HocLieuBUS();
            chuongBUS = new ChuongBUS();
            lopBUS = new LopHocBUS();
            loading.CloseForm();
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void addFormtoPanelContainer(object Form)
        {
            if (this.pnlContainer.Controls.Count > 0)
                this.pnlContainer.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Controls.Add(this.btnMinimizeForm);
            f.Controls.Add(this.btnCloseForm);
            this.btnMinimizeForm.BringToFront();
            this.btnCloseForm.BringToFront();
            this.pnlContainer.Controls.Add(f);
            this.pnlContainer.Tag = f;
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Taikhoan tk = taikhoanBUS.GetTaiKhoanByEmail("nguyenhuyhoang@gmail.com");
            addFormtoPanelContainer(new HomeFrm(this));
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new TodoFrm(this.tk,this.btBUS,this.lopBUS,this.dktBUS,this.chuongBUS));
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new DanhbaFrm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHome_Click(this, EventArgs.Empty);
            MakePictureBoxCircular(this.picUserAva);
        }

        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                // Tạo đường dẫn hình tròn
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

                // Gán đường dẫn cho PictureBox
                pictureBox.Region = new Region(path);
            }
        }

        private void picUserAva_Click(object sender, EventArgs e)
        {
            Thongtintaikhoan tt = new Thongtintaikhoan(this.tk,this.picUserAva,this);
            tt.ShowDialog();
        }
    }
}
