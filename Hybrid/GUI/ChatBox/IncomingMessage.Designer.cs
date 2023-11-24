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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomingMessage));
            this.panel_contain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_sent_time = new System.Windows.Forms.Label();
            this.lbl_sent_content = new System.Windows.Forms.Label();
            this.label_sent_userName = new System.Windows.Forms.Label();
            this.user_avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel_contain)).BeginInit();
            this.panel_contain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contain
            // 
            this.panel_contain.AutoSize = true;
            this.panel_contain.Controls.Add(this.lbl_sent_time);
            this.panel_contain.Controls.Add(this.lbl_sent_content);
            this.panel_contain.Controls.Add(this.label_sent_userName);
            this.panel_contain.Controls.Add(this.user_avatar);
            this.panel_contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contain.Location = new System.Drawing.Point(0, 0);
            this.panel_contain.MaximumSize = new System.Drawing.Size(490, 0);
            this.panel_contain.Name = "panel_contain";
            this.panel_contain.Size = new System.Drawing.Size(490, 151);
            this.panel_contain.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.panel_contain.TabIndex = 7;
            // 
            // lbl_sent_time
            // 
            this.lbl_sent_time.AutoSize = true;
            this.lbl_sent_time.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_sent_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_time.Location = new System.Drawing.Point(411, 0);
            this.lbl_sent_time.Name = "lbl_sent_time";
            this.lbl_sent_time.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lbl_sent_time.Size = new System.Drawing.Size(50, 24);
            this.lbl_sent_time.TabIndex = 3;
            this.lbl_sent_time.Text = "12:40";
            // 
            // lbl_sent_content
            // 
            this.lbl_sent_content.AutoSize = true;
            this.lbl_sent_content.BackColor = System.Drawing.Color.White;
            this.lbl_sent_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_content.Location = new System.Drawing.Point(57, 29);
            this.lbl_sent_content.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_sent_content.MaximumSize = new System.Drawing.Size(430, 0);
            this.lbl_sent_content.Name = "lbl_sent_content";
            this.lbl_sent_content.Padding = new System.Windows.Forms.Padding(7);
            this.lbl_sent_content.Size = new System.Drawing.Size(415, 102);
            this.lbl_sent_content.TabIndex = 2;
            this.lbl_sent_content.Text = "Mong ae tìm giúp tôi bộ này. Có nữ chính bị nhốt dưới hầm hay j đó và bị bắt đấu " +
    "với một thằng đô con, nó có thể ngửi thấy và biết gái đó còn trinh hay ko.";
            // 
            // label_sent_userName
            // 
            this.label_sent_userName.AutoSize = true;
            this.label_sent_userName.BackColor = System.Drawing.Color.Gainsboro;
            this.label_sent_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_sent_userName.Location = new System.Drawing.Point(57, 4);
            this.label_sent_userName.Name = "label_sent_userName";
            this.label_sent_userName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label_sent_userName.Size = new System.Drawing.Size(82, 22);
            this.label_sent_userName.TabIndex = 1;
            this.label_sent_userName.Text = "abc@gmail";
            // 
            // user_avatar
            // 
            this.user_avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.user_avatar.Image = ((System.Drawing.Image)(resources.GetObject("user_avatar.Image")));
            this.user_avatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("user_avatar.InitialImage")));
            this.user_avatar.Location = new System.Drawing.Point(0, 0);
            this.user_avatar.Name = "user_avatar";
            this.user_avatar.Size = new System.Drawing.Size(50, 50);
            this.user_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_avatar.TabIndex = 0;
            this.user_avatar.TabStop = false;
            // 
            // IncomingMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel_contain);
            this.MaximumSize = new System.Drawing.Size(875, 0);
            this.Name = "IncomingMessage";
            this.Size = new System.Drawing.Size(495, 151);
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
        private System.Windows.Forms.Label label_sent_userName;
        private System.Windows.Forms.PictureBox user_avatar;
        private System.Windows.Forms.Label lbl_sent_time;
    }
}
