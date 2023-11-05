using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class HocLieu
    {
        private string mahoclieu;
        private string tieude;
        private string noidung;
        private string machuong;

        public HocLieu(string mahoclieu = "", string tieude = "", string noidung = "", string machuong = "")
        {
            this.mahoclieu = mahoclieu;
            this.tieude = tieude;
            this.noidung = noidung;
            this.machuong = machuong;
        }

        public string Mahoclieu { get => mahoclieu; set => mahoclieu = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Machuong { get => machuong; set => machuong = value; }
    }
}
