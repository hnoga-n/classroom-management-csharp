using Hybrid.BUS;
using Hybrid.DTO;
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

namespace Hybrid.GUI.Baitap.Giaovien
{
    public partial class XemChiTietBaiTap : Form
    {
        private BaiTap baitap;
        private FileBaiTapBUS fileBtBUS;
        public XemChiTietBaiTap()
        {
            InitializeComponent();
        }

        public XemChiTietBaiTap(BaiTap bt)
        {
            InitializeComponent();
            this.baitap = bt;
            this.fileBtBUS = new FileBaiTapBUS();
            this.lblBaiTapTitle.Text = bt.Tieude;
            this.txtHomeworkContent.Text = bt.Noidungbaitap;
            this.txtAnswerContent.Text = bt.Noidungdapan;

            foreach (FileBaiTap file in fileBtBUS.List)
            {
                if (file.Mabaitap.Equals(this.baitap.Mabaitap) && file.Lafiledapan == 0)
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
                    this.flowFileBaiTapPanel.Controls.Add(tmp);
                }
                else if(file.Mabaitap.Equals(this.baitap.Mabaitap) && file.Lafiledapan == 1)
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
                    this.flowFileDapAnPanel.Controls.Add(tmp);
                }
            }
        }
    }
}
