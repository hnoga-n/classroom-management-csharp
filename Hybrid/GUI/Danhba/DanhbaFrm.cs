using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;

namespace Hybrid.GUI.Danhba
{
    public partial class DanhbaFrm : Form
    {
        private Taikhoan taikhoanhienhanh;
        private Boolean isCollapsed1;
        private Boolean isCollapsed2;
        private Boolean isCollapsed3;
        private int DROP_DOWN_SPEED =20;
        private BanbeBUS banbeBUS;
        public DanhbaFrm()
        {
            InitializeComponent();
            
        }
        public DanhbaFrm(Taikhoan taikhoan)
        {
            InitializeComponent();
            this.taikhoanhienhanh = taikhoan;
            this.banbeBUS = new BanbeBUS();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                panelDropDown.Height += DROP_DOWN_SPEED;
                if(panelDropDown.Size == panelDropDown.MaximumSize )
                {
                    timer1.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                panelDropDown.Height -= DROP_DOWN_SPEED;
                if(panelDropDown.Size == panelDropDown.MinimumSize )
                {
                    timer1.Stop();
                    isCollapsed1 = true;
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                panelDropDown2.Height += DROP_DOWN_SPEED;
                if (panelDropDown2.Size == panelDropDown2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                panelDropDown2.Height -= DROP_DOWN_SPEED;
                if (panelDropDown2.Size == panelDropDown2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                panelDropDown3.Height += DROP_DOWN_SPEED;
                if (panelDropDown3.Size == panelDropDown3.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                panelDropDown3.Height -= DROP_DOWN_SPEED;
                if (panelDropDown3.Size == panelDropDown3.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is TrangCaNhan)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
            TrangCaNhan a = new TrangCaNhan();
            a.Visible = true;
            a.Location = new System.Drawing.Point(325, 15);
            this.Controls.Add(a);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void DanhbaFrm_Load(object sender, EventArgs e)
        {
            for (int i = panelDropDown.Controls.Count - 1; i >= 0; i--)
            {
                if (panelDropDown.Controls[i] is Banbe)
                {
                    panelDropDown.Controls.RemoveAt(i);
                }
            }
            for (int i = panelDropDown3.Controls.Count - 1; i >= 0; i--)
            {
                if (panelDropDown3.Controls[i] is Banbe)
                {
                    panelDropDown3.Controls.RemoveAt(i);
                }
            }
            //string ma = "58824edd-2ce6-46e8-97f3-8ca6970d8cbf"; //Mã tài khoản của người đang đăng nhập
            //string ma = "17593a02-3763-4b70-9454-d71c3af0bd19";
            List<BanBe> list = new BanbeBUS().GetList();
            foreach (BanBe b in list)
            {
                if (b.Manguoiketban.Equals(this.taikhoanhienhanh.Mataikhoan) && b.Trangthaiketban == 0)
                {
                    Banbe ban = new Banbe(b);
                    ban.ButtonClicked += FormLoiMoi;
                    panelDropDown3.Controls.Add(ban);

                }
                else if (b.Manguoiketban.Equals(this.taikhoanhienhanh.Mataikhoan))
                {
                    Banbe ban = new Banbe(b);
                    ban.ButtonClicked += GuiTinNhan;
                    panelDropDown.Controls.Add(ban);
                }
            }
        }

       

        private void FormLoiMoi(object sender, EventArgs e)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is TrangCaNhan)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
            // Xử lý sự kiện Click chung cho tất cả các UserControl
            Banbe clickedControl = sender as Banbe;
            if (clickedControl != null)
            {
                BanbeCard a = new BanbeCard(clickedControl.dto());
                a.Visible = true;
                a.Location = new System.Drawing.Point(325,15);
                a.noAccept();
                a.btChapNhan += ChapNhanLoiMoi;
                a.btXoa += XoaLoiMoi;
                this.Controls.Add(a);
            }
        }

        private void ChapNhanLoiMoi(object sender, EventArgs e)
        {
            DanhbaFrm_Load(sender,e);
            MessageBox.Show("Bạn đã chấp nhận lời mời kết bạn !\nHiện tại các bạn có thể nhắn tin.","Thông báo!");
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is TrangCaNhan)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
        }

        private void XoaLoiMoi(object sender, EventArgs e)
        {
            DanhbaFrm_Load(sender, e);
            MessageBox.Show("Bạn đã xóa lời mời kết bạn", "Thông báo");
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is TrangCaNhan)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
        }

         
        private void GuiTinNhan(object sender, EventArgs e)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is TrangCaNhan)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
            Banbe click = sender as Banbe;
            if (click != null)
            {
                TinNhanCard a = new TinNhanCard(click.dto());
                a.Visible = true;
                a.Location = new System.Drawing.Point(325, 15);
                this.Controls.Add(a);
            }
        }

        private void panelDropDown3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btGui_Click(object sender, EventArgs e)
        {
            BanBe banmoi = new BanBe();
            bool duplicate = true, exist = false, empty = true;
            banmoi.Manguoiduocketban =  this.taikhoanhienhanh.Mataikhoan;
            banmoi.Thoigianketban = DateTime.Now;
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
                    banmoi.Manguoiketban = t.Mataikhoan;
                    exist = true;
                    break;
                }
                exist = false;
            }
            if (exist)
            {
                List<BanBe> listbb = banbeBUS.GetList() ;
                foreach (BanBe bb in listbb)
                {
                    if (banmoi.Manguoiketban == bb.Manguoiketban && banmoi.Manguoiduocketban == bb.Manguoiduocketban)
                    {
                        MessageBox.Show("Bạn đã gửi lời mời với người bạn này!", "Thông báo");
                        duplicate = false;
                    }
                }
                if (duplicate)
                {
                    try
                    {
                        banbeBUS.ThemLoiMoi(banmoi);

                        MessageBox.Show("Gửi lời mời kết bạn thành công!", "Thông báo");
                        textBox1.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (empty) MessageBox.Show("Email này chưa đăng kí tài khoản!", "Thông báo");
        }
        bool IsEmailValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(emailPattern);

            return regex.IsMatch(email);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
