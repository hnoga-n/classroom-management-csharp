using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class FileBaiLamBaiTap
    {
        private string mabailam;
        private string linkdinhkem;

        public FileBaiLamBaiTap(string mabailam="", string linkdinhkem = "")
        {
            this.mabailam = mabailam;
            this.linkdinhkem = linkdinhkem;
        }

        public string Mabailam { get => mabailam; set => mabailam = value; }
        public string Linkdinhkem { get => linkdinhkem; set => linkdinhkem = value; }
    }
}
