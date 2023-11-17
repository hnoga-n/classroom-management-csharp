using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class BailamkiemtraComparer:IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mabailam, mataikhoan
        }

        public int Compare(object i, object j)
        {
            BaiLamKiemTra left = (BaiLamKiemTra)i;
            BaiLamKiemTra right = (BaiLamKiemTra)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}
