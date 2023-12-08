namespace Hybrid.GUI
{
    partial class SignupUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupUI));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matkhau = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lab_matkhau = new System.Windows.Forms.Label();
            this.txt_email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matkhau2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.but_quaylai = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.but_dangky = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.hienmatkhau2 = new System.Windows.Forms.PictureBox();
            this.hienmatkhau1 = new System.Windows.Forms.PictureBox();
            this.anmatkhau2 = new System.Windows.Forms.PictureBox();
            this.anmatkhau1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmatkhau2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmatkhau1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmatkhau2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmatkhau1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hybrid";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(34, 312);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(330, 33);
            this.txt_matkhau.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_matkhau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_matkhau.StateCommon.Border.Rounding = 10;
            this.txt_matkhau.TabIndex = 11;
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            // 
            // lab_matkhau
            // 
            this.lab_matkhau.AutoSize = true;
            this.lab_matkhau.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_matkhau.Location = new System.Drawing.Point(19, 286);
            this.lab_matkhau.Name = "lab_matkhau";
            this.lab_matkhau.Size = new System.Drawing.Size(98, 24);
            this.lab_matkhau.TabIndex = 10;
            this.lab_matkhau.Text = "Mật khẩu:";
            this.lab_matkhau.Click += new System.EventHandler(this.lab_matkhau_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(34, 233);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(330, 33);
            this.txt_email.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_email.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_email.StateCommon.Border.Rounding = 10;
            this.txt_email.TabIndex = 9;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.Location = new System.Drawing.Point(19, 207);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(65, 24);
            this.lab_email.TabIndex = 8;
            this.lab_email.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Xác nhận mật khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_matkhau2
            // 
            this.txt_matkhau2.Location = new System.Drawing.Point(34, 389);
            this.txt_matkhau2.Name = "txt_matkhau2";
            this.txt_matkhau2.PasswordChar = '*';
            this.txt_matkhau2.Size = new System.Drawing.Size(330, 33);
            this.txt_matkhau2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_matkhau2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_matkhau2.StateCommon.Border.Rounding = 10;
            this.txt_matkhau2.TabIndex = 14;
            this.txt_matkhau2.TextChanged += new System.EventHandler(this.txt_matkhau2_TextChanged);
            // 
            // but_quaylai
            // 
            this.but_quaylai.Location = new System.Drawing.Point(113, 528);
            this.but_quaylai.Name = "but_quaylai";
            this.but_quaylai.Size = new System.Drawing.Size(164, 45);
            this.but_quaylai.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.but_quaylai.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.but_quaylai.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_quaylai.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_quaylai.StateCommon.Border.Rounding = 20;
            this.but_quaylai.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.but_quaylai.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.but_quaylai.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_quaylai.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_quaylai.TabIndex = 19;
            this.but_quaylai.Values.Text = "Quay lại";
            this.but_quaylai.Click += new System.EventHandler(this.but_quaylai_Click);
            // 
            // but_dangky
            // 
            this.but_dangky.Location = new System.Drawing.Point(87, 475);
            this.but_dangky.Name = "but_dangky";
            this.but_dangky.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangky.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangky.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangky.Size = new System.Drawing.Size(212, 47);
            this.but_dangky.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangky.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangky.StateCommon.Border.Rounding = 20;
            this.but_dangky.StateCommon.Border.Width = 1;
            this.but_dangky.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_dangky.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_dangky.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangky.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangky.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangky.StatePressed.Back.ColorAngle = 135F;
            this.but_dangky.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangky.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(17)))), ((int)(((byte)(125)))));
            this.but_dangky.StatePressed.Border.ColorAngle = 135F;
            this.but_dangky.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangky.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangky.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_dangky.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_dangky.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangky.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateTracking.Back.ColorAngle = 45F;
            this.but_dangky.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_dangky.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.but_dangky.StateTracking.Border.Rounding = 20;
            this.but_dangky.StateTracking.Border.Width = 1;
            this.but_dangky.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_dangky.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_dangky.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangky.TabIndex = 20;
            this.but_dangky.Values.Text = "Đăng ký";
            this.but_dangky.Click += new System.EventHandler(this.but_dangky_Click);
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
            this.pic_logo.TabIndex = 2;
            this.pic_logo.TabStop = false;
            // 
            // hienmatkhau2
            // 
            this.hienmatkhau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.hienmatkhau2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hienmatkhau2.Image = ((System.Drawing.Image)(resources.GetObject("hienmatkhau2.Image")));
            this.hienmatkhau2.Location = new System.Drawing.Point(321, 391);
            this.hienmatkhau2.Name = "hienmatkhau2";
            this.hienmatkhau2.Size = new System.Drawing.Size(30, 28);
            this.hienmatkhau2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hienmatkhau2.TabIndex = 16;
            this.hienmatkhau2.TabStop = false;
            this.hienmatkhau2.Click += new System.EventHandler(this.hienmatkhau2_Click);
            // 
            // hienmatkhau1
            // 
            this.hienmatkhau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.hienmatkhau1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hienmatkhau1.Image = ((System.Drawing.Image)(resources.GetObject("hienmatkhau1.Image")));
            this.hienmatkhau1.Location = new System.Drawing.Point(321, 314);
            this.hienmatkhau1.Name = "hienmatkhau1";
            this.hienmatkhau1.Size = new System.Drawing.Size(30, 28);
            this.hienmatkhau1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hienmatkhau1.TabIndex = 15;
            this.hienmatkhau1.TabStop = false;
            this.hienmatkhau1.Click += new System.EventHandler(this.hienmatkhau1_Click);
            // 
            // anmatkhau2
            // 
            this.anmatkhau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.anmatkhau2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anmatkhau2.Image = ((System.Drawing.Image)(resources.GetObject("anmatkhau2.Image")));
            this.anmatkhau2.Location = new System.Drawing.Point(321, 391);
            this.anmatkhau2.Name = "anmatkhau2";
            this.anmatkhau2.Size = new System.Drawing.Size(30, 28);
            this.anmatkhau2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anmatkhau2.TabIndex = 17;
            this.anmatkhau2.TabStop = false;
            this.anmatkhau2.Visible = false;
            this.anmatkhau2.Click += new System.EventHandler(this.anmatkhau2_Click);
            // 
            // anmatkhau1
            // 
            this.anmatkhau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.anmatkhau1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anmatkhau1.Image = ((System.Drawing.Image)(resources.GetObject("anmatkhau1.Image")));
            this.anmatkhau1.Location = new System.Drawing.Point(321, 314);
            this.anmatkhau1.Name = "anmatkhau1";
            this.anmatkhau1.Size = new System.Drawing.Size(30, 28);
            this.anmatkhau1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anmatkhau1.TabIndex = 12;
            this.anmatkhau1.TabStop = false;
            this.anmatkhau1.Visible = false;
            this.anmatkhau1.Click += new System.EventHandler(this.anmatkhau1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 425);
            this.label3.MaximumSize = new System.Drawing.Size(350, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mật khẩu có ít nhất 8 kí tự,bao gồm 1 chữ cái in hoa,1 chữ thường 1 con số,1 kí t" +
    "ự đặc biệt";
            // 
            // SignupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(382, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_dangky);
            this.Controls.Add(this.but_quaylai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_matkhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hienmatkhau2);
            this.Controls.Add(this.hienmatkhau1);
            this.Controls.Add(this.anmatkhau2);
            this.Controls.Add(this.anmatkhau1);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_matkhau2);
            this.Name = "SignupUI";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignupUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmatkhau2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmatkhau1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmatkhau2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmatkhau1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox anmatkhau1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_matkhau;
        private System.Windows.Forms.Label lab_matkhau;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_email;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_matkhau2;
        private System.Windows.Forms.PictureBox hienmatkhau1;
        private System.Windows.Forms.PictureBox hienmatkhau2;
        private System.Windows.Forms.PictureBox anmatkhau2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton but_quaylai;
        private ComponentFactory.Krypton.Toolkit.KryptonButton but_dangky;
        private System.Windows.Forms.Label label3;
    }
}