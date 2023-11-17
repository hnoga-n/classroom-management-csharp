using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Kiemtra
{
    public partial class CauhoiNavigate : UserControl
    {
        public CauhoiNavigate()
        {
            InitializeComponent();
        }

        public KryptonButton getButtonNav()
        {
            return this.kryptonButton2;
        }
    }
}
