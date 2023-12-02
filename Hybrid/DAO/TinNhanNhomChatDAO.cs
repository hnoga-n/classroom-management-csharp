using Hybrid.DTO;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class TinNhanNhomChatDAO
    {

        public TinNhanNhomChatDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM tinnhan";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TinNhanNhomChat tmp = new TinNhanNhomChat();
                    tmp.Matinnhan = dr["matinnhan"].ToString();
                    tmp.Manhomchat = dr["manhomchat"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiangui = DateTime.Parse(dr["thoigiangui"].ToString());
                    tmp.Antinnhan = int.Parse(dr["antinnhan"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file tinnhannhomchatDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public ArrayList loadList(int perMess, int mess_index_value, string maLopHoc)
        {
            ArrayList listTmp = new ArrayList();
            int start = (mess_index_value - 1) * perMess;
            try
            {

                string sql_get_all = string.Format("SELECT * FROM tinnhan join nhomchat on tinnhan.manhomchat = nhomchat.manhomchat WHERE malophoc = '{2}' AND antinnhan = 0 ORDER BY thoigiangui DESC  OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, perMess, maLopHoc);
                //Console.WriteLine(sql_get_all);
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TinNhanNhomChat tmp = new TinNhanNhomChat();
                    tmp.Matinnhan = dr["matinnhan"].ToString();
                    tmp.Manhomchat = dr["manhomchat"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiangui = DateTime.Parse(dr["thoigiangui"].ToString());
                    tmp.Antinnhan = int.Parse(dr["antinnhan"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file TinNhanNhomChatDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}
