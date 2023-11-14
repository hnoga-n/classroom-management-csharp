using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    internal class TinNhanBanBe
    {
        private string matinnhan;
        private string manguoigui;
        private string manguoinhan;
        private string noidung;
        private DateTime thoigiangui;
        private int daxoa;

        public TinNhanBanBe() { }

        public TinNhanBanBe(string matinnhan, string manguoigui, string manguoinhan, string noidung, DateTime thoigiangui, int daxoa)
        {
            this.matinnhan = matinnhan;
            this.manguoigui = manguoigui;
            this.manguoinhan = manguoinhan;
            this.noidung = noidung;
            this.thoigiangui = thoigiangui;
            this.daxoa = daxoa;
        }

        public string Matinnhan { get => matinnhan; set => matinnhan = value; }
        public string Manguoigui { get => manguoigui; set => manguoigui = value; }
        public string Manguoinhan { get => manguoinhan; set => manguoinhan = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public DateTime Thoigiangui { get => thoigiangui; set => thoigiangui = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }
    }
}
