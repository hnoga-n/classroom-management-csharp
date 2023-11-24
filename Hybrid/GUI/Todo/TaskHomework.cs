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
    public partial class TaskHomework : UserControl
    {
        private BaiTap bt;
        public TaskHomework( )
        {
            InitializeComponent();
        }

        public TaskHomework(BaiTap bt)
        {
            InitializeComponent();
            this.bt = bt;
            loadBaitap();
        }

        public Label getLabelClass()
        {
            return this.lblClass;
        }
        private void loadBaitap()
        {
            this.lblTitle.Text = bt.Tieude;
            this.lblDeadline.Text = bt.Thoigiantao.ToString();
            if (bt.Dahoanthanh == 1)
                this.btnDoHomework.Visible = false;
            else
                this.btnDoHomework.Visible = true;
        }
    }
}
