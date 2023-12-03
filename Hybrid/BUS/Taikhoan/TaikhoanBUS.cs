using ComponentFactory.Krypton.Toolkit;
using Google.Apis.Drive.v3;
using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack;
using System.Data.SqlClient;
using System.Data;
using Unidecode.NET;
using System.Drawing;

namespace Hybrid.BUS
{
    public class TaikhoanBUS
    {
        private List<Taikhoan> list = new List<Taikhoan>();
        public TaikhoanDAO dao = new TaikhoanDAO();

        public List<Taikhoan> List { get => list; set => list = value; }

        Chucnang cn = new Chucnang();
        DataTable dataTable = null;
        public TaikhoanBUS()
        {
            list = dao.get_danhsach();
        }
        public List<Taikhoan> get_list()
        {
            return list;
        }
        public bool kt_email(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email Gmail
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        public Boolean kt_taikhoan_tontai(string email)
        {
            foreach (Taikhoan t in list)
            {
                if (t.Email == email)
                    return true;
            }
            return false;

        }
        //ham tao tai khoan khia ban co email va mat khau
        public Boolean tao_taikhoan1(string email, string password)
        {
            Taikhoan tk = new Taikhoan(null, email, email, password, null, null, 2, 0);
            if (dao.insert_taikhoan(tk) == true)
            {
                list.Add(tk);
                return true;
            }
            else { return false; }
        }
        public Boolean reset_matkhau1(string email)
        {
            if (dao.reset_matkhau(email) == true)
            {
                list = dao.get_danhsach();
                return true;
            }
            else
            { return false; }
        }

        public int kt_daxoa_taikhoan(string email)
        {
            foreach (Taikhoan t in list)
            {
                if (t.Email == email)
                    return t.Daxoa;
            }
            return 1;
        }
        public int kt_quyenhan_taikhoan(string email)
        {
            foreach (Taikhoan t in list)
            {
                if (t.Email == email)
                    return t.Manhomquyen;
            }
            return 1;
        }

        public Boolean kt_dinhdang_matkhau(string matkhau)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+]).{8,}$";

            // Kiểm tra xem mật khẩu có khớp với biểu thức chính quy hay không
            return Regex.IsMatch(matkhau, pattern);
        }
        public Taikhoan GetTaiKhoanByEmail(string email)
        {
            Taikhoan taikhoan = null;
            foreach (Taikhoan tk in this.list)
            {
                if (tk.Email.Equals(email))
                {
                    taikhoan = tk;
                    break;
                }
            }
            return taikhoan;
        }
        public int GetTaiKhoanByMaTaiKhoan(string mataikhoan)
        {
            TaikhoanComparer comparer = new TaikhoanComparer();
            comparer.TypeToCompare = TaikhoanComparer.ComparisonType.mataikhoan;
            Taikhoan tk = new Taikhoan();
            tk.Mataikhoan = mataikhoan;
            this.list.Sort();
            int index = list.BinarySearch(tk, comparer);
            return index;
        }
        public void update_ten_sodienthoai_bymataikhoan(string ten, string sodienthoai, string mataikhoan)
        {
            dao.update_ten_sodienthoai_bymatoaikhoan(ten, sodienthoai, mataikhoan);
            list.Clear();
            list = dao.get_danhsach();
        }
        /*        public void update_hinhanhcanhan(string filePath, string mataikhoan)
                {
                    DriveService service = Chucnang.service;
                    var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                    {
                        Name = Path.GetFileName(filePath),
                        Parents = new List<string> { "18BLA4qmK53RckQHjlN50-pwGfKLi4Aih" } // Thay "ID_cua_thu_muc_dich" bằng ID thư mục cụ thể.
                    };

                    FilesResource.CreateMediaUpload request;
                    using (var stream = new FileStream(filePath, FileMode.Open))
                    {
                        request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                        request.Upload();
                    }

                    var file = request.ResponseBody;
                    dao.update_anhcanhan(file.Id, mataikhoan);
                    list.Clear();
                    list = dao.get_danhsach();
                }*/
        public void dataview_taikhoan(DataGridView dataGridView)
        {

            DataTable dataTable = dao.LayDanhSachTaiKhoan();
            // Gọi phương thức để lấy dữ liệu từ cơ sở dữ liệu
            // Gán dữ liệu cho DataGridView
            dataGridView.DataSource = dataTable;

            // Tạo cột checkbox cho cột "daxoa"
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "daxoa";
            checkBoxColumn.HeaderText = "Đã Xóa";
            checkBoxColumn.Name = "daxoa";
            dataGridView.Columns.Add(checkBoxColumn);
            dataGridView.Columns[0].HeaderText = "Họ tên";
            dataGridView.Columns[1].HeaderText = "Email";
            dataGridView.Columns[2].HeaderText = "Số điện thoại";
            dataGridView.Columns[0].Width = 300;
            dataGridView.Columns[1].Width = 300;
            dataGridView.Columns[2].Width = 280;
            dataGridView.Columns[3].Visible = false;

        }
        public int count_user_ban(DataGridView dataGridView)
        {
            int soLuong_user_ban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "1")
                {
                    soLuong_user_ban++;
                }
            }

            return soLuong_user_ban;
        }
        public int count_user_unban(DataGridView dataGridView)
        {
            int soLuong_user_unban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "0")
                {
                    soLuong_user_unban++;
                }
            }

            return soLuong_user_unban;
        }
        public void timkiem_taikhoan_ten(string searchTerm, DataGridView dataGridView)
        {
            dataTable = dao.LayDanhSachTaiKhoan();
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
                DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }

        }
        public void timkiem_taikhoan_email(string searchTerm, DataGridView dataGridView)
        {
            dataTable = dao.LayDanhSachTaiKhoan();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode().Trim(); // Loại bỏ khoảng trắng đầu và cuối

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let hoten = row.Field<string>("email").ToLower().Unidecode().Trim() // Loại bỏ khoảng trắng đầu và cuối
                                where hoten.Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }
        }
        public void timkiem_taikhoan_sdt(string searchTerm, DataGridView dataGridView)
        {
            dataTable = dao.LayDanhSachTaiKhoan();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode();

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let sodienthoai = row.Field<string>("sodienthoai")
                                where sodienthoai != null && sodienthoai.ToLower().Unidecode().Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }
        }
        public void ban_user(string email)
        {
            dao.ban_taikhoan(email);
            list = dao.get_danhsach();
        }
        public void unban_user(string email)
        {
            dao.unban_taikhoan(email);
            list = dao.get_danhsach();
        }
        public PictureBox load_hinhdaidien(string ten)
        {
            PictureBox pictureBox = new PictureBox();

            // Sử dụng ResourceManager để lấy hình ảnh từ tài nguyên theo tên
            System.Resources.ResourceManager rm = global::Hybrid.Properties.Resources.ResourceManager;
            pictureBox.Image = (Image)rm.GetObject(ten);

            return pictureBox;
        }
        public void capnhap_hinhanhdaidien(string email, string tenhinh)
        {
            string luachon = null;
            switch (tenhinh)
            {
                case "pic1":
                    luachon = "canhan1";
                    break;
                case "pic2":
                    luachon = "canhan2";
                    break;
                case "pic3":
                    luachon = "canhan3";
                    break;
                case "pic4":
                    luachon = "canhan4";
                    break;
                case "pic5":
                    luachon = "canhan5";
                    break;
                case "pic6":
                    luachon = "canhan6";
                    break;

            }
            dao.update_anhcanhan(luachon, email);
            list = dao.get_danhsach();

        }
    }
}
