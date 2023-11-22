using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap.Giaovien
{
    public partial class TaoBaiTap : Form
    {
        public TaoBaiTap()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblCharCountTitle.Text = txtTitle.Text.Length.ToString() + "/200";
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            lblCharCountContent.Text = txtContent.Text.Length.ToString() + "/4000";
        }
    }
}
