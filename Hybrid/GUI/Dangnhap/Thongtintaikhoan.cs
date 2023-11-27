using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Hybrid.DTO;

namespace Hybrid.GUI
{
    public partial class Thongtintaikhoan : KryptonForm
    {
        Taikhoan tk;
        Form1 frm;
        public Thongtintaikhoan(Taikhoan tk,PictureBox pic,Form1 frm)
        {
            InitializeComponent();
            this.tk = tk;
            this.frm = frm;
            this.hinhanh.Image = pic.Image;
            this.Location = new Point(frm.Location.X+50,frm
                .Location.Y + 50);
        }

        private void Thongtintaikhoan_Load(object sender, EventArgs e)
        {
            lab_hoten.Visible=false;
            txt_hoten.Visible = false;
            lab_matkhau.Visible=false;
            txt_matkhau.Visible = false;
            MakePictureBoxCircular(hinhanh);
            lab_ten.Text = this.tk.Hoten;
            txt_email.Text=this.tk.Email;
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



        private void but_chinhsua_Click(object sender, EventArgs e)
        {
            lab_hoten.Visible = true;
            txt_hoten.Visible = true;
            lab_matkhau.Visible = true;
            txt_matkhau.Visible = true;
            lab_ten.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
