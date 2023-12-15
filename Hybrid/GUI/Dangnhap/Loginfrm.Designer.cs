namespace Hybrid.GUI.Dangnhap
{
    partial class Loginfrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.thanhngang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.quenmatkhau = new System.Windows.Forms.Label();
            this.chx_nhomatkhau = new System.Windows.Forms.CheckBox();
            this.but_dangnhap = new System.Windows.Forms.Button();
            this.but_dangky = new System.Windows.Forms.Button();
            this.pic_showpass = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_hidepass = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_showpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hidepass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(450, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 600);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(128, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 72);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hybrid";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Hybrid.Properties.Resources.icons8_close_30;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(414, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 21);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Hybrid.Properties.Resources.videoconference;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(76, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(321, 255);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Silver;
            this.txt_email.Location = new System.Drawing.Point(88, 229);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(336, 28);
            this.txt_email.TabIndex = 3;
            this.txt_email.Text = "Email";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // thanhngang
            // 
            this.thanhngang.BackColor = System.Drawing.Color.Black;
            this.thanhngang.Location = new System.Drawing.Point(85, 260);
            this.thanhngang.Name = "thanhngang";
            this.thanhngang.Size = new System.Drawing.Size(336, 2);
            this.thanhngang.TabIndex = 4;
            this.thanhngang.Text = "label2";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(82, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 2);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.Silver;
            this.txt_matkhau.Location = new System.Drawing.Point(85, 317);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(287, 28);
            this.txt_matkhau.TabIndex = 4;
            this.txt_matkhau.Text = "Mật khẩu";
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            this.txt_matkhau.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_matkhau.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // quenmatkhau
            // 
            this.quenmatkhau.AutoSize = true;
            this.quenmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenmatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.quenmatkhau.Location = new System.Drawing.Point(270, 427);
            this.quenmatkhau.Name = "quenmatkhau";
            this.quenmatkhau.Size = new System.Drawing.Size(148, 23);
            this.quenmatkhau.TabIndex = 6;
            this.quenmatkhau.Text = "Quên mật khẩu?";
            this.quenmatkhau.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // chx_nhomatkhau
            // 
            this.chx_nhomatkhau.AutoSize = true;
            this.chx_nhomatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_nhomatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.chx_nhomatkhau.Location = new System.Drawing.Point(36, 427);
            this.chx_nhomatkhau.Name = "chx_nhomatkhau";
            this.chx_nhomatkhau.Size = new System.Drawing.Size(152, 27);
            this.chx_nhomatkhau.TabIndex = 5;
            this.chx_nhomatkhau.Text = "Nhớ mật khẩu";
            this.chx_nhomatkhau.UseVisualStyleBackColor = true;
            // 
            // but_dangnhap
            // 
            this.but_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangnhap.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangnhap.ForeColor = System.Drawing.Color.White;
            this.but_dangnhap.Location = new System.Drawing.Point(88, 473);
            this.but_dangnhap.Name = "but_dangnhap";
            this.but_dangnhap.Size = new System.Drawing.Size(261, 55);
            this.but_dangnhap.TabIndex = 1;
            this.but_dangnhap.Text = "Đăng nhập";
            this.but_dangnhap.UseVisualStyleBackColor = false;
            this.but_dangnhap.Click += new System.EventHandler(this.but_dangnhap_Click);
            this.but_dangnhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.but_dangnhap_KeyDown);
            // 
            // but_dangky
            // 
            this.but_dangky.BackColor = System.Drawing.Color.White;
            this.but_dangky.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_dangky.Location = new System.Drawing.Point(88, 534);
            this.but_dangky.Name = "but_dangky";
            this.but_dangky.Size = new System.Drawing.Size(261, 44);
            this.but_dangky.TabIndex = 2;
            this.but_dangky.Text = "Đăng ký";
            this.but_dangky.UseVisualStyleBackColor = false;
            this.but_dangky.Click += new System.EventHandler(this.but_dangky_Click);
            // 
            // pic_showpass
            // 
            this.pic_showpass.BackgroundImage = global::Hybrid.Properties.Resources.show_24;
            this.pic_showpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_showpass.Location = new System.Drawing.Point(378, 317);
            this.pic_showpass.Name = "pic_showpass";
            this.pic_showpass.Size = new System.Drawing.Size(40, 28);
            this.pic_showpass.TabIndex = 8;
            this.pic_showpass.TabStop = false;
            this.pic_showpass.Click += new System.EventHandler(this.pic_showpass_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Hybrid.Properties.Resources.padlock_1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(36, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hybrid.Properties.Resources.mail;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(36, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pic_hidepass
            // 
            this.pic_hidepass.BackgroundImage = global::Hybrid.Properties.Resources.hide_24;
            this.pic_hidepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_hidepass.Location = new System.Drawing.Point(378, 317);
            this.pic_hidepass.Name = "pic_hidepass";
            this.pic_hidepass.Size = new System.Drawing.Size(40, 28);
            this.pic_hidepass.TabIndex = 9;
            this.pic_hidepass.TabStop = false;
            this.pic_hidepass.Click += new System.EventHandler(this.pic_hidepass_Click);
            // 
            // Loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.but_dangky);
            this.Controls.Add(this.but_dangnhap);
            this.Controls.Add(this.chx_nhomatkhau);
            this.Controls.Add(this.quenmatkhau);
            this.Controls.Add(this.pic_showpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.thanhngang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_hidepass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginfrm";
            this.Load += new System.EventHandler(this.Loginfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_showpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hidepass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label thanhngang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_showpass;
        private System.Windows.Forms.PictureBox pic_hidepass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label quenmatkhau;
        private System.Windows.Forms.CheckBox chx_nhomatkhau;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button but_dangnhap;
        private System.Windows.Forms.Button but_dangky;
    }
}