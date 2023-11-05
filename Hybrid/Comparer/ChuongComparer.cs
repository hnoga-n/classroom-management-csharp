using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class ChuongComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            machuong, tenchuong
        }

        public int Compare(object i, object j)
        {
            Chuong left = (Chuong)i;
            Chuong right = (Chuong)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}
