using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Hybrid.GUI
{
    public partial class Thongtintaikhoan : KryptonForm
    {
        public Thongtintaikhoan()
        {
            InitializeComponent();
        }

        private void Thongtintaikhoan_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(hinhanh);
        }
        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                // Tạo đường dẫn hình tròn
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

                // Gán đường dẫn cho PictureBox
                pictureBox.Region = new Region(path);
            }
        }

    }
}
