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
    public class TinNhanBanBeDAO
    {
        private ArrayList list;

        public TinNhanBanBeDAO()
        {
            list = loadList();
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM tinnhanbanbe";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TinNhanBanBe tmp = new TinNhanBanBe();
                    tmp.Matinnhan = dr["matinnhan"].ToString();
                    tmp.Manguoigui = dr["manguoigui"].ToString();
                    tmp.Manguoinhan = dr["manguoinhan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiangui = DateTime.Parse(dr["thoigiangui"].ToString());
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file tinnhanbanbeDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public TinNhanBanBe getLatest(String currentID, String friendAccountID)
        {
            TinNhanBanBe tmp = null;
            try
            {

                string sql_get_all = string.Format("SELECT TOP 1 * FROM tinnhanbanbe WHERE (manguoigui = '{0}' OR manguoinhan = '{0}') AND (manguoigui = '{1}' OR manguoinhan = '{1}') AND daxoa = 0 ORDER BY thoigiangui DESC", currentID, friendAccountID);
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tmp = new TinNhanBanBe();
                    tmp.Matinnhan = dr["matinnhan"].ToString();
                    tmp.Manguoigui = dr["manguoigui"].ToString();
                    tmp.Manguoinhan = dr["manguoinhan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiangui = DateTime.Parse(dr["thoigiangui"].ToString());
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file TinNhanBanBeDAO getLatest:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return tmp;
        }

        public ArrayList loadList(int perMess, int mess_index_value, String currentID, String friendAccountID)
        {
            ArrayList listTmp = new ArrayList();
            int start = (mess_index_value - 1) * perMess;
            try
            {

                string sql_get_all = string.Format("SELECT * FROM tinnhanbanbe WHERE (manguoigui = '{2}' OR manguoinhan = '{2}') AND (manguoigui = '{3}' OR manguoinhan = '{3}') AND daxoa = 0 ORDER BY thoigiangui DESC  OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, perMess, currentID, friendAccountID);
                Console.WriteLine(sql_get_all);
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TinNhanBanBe tmp = new TinNhanBanBe();
                    tmp.Matinnhan = dr["matinnhan"].ToString();
                    tmp.Manguoigui = dr["manguoigui"].ToString();
                    tmp.Manguoinhan = dr["manguoinhan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiangui = DateTime.Parse(dr["thoigiangui"].ToString());
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file TinNhanBanBeDAO loadList:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }


        public void insert(string maTN, String maNguoiGui, String maNguoiNhan, string message, string thoiGianGui)
        {
            try
            {
                string sql = string.Format("INSERT INTO tinnhanbanbe VALUES  ('{0}', '{1}', '{2}', N'{3}', '{4}', 0)", maTN, maNguoiGui, maNguoiNhan, message, thoiGianGui);
                SqlCommand cmd = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file TinNhanBanBeDAO insert:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public void delete(string maTN)
        {
            try
            {
                string sql = string.Format("update tinnhan set antinnhan = '1' WHERE matinnhan = '{0}'", maTN);
                SqlCommand cmd = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file TinNhanBanBeDAO delete:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
