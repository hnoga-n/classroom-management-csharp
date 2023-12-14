using Hybrid.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    public partial class ChonHinhFrm : Form
    {
        private PictureBox selectedPictureBox = null;
        TaikhoanBUS taikhoanBUS=new TaikhoanBUS();
        string email = null;
        public ChonHinhFrm(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                // Lấy Panel tương ứng với PictureBox được click
                Panel correspondingPanel = GetCorrespondingPanel(clickedPictureBox);

                if (selectedPictureBox == null)
                {
                    // Nếu chưa có PictureBox nào được chọn, thì chọn PictureBox hiện tại
                    selectedPictureBox = clickedPictureBox;
                    correspondingPanel.BackColor = Color.FromArgb(0, 146, 101);
                }
                else
                {
                    // Nếu có PictureBox khác đang được chọn, thì chuyển về trạng thái màu transparent
                    GetCorrespondingPanel(selectedPictureBox).BackColor = Color.Transparent;

                    // Chọn PictureBox mới
                    selectedPictureBox = clickedPictureBox;
                    correspondingPanel.BackColor = Color.FromArgb(0, 146, 101);
                }
            }
        }
        

        private Panel GetCorrespondingPanel(PictureBox pictureBox)
        {
            // Tìm tên Panel dựa trên tên của PictureBox
            string panelName = "panel" + pictureBox.Name.Substring(3); // Giả sử PictureBox có tên là "pictureBox1", Panel sẽ có tên "panel1"

            // Tìm Panel trong Controls của Form
            Panel correspondingPanel = Controls.Find(panelName, true).FirstOrDefault() as Panel;

            return correspondingPanel;
        }
        public delegate void SendImage(Image image);
        public SendImage sendImage;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selectedPictureBox != null)
            {
                
                if (sendImage != null)
                {

                    taikhoanBUS.capnhap_hinhanhdaidien(email, selectedPictureBox.Name);
                    Form1.picha.Image = selectedPictureBox.Image;
                    sendImage(selectedPictureBox.Image);
                }
            }
            //đã set xong thì đóng form
            this.Close();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
