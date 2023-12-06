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
    public class NhomChatDAO
    {

        public NhomChatDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM nhomchat";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhomChat tmp = new NhomChat();
                    tmp.Manhomchat = dr["manhomchat"].ToString();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Tennhomchat = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file NhomchatDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public bool ThemNhomChat(NhomChat nhomchat)
        {
            try
            {
                string sql_themlophoc = "INSERT INTO nhomchat(manhomchat,malophoc,ten) VALUES (@manhomchat,@malophoc,N'" + nhomchat.Tennhomchat + "')";
                SqlCommand cmd_themlophoc = new SqlCommand(sql_themlophoc, Ketnoisqlserver.GetConnection());
                cmd_themlophoc.Parameters.AddWithValue("@manhomchat", Guid.Parse(nhomchat.Manhomchat));
                cmd_themlophoc.Parameters.AddWithValue("@malophoc", Guid.Parse(nhomchat.Malop));
                cmd_themlophoc.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file NhomchatDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public NhomChat GetNhomChatByMaLop(string maLop)
        {
            NhomChat nhomChat = null;
            try
            {

                string sql_get_all = "SELECT * FROM nhomchat WHERE malophoc = '" + maLop + "'";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nhomChat = new NhomChat();
                    nhomChat.Manhomchat = dr["manhomchat"].ToString();
                    nhomChat.Malop = dr["malophoc"].ToString();
                    nhomChat.Tennhomchat = dr["ten"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file NhomchatDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return nhomChat;
        }
    }

}
