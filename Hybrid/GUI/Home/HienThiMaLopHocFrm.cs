﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class HienThiMaLopHocFrm : Form
    {
        public HienThiMaLopHocFrm(string malop)
        {
            InitializeComponent();
            this.lblMaLop.Text = malop;
        }
    }
}
