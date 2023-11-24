using ComponentFactory.Krypton.Toolkit;
using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.BUS
{
    class TaikhoanBUS
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

        public Boolean kt_taikhoan_tontai(string email)
        {
            foreach(Taikhoan t in list)
            {
                if(t.Email == email) 
                    return true;
            } 
            return false;
                
        }
        //ham tao tai khoan khia ban co email va mat khau
        public Boolean tao_taikhoan1(string email,string password)
        {
            Taikhoan tk =new Taikhoan(null,email,email,password,null,null,2,0);
            if(dao.insert_taikhoan(tk)==true)
            {
                list.Add(tk);
                return true;
            }
            else { return false; }
        }
        public Boolean reset_matkhau1(string email)
        {
            if(dao.reset_matkhau(email)==true)
            {
                list = dao.get_danhsach();
                return true;
            }
            else
            { return false; }
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
    }
}
