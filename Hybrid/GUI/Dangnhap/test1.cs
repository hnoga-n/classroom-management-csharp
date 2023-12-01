using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Dangnhap
{
    public partial class test1 : Form
    {
        TaikhoanDAO tkdao=new TaikhoanDAO();
        TaikhoanBUS tkbus = new TaikhoanBUS();
        public test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset_matkhau(textBox1.Text);
        }
        public Boolean reset_matkhau(string email)
        {
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                // Hash the password with bcrypt
                string hash = BCrypt.Net.BCrypt.HashPassword("admin", salt);
                string sqlQuery = "Update taikhoan set matkhau='" + hash + "' where email=@email1";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@email1", email);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }

}
