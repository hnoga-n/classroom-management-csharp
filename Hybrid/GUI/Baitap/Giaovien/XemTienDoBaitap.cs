using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Baitap.Giaovien;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.GUI.Home.KiemTra.KiemTraComponents;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Baitap
{
    public partial class XemTienDoBaitap : Form
    {
        private BaiTap baitap;
        private LopHoc lophoc;
        private TaikhoanBUS taikhoanBUS;
        private ThamGiaBUS thamgiaBUS;
        private BailambaitapBUS blbtBUS;
        private ArrayList listSubmited;
        private ArrayList listNotSubmited;
        private int whichIsClick = 1; // 1=chưa nộp ; 2=chưa đánh giá ; 3=đã đánh giá
        public XemTienDoBaitap()
        {
            InitializeComponent();
        }
        public XemTienDoBaitap(BaiTap bt, LopHoc lophoc, Chuong chuong)
        {
            InitializeComponent();
            this.baitap = bt;
            this.lophoc = lophoc;
            this.lblChuong.Text = chuong.Tenchuong;
        }

        private void XemTienDoBaitap_Load(object sender, EventArgs e)
        {
            listSubmited = new ArrayList();
            listNotSubmited = new ArrayList();
            taikhoanBUS = new TaikhoanBUS();
            thamgiaBUS = new ThamGiaBUS();
            blbtBUS = new BailambaitapBUS();
            this.lblTitle.Text = this.baitap.Tieude;
            this.lblLop.Text = this.lophoc.Tenlop;
            this.createAt.Text = this.baitap.Thoigiantao.ToString();
            this.startAt.Text = this.baitap.Thoigianbatdau.ToString();
            this.endAt.Text = this.baitap.Thoigianketthuc.ToString();

            if ((DateTime.Now > this.baitap.Thoigianketthuc))
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
            loadListSubmitedAndNotSubmited(this.lophoc);
            this.notSubmit.PerformClick();
        }
        private void loadListSubmitedAndNotSubmited(LopHoc lophoc)
        {
            try
            {
                this.listNotSubmited.Clear();
                this.listSubmited.Clear();
                blbtBUS.loadList();
                double highestScore = -1;
                double totalScore = 0;
                double numberOfStudentSubmit = 0;
                ArrayList danhsachlop = new ArrayList();
                ArrayList listTmp = thamgiaBUS.getDanhSachLopWithMaLopHoc(lophoc.Malop);
                foreach (string mataikhoan in listTmp)
                {
                    int index_taikhoan = taikhoanBUS.GetTaiKhoanByMaTaiKhoan(mataikhoan);
                    if (index_taikhoan < 0) throw new Exception("Mã tài khoản tham gia lớp học không đúng");
                    danhsachlop.Add(taikhoanBUS.List[index_taikhoan]);// use for load submit/notsubmit btn
                    int index_blbt = this.blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(mataikhoan, this.baitap.Mabaitap);
                    if (index_blbt >= 0)
                    {
                        this.listSubmited.Add(blbtBUS.List[index_blbt]);
                        double diem_bai_lam = (blbtBUS.List[index_blbt] as BaiLamBaiTap).Diem;
                        if (diem_bai_lam != -1 && diem_bai_lam > highestScore)
                        {
                            highestScore = diem_bai_lam;
                        }
                        if (diem_bai_lam != -1)
                        {
                            totalScore += diem_bai_lam;
                            numberOfStudentSubmit++;
                        }
                    }
                    else
                    {
                        this.listNotSubmited.Add(taikhoanBUS.List[index_taikhoan]);
                    }
                }

                if(highestScore == -1) {
                    this.highestScore.Text = "--";
                }
                else
                {
                    this.highestScore.Text = highestScore.ToString();
                }

                this.lblAvaregeScore.Text =(numberOfStudentSubmit==0)?"--":Math.Round((totalScore / numberOfStudentSubmit),2).ToString();
                this.lblSubmitRadio.Text = (danhsachlop.Count==0)?"0%":Math.Round(((float)this.listSubmited.Count / (danhsachlop.Count))*100, 2).ToString() + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString()); ;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lblTimKiem.Hide();
            if (txtTimKiem.Text.Length == 0)
                lblTimKiem.Show();
        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }

        private void notSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                whichIsClick = 1;
                this.flowHocSinhPnl.Controls.Clear();
                if (this.listNotSubmited.Count == 0)
                {
                    EmptyPanel emptPnl = new EmptyPanel("Không có học sinh chưa nộp bài");
                    flowHocSinhPnl.Controls.Add(emptPnl);
                    return;
                }

                foreach (Taikhoan hocsinh in this.listNotSubmited)
                {
                    HocsinhNoptre hsPnl = new HocsinhNoptre(hocsinh);
                    this.flowHocSinhPnl.Controls.Add(hsPnl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }

        }

        private void notMark_Click(object sender, EventArgs e)
        {

            try
            {
                whichIsClick = 2;
                this.flowHocSinhPnl.Controls.Clear();
                if (this.listSubmited.Count == 0)
                {
                    EmptyPanel emptPnl = new EmptyPanel("Không có bài làm cần chấm điểm.");
                    flowHocSinhPnl.Controls.Add(emptPnl);
                    return;
                }

                foreach (BaiLamBaiTap bailam in this.listSubmited)
                {
                    int hsIndex = taikhoanBUS.GetTaiKhoanByMaTaiKhoan(bailam.Mataikhoan);
                    if (bailam.Diem == -1)
                    {
                        HocsinhNoptre hsPnl = new HocsinhNoptre(taikhoanBUS.List[hsIndex], false,this.baitap, bailam);
                        this.flowHocSinhPnl.Controls.Add(hsPnl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void alreadyMark_Click(object sender, EventArgs e)
        {
            try
            {
                whichIsClick = 3;
                this.flowHocSinhPnl.Controls.Clear();
                if (this.listSubmited.Count == 0)
                {
                    EmptyPanel emptPnl = new EmptyPanel("Không có bài làm nào đã chấm.");
                    flowHocSinhPnl.Controls.Add(emptPnl);
                    return;
                }

                foreach (BaiLamBaiTap bailam in this.listSubmited)
                {
                    int hsIndex = taikhoanBUS.GetTaiKhoanByMaTaiKhoan(bailam.Mataikhoan);
                    if (bailam.Diem != -1)
                    {
                        HocsinhNoptre hsPnl = new HocsinhNoptre(taikhoanBUS.List[hsIndex], true, this.baitap, bailam);
                        this.flowHocSinhPnl.Controls.Add(hsPnl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadListSubmitedAndNotSubmited(this.lophoc);
            switch (whichIsClick)
            {
                case 1:
                    this.notSubmit.PerformClick();
                    break;
                case 2:
                    this.notMark.PerformClick();
                    break;
                case 3:
                    this.alreadyMark.PerformClick();
                    break;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.flowHocSinhPnl.Controls.Clear();
            if (txtTimKiem.Text.Length < 0)
            {
                switch (whichIsClick)
                {
                    case 1:
                        this.notSubmit.PerformClick();
                        break;
                    case 2:
                        this.notMark.PerformClick();
                        break;
                    case 3:
                        this.alreadyMark.PerformClick();
                        break;
                }
            }
            else
            {
                string searchString = RemoveDiacritics(txtTimKiem.Text.ToLower().Trim());
                if (this.whichIsClick == 1)
                {
                    foreach (Taikhoan hocsinh in this.listNotSubmited)
                    {
                        if (RemoveDiacritics(hocsinh.Hoten.ToLower()).Contains(searchString))
                        {
                            HocsinhNoptre hsPnl = new HocsinhNoptre(hocsinh);
                            this.flowHocSinhPnl.Controls.Add(hsPnl);
                        }

                    }
                }
                if (this.whichIsClick == 2)
                {
                    foreach (BaiLamBaiTap bailam in this.listSubmited)
                    {
                        int hsIndex = taikhoanBUS.GetTaiKhoanByMaTaiKhoan(bailam.Mataikhoan);
                        if (bailam.Diem == -1)
                        {
                            if (RemoveDiacritics(taikhoanBUS.List[hsIndex].Hoten.ToLower()).Contains(searchString))
                            {
                                HocsinhNoptre hsPnl = new HocsinhNoptre(taikhoanBUS.List[hsIndex],false, this.baitap, bailam);
                                this.flowHocSinhPnl.Controls.Add(hsPnl);
                            }
                        }

                    }
                }
                if (this.whichIsClick == 3)
                {
                    foreach (BaiLamBaiTap bailam in this.listSubmited)
                    {
                        int hsIndex = taikhoanBUS.GetTaiKhoanByMaTaiKhoan(bailam.Mataikhoan);
                        if (bailam.Diem != -1)
                        {
                            if (RemoveDiacritics(taikhoanBUS.List[hsIndex].Hoten.ToLower()).Contains(searchString))
                            {
                                HocsinhNoptre hsPnl = new HocsinhNoptre(taikhoanBUS.List[hsIndex], true, this.baitap, bailam);
                                this.flowHocSinhPnl.Controls.Add(hsPnl);
                            }
                        }
                    }
                }
                if (this.flowHocSinhPnl.Controls.Count == 0)
                {
                    EmptyPanel emptPnl = new EmptyPanel("Không tìm thấy học sinh!");
                    flowHocSinhPnl.Controls.Add(emptPnl);
                    return;
                }
            }
        }
        public static string RemoveDiacritics(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder builder = new StringBuilder();

            foreach (char ch in normalized)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(ch);
                }
            }

            return builder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void btnHomeworkDetail_Click(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            XemChiTietBaiTap ctbtFrm = new XemChiTietBaiTap(this.baitap);
            loading.CloseForm();
            ctbtFrm.Show();
        }
    }
}
