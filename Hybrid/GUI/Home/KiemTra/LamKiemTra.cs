using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Kiemtra
{
    public partial class LamKiemTra : Form
    {
        private const int TOTAL_POINT = 10;
        private DeKiemTra dkt;
        private DeKiemTraBUS dktBUS;
        private ChiTietDeKiemTraBUS ctdktBUS;
        private CauHoiBUS chBUS;
        private CauTraLoiBUS ctlBUS;
        private Taikhoan taikhoanhienhanh;
        public LamKiemTra()
        {
            InitializeComponent();
        }

        public LamKiemTra(DeKiemTra dkt, Taikhoan taikhoanhienhanh)
        {
            InitializeComponent();
            // TODO: check xem đã nộp bài chưa
            loading.ShowSplashScreen();
            this.dkt = dkt;
            this.dktBUS = new DeKiemTraBUS();
            this.chBUS = new CauHoiBUS();
            this.ctlBUS = new CauTraLoiBUS();
            this.ctdktBUS = new ChiTietDeKiemTraBUS();
            this.taikhoanhienhanh = taikhoanhienhanh; ;
            loading.CloseForm();
            loadDataIntoForm();
        }

        private void loadDataIntoForm()
        {
            ArrayList listmacauhoi = this.ctdktBUS.getMaCauhoiWithMaDeKiemTra(this.dkt.Madekiemtra.ToLower());
            ArrayList listcautraloi;
            if (listmacauhoi.Count <= 0)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải đề kiểm tra!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            listcauhoipanel.SuspendLayout();
            listcauhoipanel.Controls.Clear();
            int index = 0;
            foreach (string macauhoi in listmacauhoi)
            {
                //cauhoi
                CauHoi tmp = this.chBUS.getCauhoiWithMaCauHoi(macauhoi);
                listcautraloi = this.ctlBUS.getCauTraLoiWithMaCauHoi(tmp.Macauhoi);
                CauhoiPanel chComponent = new CauhoiPanel(tmp, listcautraloi, userChose(tmp.Macauhoi), false);
                chComponent.getOrder().Text = "Câu hỏi " + (++index);
                //chComponent.getAnswer1Radbtn().Click += cauTraLoi_choose(index);
                listcauhoipanel.Controls.Add(chComponent);

                // button navigate
                CauhoiNavigate btnNav = new CauhoiNavigate();
                if (chComponent.Madapanchon != null)
                {
                    btnNav.getButtonNav().StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                    | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                    | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                    btnNav.getButtonNav().StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
                    btnNav.getButtonNav().StateCommon.Border.Color2 = SystemColors.Control;
                    btnNav.getButtonNav().StateCommon.Border.Rounding = 25;
                    btnNav.getButtonNav().StateCommon.Border.Width = 2;
                }

                btnNav.getButtonNav().Text = index.ToString();
                btnNav.getButtonNav().Click += new System.EventHandler(this.btnNavigate_Cliked);
                navigatePanel.Controls.Add(btnNav);
            }
            listcauhoipanel.ResumeLayout();
            listcauhoipanel.Refresh();
            this.lblNumberQuestion.Text = listmacauhoi.Count.ToString();
            this.lblTitleExam.Text = dkt.Tieude;
            this.timeStart.Text = dkt.Thoigianbatdau.ToString();
            this.timeEnd.Text = dkt.Thoigianketthuc.ToString();
        }

        private string userChose(string macauhoi)
        {
            string cautraloidachon = string.Empty;
            string sql_str1 = "SELECT madapanchon FROM luuvetbailamkiemtra WHERE email=@email AND madekiemtra=@made AND macauhoi=@macauhoi";
            SqlCommand command = new SqlCommand(sql_str1, Ketnoisqlserver.GetConnection());
            command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50)).Value = this.taikhoanhienhanh.Email;
            command.Parameters.Add(new SqlParameter("@made", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(this.dkt.Madekiemtra);
            command.Parameters.Add(new SqlParameter("@macauhoi", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(macauhoi);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cautraloidachon = dr["madapanchon"].ToString();
            }
            dr.Close();
            Ketnoisqlserver.CloseConnection();
            return cautraloidachon;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            //clean up
            string sql_str1 = "DELETE FROM luuvetbailamkiemtra WHERE email=@email AND madekiemtra=@made";
            SqlCommand command = new SqlCommand(sql_str1, Ketnoisqlserver.GetConnection());
            command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50)).Value = this.taikhoanhienhanh.Email;
            command.Parameters.Add(new SqlParameter("@made", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(this.dkt.Madekiemtra);
            command.ExecuteNonQuery();
            Ketnoisqlserver.CloseConnection();

            // insert
            string sql_str2 = "INSERT INTO luuvetbailamkiemtra(email,madekiemtra,macauhoi,madapanchon) VALUES (@email,@made,@macauhoi, @chon)";
            SqlCommand command2 = new SqlCommand(sql_str2, Ketnoisqlserver.GetConnection());

            foreach (CauhoiPanel cauhoipanel in this.listcauhoipanel.Controls)
            {
                if (cauhoipanel.Madapanchon == null) continue;
                command2.Parameters.Clear();
                command2.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50)).Value = this.taikhoanhienhanh.Email;
                command2.Parameters.Add(new SqlParameter("@made", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(this.dkt.Madekiemtra);
                command2.Parameters.Add(new SqlParameter("@macauhoi", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(cauhoipanel.Macauhoi);
                command2.Parameters.Add(new SqlParameter("@chon", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(cauhoipanel.Madapanchon);
                command2.ExecuteNonQuery();
            }
            Ketnoisqlserver.CloseConnection();
            loading.CloseForm();
            MessageBox.Show("Đã lưu bản nháp!", "Thông báo !", MessageBoxButtons.OK);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.btnSubmit.Enabled = false;
            DialogResult isConfirm = MessageBox.Show("Xác nhận nộp bài kiểm tra ?", "Thông báo !", MessageBoxButtons.OKCancel);
            if (isConfirm == DialogResult.Cancel) return;

            loading.ShowSplashScreen();
            // create bailamkt
            DateTime thoigiannop = DateTime.Now;
            string mabailam = Guid.NewGuid().ToString();
            float pointsPerQuestion = TOTAL_POINT / this.listcauhoipanel.Controls.Count;
            float point = 0;
            int socaudung = 0;
            ArrayList Bailam = new ArrayList(); // use for chitietbailam
            foreach (CauhoiPanel cauhoipanel in this.listcauhoipanel.Controls)
            {
                ChiTietBaiLamKiemTra ctbl = new ChiTietBaiLamKiemTra()
                {
                    Mabailamkiemtra = mabailam,
                    Macauhoi = cauhoipanel.Macauhoi,
                    Dapanchon = cauhoipanel.Madapanchon
                };
                Bailam.Add(ctbl);
                if (cauhoipanel.Madapanchon != null && ctlBUS.getCauTraLoiWithMaCauTraLoi(cauhoipanel.Madapanchon).Ladapan == 1)
                {
                    point += pointsPerQuestion;
                    socaudung++;
                }
            }

            BaiLamKiemTra blkt = new BaiLamKiemTra()
            {
                Mabailam = mabailam,
                Madekiemtra = dkt.Madekiemtra,
                Mataikhoan = taikhoanhienhanh.Mataikhoan,
                Diem = float.Parse(Math.Round(point, 2).ToString()),
                Thoigiannop = thoigiannop,
                Socaudung = socaudung,
                Noptre = (thoigiannop > dkt.Thoigianketthuc) ? 1 : 0
            };
            BailamKiemtraBUS blktbus = new BailamKiemtraBUS();
            if (!blktbus.addBaiLam(blkt))
            {
                loading.CloseForm();
                MessageBox.Show("Xảy ra lỗi khi lưu bài làm, vui lòng thử lại !", "Thông báo!", MessageBoxButtons.OK);
                this.btnSubmit.Enabled = true;
                return;
            }

            ChiTietBaiLamKiemTraBUS ctblkt = new ChiTietBaiLamKiemTraBUS();
            ctblkt.addChiTietBaiLam(Bailam);
            loading.CloseForm();
            MessageBox.Show("Bài làm đã lưu !", "Thông báo !", MessageBoxButtons.OK);
            this.btnSubmit.Enabled = true;
            this.Close();
        }

        public void btnNavigate_Cliked(object sender, EventArgs e)
        {
            int targetChildIndex;
            int.TryParse((sender as KryptonButton).Text, out targetChildIndex);

            if (targetChildIndex >= 0 && targetChildIndex < navigatePanel.Controls.Count)
            {
                Control targetControl = listcauhoipanel.Controls[targetChildIndex - 1];
                // Calculate the scroll position
                int scrollX = targetControl.Left - listcauhoipanel.AutoScrollPosition.X;
                int scrollY = targetControl.Top - listcauhoipanel.AutoScrollPosition.Y;

                // Set the AutoScrollPosition to scroll to the desired position
                listcauhoipanel.AutoScrollPosition = new Point(scrollX, scrollY);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận tạm dừng làm kiểm tra ?\nBài làm sẽ được lưu thành bản nháp.", "Thông báo !", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;
            btnPause.PerformClick();
            this.Close();
        }
    }
}
