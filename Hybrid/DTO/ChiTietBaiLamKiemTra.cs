using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class ChiTietBaiLamKiemTra
    {
        private string mabailamkiemtra;
        private string macauhoi;
        private string dapanchon;

        public ChiTietBaiLamKiemTra(string mabailamkiemtra="", string macauhoi="", string dapanchon="")
        {
            this.mabailamkiemtra = mabailamkiemtra;
            this.macauhoi = macauhoi;
            this.dapanchon = dapanchon;
        }

        public string Mabailamkiemtra { get => mabailamkiemtra; set => mabailamkiemtra = value; }
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Dapanchon { get => dapanchon; set => dapanchon = value; }
    }
}
