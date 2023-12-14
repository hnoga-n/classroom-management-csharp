using ComponentFactory.Krypton.Toolkit;
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
    public partial class TaskDoneButton : UserControl
    {
        public TaskDoneButton()
        {
            InitializeComponent();
        }

        public KryptonButton getBtnDone()
        {
            return this.kryptonButton1;
        }

        private void lblNotDone_Click(object sender, EventArgs e)
        {
            this.kryptonButton1.PerformClick();
        }

        private void tickPic_Click(object sender, EventArgs e)
        {
            this.kryptonButton1.PerformClick();

        }
    }
}
