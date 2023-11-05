using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class CauTraLoi
    {
        private string macautraloi;
        private string noidung;
        private int ladapan;
        private string macauhoi;

        public CauTraLoi(string macautraloi="", string noidung = "", int ladapan=0, string macauhoi = "")
        {
            this.Macautraloi = macautraloi;
            this.Noidung = noidung;
            this.Ladapan = ladapan;
            this.Macauhoi = macauhoi;
        }

        public string Macautraloi { get => macautraloi; set => macautraloi = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public int Ladapan { get => ladapan; set => ladapan = value; }
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
    }
}
