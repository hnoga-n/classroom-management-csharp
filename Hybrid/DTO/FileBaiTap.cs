using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class FileBaiTap
    {
        private string mabaitap;
        private string linkdinhkem;

        public FileBaiTap(string mabaitap="", string linkdinhkem = "")
        {
            this.mabaitap = mabaitap;
            this.linkdinhkem = linkdinhkem;
        }

        public string Mabaitap { get => mabaitap; set => mabaitap = value; }
        public string Linkdinhkem { get => linkdinhkem; set => linkdinhkem = value; }
    }
}
