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
    public partial class TaskExam : UserControl
    {
        private DeKiemTra dkt;
        public TaskExam()
        {
            InitializeComponent();
        }

        public TaskExam(DeKiemTra dekt)
        {
            InitializeComponent();
            this.dkt = dekt;
            loadTaskExam();
        }
        public Label getLabelClass()
        {
            return this.lblClass;
        }

        public void loadTaskExam()
        {
            this.lblExamTitle.Text = this.dkt.Tieude;
            this.lblStart.Text = "Bắt đầu:"  + dkt.Thoigianbatdau.ToString();
            this.lblEnd.Text = "Kết thúc:"+dkt.Thoigianketthuc.ToString();
            if(dkt.Daxoa==1)
                this.btnDoExam.Visible= false;
            else
                this.btnDoExam.Visible = true;
        }
    }
}
