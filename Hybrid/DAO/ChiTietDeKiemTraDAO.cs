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

namespace Hybrid.DAO
{
    public class ChiTietDeKiemTraDAO
    {
        private ArrayList list;

        public ChiTietDeKiemTraDAO()
        {
            list = loadList();
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM chitietbaikiemtra";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietDeKiemTra tmp = new ChiTietDeKiemTra();
                    tmp.Madekiemtra = dr["madekiemtra"].ToString();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Thutu = Convert.ToInt32(dr["thutu"]);
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file chitietbaiktDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
        public void ThemChiTietDeKiemTra(ChiTietDeKiemTra ctdtk)
        {
            try
            {
                string sql_themchitietdekiemtra = "INSERT INTO chitietbaikiemtra(madekiemtra,macauhoi,thutu) VALUES (@madekiemtra,@macauhoi,@thutu)";
                SqlCommand cmd_themchitietdekiemtra = new SqlCommand(sql_themchitietdekiemtra, Ketnoisqlserver.GetConnection());
                cmd_themchitietdekiemtra.Parameters.AddWithValue("@madekiemtra", Guid.Parse(ctdtk.Madekiemtra));
                cmd_themchitietdekiemtra.Parameters.AddWithValue("@macauhoi", Guid.Parse(ctdtk.Macauhoi));
                cmd_themchitietdekiemtra.Parameters.AddWithValue("@thutu", ctdtk.Thutu);
                cmd_themchitietdekiemtra.ExecNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChitietdekiemtraDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
