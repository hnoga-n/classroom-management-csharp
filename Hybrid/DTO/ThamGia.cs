using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class ThamGia
    {
        private string malop;
        private string mataikhoan;

        public ThamGia(string malop="", string mataikhoan = "")
        {
            this.malop = malop;
            this.mataikhoan = mataikhoan;
        }

        public string Malop { get => malop; set => malop = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
    }
}
