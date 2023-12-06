using Hybrid.DTO;
using System;
using System.Collections;
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
    }
}
