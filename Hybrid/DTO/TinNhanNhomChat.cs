using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class TinNhanNhomChat
    {
        private string matinnhan;
        private string noidung;
        private DateTime thoigiangui;
        private int antinnhan;
        private string matk;
        private string manhomchat;

        public TinNhanNhomChat() { }
        public TinNhanNhomChat(string matinnhan, string noidung, DateTime thoigiangui, int antinnhan, string matk, string manhomchat)
        {
            this.matinnhan = matinnhan;
            this.noidung = noidung;
            this.thoigiangui = thoigiangui;
            this.antinnhan = antinnhan;
            this.matk = matk;
            this.manhomchat = manhomchat;
        }

        public string Matinnhan { get => matinnhan; set => matinnhan = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public DateTime Thoigiangui { get => thoigiangui; set => thoigiangui = value; }
        public int Antinnhan { get => antinnhan; set => antinnhan = value; }
        public string Matk { get => matk; set => matk = value; }
        public string Manhomchat { get => manhomchat; set => manhomchat = value; }
    }
}
