using Hybrid.DTO; 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
namespace Hybrid.DAO
{
    class TaikhoanDAO
    {
        public List<Taikhoan> get_danhsach()
        {
            List<Taikhoan> danhSachTaiKhoan = new List<Taikhoan>();
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string sqlQuery = "SELECT mataikhoan, hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen,daxoa FROM dbo.taikhoan";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Taikhoan taiKhoan = new Taikhoan
                            {
                                Mataikhoan = reader["mataikhoan"].ToString(),
                                Hoten = reader["hoten"].ToString(),
                                Email = reader["email"].ToString(),
                                Matkhau = reader["matkhau"].ToString(),
                                Sodienthoai = reader["sodienthoai"].ToString(),
                                Anhdaidien = reader["anhdaidien"].ToString(),
                                Manhomquyen = Convert.ToInt32(reader["manhomquyen"]),
                                Daxoa = Convert.ToInt32(reader["daxoa"])
                            };
                            danhSachTaiKhoan.Add(taiKhoan);
                        }
                    }
                }
            }
            return danhSachTaiKhoan;
        }
        public Boolean insert_taikhoan(Taikhoan tk)
        {
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string sqlQuery = "INSERT INTO taikhoan( hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen,daxoa) VALUES ( @hoten, @email, @matkhau, @sodienthoai, @anhdaidien, @manhomquyen,0)";
                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                // Hash the password with bcrypt
                string hash = BCrypt.Net.BCrypt.HashPassword(tk.Matkhau, salt);
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@hoten", tk.Hoten);
                    command.Parameters.AddWithValue("@email", tk.Email);
                    command.Parameters.AddWithValue("@matkhau", hash);
                    command.Parameters.AddWithValue("@sodienthoai", DBNull.Value);
                    command.Parameters.AddWithValue("@anhdaidien", DBNull.Value);
                    command.Parameters.AddWithValue("@manhomquyen", tk.Manhomquyen);

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
        public Boolean reset_matkhau(string email)
        {
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                // Hash the password with bcrypt
                string hash = BCrypt.Net.BCrypt.HashPassword("123456789", salt);
                string sqlQuery = "Update taikhoan set matkhau='"+hash+"' where email=@email1";

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
        public Boolean check_taikhoan(string email,string password)
        {
            using (SqlConnection conn=Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select * from taikhoan where email=@email;";
                using (SqlCommand command=new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var storedPasswordHash = (string)reader["matkhau"];

                            // Check if the provided password matches the stored hash
                            return BCrypt.Net.BCrypt.Verify(password, storedPasswordHash);
                        }
                        else
                            return false;
                    }
                }
            }
        }
        public int get_daxoa_email(string email)
        {
            int temp=-1;
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select daxoa from taikhoan where email=@email";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@email",email);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = Convert.ToInt32(reader["daxoa"].ToString());
                    }
                }
            }

            return temp;
        }
        public string get_tenlop_malop(string malop)
        {
            string temp = null;
            using(SqlConnection conn=Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select ten from lophoc where malophoc=@malophoc";
                using(SqlCommand command=new SqlCommand(sqlstring,conn))
                {
                    command.Parameters.AddWithValue("@malophoc", malop);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["ten"].ToString();
                    }
                }
            }

            return temp;
        }
        public string get_tenchuong_machuong(string machuong)
        {
            string temp = null;
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select ten from chuong where machuong=@machuong";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@machuong", machuong);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["ten"].ToString();
                    }
                }
            }

            return temp;
        }
        public string get_tengiangvien_magiangvien(string magiangvien)
        {
            string temp = null;
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select hoten from taikhoan where mataikhoan=@mataikhoan";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mataikhoan", magiangvien);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["hoten"].ToString();
                    }
                }
            }

            return temp;
        }
    }
}

