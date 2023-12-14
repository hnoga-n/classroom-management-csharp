﻿using System;
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
using Hybrid.GUI.Home;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.DTO;
using Hybrid.BUS;
using System.Drawing.Drawing2D;
using Hybrid.GUI.Todo;
using Hybrid.GUI.Utilities;
using Hybrid.GUI.Dangnhap;
using Hybrid.GUI.Danhba;

namespace Hybrid
{
    public partial class Form1 : KryptonForm
    {
        private BaiTapBUS btBUS;
        private DeKiemTraBUS dktBUS;
        private ChuongBUS chuongBUS;
        private LopHocBUS lopBUS;
        private BailambaitapBUS blbtBUS;
        private BailamKiemtraBUS blktBUS;
        Chucnang cn = new Chucnang();
        TaikhoanBUS taikhoanBUS;

        private Taikhoan tk ;

        public Taikhoan Tk { get => tk; set => tk = value; }

        public static PictureBox picha = new PictureBox();
        public Form1(Taikhoan tk)
        {
            InitializeComponent();
            loading.ShowSplashScreen();
            this.tk = tk;
            chuongBUS = new ChuongBUS();
            lopBUS = new LopHocBUS();
            dktBUS = new DeKiemTraBUS();
            btBUS = new BaiTapBUS();
            taikhoanBUS = new TaikhoanBUS();
            blbtBUS = new BailambaitapBUS();
            blktBUS = new BailamKiemtraBUS();
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
            addFormtoPanelContainer(new TodoFrm(this.tk, this.btBUS, this.lopBUS, this.dktBUS, this.chuongBUS,this.blbtBUS,this.blktBUS));
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new DanhbaFrm(this.tk));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pic = taikhoanBUS.load_hinhdaidien(tk.Anhdaidien);
            pictureBox1.Image = pic.Image;
            picha.Image = pic.Image;
            cn.loadggdrive();
            //cn.load_hinhanhcanhan(this.taikhoanhienhanh.Anhdaidien, pictureBox1);
            MakePictureBoxCircular(pictureBox1);

            btnHome_Click(this, EventArgs.Empty);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thongtintaikhoan frmtt = new Thongtintaikhoan(this.tk, this, pictureBox1);
            frmtt.ShowDialog();
            taikhoanBUS = new TaikhoanBUS();
            this.tk = taikhoanBUS.GetTaiKhoanByEmail(this.tk.Email);
            pictureBox1.Image = picha.Image;
            MakePictureBoxCircular(pictureBox1);
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            cn.ghi_nhomk("0");
            cn.remove_file();
            this.Hide();
            Form form = new Loginfrm();
            form.Show();
            
        }
        private void LoadHinh(Image image)
        {
            //ptbThumbnail.Image = null;
            pictureBox1.Image = Properties.Resources.canhan1;
            pictureBox1.Image = image;
        }
    }
}
