using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI
{
    public partial class Test : Form
    {
        TaikhoanBUS tkbus = new TaikhoanBUS();
        TaikhoanDAO tkdao = new TaikhoanDAO(); 
        public Test()
        {
            InitializeComponent();

            List<Taikhoan> rslist = tkbus.List;
            foreach(Taikhoan tk in rslist)
            {
                if (tkdao.reset_matkhau(tk.Email))
                    continue;
            }
        }
    }
}
