using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class CauHoi
    {
        private string macauhoi;
        private string noidung;
        private string giaithich;
        private string matk;
        private int trangthai;

        public CauHoi() { }
        public CauHoi(string macauhoi, string noidung, string giaithich, string matk, int trangthai)
        {
            this.macauhoi = macauhoi;
            this.noidung = noidung;
            this.giaithich = giaithich;
            this.matk = matk;
            this.trangthai = trangthai;
        }

        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Giaithich { get => giaithich; set => giaithich = value; }
        public string Matk { get => matk; set => matk = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
