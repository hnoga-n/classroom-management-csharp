namespace Hybrid.GUI
{
    partial class Thongtintaikhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_chinhsua = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.lab_xacnhan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_matkhau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_doimatkhau = new System.Windows.Forms.Label();
            this.btnTaoLop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.lab_chinhsua);
            this.panel1.Controls.Add(this.txt_ten);
            this.panel1.Controls.Add(this.hinhanh);
            this.panel1.Controls.Add(this.lab_xacnhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 153);
            this.panel1.TabIndex = 0;
            // 
            // lab_chinhsua
            // 
            this.lab_chinhsua.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lab_chinhsua.ForeColor = System.Drawing.Color.Linen;
            this.lab_chinhsua.Location = new System.Drawing.Point(252, 9);
            this.lab_chinhsua.Name = "lab_chinhsua";
            this.lab_chinhsua.Size = new System.Drawing.Size(127, 28);
            this.lab_chinhsua.TabIndex = 15;
            this.lab_chinhsua.Text = "Chỉnh sửa";
            this.lab_chinhsua.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lab_chinhsua.Click += new System.EventHandler(this.lab_chinhsua_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.txt_ten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ten.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.ForeColor = System.Drawing.Color.White;
            this.txt_ten.Location = new System.Drawing.Point(137, 58);
            this.txt_ten.MaxLength = 50;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.ReadOnly = true;
            this.txt_ten.Size = new System.Drawing.Size(260, 25);
            this.txt_ten.TabIndex = 1;
            // 
            // hinhanh
            // 
            this.hinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hinhanh.Location = new System.Drawing.Point(12, 12);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(113, 108);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 0;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // lab_xacnhan
            // 
            this.lab_xacnhan.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lab_xacnhan.ForeColor = System.Drawing.Color.Linen;
            this.lab_xacnhan.Location = new System.Drawing.Point(252, 9);
            this.lab_xacnhan.Name = "lab_xacnhan";
            this.lab_xacnhan.Size = new System.Drawing.Size(127, 28);
            this.lab_xacnhan.TabIndex = 16;
            this.lab_xacnhan.Text = "Xác nhận";
            this.lab_xacnhan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lab_xacnhan.Visible = false;
            this.lab_xacnhan.Click += new System.EventHandler(this.lab_xacnhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // lab_matkhau
            // 
            this.lab_matkhau.AutoSize = true;
            this.lab_matkhau.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_matkhau.ForeColor = System.Drawing.Color.Black;
            this.lab_matkhau.Location = new System.Drawing.Point(8, 282);
            this.lab_matkhau.Name = "lab_matkhau";
            this.lab_matkhau.Size = new System.Drawing.Size(86, 20);
            this.lab_matkhau.TabIndex = 4;
            this.lab_matkhau.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(137, 190);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(251, 28);
            this.txt_email.TabIndex = 7;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodienthoai.Location = new System.Drawing.Point(137, 231);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.ReadOnly = true;
            this.txt_sodienthoai.Size = new System.Drawing.Size(251, 28);
            this.txt_sodienthoai.TabIndex = 9;
            this.txt_sodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sodienthoai_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "**************";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_doimatkhau
            // 
            this.lab_doimatkhau.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lab_doimatkhau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab_doimatkhau.Location = new System.Drawing.Point(221, 277);
            this.lab_doimatkhau.Name = "lab_doimatkhau";
            this.lab_doimatkhau.Size = new System.Drawing.Size(158, 29);
            this.lab_doimatkhau.TabIndex = 14;
            this.lab_doimatkhau.Text = "Đổi mật khẩu";
            this.lab_doimatkhau.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lab_doimatkhau.Click += new System.EventHandler(this.lab_doimatkhau_Click);
            // 
            // btnTaoLop
            // 
            this.btnTaoLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoLop.Location = new System.Drawing.Point(144, 343);
            this.btnTaoLop.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaoLop.Name = "btnTaoLop";
            this.btnTaoLop.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.OverrideDefault.Border.Rounding = 5;
            this.btnTaoLop.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.Size = new System.Drawing.Size(120, 40);
            this.btnTaoLop.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.StateCommon.Border.Rounding = 5;
            this.btnTaoLop.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnTaoLop.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTaoLop.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTaoLop.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoLop.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnTaoLop.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnTaoLop.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTaoLop.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTaoLop.TabIndex = 15;
            this.btnTaoLop.Values.Text = "Thoát";
            this.btnTaoLop.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "**************";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_doimatkhau
            // 
            this.lab_doimatkhau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab_doimatkhau.Location = new System.Drawing.Point(221, 282);
            this.lab_doimatkhau.Name = "lab_doimatkhau";
            this.lab_doimatkhau.Size = new System.Drawing.Size(98, 20);
            this.lab_doimatkhau.TabIndex = 14;
            this.lab_doimatkhau.Text = "Đổi mật khẩu";
            this.lab_doimatkhau.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Thongtintaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 392);
            this.Controls.Add(this.btnTaoLop);
            this.Controls.Add(this.lab_doimatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sodienthoai);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_matkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Thongtintaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thongtintaikhoan";
            this.Load += new System.EventHandler(this.Thongtintaikhoan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Thongtintaikhoan_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_doimatkhau;
        private System.Windows.Forms.Label lab_chinhsua;
        private System.Windows.Forms.Label lab_xacnhan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTaoLop;
    }
}