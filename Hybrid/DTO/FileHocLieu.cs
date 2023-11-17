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
        private string tenfile;
        private string id_file;
        public FileHocLieu() { }
        public FileHocLieu(string mahoclieu, string tenfile, string id_file)
        {
            this.mahoclieu = mahoclieu;
            this.tenfile = tenfile;
            this.id_file = id_file;
        }

        public string Mahoclieu { get => mahoclieu; set => mahoclieu = value; }
        public string Tenfile { get => tenfile; set => tenfile = value; }
        public string Id_file { get => id_file; set => id_file = value; }
    }
}
