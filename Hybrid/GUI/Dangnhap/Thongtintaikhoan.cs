using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Dangnhap;
using Hybrid.GUI.Home;
using ServiceStack.Script;

namespace Hybrid.GUI
{
    public partial class Thongtintaikhoan : KryptonForm
    {
        Taikhoan tk;
        TaikhoanBUS taikhoanBUS=new TaikhoanBUS();
        Chucnang cn=new Chucnang();
        PictureBox hinhanhcanhan = new PictureBox();

        public Thongtintaikhoan(Taikhoan tk,Form1 frm,PictureBox pic)
        {
            InitializeComponent();
            this.tk = tk;
            this.Location=new Point(frm.Location.X+50, frm.Location.Y+20);
            hinhanh.Image = pic.Image;

        }

        private void Thongtintaikhoan_Load(object sender, EventArgs e)
        {
            txt_ten.Text = this.tk.Hoten;
            txt_email.Text = this.tk.Email;
            txt_sodienthoai.Text = this.tk.Sodienthoai;
            MakePictureBoxCircular(hinhanh);
            //txt_email.Text=this.tk.Email;
        }
        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                // Tạo đường dẫn hình tròn
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

                // Gán đường dẫn cho PictureBox
                pictureBox.Region = new Region(path);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (lab_xacnhan.Visible == true)
                MessageBox.Show("Vui lòng bấm xác nhận thay đổi trước khi thoát! ", "Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }

        private void lab_chinhsua_Click(object sender, EventArgs e)
        {
            lab_chinhsua.Visible = false;
            lab_xacnhan.Visible = true;
            txt_ten.ReadOnly = false;
            txt_sodienthoai.ReadOnly = false;
        }



        private void lab_xacnhan_Click(object sender, EventArgs e)
        {
            if(!cn.IsPhoneNumber(txt_sodienthoai.Text)&&txt_sodienthoai.Text.Length!=0)
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!\nVD:0912345678","Cảnh bảo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_ten.Text != this.tk.Hoten || txt_sodienthoai.Text != this.tk.Sodienthoai)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc là muốn thay đổi thông tin chưa?", "Câu hỏi", MessageBoxButtons.YesNoCancel);

                    // Xử lý kết quả từ MessageBox
                    switch (result)
                    {
                        case DialogResult.Yes:
                            //xu li su kien chinh thong tin tk
                            taikhoanBUS.update_ten_sodienthoai_bymataikhoan(txt_ten.Text, txt_sodienthoai.Text, this.tk.Mataikhoan);
                            lab_xacnhan.Visible = false;
                            lab_chinhsua.Visible = true;
                            txt_ten.ReadOnly = true;
                            txt_sodienthoai.ReadOnly = true;
                            break;
                        case DialogResult.No:
                            txt_ten.Text = this.tk.Hoten;
                            txt_sodienthoai.Text = this.tk.Sodienthoai;
                            lab_xacnhan.Visible = false;
                            lab_chinhsua.Visible = true;
                            txt_ten.ReadOnly = true;
                            txt_sodienthoai.ReadOnly = true;
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                else
                {
                    lab_xacnhan.Visible = false;
                    lab_chinhsua.Visible = true;
                }    
            }    
            
        }

        private void lab_doimatkhau_Click(object sender, EventArgs e)
        {
            Doimatkhaufrm form = new Doimatkhaufrm(this.tk.Email);
            form.ShowDialog();

        }

        private void txt_sodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không phải số được nhập vào TextBox
            }
        }

        private void hinhanh_Click(object sender, EventArgs e)
        {
            ChonHinhFrm form = new ChonHinhFrm(tk.Email);
            form.sendImage = new ChonHinhFrm.SendImage(LoadHinh);
            form.ShowDialog();

        }
        private void LoadHinh(Image image)
        {
            //ptbThumbnail.Image = null;
            hinhanh.Image = Properties.Resources.canhan1;
            hinhanh.Image = image;
        }
    }
}
