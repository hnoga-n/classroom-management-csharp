using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class ChiTietDeKiemTra
    {
        private string madekiemtra;
        private string macauhoi;
        private int thutu;

        public ChiTietDeKiemTra(string madekiemtra="", string macauhoi = "", int thutu = 0)
        {
            this.madekiemtra = madekiemtra;
            this.macauhoi = macauhoi;
            this.thutu = thutu;
        }

        public string Madekiemtra { get => madekiemtra; set => madekiemtra = value; }
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public int Thutu { get => thutu; set => thutu = value; }
    }
}
