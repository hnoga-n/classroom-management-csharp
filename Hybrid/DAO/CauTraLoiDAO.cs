using Hybrid.DTO;
using ServiceStack.OrmLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class CauTraLoiDAO
    {

        public CauTraLoiDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM cautraloi";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauTraLoi tmp = new CauTraLoi();
                    tmp.Macautraloi= dr["macautraloi"].ToString();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Noidung= dr["noidung"].ToString();
                    tmp.Ladapan = int.Parse(dr["lacautraloidung"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CautraloiDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public void ThemCauTraLoi(CauTraLoi cautraloi)
        {
            try
            {
                string sql_themcautraloi = "INSERT INTO cautraloi(macautraloi,macauhoi,noidung,lacautraloidung) VALUES (@macautraloi,@macauhoi,N'" + cautraloi.Noidung + "',@lacautraloidung)";
                SqlCommand cmd_themcautraloi = new SqlCommand(sql_themcautraloi, Ketnoisqlserver.GetConnection());
                cmd_themcautraloi.Parameters.AddWithValue("@macautraloi", Guid.Parse(cautraloi.Macautraloi));
                cmd_themcautraloi.Parameters.AddWithValue("@macauhoi", Guid.Parse(cautraloi.Macauhoi));
                cmd_themcautraloi.Parameters.AddWithValue("@lacautraloidung", cautraloi.Ladapan);
                cmd_themcautraloi.ExecNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CautraloiDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public bool SuaCauTraLoi(CauTraLoi cautraloi)
        {
            try
            {
                string sql_suacautraloi = "UPDATE cautraloi SET noidung = N'"+cautraloi.Noidung+"',lacautraloidung = @lacautraloidung WHERE macautraloi = @macautraloi";
                SqlCommand cmd_suacautraloi = new SqlCommand(sql_suacautraloi, Ketnoisqlserver.GetConnection());
                cmd_suacautraloi.Parameters.AddWithValue("@macautraloi", Guid.Parse(cautraloi.Macautraloi));
                cmd_suacautraloi.Parameters.AddWithValue("@lacautraloidung", cautraloi.Ladapan);
                cmd_suacautraloi.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CautraloiDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }

}
