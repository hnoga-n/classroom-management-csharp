using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using ServiceStack;

namespace Hybrid.GUI.Danhba
{
    public partial class TinNhanCard : UserControl
    {
        string maUser;
        string maFriend;

        public event EventHandler btXoaBan;
        public TinNhanCard(BanBe a)
        {
            InitializeComponent();

            //label1.Text = a.Hoten;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            List<Taikhoan> list = new TaikhoanDAO().get_danhsach();
            foreach (Taikhoan t in list)
            {
                if (t.Mataikhoan == a.Manguoiduocketban)
                {
                    label1.Text = t.Hoten;
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

            maUser = a.Manguoiketban;
            maFriend = a.Manguoiduocketban;


            button1.Enabled = false;
        }

        private void TinNhanCard_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void LoadData()
        {
            for (int i = flowKhungChat.Controls.Count - 1; i >= 0; i--)
            {
                if (flowKhungChat.Controls[i] is TinNhanCell || flowKhungChat.Controls[i] is TinNhanSend)
                {
                    flowKhungChat.Controls.RemoveAt(i);
                }
            }
            List<TinNhanBanBe> list = new TinNhanBanBeBUS().GetList(maUser, maFriend);
            foreach (TinNhanBanBe b in list)
            {
               
                if (b.Manguoigui.Equals(maFriend) && b.Daxoa == 0)
                {
                    TinNhanCell a = new TinNhanCell(b);
                    flowKhungChat.Controls.Add(a);
                }
                else if (b.Manguoigui.Equals(maUser) && b.Daxoa == 0)
                {
                    TinNhanSend a = new TinNhanSend(b);
                    a.XoaTN += XoaTinNhan;
                    flowKhungChat.Controls.Add(a);
                }
            }
        }

        private void XoaTinNhan(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text != Environment.NewLine)
            {
                TinNhanBanBe a = new TinNhanBanBe();
                a.Manguoigui = maUser;
                a.Manguoinhan = maFriend;
                a.Noidung = textBox1.Text;

                try
                {
                    new TinNhanBanBeBUS().AddMessage(maUser, maFriend, textBox1.Text);
                    LoadData();
                    textBox1.Text = string.Empty;
                    button1.Enabled = false;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            textBox1.Text = string.Empty;
            textBox1.SelectionStart = 0;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
                button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text.Equals("*  *  *"))
            {
                label2.Text = "Xóa bạn";
                return;
            }
            if (label2.Text.Equals("Xóa bạn"))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa bạn bè với người này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Xác định lựa chọn của người dùng
                if (result == DialogResult.Yes)
                {
                    BanBe b = new BanBe();
                    b.Manguoiketban = maUser;
                    b.Manguoiduocketban = maFriend;
                    new BanbeDAO().XoaBan(b);
                    new TinNhanBanBeBUS().UnFriendMessage(b);
                }
                else if (result == DialogResult.No)
                {
                    label2.Text = "*  *  *";
                    return;
                }

                btXoaBan?.Invoke(this, EventArgs.Empty);
                label2.Text = "*  *  *";
                return;
            }
        }
    }
}
