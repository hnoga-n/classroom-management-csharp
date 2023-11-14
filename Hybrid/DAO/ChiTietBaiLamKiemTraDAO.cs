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
    public class ChiTietBaiLamKiemTraDAO
    {

        public ChiTietBaiLamKiemTraDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM chitietbailamkiemtra";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietBaiLamKiemTra tmp = new ChiTietBaiLamKiemTra();
                    tmp.Mabailamkiemtra = dr["mabailamkiemtra"].ToString();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Dapanchon = dr["dapanchon"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file chitietbailambaiktDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
        public void addChiTietBaiLamKiemTra(ArrayList chitietbailam)
        {
            try
            {
                string sql = "INSERT INTO chitietbailamkiemtra(mabailamkiemtra,macauhoi,dapanchon) VALUES (@mabailamkt,@macauhoi,@dapanchon)";
                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                foreach (ChiTietBaiLamKiemTra ct in chitietbailam)
                {
                    command.Parameters.Clear();
                    command.Parameters.Add("@mabailamkt", SqlDbType.UniqueIdentifier).Value = Guid.Parse(ct.Mabailamkiemtra);
                    command.Parameters.Add("@macauhoi", SqlDbType.UniqueIdentifier).Value =
                        Guid.Parse(ct.Macauhoi);
                    command.Parameters.Add("@dapanchon", SqlDbType.UniqueIdentifier).Value = Guid.Parse(ct.Dapanchon);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file chitietbailambaiktDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
