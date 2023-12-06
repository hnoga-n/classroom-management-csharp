using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Baitap.Giaovien;
using Hybrid.GUI.Baitap.Hocsinh;
using Hybrid.GUI.Home;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap
{
    public partial class Chinhsuabaitap : Form
    {
        private PanelChuongDropDown panelChuong;
        private Taikhoan taikhoangiangvien;
        private LopHoc lophoc;
        private Chuong chuong;
        private ThemDapAn answerPanel;
        private BaiTapBUS btBUS;
        private FileBaiTapBUS fileBaiTapBUS;
        private BaiTap bt;
        public Chinhsuabaitap()
        {
            InitializeComponent();
        }
        public Chinhsuabaitap(PanelChuongDropDown pnl, Taikhoan taikhoangiangvien, LopHoc lophoc, Chuong chuong, BaiTap bt,BaiTapBUS btbus)
        {
            InitializeComponent();
            this.panelChuong = pnl;
            this.taikhoangiangvien = taikhoangiangvien;
            this.lophoc = lophoc;
            this.chuong = chuong;
            this.bt = bt;
            this.btBUS = btbus;
            answerPanel = new ThemDapAn();
        }

        private void Chinhsuabaitap_Load(object sender, EventArgs e)
        {
            this.lblClass.Text = lophoc.Tenlop;
            this.lblChuong.Text = chuong.Tenchuong;
            this.lblTeacher.Text = taikhoangiangvien.Hoten;
            this.txtTitle.Text = this.bt.Tieude;
            this.txtContent.Text = this.bt.Noidungbaitap;
            this.answerPanel.Noidungdapan.Text = this.bt.Noidungdapan;
            this.dtpThoiGianBatDau.Value = this.bt.Thoigianbatdau;
            this.dtpThoiGianBatDau.Enabled = false;
            this.dtpThoiGianKetThuc.Value = this.bt.Thoigianketthuc;
            if (this.bt.Congkhaidapan == 1)
                this.answerPanel.CkbPublicAnswer.Checked = true;
            else
                this.answerPanel.CkbPublicAnswer.Checked = false;

            fileBaiTapBUS = new FileBaiTapBUS();
            loadFile();
        }
        private void loadFile()
        {
            foreach (FileBaiTap file in fileBaiTapBUS.List)
            {
                if (file.Mabaitap.Equals(this.bt.Mabaitap) && file.Lafiledapan == 0)
                {
                    LocalFile tmp = new LocalFile(Path.GetFileName(file.Path), file.Id_file);
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
                        case "pptx":
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_pdf_40;
                            tmp.FileExtension = "pptx";
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
                else if (file.Mabaitap.Equals(this.bt.Mabaitap) && file.Lafiledapan == 1)
                {
                    LocalFile tmp = new LocalFile(Path.GetFileName(file.Path), file.Id_file);
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
                            tmp.getIcon().Image = Hybrid.Properties.Resources.icons8_excel_40;
                            tmp.FileExtension = "pptx";
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
                    this.answerPanel.FilePanel.Controls.Add(tmp);
                }
            }
        }
        private bool isValidTime()
        {
            if (this.dtpThoiGianBatDau.Value > this.dtpThoiGianKetThuc.Value)
            {
                MessageBox.Show("Thời gian bắt đầu không vượt quá thời gian kết thúc !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if ((this.dtpThoiGianBatDau.Value.AddMinutes(15)) > this.dtpThoiGianKetThuc.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải cách thời gian bắt đầu ít nhất 15 phút !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void createHomework_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tiêu đề bài tập không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTitle.Text = string.Empty;
                txtTitle.Focus();
                return;
            }

            if (txtContent.Text.Trim().Length == 0 && flowFilePanel.Controls.Count == 0)
            {
                MessageBox.Show("Phải có nội dung bài tập hoặc file bài tập !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContent.Text = string.Empty;
                txtContent.Focus();
                return;
            }
            if (this.answerPanel.HomeworkContent.Length == 0)
            {
                DialogResult confirm = MessageBox.Show("Bài tập không có đáp án. Xác nhận ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;
            }

            DialogResult isConfirm = MessageBox.Show("Xác nhận lưu chỉnh sửa ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isConfirm == DialogResult.No) return;

            if (!isValidTime()) return;

            BaiTap bt = new BaiTap()
            {
                Mabaitap = this.bt.Mabaitap,
                Machuong = this.chuong.Machuong,
                Tieude = this.txtTitle.Text,
                Noidungbaitap = this.txtContent.Text,
                Noidungdapan = this.answerPanel.HomeworkContent,
                Thoigianbatdau = DateTime.Parse(this.dtpThoiGianBatDau.Value.ToString()),
                Thoigianketthuc = DateTime.Parse(this.dtpThoiGianKetThuc.Value.ToString()),
                Congkhaidapan = (this.answerPanel.Congkhaidapan) ? 1 : 0,
                Daxoa = 0
            };

            ArrayList fileBTvaDA = new ArrayList();
            FileBaiTap fileTemp;
            // get file baitap
            if (flowFilePanel.Controls.Count >= 0)
            {
                foreach (LocalFile file in flowFilePanel.Controls)
                {
                    fileTemp = new FileBaiTap()
                    {
                        Mabaitap = this.bt.Mabaitap.ToString(),
                        Lafiledapan = 0,
                        Path = file.Path,
                        Id_file = file.Id_file
                    };
                    fileBTvaDA.Add(fileTemp);
                }
            }

            if (this.answerPanel.FilePanel.Controls.Count >= 0)
            {
                // get file dap an
                foreach (LocalFile file in this.answerPanel.FilePanel.Controls)
                {
                    fileTemp = new FileBaiTap()
                    {
                        Mabaitap = this.bt.Mabaitap.ToString(),
                        Lafiledapan = 1,
                        Path = file.Path,
                        Id_file = file.Id_file
                    };
                    fileBTvaDA.Add(fileTemp);
                }
            }

            try
            {
                loading.ShowSplashScreen();
                if (btBUS.EditBaitap(bt))
                {
                    if (fileBTvaDA.Count >= 0)
                    {
                        fileBaiTapBUS.deleteFile(this.bt.Mabaitap);
                        if (fileBaiTapBUS.EditFile(fileBTvaDA))
                        {
                            loading.CloseForm();
                            MessageBox.Show("Chỉnh sửa bài tập thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btBUS.loadList();
                            this.Dispose();
                            return;
                        }
                        else
                        {
                            loading.CloseForm();
                            MessageBox.Show("Upload file thất bại !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.btBUS.loadList();
                            return;
                        }
                    }
                    else
                    {
                        loading.CloseForm();
                        MessageBox.Show("Chỉnh sửa bài tập thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btBUS.loadList();
                        this.Dispose();
                        return;
                    }
                }
                else
                {
                    loading.CloseForm();
                    this.btBUS.loadList();
                    MessageBox.Show("Chỉnh sửa bài tập thất bại !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                loading.CloseForm();
                this.btBUS.loadList();
                MessageBox.Show("Có lỗi đã xảy ra !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            this.answerPanel.ShowDialog();
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
                    flowFilePanel.Controls.Add(file_temp);
                }

            }
        }
        private void dtpThoiGianKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (!isValidTime()) return;
        }
        private void lblPlaceholderTitle_Click(object sender, EventArgs e)
        {
            this.txtTitle.Focus();
        }

        private void lblPlaceholderContent_Click(object sender, EventArgs e)
        {
            this.txtContent.Focus();
        }

        private void txtTitle_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length == 0)
            {
                lblPlaceholderTitle.Show();
            }
            else
            {
                lblPlaceholderTitle.Hide();
            }
            lblCharCountTitle.Text = txtTitle.Text.Length + "/200";
        }
        private void txtContent_TextChanged_1(object sender, EventArgs e)
        {
            if (txtContent.Text.Length == 0)
            {
                lblPlaceholderContent.Show();
            }
            else
            {
                lblPlaceholderContent.Hide();
            }
            lblCharCountContent.Text = txtContent.Text.Length + "/4000";
        }
    }
}
