using ComponentFactory.Krypton.Toolkit;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
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
        TaikhoanDAO tkdao = new TaikhoanDAO();
        HocLieuDAO tldao = new HocLieuDAO();
        HocLieuBUS tlbus = new HocLieuBUS();
        LopHocBUS lhbus = new LopHocBUS();
        private DriveService service;
        string magiaovien, malop, machuong,mahoclieu;
        ButtonHocLieu buttonhoclieu;

        public Hienthitailieufrm(ButtonHocLieu btnhoclieu)
        {
            this.magiaovien = btnhoclieu.PanelChuong.Khfrm.Lophoc.Magiangvien;
            this.malop = btnhoclieu.PanelChuong.Khfrm.Lophoc.Malop;
            this.machuong = btnhoclieu.PanelChuong.Chuong.Machuong;
            this.mahoclieu = btnhoclieu.Hoclieu.Mahoclieu;
            this.buttonhoclieu = btnhoclieu;
            InitializeComponent();
            if (lhbus.GetLopHocByMaLop(malop).Daxoa == 1 || !btnhoclieu.PanelChuong.Khfrm.Taikhoan.Mataikhoan.Equals(magiaovien))
            {
                this.but_chinhsua.Visible = false;
                this.but_xoa.Visible = false;
                this.but_xacnhan.Visible = false;
            }
            this.but_layfile.Visible = false;
        }

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
                MessageBox.Show("Vui lòng nhập đầy đủ nội dung", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tlbus.change_hoclieu_filehoclieu(panel_luufile,mahoclieu, machuong, text_tentailieu.Text, text_noidungtailieu.Text, service);
                MessageBox.Show("Chỉnh sửa tài liệu thành công", "Thông báo");
                but_chinhsua.Visible = true;
                but_xoa.Visible = true;
                but_xacnhan.Visible = false;
                but_layfile.Visible = false;
                but_layfile.Visible = false;
                text_tentailieu.ReadOnly = true;
                text_noidungtailieu.ReadOnly = true;
                this.ActiveControl = null;
                text_tentailieu.Text = tldao.get_tieude_mahoclieu(this.mahoclieu);
                text_noidungtailieu.Text = tldao.get_noidung_mahoclieu(this.mahoclieu);
                panel_luufile = (FlowLayoutPanel)tlbus.insert_file(panel_luufile, this.mahoclieu, 1);
                this.buttonhoclieu.LblTieuDeHocLieu.Text = text_tentailieu.Text;
            }
            

        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xóa học liệu ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.buttonhoclieu.Hoclieu.Daxoa = 1;
                tlbus.SuaHocLieu(this.buttonhoclieu.Hoclieu);
                this.buttonhoclieu.PanelChuong.XoaChuongComponent(this.buttonhoclieu);
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void text_noidungtailieu_TextChanged(object sender, EventArgs e)
        {
            if (text_noidungtailieu.Text.Length > 300)
            {
                text_noidungtailieu.Text = text_noidungtailieu.Text.Substring(0, 300);
                text_noidungtailieu.SelectionStart = text_noidungtailieu.Text.Length;
            }
            else
                lab_demkitu_noidungtailieu.Text = text_noidungtailieu.Text.Length.ToString() + "/300 kí tự";
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
