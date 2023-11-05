using Hybrid.DAO;
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
    public class BaiTapDAO
    {
        private ArrayList list;

        public BaiTapDAO()
        {
            list = loadList();

        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_getall = "SELECT * FROM baitap";
                SqlCommand cmd = new SqlCommand(sql_getall, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTap tmp = new BaiTap();
                    tmp.Mabaitap = dr["mabaitap"].ToString();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Tieude = dr["tieude"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Dahoanthanh = int.Parse(dr["dahoanthanh"].ToString());
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Thoihan = DateTime.Parse(dr["thoihan"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaitapDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}
