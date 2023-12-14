using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.GUI.Kiemtra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hybrid.GUI.Dangnhap
{
    public partial class Doimatkhaufrm : KryptonForm
    {
        TaikhoanBUS taikhoanBUS=new TaikhoanBUS();
        TaikhoanDAO taikhoanDAO=new TaikhoanDAO();
        string emai;
        public Doimatkhaufrm(string email)
        {
            InitializeComponent();
            this.emai = email;
        }

        private void Doimatkhaufrm_Load(object sender, EventArgs e)

        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (txt_mkcu.Text.Length == 0 || txt_mkmoi.Text.Length == 0 || txt_mkxacnhan.Text.Length == 0)
                MessageBox.Show("Vui lòng nhập đầy đủ");
            else
                if (taikhoanBUS.kt_dinhdang_matkhau(txt_mkcu.Text) == false || taikhoanBUS.kt_dinhdang_matkhau(txt_mkmoi.Text) == false || taikhoanBUS.kt_dinhdang_matkhau(txt_mkxacnhan.Text) == false)
                    MessageBox.Show("Mật khẩu không đúng định dạng.\nVd:Abcxyz@123", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    if (txt_mkcu.Text == txt_mkmoi.Text)
                        MessageBox.Show("Vui lòng nhập mật khẩu mới khác mật khẩu cũ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                        if (txt_mkmoi.Text != txt_mkxacnhan.Text)
                            MessageBox.Show("Mật khẩu xác nhận không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            DialogResult result = MessageBox.Show("Xác nhận đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            // Kiểm tra kết quả và thực hiện hành động tương ứng
                            if (result == DialogResult.Yes)
                            {
                                taikhoanBUS.thaydoimatkhau(this.emai, txt_mkmoi.Text);
                                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else if(result == DialogResult.No)
                            {
                                this.Close();
                            }
            }                
        }

        private void an_mkcu_Click(object sender, EventArgs e)
        {
            txt_mkcu.PasswordChar = '*';
            hien_mkcu.Visible = true;
            an_mkcu.Visible = false;
        }

        private void an_mkmoi_Click(object sender, EventArgs e)
        {
            txt_mkmoi.PasswordChar = '*';
            hien_mkmoi.Visible = true;
            an_mkmoi.Visible = false;
        }

        private void an_mkxacnhan_Click(object sender, EventArgs e)
        {
            txt_mkxacnhan.PasswordChar = '*';
            hien_mkxacnhan.Visible = true;
            an_mkxacnhan.Visible = false;
        }

        private void hien_mkcu_Click(object sender, EventArgs e)
        {
            txt_mkcu.PasswordChar = '\0';
            hien_mkcu.Visible = false;
            an_mkcu.Visible = true;
        }

        private void hien_mkmoi_Click(object sender, EventArgs e)
        {
            txt_mkmoi.PasswordChar = '\0';
            hien_mkmoi.Visible = false;
            an_mkmoi.Visible = true;
        }

        private void hien_mkxacnhan_Click(object sender, EventArgs e)
        {
            txt_mkxacnhan.PasswordChar = '\0';
            hien_mkxacnhan.Visible = false;
            an_mkxacnhan.Visible = true;
        }

        private void txt_mkmoi_TextChanged(object sender, EventArgs e)
        {
            if (taikhoanBUS.kt_dinhdang_matkhau(txt_mkmoi.Text))
                lab_thongtin.ForeColor = Color.Blue;
            else
                lab_thongtin.ForeColor = Color.Red;
        }
    }
}
