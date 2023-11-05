using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class NhomChat
    {
        private string manhomchat;
        private string mota;
        private string malop;

        public NhomChat(string manhomchat="", string mota = "", string malop = "")
        {
            this.manhomchat = manhomchat;
            this.mota = mota;
            this.malop = malop;
        }

        public string Manhomchat { get => manhomchat; set => manhomchat = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Malop { get => malop; set => malop = value; }
    }
}
