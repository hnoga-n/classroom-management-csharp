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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongtintaikhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_chinhthongtin = new System.Windows.Forms.Label();
            this.lab_ten = new System.Windows.Forms.Label();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(107)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lab_chinhthongtin);
            this.panel1.Controls.Add(this.lab_ten);
            this.panel1.Controls.Add(this.hinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 153);
            this.panel1.TabIndex = 0;
            // 
            // lab_chinhthongtin
            // 
            this.lab_chinhthongtin.AutoSize = true;
            this.lab_chinhthongtin.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_chinhthongtin.ForeColor = System.Drawing.Color.White;
            this.lab_chinhthongtin.Location = new System.Drawing.Point(301, 9);
            this.lab_chinhthongtin.Name = "lab_chinhthongtin";
            this.lab_chinhthongtin.Size = new System.Drawing.Size(87, 20);
            this.lab_chinhthongtin.TabIndex = 2;
            this.lab_chinhthongtin.Text = "Chỉnh sửa";
            // 
            // lab_ten
            // 
            this.lab_ten.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ten.ForeColor = System.Drawing.Color.White;
            this.lab_ten.Location = new System.Drawing.Point(131, 82);
            this.lab_ten.Name = "lab_ten";
            this.lab_ten.Size = new System.Drawing.Size(257, 38);
            this.lab_ten.TabIndex = 1;
            this.lab_ten.Text = "Lâm Tuấn Kiệt";
            // 
            // hinhanh
            // 
            this.hinhanh.Image = ((System.Drawing.Image)(resources.GetObject("hinhanh.Image")));
            this.hinhanh.Location = new System.Drawing.Point(12, 12);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(113, 108);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 0;
            this.hinhanh.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại:";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(137, 193);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(251, 22);
            this.txt_email.TabIndex = 7;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Enabled = false;
            this.txt_matkhau.Location = new System.Drawing.Point(137, 240);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(251, 22);
            this.txt_matkhau.TabIndex = 8;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Enabled = false;
            this.txt_sodienthoai.Location = new System.Drawing.Point(137, 295);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(251, 22);
            this.txt_sodienthoai.TabIndex = 9;
            // 
            // Thongtintaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 499);
            this.Controls.Add(this.txt_sodienthoai);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Thongtintaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thongtintaikhoan";
            this.Load += new System.EventHandler(this.Thongtintaikhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.Label lab_ten;
        private System.Windows.Forms.Label lab_chinhthongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_sodienthoai;
    }
}