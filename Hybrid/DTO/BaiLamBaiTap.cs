using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BaiLamBaiTap
    {
        private string mabailam;
        private string noidung;
        private DateTime thoigiannopbai;
        private int diem;
        private string nhanxet;
        private string  mataikhoan;
        private string mabaitap;

        public BaiLamBaiTap() { }

        public BaiLamBaiTap(string mabailam, string noidung, DateTime thoigiannopbai, int diem, string nhanxet, string mataikhoan, string mabaitap)
        {
            this.Mabailam = mabailam;
            this.Noidung = noidung;
            this.Thoigiannopbai = thoigiannopbai;
            this.Diem = diem;
            this.Nhanxet = nhanxet;
            this.Mataikhoan = mataikhoan;
            this.Mabaitap = mabaitap;
        }

        public string Mabailam { get => mabailam; set => mabailam = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public DateTime Thoigiannopbai { get => thoigiannopbai; set => thoigiannopbai = value; }
        public int Diem { get => diem; set => diem = value; }
        public string Nhanxet { get => nhanxet; set => nhanxet = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public string Mabaitap { get => mabaitap; set => mabaitap = value; }
    }
}
