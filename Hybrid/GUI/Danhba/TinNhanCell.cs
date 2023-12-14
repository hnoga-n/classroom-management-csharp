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
    public partial class TinNhanCell : UserControl
    {
        int w = 0, h = 0;
        public TinNhanCell(TinNhanBanBe a)
        {
            InitializeComponent();
            Label(a.Noidung);
            string formattedDateTime = a.Thoigiangui.ToString("dd/MM/yy HH:mm");
            label1.Text = formattedDateTime;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            List<Taikhoan> list = new TaikhoanDAO().get_danhsach();
            foreach (Taikhoan t in list)
            {
                if (t.Mataikhoan == a.Manguoigui)
                {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TinNhanCell_Load(object sender, EventArgs e)
        {

        }

        private void Label(string a)
        {
            label2.Text = WrapText(a, 50);
            System.Drawing.Size labelSize = label2.Size;
            w = labelSize.Width;
            h = labelSize.Height;
            panel1.Size = new Size(w, h);
            this.Size = new Size(panel1.Width+58, panel1.Height);
            this.Margin = new System.Windows.Forms.Padding(this.Margin.Left, this.Margin.Top, 400-panel1.Width-60-20, this.Margin.Bottom);
            label1.Location = new System.Drawing.Point(label1.Location.X,h+30);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private string WrapText(string text, int maxCharsPerLine)
        {
            string[] words = text.Split(' '); // Tách chuỗi thành các từ

            string wrappedText = "";
            string currentLine = "";

            foreach (string word in words)
            {
                // Kiểm tra xem thêm từ này có làm vượt quá ngưỡng ký tự không

                if ((currentLine + word).Length <= maxCharsPerLine)
                {
                    // Nếu không, thêm từ vào dòng hiện tại
                    currentLine += word + " ";
                }
                else
                {
                    // Nếu có, xuống hàng và bắt đầu dòng mới
                    wrappedText += currentLine.Trim() + Environment.NewLine;
                    currentLine = word + " ";
                }
            }
           
            wrappedText += currentLine.Trim();

            return wrappedText;
        }
    }
}
