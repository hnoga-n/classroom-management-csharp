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

        public void ThemChuong(Chuong chuong)
        {
            try
            {
                string sql_chuong = "INSERT INTO chuong(machuong,ten,thoigiantao,malophoc) VALUES (@machuong,N'" + chuong.Tenchuong + "',@thoigiantao,@malophoc)";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, Ketnoisqlserver.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(chuong.Machuong));
                cmd_chuong.Parameters.AddWithValue("@thoigiantao", chuong.Thoigiantao);
                cmd_chuong.Parameters.AddWithValue("@malophoc", Guid.Parse(chuong.Malop));
                cmd_chuong.ExecNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public void XoaChuong(string machuong)
        {
            try
            {
                string sql_chuong = "DELETE FROM chuong WHERE machuong = @machuong";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, Ketnoisqlserver.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(machuong));
                cmd_chuong.ExecNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
