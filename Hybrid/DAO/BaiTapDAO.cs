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

        public BaiTapDAO()
        {

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
                    tmp.Noidungbaitap = dr["noidungbaitap"].ToString();
                    tmp.Noidungdapan = dr["noidungdapan"].ToString();
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Thoihan = DateTime.Parse(dr["thoihan"].ToString());
                    tmp.Congkhaidapan = int.Parse(dr["congkhaidapan"].ToString());
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
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
