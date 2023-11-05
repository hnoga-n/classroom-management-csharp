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
    public class DeKiemTraDAO
    {
        private ArrayList list;

        public DeKiemTraDAO()
        {
            list = loadList();
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM dekiemtra";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DeKiemTra tmp = new DeKiemTra();
                    tmp.Madekiemtra = dr["madekiemtra"].ToString();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Tieude = dr["tieude"].ToString();
                    tmp.Xemdiem = int.Parse(dr["xemdiem"].ToString());
                    tmp.Xemdapan = int.Parse(dr["xemdapan"].ToString());
                    tmp.Troncauhoi = int.Parse(dr["troncauhoi"].ToString());
                    tmp.Dahoanthanh = int.Parse(dr["dahoanthanh"].ToString());
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString());
                    tmp.Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}
