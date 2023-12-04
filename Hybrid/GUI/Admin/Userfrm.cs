using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Admin
{
    public partial class Userfrm : Form
    {
        TaikhoanDAO taikhoanDAO=new TaikhoanDAO();
        TaikhoanBUS taikhoanBUS =new TaikhoanBUS();
        string emailValue;
        string tinhtrang ;
        int vitri;
        public Userfrm()
        {
            InitializeComponent();
        }

        private void Userfrm_Load(object sender, EventArgs e)
        {
            taikhoanBUS.dataview_taikhoan(dataGridView1);
            comboBox1.SelectedIndex = 0;
            reload_data();
            //MessageBox.Show(dataGridView1.Columns[2].Name);
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text.Length<=0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }   
            else
            {
                if (comboBox1.SelectedIndex == 0)
                    taikhoanBUS.timkiem_taikhoan_ten(txt_timkiem.Text, dataGridView1);
                if (comboBox1.SelectedIndex == 1)
                    taikhoanBUS.timkiem_taikhoan_email(txt_timkiem.Text, dataGridView1);
                if (comboBox1.SelectedIndex == 2)
                    taikhoanBUS.timkiem_taikhoan_sdt(txt_timkiem.Text, dataGridView1);
                int rowCount = dataGridView1.Rows.Count;
                lab_timkiem.Text = rowCount.ToString() + "\nngười dùng";
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
            comboBox1.SelectedIndex = 0;
            reload_data();
            vitri = 0;
        }

        private void txt_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 2 && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn việc nhập ký tự không phải số
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
            if(comboBox1.SelectedIndex == 2)
                txt_timkiem.MaxLength = 10;
            
            reload_data();

        }
        private void reload_data()
        {

            DataTable dataTable = taikhoanDAO.LayDanhSachTaiKhoan();
            // Gọi phương thức để lấy dữ liệu từ cơ sở dữ liệu
            // Gán dữ liệu cho DataGridView
            dataGridView1.DataSource = dataTable;

            int rowCount = dataGridView1.Rows.Count;
            lab_timkiem.Text = rowCount.ToString() + "\nngười dùng";
            lab_tong.Text = rowCount.ToString() + "\nngười dùng";
            
            lab_hoatdong.Text = taikhoanBUS.count_user_unban(dataGridView1).ToString() + "\nngười dùng";
            lab_xoa.Text = taikhoanBUS.count_user_ban(dataGridView1).ToString() + "\nngười dùng";
        }

        private void but_ban_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(taikhoanBUS.count_user_ban(dataGridView1).ToString());
            //MessageBox.Show(emailValue);
            if(vitri == -1 || vitri == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 ô giá trị bất kì trong table!","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tinhtrang == "1")
                    MessageBox.Show("Tài khoản đã bị ban trước đó rồi.","Thông báo");
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn ban "+emailValue+" ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Xử lý kết quả từ hộp thoại
                    if (result == DialogResult.Yes)
                    {
                        taikhoanBUS.ban_user(emailValue);
                        MessageBox.Show("Đã ban thành công email:"+emailValue, "Thông báo");
                        reload_data();
                        vitri = 0;
                    }
                }    
            }    
        }

        private void but_unban_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(taikhoanBUS.count_user_unban(dataGridView1).ToString());
            if (vitri == -1||vitri==0)
            {
                MessageBox.Show("Vui lòng chọn 1 ô giá trị bất kì trong table!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tinhtrang == "0")
                    MessageBox.Show("Tài khoản chưa bị ban trước đó .", "Thông báo");
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn unban " + emailValue + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Xử lý kết quả từ hộp thoại
                    if (result == DialogResult.Yes)
                    {
                        taikhoanBUS.unban_user(emailValue);
                        MessageBox.Show("Đã unban thành công email:" + emailValue, "Thông báo");
                        reload_data();
                        vitri = 0;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 )
            {
                vitri =e.RowIndex;
            }
            if ( e.ColumnIndex == -1)
            {
                vitri=e.ColumnIndex;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                vitri = 1;
                // Lấy tên cột của ô được nhấp
                // Lấy giá trị của cột "email" tương ứng với ô vừa nhấp
                emailValue = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                tinhtrang = dataGridView1.Rows[e.RowIndex].Cells["daxoa"].Value.ToString();

            }
        }
    }
}
