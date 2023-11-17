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
        public LopHocDAO()
        {
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
<<<<<<< HEAD
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
=======
>>>>>>> main
                    tmp.Magiangvien = dr["magiangvien"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
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

        public bool ThemLopHoc(LopHoc lophoc)
        {
            try
            {
<<<<<<< HEAD
                string sql_themlophoc = "INSERT INTO lophoc(malophoc,ten,mota,daxoa,magiangvien) VALUES (@malophoc,N'" + lophoc.Tenlop + "',@mota,@daxoa,@magiangvien)";
=======
                string sql_themlophoc = "INSERT INTO lophoc(malophoc,ten,mota,daxoa,magiangvien) VALUES (@malophoc,N'"+ lophoc.Tenlop + "',@mota,@daxoa,@magiangvien)";
>>>>>>> main
                SqlCommand cmd_themlophoc = new SqlCommand(sql_themlophoc, Ketnoisqlserver.GetConnection());
                cmd_themlophoc.Parameters.AddWithValue("@malophoc", Guid.Parse(lophoc.Malop));
                cmd_themlophoc.Parameters.AddWithValue("@mota", lophoc.Mota);
                cmd_themlophoc.Parameters.AddWithValue("@daxoa", lophoc.Daxoa);
                cmd_themlophoc.Parameters.AddWithValue("@magiangvien",Guid.Parse(lophoc.Magiangvien));
                cmd_themlophoc.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
                return false;
            } finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
        public bool SuaLopHoc(LopHoc lophoc)
        {
            try
            {
                string sql_sualophoc = "UPDATE lophoc SET ten = N'" + lophoc.Tenlop + "', mota = N'" + lophoc.Mota + "' WHERE malophoc = @malophoc";
                SqlCommand cmd_sualophoc = new SqlCommand(sql_sualophoc, Ketnoisqlserver.GetConnection());
                cmd_sualophoc.Parameters.AddWithValue("@malophoc", Guid.Parse(lophoc.Malop));
                cmd_sualophoc.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
                return false;
            } finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
        public bool XoaLopHoc(string malop)
        {
            try
            {
                string sql_sualophoc = "UPDATE lophoc SET daxoa = 1 WHERE malophoc = @malophoc";
                SqlCommand cmd_sualophoc = new SqlCommand(sql_sualophoc, Ketnoisqlserver.GetConnection());
                cmd_sualophoc.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                cmd_sualophoc.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
                return false;
            } finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
        public ArrayList GetDanhSachTatCaLopHocByMaTaiKhoan(string mataikhoan) 
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_get_all = "select l.* \r\n" +
                    "from lophoc l join thamgialophoc tg on l.malophoc = tg.malophoc \r\n" +
                    "join taikhoan tk on tk.mataikhoan = tg.mataikhoan\r\n" +
                    "where tk.mataikhoan = @mataikhoan\r\n" +
                    "UNION\r\n" +
                    "select lophoc.* \r\n" +
                    "from lophoc join taikhoan on lophoc.magiangvien = taikhoan.mataikhoan\r\n" +
                    "where taikhoan.mataikhoan= @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan",mataikhoan);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LopHoc tmp = new LopHoc();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    tmp.Magiangvien = dr["magiangvien"].ToString();
                    tmp.Tenlop = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}
