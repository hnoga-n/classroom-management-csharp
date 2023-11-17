﻿using System;
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
    public partial class TaskEmpty : UserControl
    {
        public TaskEmpty()
        {
            InitializeComponent();
        }
        public TaskEmpty(string title, string body)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            this.body.Text = body;
        }
    }
}
