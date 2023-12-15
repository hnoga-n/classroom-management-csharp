using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using Hybrid.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hybrid.GUI.Dangnhap
{
    public partial class Loginfrm : Form
    {
        TaikhoanDAO tkdao=new TaikhoanDAO();
        TaikhoanBUS tkbus=new TaikhoanBUS();
        Chucnang cn = new Chucnang();
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = but_dangnhap;
            //this.ActiveControl = null;
            if (cn.lay_nhomk() == "1")
            {
                chx_nhomatkhau.Checked = true;
                Taikhoan tk = cn.doc_tk_file();
                Taikhoan tk1 = tkbus.GetTaiKhoanByEmail(tk.Email);
                this.Hide();
                KryptonForm form = new Form1(tk1);
                form.ShowDialog();
            }
            else
                chx_nhomatkhau.Checked = false;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = string.Empty;
            }
            txt_email.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
               txt_email.Text = "Email";
                txt_email.ForeColor = System.Drawing.Color.Silver;
            }
            
        }


        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "Mật khẩu")
            {
                txt_matkhau.Text = string.Empty;
            }
            txt_matkhau.ForeColor= System.Drawing.Color.Black;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                txt_matkhau.Text = "Mật khẩu";
                txt_matkhau.ForeColor = System.Drawing.Color.Silver;
            }
            if(pic_hidepass.Visible==true )
            {
                //txt_matkhau.PasswordChar = '*';
                pic_showpass.Visible = true;
                pic_hidepass.Visible = false;
            }
            
        }

        private void pic_showpass_Click(object sender, EventArgs e)
        {
            if (txt_matkhau.Text != "Mật khẩu")
            {
                txt_matkhau.PasswordChar = '\0';
                pic_showpass.Visible = false;
                pic_hidepass.Visible = true;
            }
        }

        private void pic_hidepass_Click(object sender, EventArgs e)
        {
                txt_matkhau.PasswordChar = '*';
                pic_showpass.Visible = true;
                pic_hidepass.Visible = false;
        }

        private void but_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Length == 0 || txt_matkhau.Text.Length == 0)
            {
                MessageBox.Show("Email hoặc mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tkbus.kt_email(txt_email.Text))
                    if (tkbus.kt_taikhoan_tontai(txt_email.Text))
                        if (tkbus.kt_daxoa_taikhoan(txt_email.Text) == 0)
                            if (tkdao.check_taikhoan(txt_email.Text, txt_matkhau.Text))
                            {
                                if (tkbus.kt_quyenhan_taikhoan(txt_email.Text) == 1)
                                {
                                    this.Hide();
                                    Form form = new Homeadminfrm();
                                    form.ShowDialog();
                                }
                                else
                                {
                                    if (chx_nhomatkhau.Checked == true)
                                    {
                                        cn.ghi_nhomk("1");
                                        cn.remove_file();
                                        Taikhoan tk = new Taikhoan("00", "00", txt_email.Text, txt_matkhau.Text, "00", "00", 0, 0);
                                        cn.ghi_tk_file(tk);
                                    }
                                    else
                                    {
                                        cn.ghi_nhomk("0");
                                        cn.remove_file();
                                    }
                                    // MessageBox.Show(tkbus.GetTaiKhoanByEmail(txt_email.Text).ToString());
                                    Taikhoan tk1 = tkbus.GetTaiKhoanByEmail(txt_email.Text);
                                    this.Hide();
                                    KryptonForm form = new Form1(tk1);
                                    form.Show();
                                }
                            }
                            else
                                MessageBox.Show("Sai mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Email đã bị ban khỏi phần mềm Hybrid do bị quá nhiều report từ các người dùng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Email này chưa được đăng ký trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Email không hợp lệ hoặc không đúng định dạng cơ bản\nVD:abc@gmail.com", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quenmatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Forgetpassfrm();
            form.ShowDialog();
            tkbus = new TaikhoanBUS();
            this.Show();
        }

        private void but_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Signupfrm();
            form.ShowDialog();
            tkbus = new TaikhoanBUS();
            this.Show();
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            if(txt_matkhau.Text!="Mật khẩu" && txt_matkhau.Text.Length>0)
                txt_matkhau.PasswordChar = '*';
            else
                txt_matkhau.PasswordChar = '\0';
        }

        private void but_dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý sự kiện khi phím Enter được nhấn
                but_dangnhap.PerformClick(); // Kích hoạt sự kiện Click của Button
            }
        }   
    }
}
