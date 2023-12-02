using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class BailambaitapComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mabailam, mataikhoan, mabaitap
        }

        public int Compare(object i, object j)
        {
            BaiLamBaiTap left = (BaiLamBaiTap)i;
            BaiLamBaiTap right = (BaiLamBaiTap)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}
