using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BanbeDTO
    {
        private string mabanbe;
        private string manguoiketban;
        private string manguoiduocketban;
        private DateTime thoigianketban;
        private int trangthaiketban;

        public BanbeDTO() { }

        public BanbeDTO(string mabanbe, string manguoiketban, string manguoiduocketban, DateTime thoigianketban, int trangthaiketban)
        {
            this.mabanbe = mabanbe;
            this.manguoiketban = manguoiketban;
            this.manguoiduocketban = manguoiduocketban;
            this.thoigianketban = thoigianketban;
            this.trangthaiketban = trangthaiketban;
        }

        public string Mabanbe { get => mabanbe; set => mabanbe = value; }
        public string Manguoiketban { get => manguoiketban; set => manguoiketban = value; }
        public string Manguoiduocketban { get => manguoiduocketban; set => manguoiduocketban = value; }
        public DateTime Thoigianketban { get => thoigianketban; set => thoigianketban = value; }
        public int Trangthaiketban { get => trangthaiketban; set => trangthaiketban = value; }
    }
}
