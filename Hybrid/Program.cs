
using Hybrid.GUI.Home;
using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Baitap.Giaovien;
using Hybrid.GUI.Home.KiemTra;
using Hybrid.GUI.Kiemtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrid.GUI;
using Hybrid.GUI.Admin;
using Hybrid.GUI.Dangnhap;

namespace Hybrid
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUI());
            //Application.Run(new Form1());
            //Application.Run(new DanhSachBaiDaNop());
            //Application.Run(new KiemTraFrm());
            //Application.Run(new TaoBaiTap());
            //Application.Run(new Homeadminfrm());
            //Application.Run(new test1());
        }
    }
}
