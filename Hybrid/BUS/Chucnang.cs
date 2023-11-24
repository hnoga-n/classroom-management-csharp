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

namespace Hybrid.BUS
{
    class Chucnang
    {
        string gmail_admin = "hybridcnpm@gmail.com";
        string ma_gmail_admin = "dbdkljytafsvhfix";
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
        
    }
}
