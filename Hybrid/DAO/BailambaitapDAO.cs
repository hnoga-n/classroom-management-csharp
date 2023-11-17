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
    public class BailambaitapDAO
    {

        public BailambaitapDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM bailambaitap";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiLamBaiTap tmp = new BaiLamBaiTap();
                    tmp.Mabailam = dr["mabailam"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Mabaitap = dr["mabaitap"].ToString();
                    tmp.Nhanxet = dr["nhanxet"].ToString();
                    tmp.Diem = float.Parse(dr["diem"].ToString());
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiannopbai = DateTime.Parse(dr["thoigiannopbai"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BailambaitapDAO: " + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}
