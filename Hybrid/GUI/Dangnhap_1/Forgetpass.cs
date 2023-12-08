using Hybrid.BUS;
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
    public partial class Forgetpassfrm : Form
    {
        Chucnang cn = new Chucnang();
        TaikhoanBUS taikhoanBUS = new TaikhoanBUS();
        string ma6So,Email;
        
        public Forgetpassfrm()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_guima_Click(object sender, EventArgs e)
        {
            //lay email
            Email = txt_email.Text;
            if (taikhoanBUS.kt_email(Email))
            {
                if (taikhoanBUS.kt_taikhoan_tontai(Email))
                {
                    //tao ngau nhien so
                    ma6So = cn.TaoSo();
                    //Mo form xac nhan ma voi email, so ngau nhien ,va trang thai 1
                    //trang thai 1 la trang thai tu foem forgetpass chuyen sang form xac nhan ma
                    Form Xacnhanma = new Verifyfrm(Email, null, ma6So, 1);
                    //gui gmail kem thoe doan ma 6 chu so
                    cn.Guimail_admin(txt_email.Text, "Mã xác nhận", "Xin chào,\r\n\r\nChúng tôi rất vui thông báo rằng bạn đã yêu cầu mã xác nhận. Dưới đây là mã xác nhận của bạn:\r\n\r\n" + ma6So + "\r\n\r\nVui lòng nhập mã này vào ứng dụng của chúng tôi để hoàn tất quá trình lấy lại mật khẩu. Nếu bạn không yêu cầu mã này, xin vui lòng bỏ qua thông báo này.\r\n\r\nHybrid Trân trọng,");
                    this.Hide();

                    Xacnhanma.ShowDialog();
                }
                else
                    MessageBox.Show("Emai này chưa có đăng ký trước", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Emai nhập không đúng định dạng\n VD:abc@gmail.com", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
