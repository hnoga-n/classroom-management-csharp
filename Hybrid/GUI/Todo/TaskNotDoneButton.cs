using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Todo
{
    public partial class TaskNotDoneButton : UserControl
    {
        public TaskNotDoneButton()
        {
            InitializeComponent();
        }

        public KryptonButton btnNotDone()
        {
            return this.btnChuaxuly;
        }

        private void lblNotDone_Click(object sender, EventArgs e)
        {
            btnChuaxuly.PerformClick();
        }

        private void sangclockPic_Click(object sender, EventArgs e)
        {
            btnChuaxuly.PerformClick();

        }
    }
}
