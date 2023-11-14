using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class CautraloiComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            macautraloi, macauhoi
        }

        public int Compare(object i, object j)
        {
            CauTraLoi left = (CauTraLoi)i;
            CauTraLoi right = (CauTraLoi)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}
