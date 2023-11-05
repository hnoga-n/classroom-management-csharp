using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class NhomQuyen
    {
        private int manhomquyen;
        private string tennhomquyen;

        public NhomQuyen() { }
        public NhomQuyen(int manhomquyen, string tennhomquyen)
        {
            this.manhomquyen = manhomquyen;
            this.tennhomquyen = tennhomquyen;
        }

        public int Manhomquyen { get => manhomquyen; set => manhomquyen = value; }
        public string Tennhomquyen { get => tennhomquyen; set => tennhomquyen = value; }
    }
}
