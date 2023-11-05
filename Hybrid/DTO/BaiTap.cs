using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BaiTap
    {
        private string mabaitap;
        private string tieude;
        private string noidung;
        private DateTime thoihan;
        private DateTime thoigiantao;
        private string machuong;
        private int dahoanthanh;

        public BaiTap()
        {
        }
        public BaiTap(string mabaitap, string tieude, string noidung, DateTime thoihan, DateTime thoigiantao, string machuong, int dahoanthanh)
        {
            this.mabaitap = mabaitap;
            this.tieude = tieude;
            this.noidung = noidung;
            this.thoihan = thoihan;
            this.thoigiantao = thoigiantao;
            this.machuong = machuong;
            this.dahoanthanh = dahoanthanh;
        }

        public string Mabaitap { get => mabaitap; set => mabaitap = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public DateTime Thoihan { get => thoihan; set => thoihan = value; }
        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public string Machuong { get => machuong; set => machuong = value; }
        public int Dahoanthanh { get => dahoanthanh; set => dahoanthanh = value; }
    }
}
