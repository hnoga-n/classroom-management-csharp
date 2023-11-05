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

        public ChiTietDeKiemTra(string madekiemtra="", string macauhoi = "")
        {
            this.madekiemtra = madekiemtra;
            this.macauhoi = macauhoi;
        }

        public string Madekiemtra { get => madekiemtra; set => madekiemtra = value; }
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
    }
}
