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
    public partial class OutgoingMessage : UserControl
    {
        ChatBoxFrm chatBoxFrm;
        private string saveText;
        lbl_save_clipboard lbl_sc;
        TinNhanNhomChat tnnc;
        public OutgoingMessage(ChatBoxFrm cbFrm)
        {
            InitializeComponent();
            this.chatBoxFrm = cbFrm;
        }

        public void AddContent(TinNhanNhomChat mess)
        {
            DateTime currentTime = mess.Thoigiangui;
            tnnc = mess;
            lbl_sent_time.Text = currentTime.ToString("HH:mm");
            lbl_sent_content.Text = mess.Noidung;
            this.saveText = mess.Noidung;
        }

        public void AddNewContent(string text)
        {
            DateTime currentTime = DateTime.Now;

            lbl_sent_time.Text = currentTime.ToString("HH:mm");
            lbl_sent_content.Text = text;
            this.saveText = text;
        }

        private void lbl_sent_content_Click(object sender, EventArgs e)
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
                chatBoxFrm.del_om_mess(this, this.tnnc);
            }
        }


        private void menu_TinNhan_Opening(object sender, CancelEventArgs e)
        {
            this.kryptonContextMenuItem1.Click += copy_text;
            this.kryptonContextMenuItem2.Click += delete_mess;
        }
    }
}
