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
using Hybrid.BUS;

namespace Hybrid.GUI
{
    public partial class SignupUI : KryptonForm
    {
        TaikhoanBUS tkbus=new TaikhoanBUS();
        Chucnang cn=new Chucnang();
        public SignupUI()
        {
            InitializeComponent();
        }

        private void hienmatkhau2_Click(object sender, EventArgs e)
        {
            txt_matkhau2.PasswordChar = '\0';
            hienmatkhau2.Visible = false;
            anmatkhau2.Visible = true;
        }

        private void hienmatkhau1_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '\0';
            hienmatkhau1.Visible = false;
            anmatkhau1.Visible = true;
        }

        private void anmatkhau1_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
            hienmatkhau1.Visible = true;
            anmatkhau1.Visible = false;
        }

        private void anmatkhau2_Click(object sender, EventArgs e)
        {
            txt_matkhau2.PasswordChar = '*';
            hienmatkhau2.Visible = true;
            anmatkhau2.Visible = false;
        }

        private void but_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignupUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void but_dangky_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Length == 0 || txt_matkhau.Text.Length == 0 || txt_matkhau2.Text.Length == 0)
                MessageBox.Show("Bạn nhập thiếu thông tin!");
            else
                if (tkbus.kt_email(txt_email.Text))
                    if(tkbus.kt_dinhdang_matkhau(txt_matkhau.Text))
                    {
                        if (txt_matkhau.Text == txt_matkhau2.Text)
                        {
                            if (tkbus.kt_taikhoan_tontai(txt_email.Text))
                                MessageBox.Show("Email này đã được đăng ký.\nVui lòng nhập email khác.");
                            else
                            {
                                string maso = cn.TaoSo();
                                Form form = new xacnhanma_fgp(txt_email.Text, txt_matkhau.Text, maso, 2);
                                cn.Guimail_admin(txt_email.Text, "Mã xác nhận", "Gần đây, bạn đã đăng ký tài khoản Hybrid. Để hoàn thành quy trình đăng ký , vui lòng nhập mã này vào phần xác nhận tài khoản của bạn: " + maso);
                                this.Hide();
                                form.ShowDialog();
                                
                            }
                        }
                        else
                            MessageBox.Show("Mật khẩu xác nhận không đúng");
                    }
                    else
                        MessageBox.Show("Mật khẩu không đúng định dạng quy định\nVd:Abcxyz@123","Cảnh báo",MessageBoxButtons.OK);
                else
                    MessageBox.Show("Email không đúng định dạng\nVD:abc@gmail.com");
        }

        private void lab_matkhau_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_matkhau2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
