using Hybrid.BUS;
using Hybrid.DTO;
using Hybrid.GUI.Home.HomeComponents;
using Hybrid.GUI.Home.KiemTra.KiemTraComponents;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    public partial class XemTienDoBaiKiemTra : Form
    {
        private Taikhoan taikhoangiangvien;
        private DeKiemTra dekiemtra;
        private LopHoc lophoc;
        private TaikhoanBUS taikhoanBUS;
        private ThamGiaBUS thamgiaBUS;
        private BailamKiemtraBUS blktBUS;
        private ChiTietBaiLamKiemTraBUS ctblktBUS;
        private CauHoiBUS chBUS;
        private CauTraLoiBUS ctlBUS;

        private ArrayList listSubmited;
        private ArrayList listNotSubmited;
        private bool whichIsClick = false; // false = notsubmit; true = otherwise

        public XemTienDoBaiKiemTra()
        {
            InitializeComponent();
        }
        public XemTienDoBaiKiemTra(Taikhoan tk, DeKiemTra dkt, LopHoc lophoc, Chuong chuong)
        {
            InitializeComponent();
            loading.ShowSplashScreen();
            this.taikhoangiangvien = tk;
            this.dekiemtra = dkt;
            this.lophoc = lophoc;
            this.listSubmited = new ArrayList();
            this.listNotSubmited = new ArrayList();
            this.taikhoanBUS = new TaikhoanBUS();
            this.thamgiaBUS = new ThamGiaBUS();
            this.blktBUS = new BailamKiemtraBUS();
            this.ctblktBUS = new ChiTietBaiLamKiemTraBUS();
            this.chBUS = new CauHoiBUS();
            this.ctlBUS = new CauTraLoiBUS();
            loadListSubmitedAndNotSubmited(lophoc);
            loadDataIntoForm(chuong);
            loading.CloseForm();
        }

        private void loadListSubmitedAndNotSubmited(LopHoc lophoc)
        {
            try
            {
                this.listNotSubmited.Clear();
                this.listSubmited.Clear();
                blktBUS.loadList();
                ArrayList danhsachlop = new ArrayList();
                ArrayList listTmp = thamgiaBUS.getDanhSachLopWithMaLopHoc(lophoc.Malop);
                foreach (string mataikhoan in listTmp)
                {
                    int index1 = taikhoanBUS.GetTaiKhoanByMaTaiKhoan(mataikhoan);
                    if (index1 < 0) throw new Exception("Mã tài khoản tham gia lớp học không đúng");
                    danhsachlop.Add(taikhoanBUS.list[index1]);// use for load submit/notsubmit btn
                    int index2 = this.blktBUS.getBaiLamKiemTraWithMaTaiKhoanAndMaDeKiemTra(mataikhoan, this.dekiemtra.Madekiemtra);
                    if (index2 >= 0)
                        this.listSubmited.Add(taikhoanBUS.list[index1]);
                    else
                        this.listNotSubmited.Add(taikhoanBUS.list[index1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString()); ;
            }
        }
        private void loadDataIntoForm(Chuong chuong)
        {
            this.SuspendLayout();
            this.examTitle.Text = this.dekiemtra.Tieude;
            if ((DateTime.Now > this.dekiemtra.Thoigianketthuc))
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
            this.teacher.Text = this.taikhoangiangvien.Hoten;
            this.createAt.Text = this.dekiemtra.Thoigiantao.ToString();
            this.startAt.Text = this.dekiemtra.Thoigianbatdau.ToString();
            this.endAt.Text = this.dekiemtra.Thoigianketthuc.ToString();
            this.Chuong.Text = chuong.Tenchuong.ToString();
            this.ResumeLayout();
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

        private void examDetail_Click(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            XemBaiKiemTra frmXemDKT = new XemBaiKiemTra(this.dekiemtra,this.chBUS,this.ctlBUS);
            loading.CloseForm();
            frmXemDKT.ShowDialog();
        }

        private void notSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                whichIsClick = false;
                this.flowpanelHocSinh.SuspendLayout();
                this.flowpanelHocSinh.Controls.Clear();
                if (this.listNotSubmited.Count == 0)
                {
                    emptyPnl emptPnl = new emptyPnl("Không có học sinh chưa nộp bài");
                    flowpanelHocSinh.Controls.Add(emptPnl);
                    return;
                }

                foreach (Taikhoan hocsinh in this.listNotSubmited)
                {
                    HocSinhCard hsPnl = new HocSinhCard(hocsinh, dekiemtra,false);
                    this.flowpanelHocSinh.Controls.Add(hsPnl);
                }
                this.flowpanelHocSinh.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void submited_Click(object sender, EventArgs e)
        {
            try
            {
                whichIsClick = true;
                this.flowpanelHocSinh.SuspendLayout();
                this.flowpanelHocSinh.Controls.Clear();
                if (this.listNotSubmited.Count == 0)
                {
                    emptyPnl emptPnl = new emptyPnl("Không có học sinh nộp bài");
                    flowpanelHocSinh.Controls.Add(emptPnl);
                    return;
                }

                foreach (Taikhoan hocsinh in this.listSubmited)
                {
                    HocSinhCard hsPnl = new HocSinhCard(hocsinh, dekiemtra,true);
                    this.flowpanelHocSinh.Controls.Add(hsPnl);
                }
                this.flowpanelHocSinh.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadListSubmitedAndNotSubmited(this.lophoc);
            if(whichIsClick)
                this.submited.PerformClick();
            else
                this.notSubmit.PerformClick();
        }

        private void DanhSachBaiDaNop_Load(object sender, EventArgs e)
        {
            this.notSubmit.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.flowpanelHocSinh.Controls.Clear();
            if (txtTimKiem.Text.Length < 0)
            {
                if ((this.whichIsClick))
                    this.submited.PerformClick();
                else
                    this.notSubmit.PerformClick();
            }
            else
            {
                string searchString = RemoveDiacritics(txtTimKiem.Text.ToLower().Trim());
                if ((this.whichIsClick))
                {
                    foreach (Taikhoan hocsinh in this.listSubmited)
                    {
                        if (RemoveDiacritics(hocsinh.Hoten.ToLower()).Contains(searchString))
                        {
                            HocSinhCard hsPnl = new HocSinhCard(hocsinh, dekiemtra,true);
                            this.flowpanelHocSinh.Controls.Add(hsPnl);
                        }
                    }
                }
                else
                {
                    foreach (Taikhoan hocsinh in this.listNotSubmited)
                    {
                        if (RemoveDiacritics(hocsinh.Hoten.ToLower()).Contains(searchString))
                        {
                            HocSinhCard hsPnl = new HocSinhCard(hocsinh, dekiemtra,false);
                            this.flowpanelHocSinh.Controls.Add(hsPnl);
                        }
                    }
                }
                if (this.flowpanelHocSinh.Controls.Count == 0)
                {
                    emptyPnl emptPnl = new emptyPnl("Không tìm thấy học sinh!");
                    flowpanelHocSinh.Controls.Add(emptPnl);
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
    }
}
