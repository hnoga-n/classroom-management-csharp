﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hybrid.GUI.Danhba
{
    public partial class ItemList : UserControl
    {
        private string mataikhoan;
        private string mabanbe;

        public event EventHandler Update;
        public event EventHandler TN;


        public ItemList(Taikhoan tk, string matk)
        {
            InitializeComponent();

            mataikhoan = matk;
            mabanbe = tk.Mataikhoan;
            labelHoten.Text = tk.Hoten;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            string email = MaskEmail(tk.Email);
            labelEmail.Text = email;
            string sdt = MaskPhoneNumber(tk.Sodienthoai.ToString());
            labelSDT.Text = sdt;
            if (tk.Anhdaidien.Equals("canhan1"))
                pictureBox1.Image = Properties.Resources.canhan1;
            if (tk.Anhdaidien.Equals("canhan2"))
                pictureBox1.Image = Properties.Resources.canhan2;
            if (tk.Anhdaidien.Equals("canhan3"))
                pictureBox1.Image = Properties.Resources.canhan3;
            if (tk.Anhdaidien.Equals("canhan4"))
                pictureBox1.Image = Properties.Resources.canhan4;
            if (tk.Anhdaidien.Equals("canhan5"))
                pictureBox1.Image = Properties.Resources.canhan5;
            if (tk.Anhdaidien.Equals("canhan6"))
                pictureBox1.Image = Properties.Resources.canhan6;

            List<BanBe> list = new BanbeBUS().GetList();
            foreach (BanBe b in list)
            {
                if (b.Manguoiketban.Equals(mabanbe) && b.Manguoiduocketban.Equals(mataikhoan) && b.Trangthaiketban == 0)
                {
                    button1.Enabled = false;
                    button1.Text = "Đã gửi lời mời";
                    return;
                }
                if (b.Manguoiketban.Equals(mabanbe) && b.Manguoiduocketban.Equals(mataikhoan) && b.Trangthaiketban == 1)
                {
                    //button1.Enabled = false;
                    button1.Text = "Đã kết bạn";
                    button1.BackColor = Color.CornflowerBlue;
                    return;
                }

                if (b.Manguoiketban.Equals(mataikhoan) && b.Manguoiduocketban.Equals(mabanbe) && b.Trangthaiketban == 0)
                {
                    //button1.Enabled = false;
                    button1.Text = "Chấp nhận";
                    button1.BackColor = Color.DarkKhaki;
                    return;
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Gửi lời mời"))
            {
                List<BanBe> list = new BanbeBUS().GetList();
                foreach (BanBe b in list)
                {
                    if (b.Manguoiketban.Equals(mabanbe) && b.Manguoiduocketban.Equals(mataikhoan) && b.Trangthaiketban == 2)
                    {
                        BanBe bancu = new BanBe();
                        bancu.Manguoiduocketban = mataikhoan;
                        bancu.Manguoiketban = mabanbe;
                        bancu.Trangthaiketban = 0;

                        new BanbeDAO().LoiMoiSauXoaBan(bancu);

                        MessageBox.Show("Gửi lời mời kết bạn thành công!", "Thông báo");
                        button1.Enabled = false;
                        button1.Text = "Đã gửi lời mời";
                        return;
                    }
                    
                }

                BanBe banmoi = new BanBe();
                banmoi.Manguoiduocketban = mataikhoan;
                banmoi.Manguoiketban = mabanbe;
                banmoi.Thoigianketban = DateTime.Now;
                banmoi.Trangthaiketban = 0;
                try
                {
                    new BanbeDAO().ThemLoiMoi(banmoi);

                    MessageBox.Show("Gửi lời mời kết bạn thành công!", "Thông báo");
                    button1.Enabled = false;
                    button1.Text = "Đã gửi lời mời";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (button1.Text.Equals("Chấp nhận"))
            {
                BanBe b = new BanBe();
                b.Manguoiketban = mataikhoan;
                b.Manguoiduocketban = mabanbe;
                b.Trangthaiketban = 1;
                new BanbeBUS().SuaTrangThai(b);

                button1.Enabled = false;
                button1.Text = "Đã kết bạn";
                button1.BackColor = Color.CornflowerBlue;

                Update?.Invoke(this, EventArgs.Empty);

            }
            if (button1.Text.Equals("Đã kết bạn"))
            {
                TN?.Invoke(this, EventArgs.Empty);

            }

        }

        public BanBe dto()
        {
            BanBe banBe = new BanBe(mataikhoan,mabanbe,"",DateTime.Now,1);
            return banBe;
        }

        private string MaskPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length == 10)
            {
                // Ẩn 4 chữ số đầu và 3 chữ số cuối
                StringBuilder maskedNumber = new StringBuilder(phoneNumber);
                for (int i = 4; i < 7; i++)
                {
                    maskedNumber[i] = '*';
                }
                return maskedNumber.ToString();
            }
            else
            {
                // Trả về số điện thoại không đầy đủ
                return phoneNumber;
            }
        }

        private string MaskEmail(string email)
        {
            // Ẩn 3 ký tự trước ký tự '@'
            StringBuilder maskedEmail = new StringBuilder(email);

            int atIndex = email.IndexOf('@');
            if (atIndex >= 3)
            {
                // Ẩn 3 ký tự trước ký tự '@'
                for (int i = atIndex - 3; i < atIndex; i++)
                {
                    maskedEmail[i] = '*';
                }
            }

            return maskedEmail.ToString();
        }
    }
}
