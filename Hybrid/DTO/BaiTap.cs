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

        public BaiTap()
        {
        }

        public BaiTap(string mabaitap, string machuong, string tieude, string noidungbaitap, string noidungdapan, DateTime thoigiantao, DateTime thoigianbatdau, DateTime thoigianketthuc, int daxoa, int congkhaidapan)
        {
            this.mabaitap = mabaitap;
            this.machuong = machuong;
            this.tieude = tieude;
            this.noidungbaitap = noidungbaitap;
            this.noidungdapan = noidungdapan;
            this.thoigiantao = thoigiantao;
            this.thoigianbatdau = thoigianbatdau;
            this.thoigianketthuc = thoigianketthuc;
            this.daxoa = daxoa;
            this.congkhaidapan = congkhaidapan;
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

        public int CompareTo(Object obj)
        {
            BaiTap BaiTap = (BaiTap)obj;
            return this.mabaitap.CompareTo(BaiTap.mabaitap);
        }
        public int CompareTo(BaiTap c1, BaiTapComparer.ComparisonType type)
        {
            switch (type)
            {
                case BaiTapComparer.ComparisonType.mabaitap:
                    return this.mabaitap.CompareTo(c1.mabaitap);
            }
            return 0;
        }
    }
}
