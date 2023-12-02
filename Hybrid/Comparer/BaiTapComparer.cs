using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class BaiTapComparer:IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mabaitap
        }

        public int Compare(object i, object j)
        {
            BaiTap left = (BaiTap)i;
            BaiTap right = (BaiTap)j;
            return left.CompareTo(right, typeToCompare);
        }
    }
}
