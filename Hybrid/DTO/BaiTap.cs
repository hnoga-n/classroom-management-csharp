using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BaiTap : IComparable
    {
        private string mabaitap;
        private string machuong;
        private string tieude;
        private string noidungbaitap;
        private string noidungdapan;
        private DateTime thoigiantao;
        private DateTime thoigianbatdau;
        private DateTime thoigianketthuc;
        private int daxoa;
        private int congkhaidapan;
        private int nopbu;
        public BaiTap(string mabaitap = null, string machuong = null, string tieude = null, string noidungbaitap = null, string noidungdapan = null, DateTime thoigiantao = default, DateTime thoigianbatdau = default, DateTime thoigianketthuc = default, int daxoa = 0, int congkhaidapan = 0, int nopbu = 0)
        {
            this.Mabaitap = mabaitap;
            this.Machuong = machuong;
            this.Tieude = tieude;
            this.Noidungbaitap = noidungbaitap;
            this.Noidungdapan = noidungdapan;
            this.Thoigiantao = thoigiantao;
            this.Thoigianbatdau = thoigianbatdau;
            this.Thoigianketthuc = thoigianketthuc;
            this.Daxoa = daxoa;
            this.Congkhaidapan = congkhaidapan;
            this.Nopbu = nopbu;
        }

        public string Mabaitap { get => mabaitap; set => mabaitap = value; }
        public string Machuong { get => machuong; set => machuong = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Noidungbaitap { get => noidungbaitap; set => noidungbaitap = value; }
        public string Noidungdapan { get => noidungdapan; set => noidungdapan = value; }
        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public DateTime Thoigianbatdau { get => thoigianbatdau; set => thoigianbatdau = value; }
        public DateTime Thoigianketthuc { get => thoigianketthuc; set => thoigianketthuc = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }
        public int Congkhaidapan { get => congkhaidapan; set => congkhaidapan = value; }
        public int Nopbu { get => nopbu; set => nopbu = value; }

        public int CompareTo(Object obj)
        {
            BaiTap BaiTap = (BaiTap)obj;
            return this.Mabaitap.CompareTo(BaiTap.Mabaitap);
        }
        public int CompareTo(BaiTap c1, BaiTapComparer.ComparisonType type)
        {
            switch (type)
            {
                case BaiTapComparer.ComparisonType.mabaitap:
                    return this.Mabaitap.CompareTo(c1.Mabaitap);
            }
            return 0;
        }
        public override string ToString()
        {
            return $"Mabaitap: {Mabaitap}, Machuong: {Machuong}, Tieude: {Tieude}, " +
                   $"Noidungbaitap: {Noidungbaitap}, Noidungdapan: {Noidungdapan}, " +
                   $"Thoigiantao: {Thoigiantao}, Thoigianbatdau: {Thoigianbatdau}, " +
                   $"Thoigianketthuc: {Thoigianketthuc}, Daxoa: {Daxoa}, " +
                   $"Congkhaidapan: {Congkhaidapan}";
        }
    }
}
