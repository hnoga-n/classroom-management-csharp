using System;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.IO;
using Hybrid.DTO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using System.Text.RegularExpressions;
using Google.Apis.Download;
using System.Windows.Forms;
using System.Drawing;

namespace Hybrid.BUS
{
    public class Chucnang
    {
        string gmail_admin = "hybridcnpm@gmail.com";
        string ma_gmail_admin = "dbdkljytafsvhfix";
        public static DriveService service;
        //Gui gmail cho nguoi dung voi thong tin la 1 doan ma voi 6 so
        public void GuiMail(String from, String to, String subject, String mess)
        {
            MailMessage mail = new MailMessage(from, to, subject, mess);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(gmail_admin, ma_gmail_admin);
            client.Send(mail);
        }
        public void Guimail_admin( String to, String subject, String mess)
        {
            MailMessage mail = new MailMessage(gmail_admin, to, subject, mess);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(gmail_admin, ma_gmail_admin);
            client.Send(mail);
        }
        //tao random 6 so va tra ve voi kieu string
        public string TaoSo()
        {
            Random random = new Random();
            string randomNumer = random.Next(0, 1000000).ToString("D6");
            return randomNumer;
        }
        public void ghi_nhomk(string tt)
        {
            string tenTep = "nhomatkhau.txt";

            // Xóa hết nội dung của tệp văn bản
            File.WriteAllText(tenTep, string.Empty);

            // Ghi chuỗi mới lên tệp văn bản
            File.WriteAllText(tenTep, tt);
        }
        public string lay_nhomk()
        {
            string tenTep = @"nhomatkhau.txt";
           return File.ReadAllText(tenTep);
        }
        public void ghi_tk_file(Taikhoan tk)
        {
            string filePath = "nhomatkhau.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Taikhoan));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, tk);
            }
        }
        public void remove_file()
        {
            string filePath = "nhomatkhau.xml";

            if (System.IO.File.Exists(filePath))
            {
                // Tạo một tài liệu XML mới
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<root></root>"); // Tạo một phần tử gốc mới

                // Ghi nội dung tài liệu XML vào tệp
                doc.Save(filePath);
                //Console.WriteLine("Nội dung của tệp XML đã được xóa.");
            }
            else
            {
                // Tạo một tài liệu XML mới và lưu vào tệp
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<root></root>"); // Tạo một phần tử gốc mới

                // Ghi nội dung tài liệu XML vào tệp
                doc.Save(filePath);
                //Console.WriteLine("Tạo mới tệp XML.");
            }
        }
        public Taikhoan doc_tk_file()
        {
            string filePath = "nhomatkhau.xml";
            if (!File.Exists(filePath))
            {
                return null; // Trả về null nếu tệp không tồn tại
            }

            XDocument xmlDoc = XDocument.Load(filePath);
            if (xmlDoc.Root == null || xmlDoc.Root.Elements().Count() == 0)
            {
                return null; // Trả về null nếu tệp không có nội dung
            }

            Taikhoan taikhoan = new Taikhoan();
            taikhoan.Mataikhoan = xmlDoc.Root.Element("Mataikhoan").Value;
            taikhoan.Hoten = xmlDoc.Root.Element("Hoten").Value;
            taikhoan.Email = xmlDoc.Root.Element("Email").Value;
            taikhoan.Matkhau = xmlDoc.Root.Element("Matkhau").Value;
            taikhoan.Sodienthoai = xmlDoc.Root.Element("Sodienthoai").Value;
            taikhoan.Anhdaidien = xmlDoc.Root.Element("Anhdaidien").Value;
            taikhoan.Manhomquyen = Convert.ToInt32(xmlDoc.Root.Element("Manhomquyen").Value);

            return taikhoan;
        }
        public bool IsPhoneNumber(string input)
        {
            // Biểu thức chính quy: ^0\d{9}$
            // ^: Bắt đầu chuỗi
            // 0: Số bắt đầu
            // \d{9}: Tiếp theo là 9 số bất kỳ
            // $: Kết thúc chuỗi
            string pattern = @"^0\d{9}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }
        public void loadggdrive()
        {
            // Khởi tạo dịch vụ Google Drive
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
/*        public void load_hinhanhcanhan(string fileId,PictureBox pic)
        {
            try
            {
                // Tải tệp hình ảnh từ Google Drive bằng fileId
                var request = service.Files.Get(fileId);
                var stream = new MemoryStream();
                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            break;
                        case DownloadStatus.Completed:
                            {
                                // Lưu dữ liệu tải về vào một tệp cục bộ tạm thời
                                using (var fileStream = new FileStream("temp_image.jpg", FileMode.Create, FileAccess.Write))
                                {
                                    stream.Seek(0, SeekOrigin.Begin);
                                    stream.CopyTo(fileStream);
                                }

                                // Đọc hình ảnh từ tệp cục bộ và hiển thị nó trên PictureBox
                                using (var imageStream = new FileStream("temp_image.jpg", FileMode.Open, FileAccess.Read))
                                {
                                    // Đọc hình ảnh từ tệp cục bộ
                                    pic.Image = Image.FromStream(imageStream);



                                }

                                break;
                            }
                        case DownloadStatus.Failed:
                            MessageBox.Show("Lỗi trong quá trình tải hình ảnh từ Google Drive.");
                            break;
                    }
                };

                request.Download(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void load_hinhanhlop(string fileId, PictureBox pic)
        {

            try
            {
                // Tải tệp hình ảnh từ Google Drive bằng fileId
                var request = service.Files.Get(fileId);
                var stream = new MemoryStream();
                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            break;
                        case DownloadStatus.Completed:
                            {
                                // Lưu dữ liệu tải về vào một tệp cục bộ tạm thời
                                using (var fileStream = new FileStream("temp_image.jpg", FileMode.Create, FileAccess.Write))
                                {
                                    stream.Seek(0, SeekOrigin.Begin);
                                    stream.CopyTo(fileStream);
                                }

                                // Đọc hình ảnh từ tệp cục bộ và hiển thị nó trên PictureBox
                                using (var imageStream = new FileStream("temp_image.jpg", FileMode.Open, FileAccess.Read))
                                {
                                    // Đọc hình ảnh từ tệp cục bộ
                                    pic.Image = Image.FromStream(imageStream);



                                }

                                break;
                            }
                        case DownloadStatus.Failed:
                            MessageBox.Show("Lỗi trong quá trình tải hình ảnh từ Google Drive.");
                            break;
                    }
                };

                request.Download(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗicccccc: " + ex.Message);
            }
        }*/
    }
}
