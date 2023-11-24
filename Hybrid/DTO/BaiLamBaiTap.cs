using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BaiLamBaiTap /*: IComparable*/
    {
        private string mabailam;
        private string mataikhoan;
        private string mabaitap;
        private string noidung;
        private DateTime thoigiannopbai;
        private float diem;
        private string nhanxet;

        public BaiLamBaiTap() { }

        public BaiLamBaiTap(string mabailam, string noidung, DateTime thoigiannopbai, float diem, string nhanxet, string mataikhoan, string mabaitap)
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
        public float Diem { get => diem; set => diem = value; }
        public string Nhanxet { get => nhanxet; set => nhanxet = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public string Mabaitap { get => mabaitap; set => mabaitap = value; }

        /*public int CompareTo(object obj)
        {
            return mabailam.CompareTo(obj);
        }
        public int CompareTo(BaiLamBaiTap c1, BailambaitapComparer.ComparisonType type)
        {
            switch (type)
            {
                case BailambaitapComparer.ComparisonType.mabailam:
                    return this.mabailam.CompareTo(c1.mabailam);
                case BailambaitapComparer.ComparisonType.mabaitap:
                    return this.mabaitap.CompareTo(c1.mabaitap);
                case BailambaitapComparer.ComparisonType.mataikhoan:
                    return this.mataikhoan.CompareTo(c1.mataikhoan);
            }
            return 0;
        }*/
    }

}
