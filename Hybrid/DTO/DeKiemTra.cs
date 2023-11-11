using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class DeKiemTra
    {
        private string madekiemtra;
        private string tieude;
        private DateTime thoigianbatdau;
        private DateTime thoigianketthuc;
        private DateTime thoigiantao;
        private int xemdiem;
        private int xemdapan;
        private int troncauhoi;
        private int dahoanthanh;
        private string machuong;
        private int daxoa;

        public DeKiemTra() { }

        public DeKiemTra(string madekiemtra, string tieude, DateTime thoigiantao, DateTime thoigianbatdau, DateTime thoigianketthuc, int xemdiem, int xemdapan,int troncauhoi, string machuong, int dahoanthanh, int daxoa)
        {
            this.madekiemtra = madekiemtra;
            this.tieude = tieude;
            this.thoigiantao = thoigiantao;
            this.thoigianbatdau = thoigianbatdau;
            this.thoigianketthuc = thoigianketthuc;
            this.xemdiem = xemdiem;
            this.xemdapan = xemdapan;
            this.troncauhoi = troncauhoi;
            this.machuong = machuong;
            this.Dahoanthanh = dahoanthanh;
            this.daxoa = daxoa;
        }

        public string Madekiemtra { get => madekiemtra; set => madekiemtra = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public DateTime Thoigianbatdau { get => thoigianbatdau; set => thoigianbatdau = value; }
        public DateTime Thoigianketthuc { get => thoigianketthuc; set => thoigianketthuc = value; }
        public int Xemdiem { get => xemdiem; set => xemdiem = value; }
        public int Xemdapan { get => xemdapan; set => xemdapan = value; }
        public string Machuong { get => machuong; set => machuong = value; }
        public int Troncauhoi { get => troncauhoi; set => troncauhoi = value; }
        public int Dahoanthanh { get => dahoanthanh; set => dahoanthanh = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }
    }
}
