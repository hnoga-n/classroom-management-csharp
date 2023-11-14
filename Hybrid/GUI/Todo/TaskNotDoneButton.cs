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
        private Taikhoan taikhoanhienhanh;
        private BaiTapBUS btBUS;
        public TaskNotDoneButton()
        {
            InitializeComponent();
        }

        public KryptonButton btnNotDone()
        {
            return this.btnChuaxuly;
        }
        private void lblNotDone_MouseEnter(object sender, EventArgs e)
        {
            this.btnChuaxuly.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnChuaxuly.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212))))); ;
            this.btnChuaxuly.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
        }

        private void lblNotDone_MouseLeave(object sender, EventArgs e)
        {
            this.btnChuaxuly.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnChuaxuly.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnChuaxuly.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
        }
    }
}
