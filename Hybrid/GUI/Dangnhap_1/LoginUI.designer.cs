namespace Hybrid.GUI
{
    partial class LoginUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lab_tieude = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lab_matkhau = new System.Windows.Forms.Label();
            this.txt_matkhau = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dangky = new System.Windows.Forms.Label();
            this.chx_nhomatkhau = new System.Windows.Forms.CheckBox();
            this.quenmatkhau = new System.Windows.Forms.Label();
            this.anmatkhau = new System.Windows.Forms.PictureBox();
            this.hienmatkhau = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.but_dangnhap = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.anmatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // lab_tieude
            // 
            this.lab_tieude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_tieude.AutoSize = true;
            this.lab_tieude.Font = new System.Drawing.Font("Roboto Medium", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tieude.Location = new System.Drawing.Point(108, 5);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(169, 57);
            this.lab_tieude.TabIndex = 0;
            this.lab_tieude.Text = "Hybrid";
            this.lab_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.Location = new System.Drawing.Point(12, 201);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(65, 24);
            this.lab_email.TabIndex = 2;
            this.lab_email.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(27, 227);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(330, 38);
            this.txt_email.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_email.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_email.StateCommon.Border.Rounding = 10;
            this.txt_email.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_email.TabIndex = 3;
            // 
            // lab_matkhau
            // 
            this.lab_matkhau.AutoSize = true;
            this.lab_matkhau.Font = new System.Drawing.Font("Roboto", 12F);
            this.lab_matkhau.Location = new System.Drawing.Point(12, 280);
            this.lab_matkhau.Name = "lab_matkhau";
            this.lab_matkhau.Size = new System.Drawing.Size(98, 24);
            this.lab_matkhau.TabIndex = 4;
            this.lab_matkhau.Text = "Mật khẩu:";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(27, 306);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(330, 38);
            this.txt_matkhau.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_matkhau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_matkhau.StateCommon.Border.Rounding = 10;
            this.txt_matkhau.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_matkhau.TabIndex = 5;
            // 
            // dangky
            // 
            this.dangky.AutoSize = true;
            this.dangky.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(41)))), ((int)(((byte)(222)))));
            this.dangky.Location = new System.Drawing.Point(113, 427);
            this.dangky.Name = "dangky";
            this.dangky.Size = new System.Drawing.Size(140, 19);
            this.dangky.TabIndex = 9;
            this.dangky.Text = "Đăng ký tài khoản";
            this.dangky.Click += new System.EventHandler(this.dangky_Click);
            // 
            // chx_nhomatkhau
            // 
            this.chx_nhomatkhau.AutoSize = true;
            this.chx_nhomatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_nhomatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(41)))), ((int)(((byte)(222)))));
            this.chx_nhomatkhau.Location = new System.Drawing.Point(12, 496);
            this.chx_nhomatkhau.Name = "chx_nhomatkhau";
            this.chx_nhomatkhau.Size = new System.Drawing.Size(152, 27);
            this.chx_nhomatkhau.TabIndex = 10;
            this.chx_nhomatkhau.Text = "Nhớ mật khẩu";
            this.chx_nhomatkhau.UseVisualStyleBackColor = true;
            // 
            // quenmatkhau
            // 
            this.quenmatkhau.AutoSize = true;
            this.quenmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenmatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(41)))), ((int)(((byte)(222)))));
            this.quenmatkhau.Location = new System.Drawing.Point(217, 496);
            this.quenmatkhau.Name = "quenmatkhau";
            this.quenmatkhau.Size = new System.Drawing.Size(148, 23);
            this.quenmatkhau.TabIndex = 11;
            this.quenmatkhau.Text = "Quên mật khẩu?";
            this.quenmatkhau.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // anmatkhau
            // 
            this.anmatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.anmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anmatkhau.Image = ((System.Drawing.Image)(resources.GetObject("anmatkhau.Image")));
            this.anmatkhau.Location = new System.Drawing.Point(314, 308);
            this.anmatkhau.Name = "anmatkhau";
            this.anmatkhau.Size = new System.Drawing.Size(30, 28);
            this.anmatkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anmatkhau.TabIndex = 7;
            this.anmatkhau.TabStop = false;
            this.anmatkhau.Visible = false;
            this.anmatkhau.Click += new System.EventHandler(this.anmatkhau_Click);
            // 
            // hienmatkhau
            // 
            this.hienmatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.hienmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hienmatkhau.Image = ((System.Drawing.Image)(resources.GetObject("hienmatkhau.Image")));
            this.hienmatkhau.Location = new System.Drawing.Point(314, 308);
            this.hienmatkhau.Name = "hienmatkhau";
            this.hienmatkhau.Size = new System.Drawing.Size(30, 28);
            this.hienmatkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hienmatkhau.TabIndex = 6;
            this.hienmatkhau.TabStop = false;
            this.hienmatkhau.Click += new System.EventHandler(this.hienmatkhau_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(117, 61);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(146, 129);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 1;
            this.pic_logo.TabStop = false;
            // 
            // but_dangnhap
            // 
            this.but_dangnhap.Location = new System.Drawing.Point(76, 363);
            this.but_dangnhap.Name = "but_dangnhap";
            this.but_dangnhap.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangnhap.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangnhap.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangnhap.Size = new System.Drawing.Size(212, 47);
            this.but_dangnhap.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangnhap.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangnhap.StateCommon.Border.Rounding = 20;
            this.but_dangnhap.StateCommon.Border.Width = 1;
            this.but_dangnhap.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_dangnhap.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_dangnhap.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangnhap.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangnhap.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangnhap.StatePressed.Back.ColorAngle = 135F;
            this.but_dangnhap.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangnhap.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangnhap.StatePressed.Border.ColorAngle = 135F;
            this.but_dangnhap.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangnhap.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangnhap.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_dangnhap.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_dangnhap.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangnhap.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateTracking.Back.ColorAngle = 45F;
            this.but_dangnhap.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangnhap.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangnhap.StateTracking.Border.Rounding = 20;
            this.but_dangnhap.StateTracking.Border.Width = 1;
            this.but_dangnhap.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_dangnhap.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_dangnhap.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangnhap.TabIndex = 12;
            this.but_dangnhap.Values.Text = "Đăng nhập";
            this.but_dangnhap.Click += new System.EventHandler(this.but_dangnhap_Click_2);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoginUI
            // 
            this.AcceptButton = this.but_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.but_dangnhap);
            this.Controls.Add(this.quenmatkhau);
            this.Controls.Add(this.chx_nhomatkhau);
            this.Controls.Add(this.dangky);
            this.Controls.Add(this.hienmatkhau);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.lab_tieude);
            this.Controls.Add(this.anmatkhau);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.lab_matkhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_email);
            this.MaximizeBox = false;
            this.Name = "LoginUI";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginUI_FormClosing);
            this.Load += new System.EventHandler(this.LoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anmatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lab_email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_email;
        private System.Windows.Forms.Label lab_matkhau;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_matkhau;
        private System.Windows.Forms.PictureBox hienmatkhau;
        private System.Windows.Forms.PictureBox anmatkhau;
        private System.Windows.Forms.Label dangky;
        private System.Windows.Forms.CheckBox chx_nhomatkhau;
        private System.Windows.Forms.Label quenmatkhau;
        private ComponentFactory.Krypton.Toolkit.KryptonButton but_dangnhap;
        private System.Windows.Forms.ImageList imageList1;
    }
}