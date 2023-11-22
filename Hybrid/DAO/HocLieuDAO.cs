using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class HocLieuDAO
    {
        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM hoclieu";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HocLieu tmp = new HocLieu();
                    tmp.Mahoclieu = dr["mahoclieu"].ToString();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Tieude = dr["tieude"].ToString();
                    tmp.Noidung= dr["noidung"].ToString();
                    tmp.Daxoa=  Convert.ToInt32(dr["noidung"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file hoclieuDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
        public void taohoclieu(string machuong, string tieude, string noidung, List<FileHocLieu> list_filehl)
        {
            Guid temp;
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "INSERT INTO hoclieu (machuong, tieude, noidung, daxoa) OUTPUT INSERTED.mahoclieu VALUES (@machuong, @tieude,@noidung, 0)";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@machuong", machuong);
                    command.Parameters.AddWithValue("@tieude", tieude);
                    command.Parameters.AddWithValue("@noidung", noidung);
                    temp = (Guid)command.ExecuteScalar();
                }
            }
            if (list_filehl != null)
                taofilehoclieu_tudong(temp, list_filehl);
        }
        public void taofilehoclieu_tudong(Guid mahoclieu, List<FileHocLieu> list_filehl)
        {
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "INSERT INTO filehoclieu(mahoclieu, tenfile, id_file) VALUES(@mahoclieu, @tenfile, @id_file)";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    foreach (FileHocLieu fileHocLieu in list_filehl)
                    {
                        // Thay thế các giá trị thực tế của bạn vào tham số
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                        command.Parameters.AddWithValue("@tenfile", fileHocLieu.Tenfile);
                        command.Parameters.AddWithValue("@id_file", fileHocLieu.Id_file);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public string get_tieude_mahoclieu(string mahoclieu)
        {
            string temp = null;
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select tieude from hoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["tieude"].ToString();
                    }
                }
            }
            return temp;
        }
        public string get_noidung_mahoclieu(string mahoclieu)
        {
            string temp = null;
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select noidung from hoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["noidung"].ToString();
                    }
                }
            }
            return temp;
        }
        public List<FileHocLieu> get_list_filehoclieu(string mahoclieu)
        {
            List<FileHocLieu> list_filehl = new List<FileHocLieu>();
            using (SqlConnection conn = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Select * from filehoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        FileHocLieu temp = new FileHocLieu();
                        temp.Mahoclieu = reader["mahoclieu"].ToString();
                        temp.Tenfile = reader["tenfile"].ToString();
                        temp.Id_file = reader["id_file"].ToString();
                        list_filehl.Add(temp);
                    }
                }
            }
            return list_filehl;
        }
        public void update_hoclieu(HocLieu hoclieu)
        {
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "UPDATE hoclieu SET  [tieude] = @tieude, [noidung] = @noidung, [daxoa] = @daxoa WHERE [mahoclieu] = @mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, connection))
                {
                    command.Parameters.AddWithValue("@mahoclieu", hoclieu.Mahoclieu);
                    command.Parameters.AddWithValue("@tieude", hoclieu.Tieude);
                    command.Parameters.AddWithValue("@noidung", hoclieu.Noidung);
                    command.Parameters.AddWithValue("@daxoa", hoclieu.Daxoa);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void drop_date_filehoclieu_mahoclieu(string mahoclieu)
        {
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "Delete from filehoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, connection))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void insert_filehoclieu(FileHocLieu fileHocLieu)
        {
            using (SqlConnection connection = Ketnoisqlserver.GetConnection())
            {
                string sqlstring = "INSERT INTO filehoclieu ([mahoclieu], [tenfile], [id_file]) VALUES (@mahoclieu, @tenfile, @id_file);";
                using (SqlCommand command = new SqlCommand(sqlstring, connection))
                {
                    command.Parameters.AddWithValue("@mahoclieu", fileHocLieu.Mahoclieu);
                    command.Parameters.AddWithValue("@tenfile", fileHocLieu.Tenfile);
                    command.Parameters.AddWithValue("@id_file", fileHocLieu.Id_file);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
    }

}
