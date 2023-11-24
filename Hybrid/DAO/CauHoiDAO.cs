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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Hybrid.DAO
{
    public class CauHoiDAO
    {

        public CauHoiDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM cauhoi";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoi tmp = new CauHoi();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Mataikhoan= dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Daxoa = Convert.ToInt32(dr["daxoa"]);
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public bool ThemCauHoi(CauHoi cauhoi)
        {
            try
            {
                string sql_themcauhoi = "INSERT INTO cauhoi(macauhoi,noidung,mataikhoan,daxoa) VALUES (@macauhoi,N'"+cauhoi.Noidung+"',@mataikhoan,@daxoa)";
                SqlCommand cmd_themcauhoi = new SqlCommand(sql_themcauhoi, Ketnoisqlserver.GetConnection());
                cmd_themcauhoi.Parameters.AddWithValue("@macauhoi", Guid.Parse(cauhoi.Macauhoi));
                cmd_themcauhoi.Parameters.AddWithValue("@mataikhoan", Guid.Parse(cauhoi.Mataikhoan));
                cmd_themcauhoi.Parameters.AddWithValue("@daxoa", Convert.ToInt32(cauhoi.Daxoa));
                cmd_themcauhoi.ExecNonQuery();
                return true;
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
                return false;
            } finally { 
                Ketnoisqlserver.CloseConnection();
            }
        }
        public void XoaCauHoi(string macauhoi)
        {
            try
            {
                string sql_xoacauhoi = "UPDATE cauhoi SET daxoa = 1 WHERE macauhoi = @macauhoi";
                SqlCommand cmd_xoacauhoi = new SqlCommand(sql_xoacauhoi, Ketnoisqlserver.GetConnection());
                cmd_xoacauhoi.Parameters.AddWithValue("@macauhoi", Guid.Parse(macauhoi));
                cmd_xoacauhoi.ExecNonQuery();
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
            } finally { 
                Ketnoisqlserver.CloseConnection();
            }
        }

        public bool SuaCauHoi(CauHoi cauhoi)
        {
            try
            {
                string sql_suacauhoi = "UPDATE cauhoi SET noidung = N'"+cauhoi.Noidung+"', daxoa = @daxoa WHERE macauhoi = @macauhoi";
                SqlCommand cmd_suacauhoi = new SqlCommand(sql_suacauhoi, Ketnoisqlserver.GetConnection());
                cmd_suacauhoi.Parameters.AddWithValue("@daxoa", cauhoi.Daxoa);
                cmd_suacauhoi.Parameters.AddWithValue("@macauhoi", Guid.Parse(cauhoi.Macauhoi));
                cmd_suacauhoi.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public ArrayList GetDanhSachCauHoiByMaTaiKhoan(string matk)
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM cauhoi WHERE mataikhoan = @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan",Guid.Parse(matk));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoi tmp = new CauHoi();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Daxoa = Convert.ToInt32(dr["daxoa"]);
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}
