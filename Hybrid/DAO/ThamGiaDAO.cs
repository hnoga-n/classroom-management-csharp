using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class ThamGiaDAO
    {

        public ThamGiaDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM thamgialophoc";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ThamGia tmp = new ThamGia();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public DataTable DanhSachHocSinhTheoMaLop(string malop) {
            try
            {
                string sql_thamgia = "select t.mataikhoan,t.hoten\r\n" +
                    "from lophoc l join thamgialophoc tg on l.malophoc = tg.malophoc\r\n" +
                    "join taikhoan t on t.mataikhoan = tg.mataikhoan\r\n" +
                    "where l.malophoc = @malophoc";
                //string sql_thamgia = "select * from lophoc";
                SqlCommand cmd = new SqlCommand(sql_thamgia, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
                return null;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public bool ThemThamGia(ThamGia thamgia)
        {
            try
            {
                string sql_thamgia = "INSERT INTO thamgialophoc(malophoc,mataikhoan) VALUES (@malophoc,@mataikhoan)";
                SqlCommand cmd = new SqlCommand(sql_thamgia, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@malophoc", Guid.Parse(thamgia.Malop));
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(thamgia.Mataikhoan));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }public bool XoaThamGia(ThamGia thamgia)
        {
            try
            {
                string sql_thamgia = "DELETE FROM thamgialophoc WHERE malophoc = @malophoc AND mataikhoan = @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_thamgia, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@malophoc", Guid.Parse(thamgia.Malop));
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(thamgia.Mataikhoan));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
