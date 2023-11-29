using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.Comparer
{
    public class ChiTietBaiLamKiemTraComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            sothutu
        }

        public int Compare(object i, object j)
        {
            ChiTietBaiLamKiemTra left = (ChiTietBaiLamKiemTra)i;
            ChiTietBaiLamKiemTra right = (ChiTietBaiLamKiemTra)j;
            return left.CompareTo(right);
        }
    }
}
