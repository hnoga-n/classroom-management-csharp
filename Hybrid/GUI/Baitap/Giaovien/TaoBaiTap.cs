using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap.Giaovien
{
    public partial class TaoBaiTap : Form
    {
        private PanelChuongDropDown panelChuong;
        private Taikhoan taikhoangiangvien;
        private LopHoc lophoc;
        private Chuong chuong;
        private ThemDapAn answerPanel;
        private BaiTapBUS btBUS;
        private FileBaiTapBUS fileBaiTapBUS;
        public TaoBaiTap()
        {
            InitializeComponent();
        }

        public TaoBaiTap(PanelChuongDropDown pnl, Taikhoan taikhoangiangvien, LopHoc lophoc, Chuong chuong)
        {
            InitializeComponent();
            this.panelChuong = pnl;
            this.taikhoangiangvien = taikhoangiangvien;
            this.lophoc = lophoc;
            this.chuong = chuong;
            answerPanel = new ThemDapAn();
        }


        private void TaoBaiTap_Load(object sender, EventArgs e)
        {
            this.lblClass.Text = lophoc.Tenlop;
            this.lblChuong.Text = chuong.Tenchuong;
            this.lblTeacher.Text = taikhoangiangvien.Hoten;
            this.dtpThoiGianBatDau.MinDate = DateTime.Now;
            this.dtpThoiGianBatDau.Value = DateTime.Now.AddMinutes(5);
            this.dtpThoiGianKetThuc.Value = DateTime.Now.AddMinutes(30);
            btBUS = new BaiTapBUS();
            fileBaiTapBUS = new FileBaiTapBUS();
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTitle.Text.Length > 0)
                this.lblPlaceholderTitle.Hide();
            else
                this.lblPlaceholderTitle.Show();
            lblCharCountTitle.Text = txtTitle.Text.Length.ToString() + "/200";
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            if (this.txtContent.Text.Length > 0)
                this.lblPlaceholderContent.Hide();
            else
                this.lblPlaceholderContent.Show();
            lblCharCountContent.Text = txtContent.Text.Length.ToString() + "/4000";
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            this.answerPanel.ShowDialog();
        }

        private void dtpThoiGianBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (!isValidTime()) return;
        }
        private void dtpThoiGianKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (!isValidTime()) return;
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
        private void createHomework_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tiêu đề bài tập không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTitle.Text = string.Empty;
                txtTitle.Focus();
                return;
            }

            if (txtContent.Text.Trim().Length == 0 && flowFilePanel.Controls.Count==0)
            {
                MessageBox.Show("Phải có nội dung bài tập hoặc file bài tập !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContent.Text = string.Empty;
                txtContent.Focus();
                return;
            }
            DialogResult isConfirm =  MessageBox.Show("Vui lòng kiểm tra kĩ các thông tin và file vì khi tạo sẽ không thể chỉnh sửa !", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isConfirm == DialogResult.No) return;
            if (!isValidTime()) return;

            if (this.answerPanel.HomeworkContent.Length == 0)
            {
                DialogResult confirm = MessageBox.Show("Bài tập không có đáp án. Xác nhận ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;
            }
            Guid mabaitap = Guid.NewGuid();
            BaiTap bt = new BaiTap()
            {
                Mabaitap = mabaitap.ToString(),
                Machuong = this.chuong.Machuong,
                Tieude = this.txtTitle.Text,
                Noidungbaitap = this.txtContent.Text,
                Noidungdapan = this.answerPanel.HomeworkContent,
                Thoigiantao = DateTime.Now,
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
                foreach (Control file in flowFilePanel.Controls)
                {
                    fileTemp = new FileBaiTap()
                    {
                        Mabaitap = mabaitap.ToString(),
                        Lafiledapan = 0,
                        Path = (file as LocalFile).Path,
                    };
                    fileBTvaDA.Add(fileTemp);
                }
            }

            if (this.answerPanel.FilePanel.Controls.Count >= 0)
            {
                // get file dap an
                foreach (Control file in this.answerPanel.FilePanel.Controls)
                {
                    fileTemp = new FileBaiTap()
                    {
                        Mabaitap = mabaitap.ToString(),
                        Lafiledapan = 1,
                        Path = (file as LocalFile).Path
                    };
                    fileBTvaDA.Add(fileTemp);
                }
            }

            try
            {
                loading.ShowSplashScreen();
                if (btBUS.createBaitap(bt))
                {
                    if (fileBTvaDA.Count >= 0)
                    {
                        if (fileBaiTapBUS.createFile(fileBTvaDA))
                        {
                            loading.CloseForm();
                            MessageBox.Show("Tạo bài tập thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ButtonBaiTap btn = new ButtonBaiTap(this.panelChuong,bt);
                            this.panelChuong.PnlChuongComponent.Controls.Add(btn);
                            this.panelChuong.IsExpanded = false;
                            this.panelChuong.btnMoRong_Click(this, EventArgs.Empty);
                            this.panelChuong.DemTaiLieuChuong++;
                            this.panelChuong.LblDemTaiLieuChuong.Text = "(" + this.panelChuong.DemTaiLieuChuong + ")";
                            this.Dispose();
                            return;
                        }
                        else
                        {
                            fileBaiTapBUS.deleteFile(mabaitap.ToString());
                            btBUS.deleteBaitap(mabaitap.ToString());
                            loading.CloseForm();
                            MessageBox.Show("Upload file thất bại !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        loading.CloseForm();
                        MessageBox.Show("Tạo bài tập thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ButtonBaiTap btn = new ButtonBaiTap(this.panelChuong,bt);
                        this.panelChuong.PnlChuongComponent.Controls.Add(btn);
                        this.panelChuong.IsExpanded = false;
                        this.panelChuong.btnMoRong_Click(this, EventArgs.Empty);
                        this.panelChuong.DemTaiLieuChuong++;
                        this.panelChuong.LblDemTaiLieuChuong.Text = "(" + this.panelChuong.DemTaiLieuChuong + ")";
                        this.Dispose();
                        return;
                    }
                }
                else
                {
                    loading.CloseForm();
                    MessageBox.Show("Tạo bài tập thất bại !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                fileBaiTapBUS.deleteFile(mabaitap.ToString());
                btBUS.deleteBaitap(mabaitap.ToString());
                loading.CloseForm();
                MessageBox.Show("Có lỗi đã xảy ra !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
            //lblPlaceholderTitle.BringToFront();
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
