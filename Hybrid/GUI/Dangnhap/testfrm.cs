using Hybrid.BUS;
using Hybrid.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Dangnhap
{
    public partial class testfrm : Form
    {
        TaikhoanDAO taikhoanDAO=new TaikhoanDAO();
        public testfrm()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            MessageBox.Show("Tinh trang cua email:" + taikhoanDAO.get_daxoa_email(temp));
        }
    }
}
