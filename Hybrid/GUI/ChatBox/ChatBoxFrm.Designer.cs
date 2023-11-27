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
            this.MessageBox = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_time_create_chatbox1 = new Hybrid.GUI.ChatBox.lbl_time_create_chatbox();
            this.lbl_notifiication_chatbox1 = new Hybrid.GUI.ChatBox.lbl_notifiication_chatbox();
            this.incomingMessage2 = new Hybrid.GUI.ChatBox.IncomingMessage();
            this.outgoingMessage1 = new Hybrid.GUI.ChatBox.OutgoingMessage();
            this.incomingMessage1 = new Hybrid.GUI.ChatBox.IncomingMessage();
            this.incomingMessage3 = new Hybrid.GUI.ChatBox.IncomingMessage();
            this.incomingMessage4 = new Hybrid.GUI.ChatBox.IncomingMessage();
            this.incomingMessage5 = new Hybrid.GUI.ChatBox.IncomingMessage();
            this.incomingMessage6 = new Hybrid.GUI.ChatBox.IncomingMessage();
            this.incomingMessage7 = new Hybrid.GUI.ChatBox.IncomingMessage();
            this.panel_sent_contaner.SuspendLayout();
            this.panel_sent_right.SuspendLayout();
            this.MessageBox.SuspendLayout();
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
            this.areaChatRTB.TextChanged += new System.EventHandler(this.kryptonRichTextBox1_TextChanged);
            // 
            // sendMessBtn
            // 
            this.sendMessBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sendMessBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendMessBtn.Location = new System.Drawing.Point(0, 48);
            this.sendMessBtn.Name = "sendMessBtn";
            this.sendMessBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.sendMessBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.sendMessBtn.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.sendMessBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sendMessBtn.Size = new System.Drawing.Size(72, 52);
            this.sendMessBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.sendMessBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.sendMessBtn.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            //this.sendMessBtn.StateCommon.Back.Image = global::Hybrid.Properties.Resources.icons8_sent_32;
            this.sendMessBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.sendMessBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sendMessBtn.StateCommon.Border.Rounding = 5;
            this.sendMessBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.sendMessBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sendMessBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(100)))));
            this.sendMessBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(100)))));
            this.sendMessBtn.TabIndex = 1;
            this.sendMessBtn.Values.Text = "";
            this.sendMessBtn.Click += new System.EventHandler(this.sendMessBtn_Click);
            // 
            // count_letter_lbl
            // 
            this.count_letter_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.count_letter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.count_letter_lbl.Location = new System.Drawing.Point(0, 0);
            this.count_letter_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.count_letter_lbl.Name = "count_letter_lbl";
            this.count_letter_lbl.Size = new System.Drawing.Size(72, 34);
            this.count_letter_lbl.TabIndex = 4;
            this.count_letter_lbl.Text = "0/300";
            this.count_letter_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.count_letter_lbl.Click += new System.EventHandler(this.count_letter_lbl_Click);
            // 
            // panel_sent_contaner
            // 
            this.panel_sent_contaner.Controls.Add(this.panel_sent_right);
            this.panel_sent_contaner.Controls.Add(this.areaChatRTB);
            this.panel_sent_contaner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_sent_contaner.Location = new System.Drawing.Point(10, 590);
            this.panel_sent_contaner.Name = "panel_sent_contaner";
            this.panel_sent_contaner.Size = new System.Drawing.Size(915, 100);
            this.panel_sent_contaner.TabIndex = 5;
            this.panel_sent_contaner.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sent_contaner_Paint);
            // 
            // panel_sent_right
            // 
            this.panel_sent_right.Controls.Add(this.sendMessBtn);
            this.panel_sent_right.Controls.Add(this.count_letter_lbl);
            this.panel_sent_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_sent_right.Location = new System.Drawing.Point(843, 0);
            this.panel_sent_right.Name = "panel_sent_right";
            this.panel_sent_right.Size = new System.Drawing.Size(72, 100);
            this.panel_sent_right.TabIndex = 6;
            this.panel_sent_right.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sent_right_Paint);
            // 
            // MessageBox
            // 
            this.MessageBox.AutoScroll = true;
            this.MessageBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MessageBox.Controls.Add(this.lbl_time_create_chatbox1);
            this.MessageBox.Controls.Add(this.lbl_notifiication_chatbox1);
            this.MessageBox.Controls.Add(this.incomingMessage2);
            this.MessageBox.Controls.Add(this.outgoingMessage1);
            this.MessageBox.Controls.Add(this.incomingMessage1);
            this.MessageBox.Controls.Add(this.incomingMessage3);
            this.MessageBox.Controls.Add(this.incomingMessage4);
            this.MessageBox.Controls.Add(this.incomingMessage5);
            this.MessageBox.Controls.Add(this.incomingMessage6);
            this.MessageBox.Controls.Add(this.incomingMessage7);
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MessageBox.Location = new System.Drawing.Point(10, 10);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.MessageBox.Size = new System.Drawing.Size(915, 574);
            this.MessageBox.TabIndex = 5;
            this.MessageBox.WrapContents = false;
            this.MessageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MessageBox_Paint);
            // 
            // lbl_time_create_chatbox1
            // 
            this.lbl_time_create_chatbox1.Location = new System.Drawing.Point(23, 3);
            this.lbl_time_create_chatbox1.Name = "lbl_time_create_chatbox1";
            this.lbl_time_create_chatbox1.Size = new System.Drawing.Size(875, 40);
            this.lbl_time_create_chatbox1.TabIndex = 14;
            this.lbl_time_create_chatbox1.Load += new System.EventHandler(this.lbl_time_create_chatbox1_Load);
            // 
            // lbl_notifiication_chatbox1
            // 
            this.lbl_notifiication_chatbox1.Location = new System.Drawing.Point(23, 49);
            this.lbl_notifiication_chatbox1.Name = "lbl_notifiication_chatbox1";
            this.lbl_notifiication_chatbox1.Size = new System.Drawing.Size(875, 40);
            this.lbl_notifiication_chatbox1.TabIndex = 15;
            this.lbl_notifiication_chatbox1.Load += new System.EventHandler(this.lbl_notifiication_chatbox1_Load);
            // 
            // incomingMessage2
            // 
            this.incomingMessage2.AutoSize = true;
            this.incomingMessage2.Location = new System.Drawing.Point(23, 95);
            this.incomingMessage2.MaximumSize = new System.Drawing.Size(995, 0);
            this.incomingMessage2.Name = "incomingMessage2";
            this.incomingMessage2.Size = new System.Drawing.Size(480, 151);
            this.incomingMessage2.TabIndex = 8;
            this.incomingMessage2.Load += new System.EventHandler(this.incomingMessage2_Load);
            // 
            // outgoingMessage1
            // 
            this.outgoingMessage1.AutoSize = true;
            this.outgoingMessage1.BackColor = System.Drawing.Color.Gainsboro;
            this.outgoingMessage1.Location = new System.Drawing.Point(20, 249);
            this.outgoingMessage1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.outgoingMessage1.MaximumSize = new System.Drawing.Size(875, 0);
            this.outgoingMessage1.Name = "outgoingMessage1";
            this.outgoingMessage1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.outgoingMessage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.outgoingMessage1.Size = new System.Drawing.Size(875, 274);
            this.outgoingMessage1.TabIndex = 16;
            this.outgoingMessage1.Load += new System.EventHandler(this.outgoingMessage1_Load);
            // 
            // incomingMessage1
            // 
            this.incomingMessage1.AutoSize = true;
            this.incomingMessage1.Location = new System.Drawing.Point(23, 546);
            this.incomingMessage1.MaximumSize = new System.Drawing.Size(495, 0);
            this.incomingMessage1.MinimumSize = new System.Drawing.Size(0, 100);
            this.incomingMessage1.Name = "incomingMessage1";
            this.incomingMessage1.Size = new System.Drawing.Size(480, 151);
            this.incomingMessage1.TabIndex = 7;
            this.incomingMessage1.Load += new System.EventHandler(this.incomingMessage1_Load);
            // 
            // incomingMessage3
            // 
            this.incomingMessage3.AutoSize = true;
            this.incomingMessage3.Location = new System.Drawing.Point(23, 703);
            this.incomingMessage3.MaximumSize = new System.Drawing.Size(495, 0);
            this.incomingMessage3.MinimumSize = new System.Drawing.Size(0, 100);
            this.incomingMessage3.Name = "incomingMessage3";
            this.incomingMessage3.Size = new System.Drawing.Size(480, 151);
            this.incomingMessage3.TabIndex = 9;
            this.incomingMessage3.Load += new System.EventHandler(this.incomingMessage3_Load);
            // 
            // incomingMessage4
            // 
            this.incomingMessage4.AutoSize = true;
            this.incomingMessage4.Location = new System.Drawing.Point(23, 860);
            this.incomingMessage4.MaximumSize = new System.Drawing.Size(495, 0);
            this.incomingMessage4.MinimumSize = new System.Drawing.Size(0, 100);
            this.incomingMessage4.Name = "incomingMessage4";
            this.incomingMessage4.Size = new System.Drawing.Size(480, 151);
            this.incomingMessage4.TabIndex = 10;
            this.incomingMessage4.Load += new System.EventHandler(this.incomingMessage4_Load);
            // 
            // incomingMessage5
            // 
            this.incomingMessage5.AutoSize = true;
            this.incomingMessage5.Location = new System.Drawing.Point(23, 1017);
            this.incomingMessage5.MaximumSize = new System.Drawing.Size(495, 0);
            this.incomingMessage5.MinimumSize = new System.Drawing.Size(0, 100);
            this.incomingMessage5.Name = "incomingMessage5";
            this.incomingMessage5.Size = new System.Drawing.Size(480, 151);
            this.incomingMessage5.TabIndex = 11;
            this.incomingMessage5.Load += new System.EventHandler(this.incomingMessage5_Load);
            // 
            // incomingMessage6
            // 
            this.incomingMessage6.AutoSize = true;
            this.incomingMessage6.Location = new System.Drawing.Point(23, 1174);
            this.incomingMessage6.MaximumSize = new System.Drawing.Size(495, 0);
            this.incomingMessage6.MinimumSize = new System.Drawing.Size(0, 100);
            this.incomingMessage6.Name = "incomingMessage6";
            this.incomingMessage6.Size = new System.Drawing.Size(480, 151);
            this.incomingMessage6.TabIndex = 12;
            this.incomingMessage6.Load += new System.EventHandler(this.incomingMessage6_Load);
            // 
            // incomingMessage7
            // 
            this.incomingMessage7.AutoSize = true;
            this.incomingMessage7.Location = new System.Drawing.Point(23, 1331);
            this.incomingMessage7.MaximumSize = new System.Drawing.Size(495, 0);
            this.incomingMessage7.MinimumSize = new System.Drawing.Size(0, 100);
            this.incomingMessage7.Name = "incomingMessage7";
            this.incomingMessage7.Size = new System.Drawing.Size(480, 151);
            this.incomingMessage7.TabIndex = 13;
            this.incomingMessage7.Load += new System.EventHandler(this.incomingMessage7_Load);
            // 
            // ChatBoxFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(935, 700);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.panel_sent_contaner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatBoxFrm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBoxFrm";
            this.panel_sent_contaner.ResumeLayout(false);
            this.panel_sent_right.ResumeLayout(false);
            this.MessageBox.ResumeLayout(false);
            this.MessageBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox areaChatRTB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sendMessBtn;
        private System.Windows.Forms.Label count_letter_lbl;
        private System.Windows.Forms.Panel panel_sent_contaner;
        private System.Windows.Forms.Panel panel_sent_right;
        private System.Windows.Forms.FlowLayoutPanel MessageBox;
        private IncomingMessage incomingMessage1;
        private IncomingMessage incomingMessage2;
        private IncomingMessage incomingMessage3;
        private IncomingMessage incomingMessage4;
        private IncomingMessage incomingMessage5;
        private IncomingMessage incomingMessage6;
        private IncomingMessage incomingMessage7;
        private lbl_time_create_chatbox lbl_time_create_chatbox1;
        private lbl_notifiication_chatbox lbl_notifiication_chatbox1;
        private OutgoingMessage outgoingMessage1;
    }
}