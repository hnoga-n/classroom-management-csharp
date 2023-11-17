using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.DTO
{
    public class CauHoi : IComparable
    {
        private string macauhoi;
        private string mataikhoan;
        private string noidung;
        private int daxoa;

        public CauHoi() { }

        public CauHoi(string macauhoi, string noidung, string mataikhoan,int daxoa)
        {
            this.macauhoi = macauhoi;
            this.noidung = noidung;
            this.mataikhoan = mataikhoan;
            this.Daxoa = daxoa;
        }

        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }

        public int CompareTo(object obj)
        {
            CauHoi ch = (CauHoi)obj;
            return this.macauhoi.CompareTo(ch.macauhoi);
        }
        public int CompareTo(CauHoi c1, CauhoiComparer.ComparisonType type)
        {
            switch (type)
            {
                case CauhoiComparer.ComparisonType.macauhoi:
                    return this.macauhoi.CompareTo(c1.macauhoi);
                case CauhoiComparer.ComparisonType.mataikhoan:
                    return this.mataikhoan.CompareTo(c1.mataikhoan);
            }
            return 0;
        }
    }
}
