using Hybrid.DTO;
using ServiceStack.OrmLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Hybrid.DAO
{
    public class ChuongDAO
    {
        private ArrayList list;

        public ChuongDAO()
        {
            list = loadList();
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM chuong";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Chuong tmp = new Chuong();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Tenchuong = dr["ten"].ToString();
                    tmp.Daxoa = Convert.ToInt32(dr["daxoa"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:"+ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public bool ThemChuong(Chuong chuong)
        {
            try
            {
                string sql_chuong = "INSERT INTO chuong(machuong,ten,thoigiantao,malophoc,daxoa) VALUES (@machuong,N'" + chuong.Tenchuong + "',@thoigiantao,@malophoc,@daxoa)";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, Ketnoisqlserver.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(chuong.Machuong));
                cmd_chuong.Parameters.AddWithValue("@thoigiantao", chuong.Thoigiantao);
                cmd_chuong.Parameters.AddWithValue("@daxoa", chuong.Daxoa);
                cmd_chuong.Parameters.AddWithValue("@malophoc", Guid.Parse(chuong.Malop));
                cmd_chuong.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public bool SuaChuong(Chuong chuong)
        {
            try
            {
                string sql_chuong = "UPDATE chuong SET ten = N'" + chuong.Tenchuong + "' WHERE machuong = @machuong";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, Ketnoisqlserver.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(chuong.Machuong));
                cmd_chuong.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public bool XoaChuong(string machuong)
        {
            try
            {
                string sql_chuong = "UPDATE chuong SET daxoa = 1 WHERE machuong = @machuong";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, Ketnoisqlserver.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(machuong));
                cmd_chuong.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
