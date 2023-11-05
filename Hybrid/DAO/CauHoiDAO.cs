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
        private ArrayList list;

        public CauHoiDAO()
        {
            list = loadList();
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
                    tmp.Matk = dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Giaithich = dr["giaithich"].ToString();
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

        public void ThemCauHoi(CauHoi cauhoi)
        {
            try
            {
                string sql_themcauhoi = "INSERT INTO cauhoi(macauhoi,noidung,giaithich,mataikhoan) VALUES (@macauhoi,N'"+cauhoi.Noidung+"',N'"+cauhoi.Giaithich+"',@mataikhoan)";
                SqlCommand cmd_themcauhoi = new SqlCommand(sql_themcauhoi, Ketnoisqlserver.GetConnection());
                cmd_themcauhoi.Parameters.AddWithValue("@macauhoi", Guid.Parse(cauhoi.Macauhoi));
                cmd_themcauhoi.Parameters.AddWithValue("@mataikhoan", Guid.Parse(cauhoi.Matk));
                cmd_themcauhoi.ExecNonQuery();
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
            } finally { 
                Ketnoisqlserver.CloseConnection();
            }
        }public void XoaCauHoi(string macauhoi)
        {
            try
            {
                string sql_xoacauhoi = "UPDATE cauhoi SET trangthai = 0 WHERE macauhoi = @macauhoi";
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

        public ArrayList GetDanhSachCauHoiByMaTaiKhoan(string matk)
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM cauhoi WHERE mataikhoan = @mataikhoan AND trangthai = 1";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan",Guid.Parse(matk));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoi tmp = new CauHoi();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Matk = dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Giaithich = dr["giaithich"].ToString();
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
