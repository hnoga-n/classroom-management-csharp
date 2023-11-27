using ComponentFactory.Krypton.Toolkit;
using Hybrid.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Hybrid.DTO;
using Hybrid.BUS;

namespace Hybrid.GUI.Home
{
    public partial class Taotailieufrm : KryptonForm
    {
        string magiaovien, malop, machuong;
        TaikhoanDAO taikhoanDAO=new TaikhoanDAO();
        private DriveService service;
        HocLieuBUS tailieuBUS = new HocLieuBUS();   
        //private List<Google.Apis.Drive.v3.Data.File> files;
        public Taotailieufrm(string magiaovien,string malophoc,string machuong)
        {
            this.magiaovien = magiaovien;
            this.malop=malophoc;
            this.machuong=machuong;
            InitializeComponent();
        }

        private void Taotailieufrm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void text_tentailieu_TextChanged(object sender, EventArgs e)
        {
            if (text_tentailieu.Text.Length > 50)
            {
                text_tentailieu.Text = text_tentailieu.Text.Substring(0, 50);
                text_tentailieu.SelectionStart = text_tentailieu.Text.Length;
            }
            else
                lab_demkitu_tentailieu.Text = text_tentailieu.Text.Length.ToString() + "/50 kí tự";
        }

        private void Taotailieufrm_Load(object sender, EventArgs e)
        {
            txt_tenlop.Text = taikhoanDAO.get_tenlop_malop(this.malop);
            txt_tenchuong.Text = taikhoanDAO.get_tenchuong_machuong(this.machuong);
            txt_tengiangvien.Text = taikhoanDAO.get_tengiangvien_magiangvien(this.magiaovien);
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

            //var request = service.Files.List();
            //request.Q = "'1LJFkcwfGXMzGit1z4YA8OLETbVDvhugb' in parents";
            //request.Fields = "files(id, name, mimeType)";
            //files = request.Execute().Files.ToList();

        }

        private void text_noidungtailieu_TextChanged(object sender, EventArgs e)

        {
            if (text_noidungtailieu.Text.Length > 5000)
            {
                text_noidungtailieu.Text = text_noidungtailieu.Text.Substring(0, 5000);
                text_noidungtailieu.SelectionStart = text_noidungtailieu.Text.Length;
            }
            else
                lab_demkitu_noidungtailieu.Text = text_noidungtailieu.Text.Length.ToString() + "/5000 kí tự";
        }

        private void but_taotailieu_Click(object sender, EventArgs e)
        {
            if(text_tentailieu.Text.Length == 0||text_noidungtailieu.Text.Length==0)
                MessageBox.Show("Vui long nhập đầy đủ nội dung","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tailieuBUS.insert_hoclieu_and_filehoclieu(panel_luufile,machuong,text_tentailieu.Text,text_noidungtailieu.Text, service);
                MessageBox.Show("Tạo tài liệu thành công","Thông báo");   
                this.Close();
            }
        }

        private void text_noidungtailieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Ngăn chặn dán nếu văn bản sau khi dán có độ dài lớn hơn 5000
                string clipboardText = Clipboard.GetText();
                if (text_noidungtailieu.Text.Length + clipboardText.Length > 5000)
                {
                    e.Handled = true; // Ngăn chặn thao tác nhập ký tự từ sự kiện KeyDown
                    MessageBox.Show("Nội dung bạn muốn dán vào đã vượt quá 5000 kí tự");
                }
            }
        }

        private void but_layfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Word documents (*.doc;*.docx)|*.doc;*.docx|Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 5; // Thiết lập mặc định là All files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Icon fileIcon = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                    filetemp file_temp = new filetemp(fileIcon, openFileDialog.FileName);
                    panel_luufile.Controls.Add(file_temp);
                }
            }
        }
    }
}
