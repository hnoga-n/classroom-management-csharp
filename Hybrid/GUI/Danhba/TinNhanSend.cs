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
using Org.BouncyCastle.Crypto.Tls;
using ServiceStack.Script;

namespace Hybrid.GUI.Danhba
{
    public partial class TinNhanSend : UserControl
    {
        int w=0; int h=0;
        DateTime dateTime;
        string maTN;

        public event EventHandler XoaTN;

        public TinNhanSend(TinNhanBanBe b)
        {
            InitializeComponent();
            Label(b.Noidung);
            dateTime = b.Thoigiangui;
            maTN = b.Matinnhan;
           
            string formattedDateTime = b.Thoigiangui.ToString("dd/MM/yy HH:mm");
            label1.Text = formattedDateTime;

        }

        private void TinNhanSend_Load(object sender, EventArgs e)
        {

        }

        private void Label(string a)
        {
            label2.Text = WrapText(a, 50);
            System.Drawing.Size labelSize = label2.Size;
            w = 50;
            if (label2.Width >= label1.Width)
                w = label2.Width;
            
            
            h = labelSize.Height;
            panel1.Size = new Size(w+20, h);
            this.Size = new Size(w+35, panel1.Height+30);
            this.Margin = new System.Windows.Forms.Padding(610-w, this.Margin.Top, 0, this.Margin.Bottom);
            this.Padding = new System.Windows.Forms.Padding(this.Padding.Left, this.Padding.Top, 0, this.Padding.Bottom);
            label1.Location = new System.Drawing.Point(label1.Location.X, label2.Height+35);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tin nhắn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                new TinNhanBanBeDAO().StatusMessage(maTN);
                XoaTN?.Invoke(this, EventArgs.Empty);
                Console.WriteLine("Đã xóa.");
            }
            else
            {
                Console.WriteLine("Đã hủy bỏ.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }

}
