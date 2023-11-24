using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class DeKiemTra : IComparable
    {
        private string madekiemtra;
        private string tieude;
        private DateTime thoigianbatdau;
        private DateTime thoigianketthuc;
        private DateTime thoigiantao;
        private int hinhphat;
        private int xemdapan;
        private int troncauhoi;
        private string machuong;
        private int daxoa;

        public DeKiemTra() { }

        public DeKiemTra(string madekiemtra, string tieude, DateTime thoigiantao, DateTime thoigianbatdau, DateTime thoigianketthuc, int hinhphat, int xemdapan, int troncauhoi, string machuong, int daxoa)
        {
            this.madekiemtra = madekiemtra;
            this.tieude = tieude;
            this.thoigiantao = thoigiantao;
            this.thoigianbatdau = thoigianbatdau;
            this.thoigianketthuc = thoigianketthuc;
            this.hinhphat = hinhphat;
            this.xemdapan = xemdapan;
            this.troncauhoi = troncauhoi;
            this.machuong = machuong;
            Daxoa = daxoa;
        }

        public string Madekiemtra { get => madekiemtra; set => madekiemtra = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public DateTime Thoigianbatdau { get => thoigianbatdau; set => thoigianbatdau = value; }
        public DateTime Thoigianketthuc { get => thoigianketthuc; set => thoigianketthuc = value; }
        public int Hinhphat { get => hinhphat; set => hinhphat = value; }
        public int Xemdapan { get => xemdapan; set => xemdapan = value; }
        public string Machuong { get => machuong; set => machuong = value; }
        public int Troncauhoi { get => troncauhoi; set => troncauhoi = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }

        public int CompareTo(Object obj)
        {
            DeKiemTra chuong = (DeKiemTra)obj;
            return this.machuong.CompareTo(chuong.machuong);
        }
        public int CompareTo(DeKiemTra c1, DekiemtraComparer.ComparisonType type)
        {
            switch (type)
            {
                case DekiemtraComparer.ComparisonType.machuong:
                    return this.machuong.CompareTo(c1.machuong);
                case DekiemtraComparer.ComparisonType.madekiemtra:
                    return this.madekiemtra.CompareTo(c1.madekiemtra);
            }
            return 0;
        }
        public override string ToString()
        {
            return $"Madekiemtra: {madekiemtra}, " +
                   $"Tieude: {tieude}, " +
                   $"Thoigianbatdau: {thoigianbatdau}, " +
                   $"Thoigianketthuc: {thoigianketthuc}, " +
                   $"Thoigiantao: {thoigiantao}, " +
                   $"Hinhphat: {hinhphat}, " +
                   $"Xemdapan: {xemdapan}, " +
                   $"Troncauhoi: {troncauhoi}, " +
                   $"Machuong: {machuong}, " +
                   $"Daxoa: {daxoa}";
        }
    }
}
