using Google.Apis.Drive.v3;
using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using Npgsql.TypeHandlers.NetworkHandlers;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using Microsoft.Office.Interop.Word;
using Unidecode.NET;
using System.Data;
using System.Linq;

namespace Hybrid.BUS
{
    public class LopHocBUS
    {
        private ArrayList list;
        private LopHocDAO lopDAO;
        System.Data.DataTable dataTable = null;

        public LopHocBUS()
        {
            lopDAO = new LopHocDAO();
            list = lopDAO.loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = lopDAO.loadList();
        }

        public ArrayList GetDanhSachTatCaLopHocByMaTaiKhoan(string mataikhoan)
        {
            return lopDAO.GetDanhSachTatCaLopHocByMaTaiKhoan(mataikhoan);
        }

        public LopHoc getLophocWithMaLop(string malop)
        {
            LophocComparer comparer = new LophocComparer();
            comparer.TypeToCompare = LophocComparer.ComparisonType.malophoc;
            LopHoc lopSearch = new LopHoc();
            lopSearch.Malop= malop.ToLower();
            int index = list.BinarySearch(lopSearch, comparer);
            return (LopHoc) list[index];
        }

        public bool ThemLopHoc(LopHoc lophoc)
        {
            if (lopDAO.ThemLopHoc(lophoc))
            {
                this.list.Add(lophoc);
                return true;
            }
            return false;
        }
        public bool SuaLopHoc(LopHoc lophoc)
        {
            if(lopDAO.SuaLopHoc(lophoc))
            {
                foreach(LopHoc l in this.list)
                {
                    if(l.Malop.Equals(lophoc.Malop))
                    {
                        l.Tenlop = lophoc.Tenlop;
                        l.Mota = lophoc.Mota;
                        return true;
                    }
                }
            }
            return false;
        }
        
        public bool XoaLopHoc(string malop)
        {
            if(lopDAO.XoaLopHoc(malop))
            {
                foreach (LopHoc l in this.list)
                {
                    if (l.Malop.Equals(malop))
                    {
                        l.Daxoa = 1;
                        return true;
                    }
                }
            }
            return false;
        }

        public LopHoc GetLopHocByMaLop(string malophoc)
        {
            foreach (LopHoc lop in list)
            {
                if(lop.Malop.ToLower().Equals(malophoc.ToLower()))
                    return lop;
            }
            return null;
        }

       public ArrayList GetLopHocByMaGiangVien(string magiangvien) { 
            ArrayList listResult = new ArrayList();
            foreach(LopHoc lopHoc in list)
            {
                if(lopHoc.Magiangvien == magiangvien)
                    listResult.Add(lopHoc);
            }
            return listResult;
       }
        public string insert_hinhlop(string filePath)
        {
            DriveService service = Chucnang.service;
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(filePath),
                Parents = new List<string> { "1w167CepymPTPsunyMLH4vRpKDm76n9Oa" } // Thay "ID_cua_thu_muc_dich" bằng ID thư mục cụ thể.
            };

            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                request.Upload();
            }

            var file = request.ResponseBody;
            return file.Id;
        }
        public void dataview_lophoc(DataGridView dataGridView)
        {

            dataTable = lopDAO.LayDanhSachLopHoc();
            // Gọi phương thức để lấy dữ liệu từ cơ sở dữ liệu
            // Gán dữ liệu cho DataGridView
            dataGridView.DataSource = dataTable;

            // Tạo cột checkbox cho cột "daxoa"
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "daxoa";
            checkBoxColumn.HeaderText = "Đã Xóa";
            checkBoxColumn.Name = "daxoa";
            dataGridView.Columns.Add(checkBoxColumn);
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Tên lớp học";
            dataGridView.Columns[2].HeaderText = "Mô tả";
            dataGridView.Columns[3].HeaderText = "Tên giảng viên";
            dataGridView.Columns[1].Width = 300;
            dataGridView.Columns[2].Width = 330;
            dataGridView.Columns[3].Width = 250;
            dataGridView.Columns[4].Visible = false;

        }
        public int count_class_ban(DataGridView dataGridView)
        {
            int soLuong_class_ban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "1")
                {
                    soLuong_class_ban++;
                }
            }

            return soLuong_class_ban;
        }
        public int count_class_unban(DataGridView dataGridView)
        {
            int soLuong_class_unban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "0")
                {
                    soLuong_class_unban++;
                }
            }

            return soLuong_class_unban;
        }
        public void timkiem_lop_tengiangvien(string searchTerm, DataGridView dataGridView)
        {
            dataTable = lopDAO.LayDanhSachLopHoc();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode().Trim(); // Loại bỏ khoảng trắng đầu và cuối

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let hoten = row.Field<string>("hoten").ToLower().Unidecode().Trim() // Loại bỏ khoảng trắng đầu và cuối
                                where hoten.Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                System.Data.DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }

        }
        public void timkiem_lop_tenlop(string searchTerm, DataGridView dataGridView)
        {
            dataTable = lopDAO.LayDanhSachLopHoc();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode().Trim(); // Loại bỏ khoảng trắng đầu và cuối

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let hoten = row.Field<string>("ten").ToLower().Unidecode().Trim() // Loại bỏ khoảng trắng đầu và cuối
                                where hoten.Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                System.Data.DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }

        }
        public void ban_class(string malop)
        {
            list = lopDAO.loadList();
            lopDAO.ban_lop(malop);
        }
        public void unban_class(string malop)
        {
            list = lopDAO.loadList();
            lopDAO.unban_lop(malop);
        }
        public void capnhat_anhlop(string malop,string ten)
        {
            
            list = lopDAO.loadList();
            lopDAO.update_anhlop(ten, malop);
        }
    }
}
