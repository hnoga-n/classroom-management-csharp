using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class DekiemtraComparer:IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            madekiemtra, machuong
        }

        public int Compare(object i, object j)
        {
            DeKiemTra left = (DeKiemTra)i;
            DeKiemTra right = (DeKiemTra)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}
