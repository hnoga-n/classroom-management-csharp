using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class EmptyPanelKt : UserControl
    {
        public EmptyPanelKt()
        {
            InitializeComponent();
        }
        public EmptyPanelKt(string title)
        {
            InitializeComponent();
            this.title.Text = title;
        }
    }
}
