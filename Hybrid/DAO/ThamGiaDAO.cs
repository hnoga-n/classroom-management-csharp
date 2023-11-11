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
    public class ThamGiaDAO
    {
        private ArrayList list;

        public ThamGiaDAO()
        {
            list = loadList();
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

        public bool ThemThamGia(ThamGia thamgia)
        {
            try
            {
                string sql_thamgia = "INSERT INTO thamgialophoc VALUES (@malophoc,@mataikhoan)";
                SqlCommand cmd = new SqlCommand(sql_thamgia, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@malophoc", Guid.Parse(thamgia.Malop));
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(thamgia.Mataikhoan));
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
