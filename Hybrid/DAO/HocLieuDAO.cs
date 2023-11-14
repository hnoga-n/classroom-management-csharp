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

        public HocLieuDAO()
        {
        }

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
    }

}
