using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.Comparer
{
    public class CauhoiComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            macauhoi, mataikhoan
        }

        public int Compare(object i, object j)
        {
            CauHoi left = (CauHoi)i;
            CauHoi right = (CauHoi)j;;
            return left.CompareTo(right, typeToCompare);

        }
    }
}
