using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class BanBe
    {
        private string mamoiquanhe;
        private string matk;
        private int manguoiban;
        private DateTime thoigianketban;
        private int trangthaiketban;

        public BanBe(string mamoiquanhe, string matk, int manguoiban, DateTime thoigianketban, int trangthaiketban)
        {
            this.mamoiquanhe = mamoiquanhe;
            this.matk = matk;
            this.manguoiban = manguoiban;
            this.thoigianketban = thoigianketban;
            this.trangthaiketban = trangthaiketban;
        }

        public string Mamoiquanhe { get => mamoiquanhe; set => mamoiquanhe = value; }
        public string Matk { get => matk; set => matk = value; }
        public int Manguoiban { get => manguoiban; set => manguoiban = value; }
        public DateTime Thoigianketban { get => thoigianketban; set => thoigianketban = value; }
        public int Trangthaiketban { get => trangthaiketban; set => trangthaiketban = value; }
    }
}
