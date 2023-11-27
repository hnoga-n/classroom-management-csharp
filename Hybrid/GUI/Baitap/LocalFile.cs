using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap
{
    public partial class LocalFile : UserControl
    {
        private string path;
        public LocalFile()
        {
            InitializeComponent();
        }

        public LocalFile(string filePath, Icon fileIcon)
        {
            InitializeComponent();
            this.Path = filePath;
            string fileName = System.IO.Path.GetFileName(filePath);
            this.fileName.Text = fileName;
            this.icon.Image = fileIcon.ToBitmap();
        }
        
        public string Path { get => path; set => path = value; }

        private void btnRemoveFile_Click(object sender, System.EventArgs e)
        {
            if (this.Parent is Control parentControl)
            {
                // Xóa UserControl khỏi Controls của Parent
                parentControl.Controls.Remove(this);
                this.Dispose(); // Giải phóng tài nguyên (nếu cần)
            }
        }

    }
}
