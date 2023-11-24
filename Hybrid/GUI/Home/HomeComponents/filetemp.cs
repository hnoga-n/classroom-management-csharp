using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class filetemp : UserControl
    {
        public string FileName { get; private set; }
        public string filePath;
        public Icon icon;
        public filetemp(Icon fileIcon, string filePath)
        {
            this.FileName = filePath;
            this.filePath = filePath;
            this.icon = fileIcon;
            InitializeComponent();
        }

        private void filetemp_Load(object sender, EventArgs e)
        {
            

            // Lấy tên tệp tin
            string fileName = Path.GetFileName(filePath);

            // Hiển thị biểu tượng và tên tệp tin trong PictureBox và Label
            ShowFileInPictureBoxAndLabel(icon, fileName);
        }
        private void ShowFileInPictureBoxAndLabel(Icon fileIcon, string fileName)
        {
            // Hiển thị biểu tượng trong PictureBox
            pictureBox1.Image = fileIcon.ToBitmap();
            // Hiển thị tên tệp tin trong Label
            label1.Text = fileName;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RemoveFromParent();
        }
        public void RemoveFromParent()
        {
            // Kiểm tra xem UserControl có Parent không và Parent có kiểu là Control không
            if (this.Parent is Control parentControl)
            {
                // Xóa UserControl khỏi Controls của Parent
                parentControl.Controls.Remove(this);
                this.Dispose(); // Giải phóng tài nguyên (nếu cần)
            }
        }
    }
}
