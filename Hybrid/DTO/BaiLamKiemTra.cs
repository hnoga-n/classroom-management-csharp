using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BaiLamKiemTra : IComparable
    {
        private string mabailam;
        private string madekiemtra;
        private string mataikhoan;
        private float diem;
        private DateTime thoigianvaokiemtra;
        private DateTime thoigiannop;
        private int socaudung;
        private int noptre;

        public BaiLamKiemTra() { }
        public BaiLamKiemTra(string mabailam, float diem, DateTime thoigianvaokiemtra, DateTime thoigiannop, int socaudung, string mataikhoan, int noptre, string madekiemtra)
        {
            this.Mabailam = mabailam;
            this.Diem = diem;
            this.Thoigianvaokiemtra = thoigianvaokiemtra;
            this.Thoigiannop = thoigiannop;
            this.Socaudung = socaudung;
            this.Mataikhoan = mataikhoan;
            this.noptre = noptre;
            this.madekiemtra = madekiemtra;
        }

        public string Mabailam { get => mabailam; set => mabailam = value; }
        public float Diem { get => diem; set => diem = value; }
        public DateTime Thoigianvaokiemtra { get => thoigianvaokiemtra; set => thoigianvaokiemtra = value; }
        public DateTime Thoigiannop { get => thoigiannop; set => thoigiannop = value; }
        public int Socaudung { get => socaudung; set => socaudung = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public int Noptre { get => noptre; set => noptre = value; }
        public string Madekiemtra { get => madekiemtra; set => madekiemtra = value; }

        public override string ToString()
        {
            return $"Mã bài làm: {mabailam}\n" +
                   $"Mã đề kiểm tra: {madekiemtra}\n" +
                   $"Điểm: {diem}\n" +
                   $"Thời gian vào kiểm tra: {thoigianvaokiemtra}\n" +
                   $"Thời gian nộp: {thoigiannop}\n" +
                   $"Số câu đúng: {socaudung}\n" +
                   $"Nộp trễ: {noptre}\n" +
                   $"Mã tài khoản: {mataikhoan}";
        }
        public int CompareTo(object obj)
        {
            return mabailam.CompareTo(obj);
        }
        public int CompareTo(BaiLamKiemTra c1, BailamkiemtraComparer.ComparisonType type)
        {
            switch (type)
            {
                case BailamkiemtraComparer.ComparisonType.mabailam:
                    return this.mabailam.CompareTo(c1.Mabailam);
                case BailamkiemtraComparer.ComparisonType.mataikhoan:
                    return this.mataikhoan.CompareTo(c1.mataikhoan);
            }
            return 0;
        }
    }
}
