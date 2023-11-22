using ComponentFactory.Krypton.Toolkit;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.Tailieu
{
    public partial class Hienthitailieufrm : KryptonForm
    {
        TaikhoanDAO tkdao=new TaikhoanDAO();
        HocLieuDAO tldao=new HocLieuDAO();
        HocLieuBUS tlbus=new HocLieuBUS();
        private DriveService service;
        string magiaovien, malop, machuong,mahoclieu;

        private void Hienthitailieufrm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void but_layfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Word documents (*.docx)|*.docx|Excel files (*.xlsx)|*.xlsx|PDF files (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 3; // Thiết lập mặc định là All files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Icon fileIcon = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                    filetemp file_temp = new filetemp(fileIcon, openFileDialog.FileName);
                    panel_luufile.Controls.Add(file_temp);
                }
            }
        }

        private void but_xacnhan_Click(object sender, EventArgs e)
        {
            if (text_tentailieu.Text.Length == 0 || text_noidungtailieu.Text.Length == 0)
                MessageBox.Show("Vui long nhập đầy đủ nội dung", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tlbus.change_hoclieu_filehoclieu(panel_luufile,mahoclieu, machuong, text_tentailieu.Text, text_noidungtailieu.Text, service);
                MessageBox.Show("Chỉnh sửa tài liệu thành công", "Thông báo");
                but_chinhsua.Visible = true;
                but_xoa.Visible = true;
                but_xacnhan.Visible = false;
                but_layfile.Visible = false;
                text_tentailieu.ReadOnly = true;
                text_noidungtailieu.ReadOnly = true;
                this.ActiveControl = null;
                text_tentailieu.Text = tldao.get_tieude_mahoclieu(this.mahoclieu);
                text_noidungtailieu.Text = tldao.get_noidung_mahoclieu(this.mahoclieu);
                panel_luufile = (FlowLayoutPanel)tlbus.insert_file(panel_luufile, this.mahoclieu, 1);
            }
            

        }

        private void but_chinhsua_Click(object sender, EventArgs e)
        {
            but_chinhsua.Visible = false;
            but_xoa.Visible = false;
            but_xacnhan.Visible = true;
            but_layfile.Visible = true;
            text_tentailieu.ReadOnly = false;
            text_noidungtailieu.ReadOnly = false;
            text_tentailieu.SelectionStart=text_tentailieu.Text.Length;
            panel_luufile = (FlowLayoutPanel)tlbus.insert_file(panel_luufile, this.mahoclieu, 2);
        }

        public Hienthitailieufrm(string magiaovien, string malophoc, string machuong,string mahoclieu)
        {
            this.magiaovien = magiaovien;
            this.malop = malophoc;
            this.machuong = machuong;
            this.mahoclieu=mahoclieu;
            InitializeComponent();
        }

        private void Hienthitailieufrm_Load(object sender, EventArgs e)
        {
            txt_tenlop.Text = tkdao.get_tenlop_malop(this.malop);
            txt_tenchuong.Text = tkdao.get_tenchuong_machuong(this.machuong);
            txt_tengiangvien.Text = tkdao.get_tengiangvien_magiangvien(this.magiaovien);
            text_tentailieu.Text = tldao.get_tieude_mahoclieu(this.mahoclieu);
            text_noidungtailieu.Text = tldao.get_noidung_mahoclieu(this.mahoclieu);
            panel_luufile =(FlowLayoutPanel) tlbus.insert_file(panel_luufile, this.mahoclieu,1);
            UserCredential credential;
            using (var stream = new FileStream(@"..\..\bin\Debug\ggdrivelink.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.Drive },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true)).Result;
            }

            // Tạo dịch vụ Google Drive
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "hybrid"
            });
        }
    }
}
