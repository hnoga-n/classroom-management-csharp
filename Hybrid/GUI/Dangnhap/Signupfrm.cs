using Hybrid.BUS;
using Hybrid.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Dangnhap
{
    public partial class Signupfrm : Form
    {
        TaikhoanDAO tkdao = new TaikhoanDAO();
        TaikhoanBUS tkbus = new TaikhoanBUS();
        Chucnang cn = new Chucnang();
        public Signupfrm()
        {
            InitializeComponent();
        }

        private void pic_showpass_Click(object sender, EventArgs e)
        {
            if (txt_matkhau.Text != "Mật khẩu")
            {
                txt_matkhau.PasswordChar = '\0';
                pic_showpass.Visible = false;
                pic_hidepass.Visible = true;
            }
        }

        private void pic_hidepass_Click(object sender, EventArgs e)
        {
            
                txt_matkhau.PasswordChar = '*';
                pic_showpass.Visible = true;
                pic_hidepass.Visible = false;
            
        }

        private void pic_showpass2_Click(object sender, EventArgs e)
        {
            if (txt_xacnhanmatkhau.Text != "Xác nhận mật khẩu")
            {
                txt_xacnhanmatkhau.PasswordChar = '\0';
                pic_showpass2.Visible = false;
                pic_hidepass2.Visible = true;
            }
        }

        private void pic_hidepass2_Click(object sender, EventArgs e)
        {
            
                txt_xacnhanmatkhau.PasswordChar = '*';
                pic_showpass2.Visible = true;
                pic_hidepass2.Visible = false;
            
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = string.Empty;
            }
            txt_email.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = System.Drawing.Color.Silver;
            }
        }
        private void txt_matkhau_Enter(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "Mật khẩu")
            {
                txt_matkhau.Text = string.Empty;
            }
            txt_matkhau.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                txt_matkhau.Text = "Mật khẩu";
                txt_matkhau.ForeColor = System.Drawing.Color.Silver;
            }
            if (pic_hidepass.Visible == true)
            {
                //txt_matkhau.PasswordChar = '*';
                pic_showpass.Visible = true;
                pic_hidepass.Visible = false;
            }
        }

        private void txt_xacnhanmatkhau_Enter(object sender, EventArgs e)
        {
            if (txt_xacnhanmatkhau.Text == "Xác nhận mật khẩu")
            {
                txt_xacnhanmatkhau.Text = string.Empty;
            }
            txt_xacnhanmatkhau.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_xacnhanmatkhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_xacnhanmatkhau.Text))
            {
                txt_xacnhanmatkhau.Text = "Xác nhận mật khẩu";
                txt_xacnhanmatkhau.ForeColor = System.Drawing.Color.Silver;
            }
            if (pic_hidepass2.Visible == true)
            {
                //txt_matkhau.PasswordChar = '*';
                pic_showpass2.Visible = true;
                pic_hidepass2.Visible = false;
            }
        }

        private void but_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Length == 0 || txt_matkhau.Text.Length == 0 || txt_xacnhanmatkhau.Text.Length == 0)
                MessageBox.Show("Bạn nhập thiếu thông tin!");
            else
                if (tkbus.kt_email(txt_email.Text))
                if (tkbus.kt_dinhdang_matkhau(txt_matkhau.Text))
                {
                    if (txt_matkhau.Text == txt_xacnhanmatkhau.Text)
                    {
                        if (tkbus.kt_taikhoan_tontai(txt_email.Text))
                            MessageBox.Show("Email này đã được đăng ký.\nVui lòng nhập email khác.");
                        else
                        {
                            string maso = cn.TaoSo();
                            Form form = new Verifyfrm(txt_email.Text, txt_matkhau.Text, maso, 2);
                            cn.Guimail_admin(txt_email.Text, "Mã xác nhận", "Gần đây, bạn đã đăng ký tài khoản Hybrid. Để hoàn thành quy trình đăng ký , vui lòng nhập mã này vào phần xác nhận tài khoản của bạn: " + maso);
                            this.Hide();
                            form.ShowDialog();

                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu xác nhận không đúng");
                }
                else
                    MessageBox.Show("Mật khẩu không đúng định dạng quy định\nVd:Abcxyz@123", "Cảnh báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Email không đúng định dạng\nVD:abc@gmail.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            if (tkbus.kt_dinhdang_matkhau(txt_matkhau.Text))
                lab_kiemtra.ForeColor = Color.Blue;
            else
                lab_kiemtra.ForeColor = Color.Red;
            if (txt_matkhau.Text != "Mật khẩu" && txt_matkhau.Text.Length > 0)
                txt_matkhau.PasswordChar = '*';
            else
                txt_matkhau.PasswordChar = '\0';
        }

        private void txt_xacnhanmatkhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_xacnhanmatkhau.Text != "Xác nhận mật khẩu" && txt_xacnhanmatkhau.Text.Length > 0)
                txt_xacnhanmatkhau.PasswordChar = '*';
            else
                txt_xacnhanmatkhau.PasswordChar = '\0';
        }
    }
}
