﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubiety.Dns.Core.Records;

namespace Hybrid.GUI.Home.KiemTra.KiemTraComponents
{
    public partial class EmptyPanelBt : UserControl
    {
        public EmptyPanelBt()
        {
            InitializeComponent();
        }
        public EmptyPanelBt(string title)
        {
            InitializeComponent();
            this.title.Text  = title;
        }
    }
}