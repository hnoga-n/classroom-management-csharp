using Hybrid.DTO;
using Hybrid.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.Tailieu
{
    public partial class fileshow : UserControl
    {
        public FileHocLieu filehl {  get; set; }
        public int tinhtrang { get; set; }
        public fileshow(FileHocLieu filehl,int tinhtrang)
        {
            this.filehl = filehl;
            this.tinhtrang = tinhtrang;
            InitializeComponent();
        }

        private void fileshow_Load(object sender, EventArgs e)
        {
            label1.Text = this.filehl.Tenfile;
            hienthiicon();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            sukienclick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sukienclick();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sukienclick();
        }
        private void sukienclick()
        {
            if(tinhtrang==1)
            {
                int index = this.filehl.Tenfile.IndexOf('.') + 1; // Lấy vị trí của dấu chấm và cộng thêm 1 để lấy chuỗi sau nó
                string result = this.filehl.Tenfile.Substring(index);
                string fileUrl = null;
                if (result == "txt" || result == "docx" || result == "xlsx" || result == "pdf")
                {
                    if (result == "txt")
                        fileUrl = $"https://docs.google.com/document/d/{this.filehl.Id_file}/view";
                    if (result == "pdf")
                        fileUrl = $"https://drive.google.com/file/d/{this.filehl.Id_file}/view";
                    if (result == "xlsx")
                        fileUrl = $"https://docs.google.com/spreadsheets/d/{this.filehl.Id_file}/view";
                    if (result == "docx")
                        fileUrl = $"https://docs.google.com/document/d/{this.filehl.Id_file}/view";
                }
                else
                    fileUrl = $"https://drive.google.com/file/d/{this.filehl.Id_file}/view";
                // Mở trình duyệt mặc định để xem tệp trên Google Drive.
                Process.Start(new ProcessStartInfo
                {
                    FileName = fileUrl,
                    UseShellExecute = true
                });
            }
            
        }
        private void hienthiicon()
        {
            if(this.tinhtrang==1)
            {
                lab_xoa.Visible = false;
            }
            else
                lab_xoa.Visible = true;
            int index = this.filehl.Tenfile.IndexOf('.') + 1; // Lấy vị trí của dấu chấm và cộng thêm 1 để lấy chuỗi sau nó
            string result = this.filehl.Tenfile.Substring(index);
            if (result == "txt" || result == "docx" || result == "xlsx" || result == "pdf")
            {
                if (result == "txt")
                    pic_txt.Visible = true;
                if (result == "pdf")
                    pic_pdf.Visible = true;
                if (result == "xlsx")
                    pic_xlsx.Visible = true;
                if (result == "docx")
                    pic_docx.Visible = true;
            }
            else
                pic_file.Visible = true;

        }

        private void lab_xoa_Click(object sender, EventArgs e)
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
