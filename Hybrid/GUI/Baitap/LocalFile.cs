using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap
{
    public partial class LocalFile : UserControl
    {
        private string path;
        private string id_file;
        private string fileExtension;
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
            this.id_file = string.Empty;
        }
        public LocalFile(string filePath, string id_file)
        {
            InitializeComponent();
            this.Path = filePath;
            string fileName = System.IO.Path.GetFileName(filePath);
            this.fileName.Text = fileName;
            this.id_file = id_file;
            this.btnLocalFile.Click += BtnLocalFile_Click;
        }
        public PictureBox getIcon()
        {
            return this.icon;
        }
        private void BtnLocalFile_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public string Path { get => path; set => path = value; }
        public string Id_file { get => this.id_file; set => this.id_file = value; }
        public string FileExtension { get => fileExtension; set => fileExtension = value; }

        private void btnRemoveFile_Click(object sender, System.EventArgs e)
        {
            if (this.Parent is Control parentControl)
            {
                // Xóa UserControl khỏi Controls của Parent
                parentControl.Controls.Remove(this);
                this.Dispose(); // Giải phóng tài nguyên (nếu cần)
            }
        }

        private void btnFile_Cliked(object sender, System.EventArgs e)
        {
            string fileUrl = null;
            switch (this.FileExtension)
            {
                case "txt":
                    fileUrl = $"https://docs.google.com/document/d/{this.Id_file}/view";
                    break;
                case "pdf":
                    fileUrl = $"https://drive.google.com/file/d/{this.Id_file}/view";
                    break;
                case "xlsx":
                    fileUrl = $"https://docs.google.com/spreadsheets/d/{this.Id_file}/view";
                    break;
                case "docx":
                    fileUrl = $"https://docs.google.com/document/d/{this.Id_file}/view";
                    break;
                default:
                    fileUrl = $"https://drive.google.com/file/d/{this.Id_file}/view";
                    break;
            }
            Process.Start(new ProcessStartInfo
            {
                FileName = fileUrl,
                UseShellExecute = true
            });
        }

    }
}
