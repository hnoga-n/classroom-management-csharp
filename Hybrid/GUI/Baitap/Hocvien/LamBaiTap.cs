using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap.Hocsinh
{
    public partial class LamBaiTap : Form
    {
        private Taikhoan taikhoanhienhanh;
        private BaiTap bt;
        private BailambaitapBUS blbtBUS;
        private FileBaiTapBUS fileBtBUS;
        private FileBaiLamBaiTapBUS fileBlbtBUS;
        public LamBaiTap()
        {
            InitializeComponent();
        }

        public LamBaiTap(Taikhoan taikhoanhienhanh, BaiTap bt, BailambaitapBUS blbtBUS)
        {
            InitializeComponent();
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.bt = bt;
            this.blbtBUS = blbtBUS;
        }

        private void LamBaiTap_Load(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            fileBtBUS = new FileBaiTapBUS();
            fileBlbtBUS = new FileBaiLamBaiTapBUS();
            this.lblTitle.Text = bt.Tieude;
            this.lblHocSinh.Text = taikhoanhienhanh.Hoten;
            this.lblDeadline.Text = bt.Thoigianketthuc.ToString("dd/MM/yyyy HH:mm:ss");
            this.question.Text = bt.Noidungbaitap;
            if ((DateTime.Now > this.bt.Thoigianketthuc))
            {
                this.state.Text = "Đã kết thúc";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.state.Text = "Đang tiến hành";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Green;
            }
            foreach (FileBaiTap file in fileBtBUS.List)
            {
                if (file.Mabaitap.Equals(this.bt.Mabaitap) && file.Lafiledapan == 0)
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
                        case "pptx":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_power_point_40;
                            tmp.FileExtension = "pptx";
                            break;
                        case "docx":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_word_40;
                            tmp.FileExtension = "docx";
                            break;
                        case "doc":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_word_40;
                            tmp.FileExtension = "docx";
                            break;
                        default:
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_file_40;
                            tmp.FileExtension = "txt";
                            break;
                    }
                    this.flowFileBaiTapPanel.Controls.Add(tmp);
                }
            }
            loading.CloseForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNoiDungBaiLam.Text.Length == 0 && flowFileBaiLamPanel.Controls.Count == 0)
            {
                MessageBox.Show("Phải có nội dung bài làm hoặc file bài làm !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult confirm = MessageBox.Show("Xác nhận nộp bài ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            Guid mabailam = Guid.NewGuid();
            BaiLamBaiTap blbt = new BaiLamBaiTap()
            {
                Mabailam = mabailam.ToString(),
                Mabaitap = this.bt.Mabaitap,
                Mataikhoan = this.taikhoanhienhanh.Mataikhoan,
                Noidung = this.txtNoiDungBaiLam.Text,
                Thoigiannopbai = DateTime.Now,
                Noptre = (DateTime.Now > this.bt.Thoigianketthuc) ? 1 : 0,
                Diem = -1,
            };

            ArrayList listFileBaiLam = new ArrayList();
            if (this.flowFileBaiLamPanel.Controls.Count > 0)
            {
                FileBaiLamBaiTap fileTemp;
                // get file bai lam
                foreach (Control file in this.flowFileBaiLamPanel.Controls)
                {
                    fileTemp = new FileBaiLamBaiTap()
                    {
                        Mabailam = mabailam.ToString(),
                        Path = (file as LocalFile).Path,
                    };
                    listFileBaiLam.Add(fileTemp);
                }
            }

            try
            {
                loading.ShowSplashScreen();
                if (blbtBUS.CreateBaiLamBaiTap(blbt))
                {
                    if (listFileBaiLam.Count >= 0)
                    {
                        if (fileBlbtBUS.createFile(listFileBaiLam))
                        {
                            loading.CloseForm();
                            MessageBox.Show("Lưu bài làm thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.blbtBUS.loadList();
                            this.Dispose();
                            return;
                        }
                        else
                        {
                            fileBlbtBUS.deleteFile(mabailam.ToString());
                            blbtBUS.DeleteBaiLamBaiTap(mabailam.ToString());
                            loading.CloseForm();
                            MessageBox.Show("Upload file thất bại !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.blbtBUS.loadList();
                            return;
                        }
                    }
                    else
                    {
                        loading.CloseForm();
                        MessageBox.Show("Lưu bài làm thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.blbtBUS.loadList();
                        this.Dispose();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fileBlbtBUS.deleteFile(mabailam.ToString());
                blbtBUS.DeleteBaiLamBaiTap(mabailam.ToString());
                this.blbtBUS.loadList();
                Console.WriteLine(ex.Message);
            }


        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word documents (*.doc;*.docx)|*.doc;*.docx|Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|PDF files (*.pdf)|*.pdf|PowerPoint presentations (*.ppt;*.pptx)|*.ppt;*.pptx|Text files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 5; // Thiết lập mặc định là All files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Icon fileIcon = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                    LocalFile file_temp = new LocalFile(openFileDialog.FileName, fileIcon);
                    flowFileBaiLamPanel.Controls.Add(file_temp);
                }
            }
        }

        private void txtNoiDungBaiLam_TextChanged(object sender, EventArgs e)
        {
            if (txtNoiDungBaiLam.Text.Length != 0)
                lblPlaceholder.Hide();
            else
                lblPlaceholder.Show();
            lblCharCount.Text = txtNoiDungBaiLam.Text.Length + "/4000";
        }

        private void lblPlaceholder_Click(object sender, EventArgs e)
        {
            txtNoiDungBaiLam.Focus();
        }

        private void LamBaiTap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult isConfirm = MessageBox.Show("LƯU Ý: Mọi thông tin bài làm sẽ bị mất khi đóng cửa sổ !\n Xác nhận đóng cửa sổ ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isConfirm == DialogResult.No) e.Cancel = true;
        }
    }
}
