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
    public class TaikhoanComparer : IComparer<Taikhoan>
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mataikhoan, manhomquyen
        }

        public int Compare(Taikhoan x, Taikhoan y)
        {
            Taikhoan left = x;
            Taikhoan right = y;
            return left.CompareTo(right, typeToCompare);
        }
    }
}
