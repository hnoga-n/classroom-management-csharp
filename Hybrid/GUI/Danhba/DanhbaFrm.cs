using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Danhba
{
    public partial class DanhbaFrm : Form
    {
        private Boolean isCollapsed1;
        private Boolean isCollapsed2;
        private Boolean isCollapsed3;
        private int DROP_DOWN_SPEED =20;
        public DanhbaFrm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                panelDropDown.Height += DROP_DOWN_SPEED;
                if(panelDropDown.Size == panelDropDown.MaximumSize )
                {
                    timer1.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                panelDropDown.Height -= DROP_DOWN_SPEED;
                if(panelDropDown.Size == panelDropDown.MinimumSize )
                {
                    timer1.Stop();
                    isCollapsed1 = true;
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                panelDropDown2.Height += DROP_DOWN_SPEED;
                if (panelDropDown2.Size == panelDropDown2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                panelDropDown2.Height -= DROP_DOWN_SPEED;
                if (panelDropDown2.Size == panelDropDown2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                panelDropDown3.Height += DROP_DOWN_SPEED;
                if (panelDropDown3.Size == panelDropDown3.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                panelDropDown3.Height -= DROP_DOWN_SPEED;
                if (panelDropDown3.Size == panelDropDown3.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

   
    }
}
