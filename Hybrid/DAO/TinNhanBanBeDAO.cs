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
                    tmp.Mabanbe = dr["mabanbe"].ToString();
                    tmp.Manguoigui = dr["manguoigui"].ToString();
                    tmp.Manguoinhan = dr["manguoinhan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiangui= DateTime.Parse(dr["thoigiangui"].ToString());
                    tmp.Trangthai = int.Parse(dr["trangthai"].ToString());
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
    }
}
