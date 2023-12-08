using System;

namespace Hybrid.DTO
{
    public class BanBe
    {
        private string manguoiketban;
        private string manguoiduocketban;
        private string hoten;
        private DateTime thoigianketban;
        private int trangthaiketban;

        public BanBe() { }
        public BanBe(string manguoiketban, string manguoiduocketban, string hoten, DateTime thoigianketban, int trangthaiketban)
        {
            this.Manguoiketban = manguoiketban;
            this.Manguoiduocketban = manguoiduocketban;
            this.hoten = hoten;
            this.thoigianketban = thoigianketban;
            this.trangthaiketban = trangthaiketban;
        }

        public DateTime Thoigianketban { get => thoigianketban; set => thoigianketban = value; }
        public int Trangthaiketban { get => trangthaiketban; set => trangthaiketban = value; }
        public string Manguoiketban { get => manguoiketban; set => manguoiketban = value; }
        public string Hoten { get => hoten; set => hoten = value; }

        public string Manguoiduocketban { get => manguoiduocketban; set => manguoiduocketban = value; }
    }
}
