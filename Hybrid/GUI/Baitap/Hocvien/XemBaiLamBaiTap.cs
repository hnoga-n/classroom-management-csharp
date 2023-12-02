using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Baitap.Giaovien;
using Hybrid.GUI.Utilities;
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
using System.Windows.Forms.VisualStyles;

namespace Hybrid.GUI.Baitap.Hocvien
{
    public partial class XemBaiLamBaiTap : Form
    {
        private Taikhoan taikhoanhienhanh;
        private BaiTap baitap;
        private BaiLamBaiTap blbt;
        private FileBaiLamBaiTapBUS fileblbtBUS;
        public XemBaiLamBaiTap()
        {
            InitializeComponent();
        }

        public XemBaiLamBaiTap(Taikhoan taikhoanhienhanh, BaiTap bt, BaiLamBaiTap blbt)
        {
            InitializeComponent();
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.baitap = bt;
            this.blbt = blbt;
            fileblbtBUS = new FileBaiLamBaiTapBUS();
        }

        private void XemBaiLamBaiTap_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = this.baitap.Tieude;
            this.lblStudent.Text = this.taikhoanhienhanh.Hoten;
            this.lblSubmitTime.Text = this.blbt.Thoigiannopbai.ToString();
            this.txtContent.Text = this.blbt.Noidung;
            if (this.blbt.Diem != -1 && baitap.Congkhaidapan == 0 )
            {
                this.lblTitle.Width = this.lblTitle.MaximumSize.Width;
                this.lblTitle.Height = this.lblTitle.MaximumSize.Height;
                this.btnViewAnswer.Visible = false;
            }
            //load file
            this.flowFilePanel.Controls.Clear();
            foreach (FileBaiLamBaiTap file in fileblbtBUS.List)
            {
                if (file.Mabailam.Equals(this.blbt.Mabailam))
                {
                    CloudFile tmp = new CloudFile(Path.GetFileName(file.Path), file.Id_file);
                    int index = Path.GetFileName(file.Path).IndexOf('.') + 1; // Lấy vị trí của dấu chấm và cộng thêm 1 để lấy chuỗi sau nó
                    string result = Path.GetFileName(file.Path).Substring(index);
                    switch (result)
                    {
                        case "txt":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_txt_40;
                            tmp.FileExtension = "txt";
                            break;
                        case "pdf":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_pdf_40;
                            tmp.FileExtension = "pdf";
                            break;
                        case "xlsx":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_excel_40;
                            tmp.FileExtension = "xlsx";
                            break;
                        case "docx":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_word_40;
                            tmp.FileExtension = "docx";
                            break;
                        default:
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_file_40;
                            tmp.FileExtension = "txt";
                            break;
                    }
                    this.flowFilePanel.Controls.Add(tmp);
                }
            }
            // align center scoreTxtbox
            score.SelectAll();
            score.SelectionAlignment = HorizontalAlignment.Center;
            if (this.blbt.Diem == -1)
            {
                score.Enabled = false;
                teacherComment.Text = "Chưa đánh giá";
            }
            else
            {
                score.Text = blbt.Diem.ToString();
                teacherComment.Text = (this.blbt.Nhanxet == null || this.blbt.Nhanxet == string.Empty) ? "Không có nhận xét." : this.blbt.Nhanxet;
                if (this.blbt.Diem > 5)
                    score.StateCommon.Content.Color1 = System.Drawing.Color.Green;
                else
                    score.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            }


            if (this.blbt.Noptre == 1)
            {
                this.state.Text = "Nộp trễ";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.state.Text = "Nộp đúng hạn";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void createHomework_Click(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            XemChiTietBaiTap xemchitietFrm = new XemChiTietBaiTap(this.baitap);
            loading.CloseForm();
            xemchitietFrm.Show();
        }
    }
}
