using Hybrid.BUS;
using Hybrid.DTO;
using System;
using System.Collections;
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
    public partial class ChatBoxFrm : Form
    {
        LopHoc lophoc;
        Taikhoan tk_hienhanh;
        private int charLimit = 300;
        private bool isClickEventAssigned = false;
        private ArrayList list_messages, list_messages_tmp;
        OutgoingMessage outgoingMessagePanel;
        IncomingMessage incomingMessagePanel;
        TinNhanNhomChatBUS group_messages_data;
        bool firstLoad = false;
        int perMess = 10;
        int mess_index_value = 1;
        public ChatBoxFrm(LopHoc lh, Taikhoan tk)
        {
            InitializeComponent();
            this.tk_hienhanh = tk;
            this.lophoc = lh;
            setUp_notify();
            load_message();
            checkAreaChatTextEmpty();
        }

        public void setUp_notify()
        {
            //lbl_time_create_chatbox2.Text = "";

        }
        public void setUp_mess_load()
        {
            group_messages_data = new TinNhanNhomChatBUS();
            group_messages_data.loadList(perMess, mess_index_value, lophoc.Malop);
            list_messages = group_messages_data.getList();
        }

        public void predictSetup_mess_load()
        {
            group_messages_data = new TinNhanNhomChatBUS();
            group_messages_data.loadList(perMess, mess_index_value + 1, lophoc.Malop);
            list_messages_tmp = group_messages_data.getList();
        }

        private void btn_click_load_more(object sender, EventArgs e)
        {
            load_message();
        }
        private void load_message()
        {

            //int count = 1;
            predictSetup_mess_load();
            if (list_messages_tmp.Count == 0)
            {
                MessageBoxContainer.Controls.Remove(btn_load_mess);
            }
            setUp_mess_load();

            foreach (TinNhanNhomChat message in list_messages)
            {
                Console.WriteLine(message.Noidung);
                if (tk_hienhanh.Mataikhoan.ToLower().Equals(message.Mataikhoan.ToLower()))
                {
                    outgoingMessagePanel = new OutgoingMessage(this);
                    outgoingMessagePanel.AddContent(message);
                    MessageBoxContainer.Controls.Add(outgoingMessagePanel);
                    outgoingMessagePanel.BringToFront();
                    //MessageBoxContainer.ScrollControlIntoView(outgoingMessagePanel);
                }
                else
                {
                    incomingMessagePanel = new IncomingMessage(this);
                    incomingMessagePanel.AddContent(message);
                    MessageBoxContainer.Controls.Add(incomingMessagePanel);
                    incomingMessagePanel.BringToFront();
                    //MessageBoxContainer.ScrollControlIntoView(incomingMessagePanel);
                }
            }
            mess_index_value++;
            btn_load_mess.BringToFront();
            lbl_notifiication_chatbox1.BringToFront();
            lbl_time_create_chatbox2.BringToFront();
            if (!firstLoad)
            {
                Control lastItem = MessageBoxContainer.Controls[MessageBoxContainer.Controls.Count - 1];
                //UserControl lastUserControl = MessageBoxContainer.Controls[MessageBoxContainer.Controls.Count - 1];
                MessageBoxContainer.ScrollControlIntoView(lastItem);
                firstLoad = true;
            }
        }

        public void del_im_mess(IncomingMessage im)
        {
            MessageBoxContainer.Controls.Remove(im);
        }
        public void del_om_mess(OutgoingMessage om)
        {
            MessageBoxContainer.Controls.Remove(om);
        }


        public void checkAreaChatTextEmpty()
        {
            if (areaChatRTB.Text.Length > 0)
            {
                if (!isClickEventAssigned)
                {
                    sendMessBtn.Click += sendMessBtn_Click;
                    isClickEventAssigned = true;
                }
                sendMessBtn.Enabled = true;
                sendMessBtn.Cursor = Cursors.Hand;
                sendMessBtn.OverrideDefault.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#009265");
                sendMessBtn.OverrideDefault.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#009265");
                sendMessBtn.StateCommon.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#009265");
                sendMessBtn.StateCommon.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#009265");
            }
            else
            {
                sendMessBtn.Click -= sendMessBtn_Click;
                sendMessBtn.Enabled = false;
                isClickEventAssigned = false;
                sendMessBtn.Cursor = Cursors.Default;
                sendMessBtn.OverrideDefault.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
                sendMessBtn.OverrideDefault.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
                sendMessBtn.StateCommon.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
                sendMessBtn.StateCommon.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
            }
        }
        private void sendMessBtn_Click(object sender, EventArgs e)
        {
            if (sendMessBtn.Enabled)
            {
                Console.WriteLine(areaChatRTB.Text);
                outgoingMessagePanel = new OutgoingMessage(this);
                outgoingMessagePanel.AddNewContent(areaChatRTB.Text);
                MessageBoxContainer.Controls.Add(outgoingMessagePanel);
                areaChatRTB.Text = "";
                MessageBoxContainer.VerticalScroll.Value = MessageBoxContainer.VerticalScroll.Maximum;
            }
        }

        private void areaChatRTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)22 && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                string clipboardText = Clipboard.GetText();
                int totalTextLength = areaChatRTB.TextLength + clipboardText.Length;
                //Console.WriteLine("Length: " + areaChatRTB.TextLength + " and " + clipboardText.Length);
                string textTmp = areaChatRTB.Text + clipboardText;
                //Console.WriteLine("Text: " + textTmp);

                if (totalTextLength > charLimit)
                {
                    e.Handled = true;
                    areaChatRTB.Text = textTmp.Substring(0, charLimit);
                    areaChatRTB.SelectionStart = charLimit;
                }
                else
                {
                    e.Handled = false;
                }
            }
            //Console.WriteLine("Length: " + areaChatRTB.TextLength);
            if (areaChatRTB.TextLength >= charLimit)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void MessageBoxContainer_Scroll(object sender, ScrollEventArgs e)
        {
            Console.WriteLine(MessageBoxContainer.VerticalScroll.Value);
            if (MessageBoxContainer.VerticalScroll.Value == 0)
            {
                load_message();
            }
        }

        private void areaChatRTB_TextChanged(object sender, EventArgs e)
        {

            count_letter_lbl.Text = areaChatRTB.Text.Length + "/" + charLimit;
            if (areaChatRTB.Text.Length > 0)
            {
                if (!isClickEventAssigned)
                {
                    sendMessBtn.Click += sendMessBtn_Click;
                    isClickEventAssigned = true;
                }
                sendMessBtn.Enabled = true;
                sendMessBtn.Cursor = Cursors.Hand;
                sendMessBtn.OverrideDefault.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#041CD4");
                sendMessBtn.OverrideDefault.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#041CD4");
                sendMessBtn.StateCommon.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#041CD4");
                sendMessBtn.StateCommon.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#041CD4");
            }
            else
            {
                sendMessBtn.Click -= sendMessBtn_Click;
                sendMessBtn.Enabled = false;
                isClickEventAssigned = false;
                sendMessBtn.Cursor = Cursors.Default;
                sendMessBtn.OverrideDefault.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
                sendMessBtn.OverrideDefault.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
                sendMessBtn.StateCommon.Back.Color1 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
                sendMessBtn.StateCommon.Back.Color2 = System.Drawing.ColorTranslator.FromHtml("#DCDCDC");
            }
        }
    }
}
