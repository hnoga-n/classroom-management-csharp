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
using Hybrid.DAO;

namespace Hybrid.GUI
{
    public partial class LoginUI : KryptonForm
    {
        TaikhoanBUS tkbus = new TaikhoanBUS();
        public LoginUI()
        {
            InitializeComponent();

        }
        private void hienmatkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '\0';
            hienmatkhau.Visible = false;
            anmatkhau.Visible = true;
        }
        private void anmatkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
            anmatkhau.Visible = false;
            hienmatkhau.Visible = true;
        }
        private void dangky_Click(object sender, EventArgs e)
        {
            //Ketnoisqlserver.CloseConnection();
            this.Hide();
            KryptonForm form = new SignupUI();
            form.ShowDialog();
            this.Show();
        }
        private void but_dangnhap_Click_2(object sender, EventArgs e)
        {
            if(txt_email.Text.Length==0||txt_matkhau.Text.Length==0) 
            {
                MessageBox.Show("Email hoặc mật khẩu không được để trống");
            }
            else
            {
                if (tkbus.kt_email(txt_email.Text))
                    if (tkbus.kt_taikhoan(txt_email.Text, txt_matkhau.Text) != null) 
                        MessageBox.Show("Đăng nhập thành công");
                    else
                        MessageBox.Show("Emailo chưa được đăng kí hoặc không tồn tại");
                else
                    MessageBox.Show("Email không hợp lệ hoặc không đúng định dạng cơ bản");
            }

        }
    }
}
