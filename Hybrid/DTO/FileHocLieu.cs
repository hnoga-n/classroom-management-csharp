using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class FileHocLieu
    {
        private string mahoclieu;
        private string linkdinhkem;

        public FileHocLieu(string mahoclieu="", string linkdinhkem = "")
        {
            this.mahoclieu = mahoclieu;
            this.linkdinhkem = linkdinhkem;
        }

        public string Mahoclieu { get => mahoclieu; set => mahoclieu = value; }
        public string Linkdinhkem { get => linkdinhkem; set => linkdinhkem = value; }
    }
}
