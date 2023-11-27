using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;

namespace Hybrid.GUI
{
    public partial class LoginUI : KryptonForm
    {
        TaikhoanBUS tkbus = new TaikhoanBUS();
        TaikhoanDAO tkdao=new TaikhoanDAO();
        Chucnang cn=new Chucnang();
        public LoginUI()
        {
            InitializeComponent();

        }
        private void hienmatkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '\0';
            hienmatkhau.Visible = false;
            anmatkhau.Visible = true;
        }
        private void anmatkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
            anmatkhau.Visible = false;
            hienmatkhau.Visible = true;
        }
        private void dangky_Click(object sender, EventArgs e)
        {
            //Ketnoisqlserver.CloseConnection();
            this.Hide();
            KryptonForm form = new SignupUI();
            form.ShowDialog();
            this.Show();
        }
        private void but_dangnhap_Click_2(object sender, EventArgs e)
        {
            if(txt_email.Text.Length==0||txt_matkhau.Text.Length==0) 
            {
                MessageBox.Show("Email hoặc mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tkbus.kt_email(txt_email.Text))
                    if(tkdao.get_daxoa_email(txt_email.Text)==0)
                        if (tkdao.check_taikhoan(txt_email.Text, txt_matkhau.Text))
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
                            KryptonForm form = new Form1(txt_email.Text);
                            this.Hide();
                            form.ShowDialog();
                            chx_nhomatkhau.Checked = false;
                            this.Show();
                            this.Load += new System.EventHandler(this.LoginUI_Load);
                        }
                        else
                            MessageBox.Show("Email chưa được đăng kí hoặc không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Email đã bị ban khỏi phần mềm Hybrid do bị quá nhiều report từ các người dùng khác.","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                    MessageBox.Show("Email không hợp lệ hoặc không đúng định dạng cơ bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void quenmatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Forgetpass();
            form.ShowDialog();
            this.Show();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            if (cn.lay_nhomk() == "1")
            {
                chx_nhomatkhau.Checked = true;
                Taikhoan tk = cn.doc_tk_file();
                if (tk != null)
                {
                    KryptonForm form = new Form1(tk.Email);
                    this.Hide();
                    form.ShowDialog();
                }
            }
            else
                chx_nhomatkhau.Checked=false;
        }

    }
}
