using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap.Giaovien
{
    public partial class ThemDapAn : Form
    {
        private string homeworkContent;
        private bool congkhaidapan;
        public string HomeworkContent { get => homeworkContent; set => homeworkContent = value; }
        public bool Congkhaidapan { get => congkhaidapan; set => congkhaidapan = value; }
        public FlowLayoutPanel FilePanel { get => this.flowFilePanel; set => flowFilePanel = value; }

        public ThemDapAn()
        {
            InitializeComponent();
            this.HomeworkContent = string.Empty;
            this.Congkhaidapan = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Word documents (*.doc;*.docx)|*.doc;*.docx|Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 5; // Thiết lập mặc định là All files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Icon fileIcon = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                    LocalFile file_temp = new LocalFile(openFileDialog.FileName, fileIcon);
                    flowFilePanel.Controls.Add(file_temp);
                }
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            if (this.txtContent.Text.Length > 0)
                this.lblPlaceholderContent.Hide();
            else
                this.lblPlaceholderContent.Show();
            lblCharCountContent.Text = txtContent.Text.Length.ToString() + "/4000";
        }

        private void saveAnswer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.txtContent.Text.Length > 0)
                this.lblPlaceholderContent.Hide();
            else
                this.lblPlaceholderContent.Show();
            lblCharCountContent.Text = txtContent.Text.Length.ToString() + "/4000";
            this.homeworkContent = this.txtContent.Text;
        }
    }
}
