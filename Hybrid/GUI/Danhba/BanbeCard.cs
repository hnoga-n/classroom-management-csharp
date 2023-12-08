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



namespace Hybrid.GUI.Danhba
{
    public partial class BanbeCard : UserControl
    {

        private string manguoiketban;
        private string manguoiduocketban;
        string ht;
        private int trangthaiketban;

        public event EventHandler btChapNhan;
        public event EventHandler btXoa;
        public event EventHandler btGuiTN;

        public BanbeCard(DTO.BanBe a)
        {
            InitializeComponent();
            manguoiketban = a.Manguoiketban.ToString();
            manguoiduocketban = a.Manguoiduocketban.ToString();
            trangthaiketban = a.Trangthaiketban;
            ht = a.Hoten;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            List<Taikhoan> list = new TaikhoanDAO().get_danhsach();
            foreach (Taikhoan t in list)
            {
                if (t.Mataikhoan == manguoiduocketban)
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
        }

        public BanBe dto()
        {
            BanBe banbe = new BanBe(manguoiketban, manguoiduocketban, ht,DateTime.Now, trangthaiketban);
            return banbe;
        }

        private void BanbeCard_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            BanBe b = new BanBe();
            b.Manguoiketban = manguoiketban;
            b.Manguoiduocketban = manguoiduocketban;
            b.Trangthaiketban = 1;
            new BanbeBUS().SuaTrangThai(b);
            btChapNhan?.Invoke(this, EventArgs.Empty);
        }

        public void noAccept() 
        {
            
            kryptonButton2.Visible = true;
            kryptonButton4.Visible = true;

           

            label6.Visible = true;


        }

        public void Accepted()
        {
           

            kryptonButton2.Visible = false;
            kryptonButton4.Visible = false;

          

            label6.Visible = false;

           
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xác định lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                BanBe b = new BanBe();
                b.Manguoiketban = manguoiketban;
                b.Manguoiduocketban = manguoiduocketban;
                new BanbeBUS().XoaLoiMoi(b);
            }
            else if (result == DialogResult.No)
            {
                Console.WriteLine("Người dùng đã chọn No.");
                
            }
            
            btXoa?.Invoke(this, EventArgs.Empty);
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            btGuiTN?.Invoke(this, EventArgs.Empty);
        }

        private void BanbeCard_Load_1(object sender, EventArgs e)
        {

        }

        private void BanbeCard_Load_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
