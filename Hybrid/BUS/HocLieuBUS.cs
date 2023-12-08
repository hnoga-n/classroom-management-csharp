using Google.Apis.Drive.v3;
using Hybrid.DAO;
using Hybrid.DTO;
using Hybrid.GUI.Home.Tailieu;
using Hybrid.GUI.Home;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace Hybrid.BUS
{
    public class HocLieuBUS
    {
        List<string> file_local = new List<string>();
        List<FileHocLieu> list_filehl = new List<FileHocLieu>();
        HocLieuDAO HocLieuDAO = new HocLieuDAO();
        private ArrayList listhoclieu;

        public HocLieuBUS()
        {
            LoadList();
        }

        public void LoadList()
        {
            listhoclieu = HocLieuDAO.loadList();
        }

        public void get_local_file_in_panel(Panel panel)
        {
            file_local.Clear();
            foreach (Control control in panel.Controls)
            {
                // Check if the control is of type filetemp
                if (control is filetemp)
                {
                    //lay tat ca dia chi cua file
                    file_local.Add(((filetemp)control).FileName);
                }
            }
        }
        public HocLieu insert_hoclieu_and_filehoclieu(Panel panel, string machuong, string ten, string noidung, DriveService service)
        {
            get_local_file_in_panel(panel);
            list_filehl.Clear();
            foreach (string temp in file_local)
            {
                // Tạo yêu cầu tải lên tệp lên Google Drive và chỉ định thư mục đích bằng ID.
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Path.GetFileName(temp),
                    Parents = new List<string> { "1LJFkcwfGXMzGit1z4YA8OLETbVDvhugb" } // Thay "ID_cua_thu_muc_dich" bằng ID thư mục cụ thể.
                };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(temp, FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                    request.Upload();
                }

                var file = request.ResponseBody;
                FileHocLieu fileHocLieu = new FileHocLieu("123", Path.GetFileName(temp), file.Id);
                list_filehl.Add(fileHocLieu);
                if (file != null)
                {

                    //MessageBox.Show($"Tải lên thành công. ID của tệp: "+fileHocLieu.ToString());
                }
                else
                {
                    MessageBox.Show("Không thể tải lên tệp lên Google Drive.");
                }
            }
            return HocLieuDAO.taohoclieu(machuong, ten, noidung, list_filehl);
        }
        public Panel insert_file(Panel panel, string mahoclieu, int tinhtrang)
        {
            panel.Controls.Clear();
            List<FileHocLieu> list_filehl_temp = HocLieuDAO.get_list_filehoclieu(mahoclieu);
            foreach (FileHocLieu fileHocLieu in list_filehl_temp)
            {
                fileshow fileshow = new fileshow(fileHocLieu, tinhtrang);
                panel.Controls.Add(fileshow);
            }
            return panel;
        }
        public void change_hoclieu_filehoclieu(Panel panel, string mahoclieu, string machuong, string ten, string noidung, DriveService service)
        {
            HocLieuDAO.drop_date_filehoclieu_mahoclieu(mahoclieu);
            HocLieu hoclieu = new HocLieu(mahoclieu, ten, noidung, machuong, 0);
            HocLieuDAO.update_hoclieu(hoclieu);
            foreach (Control control in panel.Controls)
            {
                if (control is fileshow userShowControl)
                {
                    FileHocLieu fileHocLieu = userShowControl.filehl;
                    HocLieuDAO.insert_filehoclieu(fileHocLieu);
                    //MessageBox.Show(fileHocLieu.ToString());
                }
                else if (control is filetemp userTempControl)
                {


                    // Lấy và sử dụng giá trị của thuộc tính filePath
                    string filePath = userTempControl.filePath;

                    // Tạo yêu cầu tải lên tệp lên Google Drive và chỉ định thư mục đích bằng ID.
                    var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                    {
                        Name = Path.GetFileName(filePath),
                        Parents = new List<string> { "1LJFkcwfGXMzGit1z4YA8OLETbVDvhugb" } // Thay "ID_cua_thu_muc_dich" bằng ID thư mục cụ thể.
                    };

                    FilesResource.CreateMediaUpload request;
                    using (var stream = new FileStream(filePath, FileMode.Open))
                    {
                        request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                        request.Upload();
                    }

                    var file = request.ResponseBody;
                    FileHocLieu fileHocLieu = new FileHocLieu(mahoclieu, Path.GetFileName(filePath), file.Id);
                    HocLieuDAO.insert_filehoclieu(fileHocLieu);
                    if (file != null)
                    {

                        //MessageBox.Show($"Tải lên thành công. ID của tệp: "+fileHocLieu.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không thể tải lên tệp lên Google Drive.");
                    }
                }
            }
        }

        public ArrayList GetDanhSachHocLieuTheoMaChuong(string machuong, string tukhoa = "")
        {
            ArrayList rslist = new ArrayList();
            foreach (HocLieu hl in this.listhoclieu)
            {
                if (hl.Machuong.Equals(machuong) && hl.Tieude.ToLower().Contains(tukhoa.ToLower()) && hl.Daxoa == 0)
                    rslist.Add(hl);
            }
            return rslist;
        }

        public void SuaHocLieu(HocLieu hoclieu)
        {
            HocLieuDAO.update_hoclieu(hoclieu);
            foreach(HocLieu hl in this.listhoclieu)
            {
                if(hl.Mahoclieu.Equals(hoclieu.Mahoclieu))
                {
                    hl.Daxoa = hoclieu.Daxoa;
                    hl.Tieude = hoclieu.Tieude;
                    hl.Noidung = hoclieu.Noidung;
                    break;
                }
            }    
        }
    }
}
