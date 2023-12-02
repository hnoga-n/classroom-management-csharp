namespace Hybrid.GUI.ChatBox
{
    partial class ChatBoxFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.areaChatRTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.sendMessBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.count_letter_lbl = new System.Windows.Forms.Label();
            this.panel_sent_contaner = new System.Windows.Forms.Panel();
            this.panel_sent_right = new System.Windows.Forms.Panel();
            this.MessageBoxContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_time_create_chatbox2 = new Hybrid.GUI.ChatBox.lbl_time_create_chatbox();
            this.lbl_notifiication_chatbox1 = new Hybrid.GUI.ChatBox.lbl_notifiication_chatbox();
            this.btn_load_mess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel_sent_contaner.SuspendLayout();
            this.panel_sent_right.SuspendLayout();
            this.MessageBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaChatRTB
            // 
            this.areaChatRTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.areaChatRTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.areaChatRTB.Location = new System.Drawing.Point(0, 0);
            this.areaChatRTB.Name = "areaChatRTB";
            this.areaChatRTB.Size = new System.Drawing.Size(837, 100);
            this.areaChatRTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.areaChatRTB.StateCommon.Border.Rounding = 5;
            this.areaChatRTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.areaChatRTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.areaChatRTB.TabIndex = 0;
            this.areaChatRTB.Text = "";
            this.areaChatRTB.TextChanged += new System.EventHandler(this.areaChatRTB_TextChanged);
            this.areaChatRTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaChatRTB_KeyPress);
            // 
            // sendMessBtn
            // 
            this.sendMessBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sendMessBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendMessBtn.Location = new System.Drawing.Point(0, 48);
            this.sendMessBtn.Name = "sendMessBtn";
            this.sendMessBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.sendMessBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sendMessBtn.Size = new System.Drawing.Size(72, 52);
            this.sendMessBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            //this.sendMessBtn.StateCommon.Back.Image = global::Hybrid.Properties.Resources.icons8_sent_32;
            this.sendMessBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.sendMessBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sendMessBtn.StateCommon.Border.Rounding = 5;
            this.sendMessBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.sendMessBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sendMessBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(88)))), ((int)(((byte)(212)))));
            this.sendMessBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(88)))), ((int)(((byte)(212)))));
            this.sendMessBtn.TabIndex = 1;
            this.sendMessBtn.Values.Text = "";
            // 
            // count_letter_lbl
            // 
            this.count_letter_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.count_letter_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.count_letter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.count_letter_lbl.Location = new System.Drawing.Point(0, 0);
            this.count_letter_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.count_letter_lbl.Name = "count_letter_lbl";
            this.count_letter_lbl.Size = new System.Drawing.Size(72, 34);
            this.count_letter_lbl.TabIndex = 4;
            this.count_letter_lbl.Text = "0/300";
            this.count_letter_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_sent_contaner
            // 
            this.panel_sent_contaner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_sent_contaner.Controls.Add(this.panel_sent_right);
            this.panel_sent_contaner.Controls.Add(this.areaChatRTB);
            this.panel_sent_contaner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_sent_contaner.Location = new System.Drawing.Point(10, 590);
            this.panel_sent_contaner.Name = "panel_sent_contaner";
            this.panel_sent_contaner.Size = new System.Drawing.Size(915, 100);
            this.panel_sent_contaner.TabIndex = 5;
            // 
            // panel_sent_right
            // 
            this.panel_sent_right.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_sent_right.Controls.Add(this.sendMessBtn);
            this.panel_sent_right.Controls.Add(this.count_letter_lbl);
            this.panel_sent_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_sent_right.Location = new System.Drawing.Point(843, 0);
            this.panel_sent_right.Name = "panel_sent_right";
            this.panel_sent_right.Size = new System.Drawing.Size(72, 100);
            this.panel_sent_right.TabIndex = 6;
            // 
            // MessageBoxContainer
            // 
            this.MessageBoxContainer.AutoScroll = true;
            this.MessageBoxContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MessageBoxContainer.Controls.Add(this.lbl_time_create_chatbox2);
            this.MessageBoxContainer.Controls.Add(this.lbl_notifiication_chatbox1);
            this.MessageBoxContainer.Controls.Add(this.btn_load_mess);
            this.MessageBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBoxContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MessageBoxContainer.Location = new System.Drawing.Point(10, 10);
            this.MessageBoxContainer.Name = "MessageBoxContainer";
            this.MessageBoxContainer.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.MessageBoxContainer.Size = new System.Drawing.Size(915, 580);
            this.MessageBoxContainer.TabIndex = 5;
            this.MessageBoxContainer.WrapContents = false;
            this.MessageBoxContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MessageBoxContainer_Scroll);
            // 
            // lbl_time_create_chatbox2
            // 
            this.lbl_time_create_chatbox2.Location = new System.Drawing.Point(23, 3);
            this.lbl_time_create_chatbox2.Name = "lbl_time_create_chatbox2";
            this.lbl_time_create_chatbox2.Size = new System.Drawing.Size(875, 45);
            this.lbl_time_create_chatbox2.TabIndex = 16;
            // 
            // lbl_notifiication_chatbox1
            // 
            this.lbl_notifiication_chatbox1.Location = new System.Drawing.Point(23, 54);
            this.lbl_notifiication_chatbox1.Name = "lbl_notifiication_chatbox1";
            this.lbl_notifiication_chatbox1.Size = new System.Drawing.Size(875, 40);
            this.lbl_notifiication_chatbox1.TabIndex = 15;
            // 
            // btn_load_mess
            // 
            this.btn_load_mess.Location = new System.Drawing.Point(440, 109);
            this.btn_load_mess.Margin = new System.Windows.Forms.Padding(420, 12, 3, 3);
            this.btn_load_mess.Name = "btn_load_mess";
            this.btn_load_mess.OverrideDefault.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_load_mess.OverrideDefault.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_load_mess.OverrideDefault.Back.Image = global::Hybrid.Properties.Resources.icons8_up_50;
            this.btn_load_mess.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btn_load_mess.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGray;
            this.btn_load_mess.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGray;
            this.btn_load_mess.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load_mess.OverrideDefault.Border.Rounding = 20;
            this.btn_load_mess.OverrideDefault.Border.Width = 3;
            this.btn_load_mess.OverrideFocus.Border.Color1 = System.Drawing.Color.LightGray;
            this.btn_load_mess.OverrideFocus.Border.Color2 = System.Drawing.Color.LightGray;
            this.btn_load_mess.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load_mess.Size = new System.Drawing.Size(40, 35);
            this.btn_load_mess.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_load_mess.StateCommon.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_load_mess.StateCommon.Back.Image = global::Hybrid.Properties.Resources.icons8_up_50;
            this.btn_load_mess.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btn_load_mess.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.btn_load_mess.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load_mess.StateCommon.Border.Rounding = 20;
            this.btn_load_mess.StateCommon.Border.Width = 3;
            this.btn_load_mess.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btn_load_mess.StatePressed.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_load_mess.StatePressed.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_load_mess.StatePressed.Border.Color1 = System.Drawing.Color.LightGray;
            this.btn_load_mess.StatePressed.Border.Color2 = System.Drawing.Color.LightGray;
            this.btn_load_mess.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load_mess.StateTracking.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.btn_load_mess.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.btn_load_mess.StateTracking.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btn_load_mess.StateTracking.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btn_load_mess.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load_mess.StateTracking.Border.Rounding = 20;
            this.btn_load_mess.StateTracking.Border.Width = 3;
            this.btn_load_mess.TabIndex = 17;
            this.btn_load_mess.Values.Text = "";
            this.btn_load_mess.Click += new System.EventHandler(this.btn_click_load_more);
            // 
            // ChatBoxFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(935, 700);
            this.Controls.Add(this.MessageBoxContainer);
            this.Controls.Add(this.panel_sent_contaner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatBoxFrm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBoxFrm";
            this.panel_sent_contaner.ResumeLayout(false);
            this.panel_sent_right.ResumeLayout(false);
            this.MessageBoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox areaChatRTB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sendMessBtn;
        private System.Windows.Forms.Label count_letter_lbl;
        private System.Windows.Forms.Panel panel_sent_contaner;
        private System.Windows.Forms.Panel panel_sent_right;
        private lbl_notifiication_chatbox lbl_notifiication_chatbox1;
        private System.Windows.Forms.FlowLayoutPanel MessageBoxContainer;
        private lbl_time_create_chatbox lbl_time_create_chatbox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_load_mess;
    }
}