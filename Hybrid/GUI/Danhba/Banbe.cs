using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrid.DAO;
using Hybrid.DTO;

namespace Hybrid.GUI.Danhba
{
    public partial class Banbe : UserControl
    {
        private string manguoiketban;
        private string manguoiduocketban;
        private string hoten;
        private DateTime thoigianketban;
        private int trangthaiketban;

        public event EventHandler ButtonClicked;


        public Banbe(BanBe a)
        {
            InitializeComponent();

            manguoiduocketban = a.Manguoiduocketban.ToString();
            manguoiketban = a.Manguoiketban.ToString();
            hoten = a.Hoten.ToString();
            trangthaiketban = a.Trangthaiketban;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            List<Taikhoan> list = new TaikhoanDAO().get_danhsach();
            foreach (Taikhoan t in list)
            {
                if (t.Mataikhoan == manguoiduocketban)
                {
                    label1.Text = t.Hoten;
                    if (t.Anhdaidien.Equals("canhan1"))
                        pictureBox1.Image = Properties.Resources.canhan1;
                    if (t.Anhdaidien.Equals("canhan2"))
                        pictureBox1.Image = Properties.Resources.canhan2;
                    if (t.Anhdaidien.Equals("canhan3"))
                        pictureBox1.Image = Properties.Resources.canhan3;
                    if (t.Anhdaidien.Equals("canhan4"))
                        pictureBox1.Image = Properties.Resources.canhan4;
                    if (t.Anhdaidien.Equals("canhan5"))
                        pictureBox1.Image = Properties.Resources.canhan5;
                    if (t.Anhdaidien.Equals("canhan6"))
                        pictureBox1.Image = Properties.Resources.canhan6;
                }
            }
        }

        public BanBe dto()
        {
            BanBe banbe = new BanBe(manguoiketban, manguoiduocketban, hoten, thoigianketban, trangthaiketban);
            return banbe;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.kryptonButton1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.kryptonButton1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
