using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class CauTraLoi : IComparable
    {
        private string macautraloi;
        private string macauhoi;
        private string noidung;
        private int ladapan;

        public CauTraLoi(string macautraloi = "", string noidung = "", int ladapan = 0, string macauhoi = "")
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
        public int CompareTo(Object obj)
        {
            CauTraLoi chuong = (CauTraLoi)obj;
            return this.macautraloi.CompareTo(chuong.macautraloi);
        }
        public int CompareTo(CauTraLoi c1, CautraloiComparer.ComparisonType type)
        {
            switch (type)
            {
                case CautraloiComparer.ComparisonType.macauhoi:
                    return this.Macauhoi.CompareTo(c1.macauhoi);
                case CautraloiComparer.ComparisonType.macautraloi:
                    return this.macautraloi.CompareTo(c1.macautraloi);
            }
            return 0;
        }
    }
}
