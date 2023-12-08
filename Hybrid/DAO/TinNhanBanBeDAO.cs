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
            //list = loadList();
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
                    tmp.Thoigiangui= DateTime.Parse(dr["thoigiangui"].ToString());
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


        public List<TinNhanBanBe> GetList(string user, string friend)
        {
            List<TinNhanBanBe> list = new List<TinNhanBanBe>();

            try
            {
                string sql = string.Format("SELECT * FROM tinnhanbanbe WHERE (manguoigui = '{0}' AND manguoinhan = '{1}') OR (manguoigui = '{1}' AND manguoinhan = '{0}') ORDER BY thoigiangui", user, friend);

                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TinNhanBanBe tmp = new TinNhanBanBe();
                    tmp.Matinnhan = reader["matinnhan"].ToString();
                    tmp.Manguoigui = reader["manguoigui"].ToString();
                    tmp.Manguoinhan = reader["manguoinhan"].ToString();
                    tmp.Noidung = reader["noidung"].ToString();
                    tmp.Thoigiangui = DateTime.Parse(reader["thoigiangui"].ToString());
                    tmp.Daxoa = int.Parse(reader["daxoa"].ToString());
                    list.Add(tmp);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Ketnoisqlserver.GetConnection().Close();
            }

            return list;
        }


        public void AddMessage(string Manguoigui, string Manguoinhan, string Noidung)
        {
            //Guid matinnhan = Guid.NewGuid();

            try
            {
                string sql = "INSERT INTO tinnhanbanbe (matinnhan,manguoigui ,manguoinhan ,noidung,thoigiangui,daxoa) VALUES (NEWID() ,@manguoigui , @manguoinhan, @noidung ,GETDATE(),0)";

                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                
                    //command.Parameters.AddWithValue("@matinnhan", matinnhan);
                    command.Parameters.AddWithValue("@manguoigui", Manguoigui);
                    command.Parameters.AddWithValue("@manguoinhan", Manguoinhan);
                    command.Parameters.AddWithValue("@noidung", Noidung);
                    //command.Parameters.AddWithValue("@thoigiangui", a.Thoigiangui);
                    //command.Parameters.AddWithValue("@daxoa", 0);

                    command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Ketnoisqlserver.GetConnection().Close();
            }
        }

        public void StatusMessage(string a)
        {

            try
            {

                string sql = "UPDATE tinnhanbanbe SET daxoa = 1 WHERE matinnhan = @matinnhan";


                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());

                command.Parameters.AddWithValue("@matinnhan", a);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Ketnoisqlserver.GetConnection().Close();
            }
        }

    }
}
