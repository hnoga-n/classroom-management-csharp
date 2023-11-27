using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap
{
    public partial class CloudFile : UserControl
    {
        private string id_file;
        private string fileExtension;
        public CloudFile()
        {
            InitializeComponent();
        }

        public CloudFile(string fileName, string id_file)
        {
            InitializeComponent();
            this.fileName.Text = fileName;
            this.Id_file = id_file;
        }

        public string Id_file { get => id_file; set => id_file = value; }
        public string FileExtension { get => fileExtension; set => fileExtension = value; }

        public PictureBox getIcon()
        {
            return this.icon;
        }

        private void btnCloudFile_Click(object sender, EventArgs e)
        {
            string fileUrl = null;
            switch (this.fileExtension)
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

        private void fileName_Click(object sender, EventArgs e)
        {
            this.btnCloudFile.PerformClick();
        }

        private void icon_Click(object sender, EventArgs e)
        {
            this.btnCloudFile.PerformClick();
        }
    }
}
