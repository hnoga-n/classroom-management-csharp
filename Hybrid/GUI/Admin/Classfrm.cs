using Hybrid.BUS;
using Hybrid.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
namespace Hybrid.GUI.Admin
{
    public partial class Classfrm : Form
    {
        LopHocBUS lophocBUS = new LopHocBUS();
        LopHocDAO LopHocDAO = new LopHocDAO();
        string malop;
        string tinhtrang;
        int vitri;
        public Classfrm()
        {
            InitializeComponent();
        }

        private void Classfrm_Load(object sender, EventArgs e)
        {
            lophocBUS.dataview_lophoc(dataGridView1);
            comboBox1.SelectedIndex = 0;
            reload_data();
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                    lophocBUS.timkiem_lop_tengiangvien(txt_timkiem.Text, dataGridView1);
                if (comboBox1.SelectedIndex == 1)
                    lophocBUS.timkiem_lop_tenlop(txt_timkiem.Text, dataGridView1);
                int rowCount = dataGridView1.Rows.Count;
                if (rowCount <= 1)
                    lab_timkiem.Text = "1";
                else
                {
                    rowCount = dataGridView1.Rows.Count;
                    lab_timkiem.Text = rowCount.ToString();
                }

            }
        }
        private void reload_data()
        {

            DataTable dataTable = LopHocDAO.LayDanhSachLopHoc();
            // Gọi phương thức để lấy dữ liệu từ cơ sở dữ liệu
            // Gán dữ liệu cho DataGridView
            dataGridView1.DataSource = dataTable;

            int rowCount = dataGridView1.Rows.Count;
            lab_tong.Text = rowCount.ToString();
            lab_timkiem.Text = rowCount.ToString();
            lab_hoatdong.Text = lophocBUS.count_class_unban(dataGridView1).ToString();
            lab_xoa.Text = lophocBUS.count_class_ban(dataGridView1).ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
            comboBox1.SelectedIndex = 0;
            reload_data();
            vitri = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                vitri = e.RowIndex;
            }
            if (e.ColumnIndex == -1)
            {
                vitri = e.ColumnIndex;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                vitri = 1;
                // Lấy tên cột của ô được nhấp
                // Lấy giá trị của cột "email" tương ứng với ô vừa nhấp
                malop = dataGridView1.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                tinhtrang = dataGridView1.Rows[e.RowIndex].Cells["daxoa"].Value.ToString();

            }
        }

        private void but_ban_Click(object sender, EventArgs e)
        {
            if (vitri == -1 || vitri == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 ô giá trị bất kì trong table!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tinhtrang == "1")
                    MessageBox.Show("Lớp học đã bị khóa trước đó rồi.", "Thông báo");
                else
                {
                    //MessageBox.Show(malop);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn khóa lớp học này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Xử lý kết quả từ hộp thoại
                    if (result == DialogResult.Yes)
                    {
                        lophocBUS.ban_class(malop);
                        MessageBox.Show("Đã khóa thành công lớp ", "Thông báo");
                        reload_data();
                        vitri = 0;
                    }
                }
            }
        }

        private void but_unban_Click(object sender, EventArgs e)
        {
            if (vitri == -1 || vitri == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 ô giá trị bất kì trong table!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tinhtrang == "0")
                    MessageBox.Show("Lớp học chưa từng bị khóa trước đó.", "Thông báo");
                else
                {
                    //MessageBox.Show(malop);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn mở khóa lớp học này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Xử lý kết quả từ hộp thoại
                    if (result == DialogResult.Yes)
                    {
                        lophocBUS.unban_class(malop);
                        MessageBox.Show("Đã mở khóa thành công lớp ", "Thông báo");
                        reload_data();
                        vitri = 0;
                    }
                }
            }
        }

        private void but_xuat_excel_Click(object sender, EventArgs e)
        {
            lophocBUS.xuat_excel(dataGridView1);
        }
    }
}
