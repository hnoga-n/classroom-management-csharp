using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BaiLamKiemTra
    {
        private string mabailam;
        private int diem;
        private DateTime thoigianvaokiemtra;
        private DateTime thoigiannop;
        private int socaudung;
        private string mataikhoan;

        public BaiLamKiemTra() { }
        public BaiLamKiemTra(string mabailam, int diem, DateTime thoigianvaokiemtra, DateTime thoigiannop, int socaudung, string mataikhoan)
        {
            this.Mabailam = mabailam;
            this.Diem = diem;
            this.Thoigianvaokiemtra = thoigianvaokiemtra;
            this.Thoigiannop = thoigiannop;
            this.Socaudung = socaudung;
            this.Mataikhoan = mataikhoan;
        }

        public string Mabailam { get => mabailam; set => mabailam = value; }
        public int Diem { get => diem; set => diem = value; }
        public DateTime Thoigianvaokiemtra { get => thoigianvaokiemtra; set => thoigianvaokiemtra = value; }
        public DateTime Thoigiannop { get => thoigiannop; set => thoigiannop = value; }
        public int Socaudung { get => socaudung; set => socaudung = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
    }
}
