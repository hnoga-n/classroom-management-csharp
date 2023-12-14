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
using Google.Protobuf.WellKnownTypes;
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
            /*for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is SearchList)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
            TrangCaNhan a = new TrangCaNhan();
            a.Visible = true;
            a.Location = new System.Drawing.Point(325, 15);
            this.Controls.Add(a);*/
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        string ma;//= "58824edd-2ce6-46e8-97f3-8ca6970d8cbf"; //Mã tài khoản của người đang đăng nhập
                                                            //string ma = "17593a02-3763-4b70-9454-d71c3af0bd19";

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
            textBox1.Multiline = false;
        }

       

        private void FormLoiMoi(object sender, EventArgs e)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is SearchList)
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
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is SearchList)
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
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is SearchList)
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
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is SearchList)
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
                a.Location = new System.Drawing.Point(325, 60);
                this.Controls.Add(a);
            }

            
        }

        private void panelDropDown3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btGui_Click(object sender, EventArgs e)
        {
           
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is SearchList)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
            if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập văn bản để tìm kiếm!", "Thông báo");
                return;
            }
            List<Taikhoan> list = new BanbeBUS().TimKiem(textBox1.Text);
            Console.WriteLine(list.Count);
            SearchList a = new SearchList(list,this.taikhoanhienhanh.Mataikhoan);
            a.btChapNhan += ChapNhanLoiMoi;
            a.btTN += TinNhan;
            a.Visible = true;
            a.Location = new System.Drawing.Point(325, 60);
            this.Controls.Add(a);
            textBox1.Text = string.Empty;
        }

        private void TinNhan(object sender, EventArgs e)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is BanbeCard || Controls[i] is TinNhanCard || Controls[i] is SearchList)
                {
                    // Nếu là Card, xóa khỏi Controls của Form
                    Controls.RemoveAt(i);
                }
            }
            SearchList click = sender as SearchList;
            if (click != null)
            {
                TinNhanCard a = new TinNhanCard(click.dto());
                a.Visible = true;
                a.Location = new System.Drawing.Point(325, 60);
                this.Controls.Add(a);
            }

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
