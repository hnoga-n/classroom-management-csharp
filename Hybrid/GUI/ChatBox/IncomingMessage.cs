using Hybrid.BUS;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.ChatBox
{
    public partial class IncomingMessage : UserControl
    {
        ChatBoxFrm chatBoxFrm;
        private string saveText;
        private bool isVisible = false;
        TinNhanNhomChat tnnc;
        public IncomingMessage(ChatBoxFrm chatBoxFrm)
        {
            InitializeComponent();
            this.chatBoxFrm = chatBoxFrm;
        }


        private void IncomingMessage_Load(object sender, EventArgs e)
        {

        }

        public void AddContent(TinNhanNhomChat mess)
        {
            DateTime currentTime = mess.Thoigiangui;
            tnnc = mess;
            lbl_sent_time.Text = currentTime.ToString("HH:mm");
            lbl_sent_content.Text = mess.Noidung;
            this.saveText = mess.Noidung;

            TaikhoanBUS taikhoanBUS = new TaikhoanBUS();
            Taikhoan tk = taikhoanBUS.List[taikhoanBUS.GetTaiKhoanByMaTaiKhoan(mess.Mataikhoan)];
            PictureBox pic = taikhoanBUS.load_hinhdaidien(tk.Anhdaidien);
            user_avatar.Image = pic.Image;
            string headEmail = tk.Email.Split('@')[0];
            string tailEmail = tk.Email.Split('@')[1].Replace(".com", "");
            lbl_sent_userName.Text = headEmail.Substring(0, headEmail.Length) + "***" + tailEmail.Substring(tailEmail.Length - 3);
        }


        private void lbl_sent_content_MouseClick(object sender, EventArgs e)
        {
            menu_TinNhan.Show(this);
        }
        private void copy_text(object sender, System.EventArgs e)
        {
            Clipboard.SetText(lbl_sent_content.Text);
        }

        private void delete_mess(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tin nhắn?", "Xóa tin nhắn", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                chatBoxFrm.del_im_mess(this, this.tnnc);
            }
            else
            {
                return;
            }
        }

        private void menu_TinNhan_Opening(object sender, CancelEventArgs e)
        {
            this.kryptonContextMenuItem1.Click += copy_text;
            this.kryptonContextMenuItem2.Click += delete_mess;

        }
    }
}
