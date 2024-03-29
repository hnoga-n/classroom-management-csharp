﻿using Hybrid.BUS;
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
    public partial class Verifyfrm : Form
    {
        private System.Windows.Forms.Timer aTimer;
        int count = 30;
        string maXacNhan; //Lấy 6 số random từ form Forgetpass
        string email2; //Lấy email từ form Forgetpass
        string password1;
        int trangthai1;
        int SoLanNhap = 0;
        Chucnang cn = new Chucnang();
        TaikhoanBUS tkbus = new TaikhoanBUS();
        public Verifyfrm(string Email, string password, string ma6So, int trangthai)
        {
            InitializeComponent();
            email2 = Email;
            password1 = password;
            maXacNhan = ma6So;
            trangthai1 = trangthai;

            DemThoiGian();
            
        }
        private void Verifyfrm_Load(object sender, EventArgs e)
        {
            but_guilai.Visible = false;
            lbThongBao.Text = "";
            lbThongBaoo.Text = "";
            lbDem.Text = "";
            lbtitle.Text = "Chúng tôi đã gửi 1 đoạn mã gồm 6 số vào Email:" + this.email2 + ".\nVui lòng đăng nhập vào email của bạn để lấy đoạn mã đó và điền vào ô mã xác nhận.";
        }
        private void DemThoiGian()
        {
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(aTimer_Tick);
            aTimer.Interval = 1000; // 1 second
            aTimer.Start();
            lbDem.Text ="Lần gửi lại sẽ xuất hiện sau:"+ count.ToString();
        }
        
        private void aTimer_Tick(object sender, EventArgs e)
        {
            count = count - 1;

            if (count == 0)
            {
                aTimer.Stop();
                lbDem.Visible = false;
                but_guilai.Visible = true;
                count = 30;
            }

            lbDem.Text = "Lần gửi lại sẽ xuất hiện sau:" + count.ToString();

        }

        private void but_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_maxacnhan.Text == maXacNhan)
            {
                //trang thai =1 la reset mat khau
                //con lai la tao tai khoan
                if (trangthai1 == 1)
                {
                    lbThongBaoo.Text = "Xác thực thành công!";
                    if (tkbus.reset_matkhau1(email2) == true)
                    {
                        cn.Guimail_admin(email2, "Reset Password", "Đây là mật khẩu mới của bạn:Abcd@123\n, vui lòng nhanh chóng đăng nhập vào phần mềm của bạn và đổi mật khẩu khác: ");
                        MessageBox.Show("Vui lòng check email của bạn để lấy mật khẩu mới");
                    }
                    else
                        MessageBox.Show("Đã có lỗi trong quá trình quên mật khẩu");
                    this.Close();
                }
                else
                {
                    lbThongBaoo.Text = "Xác thực thành công!";
                    if (tkbus.tao_taikhoan1(email2, password1) == true)
                        MessageBox.Show("Bạn đã tạo tài khoản thành công.\nVui lòng đăng nhập vào phần mềm và cập nhật thông tin cá nhân.");
                    else
                        MessageBox.Show("Đã có lỗi trong quá trinh đăng ký tài khoản");
                    this.Close();
                }

            }
            else
            {
                SoLanNhap += 1;
                int x = 6;
                if (SoLanNhap > 5)
                {
                    lbThongBaoo.Text = "Vượt quá 5 lần. Khóa xác nhận!";
                    //Sau khi 5 lần thì khóa rồi bước tiếp theo làm gì thì ghi vào đây.
                    this.Close();
                }
                else
                    lbThongBaoo.Text = "Sai mã xác nhận! Bạn còn" + (x - SoLanNhap) + "lần nhập!";
            }
        }

        private void but_guilai_Click(object sender, EventArgs e)
        {
            count = 30;
            lbDem.Visible = true;
            but_guilai.Visible = false;
            lbDem.Text = "Lần gửi lại sẽ xuất hiện sau:" + count.ToString();
            DemThoiGian();
            maXacNhan = cn.TaoSo();
            if (trangthai1 == 1)
                cn.Guimail_admin(email2, "Mã xác nhận", "Xin chào,\r\n\r\nChúng tôi rất vui thông báo rằng bạn đã yêu cầu mã xác nhận. Dưới đây là mã xác nhận của bạn:\r\n\r\n" + maXacNhan + "\r\n\r\nVui lòng nhập mã này vào ứng dụng của chúng tôi để hoàn tất quá trình lấy lại mật khẩu. Nếu bạn không yêu cầu mã này, xin vui lòng bỏ qua thông báo này.\r\n\r\nHybrid Trân trọng,");
            else
                cn.Guimail_admin(email2, "Mã xác nhận", "Gần đây, bạn đã đăng ký tài khoản Hybrid. Để hoàn thành quy trình đăng ký , vui lòng nhập mã này vào phần xác nhận tài khoản của bạn: " + maXacNhan);
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
