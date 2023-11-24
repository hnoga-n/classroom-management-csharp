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
                    if (txt_matkhau.Text == txt_matkhau2.Text )
                        MessageBox.Show("Đăng ký thành công");
                    else
                        MessageBox.Show("Mật khẩu không đúng");
                else
                    MessageBox.Show("Email không hợp lệ");
        }
    }
}
