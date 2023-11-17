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
    public class BailamKiemtraDAO
    {

        public BailamKiemtraDAO()
        {
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
                    tmp.Madekiemtra = dr["madekiemtra"].ToString();
                    tmp.Thoigiannop = DateTime.Parse(dr["thoigiannop"].ToString());
                    tmp.Diem = float.Parse(dr["diem"].ToString());
                    tmp.Socaudung = int.Parse(dr["socaudung"].ToString());
                    tmp.Noptre = int.Parse(dr["noptre"].ToString());
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
        public int addBaiLamKiemTra(BaiLamKiemTra blkt)
        {
            string sql = "INSERT INTO bailamkiemtra(mabailam,mataikhoan,madekiemtra,diem,thoigiannop,socaudung,noptre) VALUES (@mabailam,@mataikhoan,@madekiemtra,@diem,@thoigiannop,@socaudung,@noptre)";
            SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
            command.Parameters.Add("@mabailam", SqlDbType.UniqueIdentifier).Value = Guid.Parse(blkt.Mabailam);
            command.Parameters.Add("@mataikhoan", SqlDbType.UniqueIdentifier).Value = Guid.Parse(blkt.Mataikhoan);
            command.Parameters.Add("@madekiemtra", SqlDbType.UniqueIdentifier).Value = Guid.Parse(blkt.Madekiemtra);
            command.Parameters.Add("@diem", SqlDbType.Float).Value = blkt.Diem;
            command.Parameters.Add("@thoigiannop", SqlDbType.DateTime).Value = blkt.Thoigiannop;
            command.Parameters.Add("@socaudung", SqlDbType.Int).Value = blkt.Socaudung;
            command.Parameters.Add("@noptre", SqlDbType.Int).Value = blkt.Noptre;

            int isSuccess = command.ExecuteNonQuery();

            return isSuccess;
        }
    }
}
