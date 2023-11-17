using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class LopHoc:IComparable
    {
        private string malop;
        private string tenlop;
        private string mota;
        private string avatar;
        private string magiangvien;
        private int daxoa;

        public LopHoc() { }
        public LopHoc(string malop,string tenlop, string mota, string avatar, int daxoa, string magiangvien)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.mota = mota;
            this.avatar = avatar;
            this.magiangvien = magiangvien;
            this.daxoa = daxoa;
        }

        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Magiangvien { get => magiangvien; set => magiangvien = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }

        public int CompareTo(Object obj)
        {
            LopHoc chuong = (LopHoc)obj;
            return this.malop.CompareTo(chuong.malop);
        }
        public int CompareTo(LopHoc c1, LophocComparer.ComparisonType type)
        {
            switch (type)
            {
                case LophocComparer.ComparisonType.malophoc:
                    return this.malop.CompareTo(c1.malop);
                case LophocComparer.ComparisonType.tenlophoc:
                    return this.tenlop.CompareTo(c1.tenlop);
            }
            return 0;
        }
    }
}
