using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;

namespace Hybrid.GUI.Danhba
{
    public partial class TrangCaNhan : UserControl
    {
        string maUser = "58824edd-2ce6-46e8-97f3-8ca6970d8cbf";
        public TrangCaNhan()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            List<Taikhoan> list = new TaikhoanDAO().get_danhsach();
            foreach (Taikhoan t in list)
            {
                if (t.Mataikhoan == maUser)
                {
                    hoten.Text = t.Hoten;
                    email.Text = t.Email;
                    sdt.Text = t.Sodienthoai;
                    if (t.Anhdaidien.Equals("canhan1"))
                        pictureBox1.Image = Properties.Resources.canhan1;
                    if (t.Anhdaidien.Equals("canhan2"))
                        pictureBox1.Image = Properties.Resources.canhan2;
                    if (t.Anhdaidien.Equals("canhan3"))
                        pictureBox1.Image = Properties.Resources.canhan3;
                    if (t.Anhdaidien.Equals("canhan4"))
                        pictureBox1.Image = Properties.Resources.canhan4;
                    if (t.Anhdaidien.Equals("canhan5"))
                        pictureBox1.Image = Properties.Resources.canhan5;
                    if (t.Anhdaidien.Equals("canhan6"))
                        pictureBox1.Image = Properties.Resources.canhan6;
                }
            }

            label7.Visible = false;
            textBox1.Visible = false;
            btGui.Visible = false;
            btHuy.Visible = false;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            textBox1.Visible = true;
            btGui.Visible = true;
            btHuy.Visible = true;

            kryptonButton3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGui_Click(object sender, EventArgs e)
        {
            BanBe b = new BanBe();
            bool duplicate = true, exist = false, empty = true;
            b.Manguoiduocketban = maUser;
            b.Thoigianketban = DateTime.Now;
            List<Taikhoan> list = new TaikhoanDAO().get_danhsach();
            if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo");
                empty = false;
                exist = false;
            }
            if (!IsEmailValid(textBox1.Text.Trim()) && empty == true)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!\nVD: abc123@exmail.com", "Thông báo");
                exist = false;
            }
            foreach (Taikhoan t in list)
            {
                if (t.Email == textBox1.Text.Trim())
                {
                    b.Manguoiketban = t.Mataikhoan;
                    exist = true;
                    break;
                }
                exist = false;
            }
            if (exist)
            {
                List<BanBe> listbb = new BanbeBUS().GetList();
                foreach (BanBe bb in listbb)
                {
                    if (b.Manguoiketban == bb.Manguoiketban && b.Manguoiduocketban == bb.Manguoiduocketban)
                    {
                        MessageBox.Show("Bạn đã gửi lời mời với người bạn này!", "Thông báo");
                        duplicate = false;
                    }
                }
                if (duplicate)
                {
                    try
                    {
                        new BanbeBUS().ThemLoiMoi(b);

                        MessageBox.Show("Gửi lời mời kết bạn thành công!", "Thông báo");
                        textBox1.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (duplicate) MessageBox.Show("Email này chưa đăng kí tài khoản!", "Thông báo");

            }
        }

        bool IsEmailValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(emailPattern);

            return regex.IsMatch(email);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox1.Visible = false;
            btGui.Visible = false;
            btHuy.Visible = false;

            kryptonButton3.Visible = true;
        }

    }
}
