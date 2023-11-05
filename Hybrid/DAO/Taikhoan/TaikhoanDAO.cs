using Hybrid.DTO; 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DAO
{
    public class TaikhoanDAO
    {
        public List<Taikhoan> get_danhsach()
        {
            List<Taikhoan> danhSachTaiKhoan = new List<Taikhoan>();
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string sqlQuery = "SELECT matk, hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen FROM dbo.taikhoan";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Taikhoan taiKhoan = new Taikhoan
                            {
                                Mataikhoan = reader["matk"].ToString(),
                                Hoten = reader["hoten"].ToString(),
                                Email = reader["email"].ToString(),
                                Matkhau = reader["matkhau"].ToString(),
                                Sodienthoai = reader["sodienthoai"].ToString(),
                                Anhdaidien = reader["anhdaidien"].ToString(),
                                Manhomquyen = Convert.ToInt32(reader["manhomquyen"])
                            };
                            danhSachTaiKhoan.Add(taiKhoan);
                        }
                    }
                }
            }
            return danhSachTaiKhoan;
        }

    }
}

