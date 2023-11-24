using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.KiemTra.KiemTraComponents;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ubiety.Dns.Core;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class ThemCauHoiFrm : Form
    {
        // them cau hoi
        KiemTraFrm kiemTraFrm;
        LopHocBUS lophocBUS = new LopHocBUS();
        CauHoiBUS cauhoiBUS = new CauHoiBUS();
        CauTraLoiBUS cautraloiBUS = new CauTraLoiBUS();

        // sua cau hoi
        CauHoi cauhoi;

        //them cau hoi
        public ThemCauHoiFrm(KiemTraFrm kiemTraFrm)
        {
            InitializeComponent();
            InitPanelCauTraLoiContainer_ThemCauHoi();
            this.kiemTraFrm = kiemTraFrm;
            this.btnThemCauHoi.Visible = true;
            this.btnCapNhatCauHoi.Visible = false;
        }

        // sua cau hoi
        public ThemCauHoiFrm(CauHoi cauhoi)
        {
            InitializeComponent();
            this.cauhoi = cauhoi;
            this.rtbNoiDung.Text = cauhoi.Noidung;
            InitPanelCauTraLoiContainer_SuaCauHoi();
            this.btnThemCauHoi.Visible = false;
            this.btnCapNhatCauHoi.Visible = true;
            this.Text = "Sửa câu hỏi";
        }

        private void InitPanelCauTraLoiContainer_ThemCauHoi()
        {
            for(int i = 1; i <= 4; i++) {
                PanelChiTietCauTraLoi pnl = new PanelChiTietCauTraLoi();
                pnl.ChkLaDapAn.CheckedChanged += new EventHandler(this.ChkLaDapAnCheckedChanged);
                this.pnlCauTraLoiContainer.Controls.Add(pnl);
            }
        }

        private void InitPanelCauTraLoiContainer_SuaCauHoi()
        {
            foreach (CauTraLoi ctl in cautraloiBUS.getList())
            {
                if(ctl.Macauhoi.Equals(cauhoi.Macauhoi))
                {
                    PanelChiTietCauTraLoi pnl = new PanelChiTietCauTraLoi(ctl);
                    pnl.ChkLaDapAn.CheckedChanged += new EventHandler(this.ChkLaDapAnCheckedChanged);
                    this.pnlCauTraLoiContainer.Controls.Add(pnl);
                }
            }
        }

        private void ChkLaDapAnCheckedChanged(object sender, EventArgs e)
        {
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (pnl.ChkLaDapAn != sender)
                {
                    pnl.ChkLaDapAn.Checked = false;
                }
            }
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            if(rtbNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbNoiDung.Focus();
                return;
            }
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (pnl.RtbCauTraLoi.Text == "")
                {
                    MessageBox.Show("Nội dung câu trả lời không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnl.RtbCauTraLoi.Focus();
                    return;
                }
            }
            bool flagKiemTraChonDapAn = true;
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (!pnl.ChkLaDapAn.Checked)
                    flagKiemTraChonDapAn = false;
                else
                {
                    flagKiemTraChonDapAn = true;
                    break;
                }
            }
            if(!flagKiemTraChonDapAn)
            {
                MessageBox.Show("Vui lòng chọn một câu trả lời là đáp án đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CauHoi cauhoinew = new CauHoi(Guid.NewGuid().ToString(), rtbNoiDung.Text, lophocBUS.GetLopHocByMaLop(kiemTraFrm.Chuong.Malop).Magiangvien,0);
            if(cauhoiBUS.ThemCauHoi(cauhoinew))
            {
                int ladapan;
                foreach(PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
                {
                    if (!pnl.ChkLaDapAn.Checked)
                        ladapan = 0;
                    else
                        ladapan = 1;
                    CauTraLoi cautraloi = new CauTraLoi(Guid.NewGuid().ToString(), pnl.RtbCauTraLoi.Text,ladapan, cauhoinew.Macauhoi);
                    cautraloiBUS.ThemCauTraLoi(cautraloi);
                }
                ButtonCauHoi btnCauHoi = new ButtonCauHoi(cauhoinew,this.kiemTraFrm);
                kiemTraFrm.PnlCauHoiContainer.Controls.Add(btnCauHoi);
                MessageBox.Show("Thêm câu hỏi thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Thêm câu hỏi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCapNhatCauHoi_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbNoiDung.Focus();
                return;
            }
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (pnl.RtbCauTraLoi.Text == "")
                {
                    MessageBox.Show("Nội dung câu trả lời không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnl.RtbCauTraLoi.Focus();
                    return;
                }
            }
            bool flagKiemTraChonDapAn = true;
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (!pnl.ChkLaDapAn.Checked)
                    flagKiemTraChonDapAn = false;
                else
                {
                    flagKiemTraChonDapAn = true;
                    break;
                }
            }
            if (!flagKiemTraChonDapAn)
            {
                MessageBox.Show("Vui lòng chọn một câu trả lời là đáp án đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cauhoi.Noidung = rtbNoiDung.Text;
            if (cauhoiBUS.SuaCauHoi(cauhoi))
            {
                foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
                {
                    pnl.Cautraloi.Noidung = pnl.RtbCauTraLoi.Text;
                    if (pnl.ChkLaDapAn.Checked) pnl.Cautraloi.Ladapan = 1;
                    else pnl.Cautraloi.Ladapan = 0;
                    if (!cautraloiBUS.SuaCauTraLoi(pnl.Cautraloi))
                    {
                        MessageBox.Show("Sửa câu trả lời thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Cập nhật câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật câu hỏi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        private void SaveWordFile()
        {
            try
            {
                string sourceFolderPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Filemau");
                // Tên tệp tin Word muốn lưu
                string fileName = "maucauhoi.docx";

                // Đường dẫn đầy đủ đến tệp tin nguồn
                string sourceFilePath = Path.Combine(sourceFolderPath, fileName);

                // Đưa ra lựa chọn để chọn vị trí lưu mới
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = fileName;
                saveFileDialog.Filter = "Word Documents|*.docx";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đường dẫn đầy đủ đến vị trí lưu mới
                    string destinationFilePath = saveFileDialog.FileName;

                    // Sao chép tệp từ nguồn đến đích
                    File.Copy(sourceFilePath, destinationFilePath, true);

                    MessageBox.Show("Lưu file thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lưu file: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveWordFile();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ReadWordDocument(filePath);
            }
        }

        private void ReadWordDocument(string filePath)
        {
            try
            {
                ArrayList listcauhoi = new ArrayList();
                ArrayList listcautraloi = new ArrayList();
                CauHoi ch = null;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Question:"))
                        {
                            ch = new CauHoi(Guid.NewGuid().ToString(), line.Substring(10).Trim(), lophocBUS.GetLopHocByMaLop(kiemTraFrm.Chuong.Malop).Magiangvien, 0);
                            listcauhoi.Add(ch);
                        }
                        else if (line.StartsWith("*"))
                        {
                            CauTraLoi ctl = new CauTraLoi(Guid.NewGuid().ToString(), line.Substring(1).Trim(), 1, ch.Macauhoi);
                            listcautraloi.Add(ctl);
                        }
                        else if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }
                        else
                        {
                            CauTraLoi ctl = new CauTraLoi(Guid.NewGuid().ToString(), line.Trim(), 0, ch.Macauhoi);
                            listcautraloi.Add(ctl);
                        }
                    }
                }
                foreach (CauHoi cauhoi in listcauhoi)
                    if (!cauhoiBUS.ThemCauHoi(cauhoi))
                    {
                        MessageBox.Show("Có lỗi khi thêm câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                foreach (CauTraLoi cautraloi in listcautraloi)
                    if (!cautraloiBUS.ThemCauTraLoi(cautraloi))
                    {
                        MessageBox.Show("Có lỗi khi thêm câu trả lời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file text: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
