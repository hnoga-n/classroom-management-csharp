using ComponentFactory.Krypton.Toolkit;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class TaikhoanBUS
    {
        public List<Taikhoan> list = new List<Taikhoan>();
        public TaikhoanDAO dao = new TaikhoanDAO();
        public TaikhoanBUS()
        {
            list = dao.get_danhsach();
        }
        public bool kt_email(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email Gmail
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }
        public Taikhoan kt_taikhoan(string email,string matkhau)
        {
            foreach (Taikhoan t in list)
                if (email == t.Email && matkhau == t.Matkhau)
                    return t;
            return null;
        }
        public void print_list()
        {
            foreach (Taikhoan t in list)
                Console.WriteLine(t.Email+"\t"+t.Email.Length+"\t"+t.Matkhau+"\t"+t.Matkhau.Length);
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
     }
}
