using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class LophocComparer:IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            malophoc, tenlophoc
        }

        public int Compare(object i, object j)
        {
            LopHoc left = (LopHoc)i;
            LopHoc right = (LopHoc)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}
