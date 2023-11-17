﻿using Hybrid.Comparer;
using System;
namespace Hybrid.DTO
{
    public class LopHoc:IComparable
    {
        private string malop;
        private string tenlop;
        private string magiangvien;
        private string mota;
        private string avatar;
<<<<<<< HEAD
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
=======
        private int daxoa;

        public LopHoc() { }
        public LopHoc(string malop,string tenlop, string mota, string avatar, string magiangvien,int daxoa)
        {
            this.Malop = malop;
            this.Tenlop = tenlop;
            this.Mota = mota;
            this.Avatar = avatar;
            this.Magiangvien = magiangvien;
            this.Daxoa = daxoa;
>>>>>>> main
        }

        public string Magiangvien { get => magiangvien; set => magiangvien = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Avatar { get => avatar; set => avatar = value; }
<<<<<<< HEAD
        public string Magiangvien { get => magiangvien; set => magiangvien = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }
=======
        public int Daxoa { get => daxoa; set => daxoa = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
>>>>>>> main

        public int CompareTo(Object obj)
        {
            LopHoc chuong = (LopHoc)obj;
            return this.Malop.CompareTo(chuong.Malop);
        }
        public int CompareTo(LopHoc c1, LophocComparer.ComparisonType type)
        {
            switch (type)
            {
                case LophocComparer.ComparisonType.malophoc:
                    return this.Malop.CompareTo(c1.Malop);
                case LophocComparer.ComparisonType.tenlophoc:
                    return this.Tenlop.CompareTo(c1.Tenlop);
            }
            return 0;
        }
    }
}
