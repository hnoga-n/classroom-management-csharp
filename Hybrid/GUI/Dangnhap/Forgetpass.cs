using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Hybrid.BUS;

namespace Hybrid.GUI
{
    public partial class Forgetpass : KryptonForm
    {
        Chucnang cn=new Chucnang();
        TaikhoanBUS taikhoanBUS=new TaikhoanBUS();
        String ma6So;
        string Email;
        public Forgetpass()
        {
            InitializeComponent();
        }

        private void but_guima_Click(object sender, EventArgs e)
        {
            //lay email
            Email = txt_email.Text;
            if (taikhoanBUS.kt_email(Email))
            {
                if(taikhoanBUS.kt_taikhoan_tontai(Email))
                {
                    //tao ngau nhien so
                    ma6So = cn.TaoSo();
                    //Mo form xac nhan ma voi email, so ngau nhien ,va trang thai 1
                    //trang thai 1 la trang thai tu foem forgetpass chuyen sang form xac nhan ma
                    xacnhanma_fgp Xacnhanma = new xacnhanma_fgp(Email, null, ma6So, 1);
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
        private void but_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
