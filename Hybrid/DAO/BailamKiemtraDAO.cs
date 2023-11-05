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
    public class BailamKiemtraDAO
    {
        private ArrayList list;

        public BailamKiemtraDAO()
        {
            list = loadList();
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM bailamkiemtra";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiLamKiemTra tmp = new BaiLamKiemTra();
                    tmp.Mabailam = dr["mabailam"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Thoigianvaokiemtra = DateTime.Parse(dr["thoigianbatdaulam"].ToString());
                    tmp.Thoigiannop = DateTime.Parse(dr["thoigiannop"].ToString());
                    tmp.Diem = int.Parse(dr["diem"].ToString());
                    tmp.Socaudung = int.Parse(dr["socaudung"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BailamKiemTraDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}
