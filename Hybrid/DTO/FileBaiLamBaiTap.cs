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
        private string path;
        private string id_file;

        public FileBaiLamBaiTap() { }
        public FileBaiLamBaiTap(string mabailam, string tenfile, string id_file)
        {
            this.mabailam = mabailam;
            this.path = tenfile;
            this.id_file = id_file;
        }

        public string Mabailam { get => mabailam; set => mabailam = value; }
        public string Path { get => path; set => path = value; }
        public string Id_file { get => id_file; set => id_file = value; }
    }
}
