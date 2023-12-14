using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class BanbeDAO
    {

        public BanbeDAO()
        {
        }

        public DataTable dt = new DataTable();
        public DataTable LayAllBanBe()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from banbe where trangthaiketban=1 ";
            command.Connection = Ketnoisqlserver.GetConnection();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            Ketnoisqlserver.CloseConnection();
            return dt;
        }
        public DataTable LayBanBeDeFind()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from banbe ";
            command.Connection = Ketnoisqlserver.GetConnection();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            Ketnoisqlserver.CloseConnection();
            return dt;
        }
        public List<BanBe> GetList()
        {
            List<BanBe> list = new List<BanBe>();
            string sql = string.Format("SELECT banbe.manguoiketban, banbe.manguoiduocketban, banbe.trangthaiketban, taikhoan.hoten FROM banbe INNER JOIN taikhoan ON banbe.manguoiduocketban = taikhoan.mataikhoan");
            try
            {
                SqlCommand c = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                SqlDataReader reader = c.ExecuteReader();
                while (reader.Read())
                {
                    BanBe a = new BanBe();
                    {
                        a.Manguoiketban = reader["manguoiketban"].ToString();
                        a.Manguoiduocketban = reader["manguoiduocketban"].ToString();
                        a.Trangthaiketban = Convert.ToInt32(reader["trangthaiketban"]);
                        a.Hoten = reader["hoten"].ToString();
                    };
                    list.Add(a);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Ketnoisqlserver.GetConnection().Close();
            return list;
        }
        public DataTable LayAllBanBeChuaKetBan(String strMaBanBe)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from banbe where trangthaiketban=0 and manguoiduocketban like '" + strMaBanBe + @"'";
            command.Connection = Ketnoisqlserver.GetConnection();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            Ketnoisqlserver.CloseConnection();
            return dt;
        }
        //da fix xong
        public Boolean XoaBanBe(String MaNguoiKetBan, String MaNguoiDuocKetBan)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM banbe where  (manguoiketban=@ma1 and manguoiduocketban=@ma2)";
                command.Parameters.AddWithValue("@ma1", MaNguoiKetBan);
                command.Parameters.AddWithValue("@ma2", MaNguoiDuocKetBan);
                command.Connection = Ketnoisqlserver.GetConnection();
                command.ExecuteNonQuery();
                Ketnoisqlserver.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //da fix xong
        public Boolean ChapNhanKetBan(BanBe bb)
        {
            try
            {
                String date = bb.Thoigianketban.Month + "-" + bb.Thoigianketban.Day + "-" + bb.Thoigianketban.Year;

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = @"UPDATE banbe set 
                               manguoiketban=N'" + bb.Manguoiketban +
                               @"',manguoiduocketban=N'" + bb.Manguoiduocketban +
                               @"',thoigianketban=N'" + date +
                               @"',trangthaiketban=N'" + 1 +
                               @"'where  (manguoiketban=N'" + bb.Manguoiketban + @"')";
                command.Connection = Ketnoisqlserver.GetConnection();
                command.ExecuteNonQuery();
                Ketnoisqlserver.CloseConnection();
                return true;
            }

            catch (Exception ex) { return false; }
        }
        //da fix xong
        public bool GuiKetban(BanBe bb)
        {
            String date = bb.Thoigianketban.Month + "-" + bb.Thoigianketban.Day + "-" + bb.Thoigianketban.Year;


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO banbe VALUES(@manguoiketban, @manguoiduocketban, @thoigianketban, @trangthai)";
            command.Parameters.AddWithValue("@manguoiketban", bb.Manguoiketban);
            command.Parameters.AddWithValue("@manguoiduocketban", bb.Manguoiduocketban);
            command.Parameters.AddWithValue("@thoigianketban", date);
            command.Parameters.AddWithValue("@trangthai", 0);
            command.Connection = Ketnoisqlserver.GetConnection();
            int kq = command.ExecuteNonQuery();
            Ketnoisqlserver.CloseConnection();
            if (kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void XoaLoiMoi(BanBe a)
        {
            string sqlQuery = "DELETE FROM banbe WHERE manguoiketban = @manguoiketban AND manguoiduocketban = @manguoiduocketban";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, Ketnoisqlserver.GetConnection());

                cmd.Parameters.AddWithValue("@manguoiketban", a.Manguoiketban);
                cmd.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiduocketban);


                cmd.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
        }

        public void ThemLoiMoi(BanBe a)
        {
            string sqlQuery = "INSERT INTO banbe (manguoiketban,manguoiduocketban,thoigianketban,trangthaiketban) VALUES (@manguoiketban,@manguoiduocketban,@thoigianketban,@trangthaiketban)";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, Ketnoisqlserver.GetConnection());

                cmd.Parameters.AddWithValue("@thoigianketban", a.Thoigianketban);
                cmd.Parameters.AddWithValue("@trangthaiketban", 0);
                cmd.Parameters.AddWithValue("@manguoiketban", a.Manguoiketban);
                cmd.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiduocketban);


                cmd.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }

        public List<Taikhoan> TimKiem(string tuKhoa)
        {
            List<Taikhoan> ketQuaTimKiem = new List<Taikhoan>();
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string sqlQuery = "SELECT mataikhoan, hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen, daxoa FROM dbo.taikhoan " +
                                  "WHERE hoten LIKE @tuKhoa OR sodienthoai LIKE @tuKhoa OR email LIKE @tuKhoa";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");

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
                            ketQuaTimKiem.Add(taiKhoan);
                        }
                    }
                }
            }
            return ketQuaTimKiem;
        }

        public void XoaBan(BanBe a)
        {
            string sqlQuery = "UPDATE banbe SET trangthaiketban = @trangthaiketban WHERE manguoiketban = @manguoiketban AND manguoiduocketban = @manguoiduocketban";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, Ketnoisqlserver.GetConnection());

                cmd.Parameters.AddWithValue("@trangthaiketban", 2);
                cmd.Parameters.AddWithValue("@manguoiketban", a.Manguoiketban);
                cmd.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiduocketban);


                cmd.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (Exception ex) { Console.WriteLine(); }

            string sqlQuery2 = "UPDATE banbe SET trangthaiketban = @trangthaiketban WHERE manguoiketban = @manguoiketban AND manguoiduocketban = @manguoiduocketban";
            try
            {
                SqlCommand cmd2 = new SqlCommand(sqlQuery2, Ketnoisqlserver.GetConnection());

                //cmd2.Parameters.AddWithValue("@thoigianketban", DateTime.Now.ToString());
                cmd2.Parameters.AddWithValue("@trangthaiketban", 2);
                cmd2.Parameters.AddWithValue("@manguoiketban", a.Manguoiduocketban);
                cmd2.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiketban);


                cmd2.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (Exception ex) { Console.WriteLine(); }

        }

        public void LoiMoiSauXoaBan(BanBe a)
        {
            string sqlQuery = "UPDATE banbe SET trangthaiketban = @trangthaiketban WHERE manguoiketban = @manguoiketban AND manguoiduocketban = @manguoiduocketban";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, Ketnoisqlserver.GetConnection());

                cmd.Parameters.AddWithValue("@trangthaiketban", 0);
                cmd.Parameters.AddWithValue("@manguoiketban", a.Manguoiketban);
                cmd.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiduocketban);


                cmd.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (Exception ex) { Console.WriteLine(); }


        }

        public void SuaTrangThai(BanBe a)
        {
            string sqlQuery = "UPDATE banbe SET trangthaiketban = @trangthaiketban WHERE manguoiketban = @manguoiketban AND manguoiduocketban = @manguoiduocketban";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, Ketnoisqlserver.GetConnection());

                cmd.Parameters.AddWithValue("@trangthaiketban", a.Trangthaiketban);
                cmd.Parameters.AddWithValue("@manguoiketban", a.Manguoiketban);
                cmd.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiduocketban);


                cmd.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (Exception ex) { Console.WriteLine(); }

            string sqlQuery2 = "INSERT INTO banbe (manguoiketban,manguoiduocketban,thoigianketban,trangthaiketban) VALUES (@manguoiketban,@manguoiduocketban,GETDATE(),@trangthaiketban)";

            try
            {
                SqlCommand cmd2 = new SqlCommand(sqlQuery2, Ketnoisqlserver.GetConnection());

                //cmd2.Parameters.AddWithValue("@thoigianketban", DateTime.Now.ToString());
                cmd2.Parameters.AddWithValue("@trangthaiketban", 1);
                cmd2.Parameters.AddWithValue("@manguoiketban", a.Manguoiduocketban);
                cmd2.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiketban);


                cmd2.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (Exception ex) { Console.WriteLine(); }

            string sqlQuery3 = "UPDATE banbe SET trangthaiketban = @trangthaiketban WHERE manguoiketban = @manguoiketban AND manguoiduocketban = @manguoiduocketban";

            try
            {
                SqlCommand cmd3 = new SqlCommand(sqlQuery3, Ketnoisqlserver.GetConnection());

                cmd3.Parameters.AddWithValue("@trangthaiketban", 1);
                cmd3.Parameters.AddWithValue("@manguoiketban", a.Manguoiduocketban);
                cmd3.Parameters.AddWithValue("@manguoiduocketban", a.Manguoiketban);


                cmd3.ExecuteNonQuery();
                Ketnoisqlserver.GetConnection().Close();

            }
            catch (Exception ex) { Console.WriteLine(); }
        }
    }
}
