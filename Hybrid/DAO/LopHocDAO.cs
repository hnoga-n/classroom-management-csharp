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
    public class LopHocDAO
    {
        private ArrayList list;

        public LopHocDAO()
        {
            list = loadList();

        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                
                string sql_get_all = "SELECT * FROM lophoc";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LopHoc tmp = new LopHoc();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Trangthai = int.Parse(dr["trangthai"].ToString());
                    tmp.Magiangvien = dr["magiangvien"].ToString();
                    tmp.Tenlop = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public void ThemLopHoc(LopHoc lophoc)
        {
            try
            {
                string sql_themlophoc = "INSERT INTO lophoc(malophoc,ten,mota,trangthai,magiangvien) VALUES (@malophoc,N'"+ lophoc.Tenlop + "',@mota,@trangthai,@magiangvien)";
                SqlCommand cmd_themlophoc = new SqlCommand(sql_themlophoc, Ketnoisqlserver.GetConnection());
                cmd_themlophoc.Parameters.AddWithValue("@malophoc", lophoc.Malop);
                cmd_themlophoc.Parameters.AddWithValue("@mota", lophoc.Mota);
                cmd_themlophoc.Parameters.AddWithValue("@trangthai", lophoc.Trangthai);
                cmd_themlophoc.Parameters.AddWithValue("@magiangvien",Guid.Parse(lophoc.Magiangvien));
                cmd_themlophoc.ExecNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
            } finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
