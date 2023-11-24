﻿using ComponentFactory.Krypton.Toolkit;
using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using ServiceStack;
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
        public Taikhoan kt_taikhoan(string email, string matkhau)
        {
            foreach (Taikhoan t in list)
                if (email == t.Email && matkhau == t.Matkhau)
                    return t;
            return null;
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
            int index = list.BinarySearch(tk,comparer);
            return index;
    }
    }
}
