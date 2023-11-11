using Hybrid.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.DTO
{
    public class Chuong:IComparable
    {
        private string machuong;
        private string tenchuong;
        private DateTime thoigiantao;
        private string malop;
        private int daxoa;

        public Chuong() { }
        public Chuong(string machuong,string tenchuong, DateTime thoigiantao, string malop,int daxoa)
        {
            this.machuong = machuong;   
            this.tenchuong = tenchuong;
            this.thoigiantao = thoigiantao;
            this.malop = malop;
            this.daxoa = daxoa;
        }

        public string Machuong { get => machuong; set => machuong = value; }
        public string Tenchuong { get => tenchuong; set => tenchuong = value; }
        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public string Malop { get => malop; set => malop = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }

        public int CompareTo(Object obj)
        {
            Chuong chuong = (Chuong)obj;
            return this.machuong.CompareTo(chuong.machuong);
        }
        public int CompareTo(Chuong c1, ChuongComparer.ComparisonType type)
        {
            switch (type)
            {
                case ChuongComparer.ComparisonType.machuong:
                    return this.machuong.CompareTo(c1.machuong);
                case ChuongComparer.ComparisonType.tenchuong:
                    return this.tenchuong.CompareTo(c1.tenchuong);
            }
            return 0;
        }
    }
}
