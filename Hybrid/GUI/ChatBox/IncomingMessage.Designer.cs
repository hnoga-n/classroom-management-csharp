namespace Hybrid.GUI.ChatBox
{
    partial class IncomingMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_contain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_sent_userName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_sent_time = new System.Windows.Forms.Label();
            this.lbl_sent_content = new System.Windows.Forms.Label();
            this.user_avatar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menu_TinNhan = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panel_contain)).BeginInit();
            this.panel_contain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contain
            // 
            this.panel_contain.AutoSize = true;
            this.panel_contain.Controls.Add(this.lbl_sent_userName);
            this.panel_contain.Controls.Add(this.lbl_sent_time);
            this.panel_contain.Controls.Add(this.lbl_sent_content);
            this.panel_contain.Controls.Add(this.user_avatar);
            this.panel_contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contain.Location = new System.Drawing.Point(0, 0);
            this.panel_contain.MaximumSize = new System.Drawing.Size(490, 0);
            this.panel_contain.Name = "panel_contain";
            this.panel_contain.Size = new System.Drawing.Size(490, 129);
            this.panel_contain.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panel_contain.TabIndex = 7;
            // 
            // lbl_sent_userName
            // 
            this.lbl_sent_userName.Location = new System.Drawing.Point(61, 3);
            this.lbl_sent_userName.Name = "lbl_sent_userName";
            this.lbl_sent_userName.Size = new System.Drawing.Size(89, 21);
            this.lbl_sent_userName.StateCommon.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.lbl_sent_userName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_userName.TabIndex = 4;
            this.lbl_sent_userName.Values.Text = "abc@gmail";
            // 
            // lbl_sent_time
            // 
            this.lbl_sent_time.AutoSize = true;
            this.lbl_sent_time.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_sent_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_time.Location = new System.Drawing.Point(0, 53);
            this.lbl_sent_time.Name = "lbl_sent_time";
            this.lbl_sent_time.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lbl_sent_time.Size = new System.Drawing.Size(50, 24);
            this.lbl_sent_time.TabIndex = 3;
            this.lbl_sent_time.Text = "12:40";
            // 
            // lbl_sent_content
            // 
            this.lbl_sent_content.AutoSize = true;
            this.lbl_sent_content.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_sent_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_content.Location = new System.Drawing.Point(57, 29);
            this.lbl_sent_content.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_sent_content.MaximumSize = new System.Drawing.Size(430, 0);
            this.lbl_sent_content.Name = "lbl_sent_content";
            this.lbl_sent_content.Padding = new System.Windows.Forms.Padding(7);
            this.lbl_sent_content.Size = new System.Drawing.Size(419, 80);
            this.lbl_sent_content.TabIndex = 2;
            this.lbl_sent_content.Text = "You can create various types of projects from the Project dialog box in Visual St" +
    "udio. Go to the left-hand side and click on the “Windows” option.";
            this.lbl_sent_content.Click += new System.EventHandler(this.lbl_sent_content_MouseClick);
            // 
            // user_avatar
            // 
            this.user_avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.user_avatar.Location = new System.Drawing.Point(0, 0);
            this.user_avatar.Name = "user_avatar";
            this.user_avatar.Size = new System.Drawing.Size(50, 50);
            this.user_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_avatar.TabIndex = 0;
            this.user_avatar.TabStop = false;
            // 
            // menu_TinNhan
            // 
            this.menu_TinNhan.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            this.menu_TinNhan.Opening += new System.ComponentModel.CancelEventHandler(this.menu_TinNhan_Opening);
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuItem2});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.CheckOnClick = true;
            this.kryptonContextMenuItem1.Image = global::Hybrid.Properties.Resources.icons8_copy_24;
            this.kryptonContextMenuItem1.Text = "Copy";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Image = global::Hybrid.Properties.Resources.trash_32;
            this.kryptonContextMenuItem2.Text = "Delete";
            // 
            // IncomingMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel_contain);
            this.MaximumSize = new System.Drawing.Size(875, 0);
            this.Name = "IncomingMessage";
            this.Size = new System.Drawing.Size(490, 129);
            this.Load += new System.EventHandler(this.IncomingMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_contain)).EndInit();
            this.panel_contain.ResumeLayout(false);
            this.panel_contain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_contain;
        private System.Windows.Forms.Label lbl_sent_content;
        private System.Windows.Forms.PictureBox user_avatar;
        private System.Windows.Forms.Label lbl_sent_time;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_sent_userName;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu menu_TinNhan;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
    }
}