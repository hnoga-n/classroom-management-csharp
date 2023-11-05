using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hybrid.DTO
{
    public class Taikhoan
    {
        private string mataikhoan;
        private string hoten;
        private string email;
        private string matkhau;
        private string sodienthoai;
        private string anhdaidien;
        private int manhomquyen;

        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Email { get => email; set => email = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Anhdaidien { get => anhdaidien; set => anhdaidien = value; }
        public int Manhomquyen { get => manhomquyen; set => manhomquyen = value; }

        public Taikhoan() { }

        public Taikhoan(string mataikhoan, string hoten, string email, string matkhau, string sodienthoai, string anhdaidien, int manhomquyen)
        {
            this.mataikhoan = mataikhoan;
            this.hoten = hoten;
            this.email = email;
            this.matkhau = matkhau;
            this.sodienthoai = sodienthoai;
            this.anhdaidien = anhdaidien;
            this.manhomquyen = manhomquyen;
        }

        public override string ToString()
        {
            return $"Ma tai khoan: {Mataikhoan}, Ho ten: {Hoten},Email: {Email},Mat khau:{Matkhau},So dien thoai:{Sodienthoai},Ma nhom quyen:{Manhomquyen}\n";
        }
    }
}
