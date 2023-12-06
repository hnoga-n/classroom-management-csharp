using Hybrid.DTO;
using ServiceStack.OrmLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class DeKiemTraDAO
    {
        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM dekiemtra";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DeKiemTra tmp = new DeKiemTra();
                    tmp.Madekiemtra = dr["madekiemtra"].ToString();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Tieude = dr["tieude"].ToString();
                    tmp.Hinhphat = int.Parse(dr["hinhphat"].ToString());
                    tmp.Xemdapan = int.Parse(dr["xemdapan"].ToString());
                    tmp.Troncauhoi = int.Parse(dr["troncauhoi"].ToString());
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString());
                    tmp.Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString());
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public bool ThemDeKiemTra(DeKiemTra dekiemtra)
        {
            try
            {
                string sql_themdekiemtra = "INSERT INTO dekiemtra(madekiemtra,machuong,tieude,thoigianbatdau,thoigianketthuc,hinhphat,xemdapan,thoigiantao,troncauhoi,daxoa) " +
                    "VALUES (@madekiemtra,@machuong,N'" + dekiemtra.Tieude + "',@thoigianbatdau,@thoigianketthuc,@hinhphat,@xemdapan,@thoigiantao,@troncauhoi,@daxoa)";
                SqlCommand cmd_themdekiemtra = new SqlCommand(sql_themdekiemtra, Ketnoisqlserver.GetConnection());
                cmd_themdekiemtra.Parameters.AddWithValue("@madekiemtra", Guid.Parse(dekiemtra.Madekiemtra));
                cmd_themdekiemtra.Parameters.AddWithValue("@machuong", Guid.Parse(dekiemtra.Machuong));
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianbatdau", dekiemtra.Thoigianbatdau);
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianketthuc", dekiemtra.Thoigianketthuc);
                cmd_themdekiemtra.Parameters.AddWithValue("@hinhphat", dekiemtra.Hinhphat);
                cmd_themdekiemtra.Parameters.AddWithValue("@xemdapan", dekiemtra.Xemdapan);
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigiantao", dekiemtra.Thoigiantao);
                cmd_themdekiemtra.Parameters.AddWithValue("@troncauhoi", dekiemtra.Troncauhoi);
                cmd_themdekiemtra.Parameters.AddWithValue("@daxoa", dekiemtra.Daxoa);
                cmd_themdekiemtra.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public bool SuaDeKiemTra(DeKiemTra dekiemtra)
        {
            try
            {
                string sql_themdekiemtra = "UPDATE dekiemtra SET thoigianbatdau = @thoigianbatdau, thoigianketthuc = @thoigianketthuc WHERE madekiemtra = @madekiemtra";
                SqlCommand cmd_themdekiemtra = new SqlCommand(sql_themdekiemtra, Ketnoisqlserver.GetConnection());
                cmd_themdekiemtra.Parameters.AddWithValue("@madekiemtra", Guid.Parse(dekiemtra.Madekiemtra));
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianbatdau", dekiemtra.Thoigianbatdau);
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianketthuc", dekiemtra.Thoigianketthuc);
                cmd_themdekiemtra.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public bool XoaDeKiemTra(DeKiemTra dekiemtra)
        {
            try
            {
                string sql_xoadekiemtra = "UPDATE dekiemtra SET daxoa = 1 WHERE madekiemtra = @madekiemtra";
                SqlCommand cmd_xoadekiemtra = new SqlCommand(sql_xoadekiemtra, Ketnoisqlserver.GetConnection());
                cmd_xoadekiemtra.Parameters.AddWithValue("@madekiemtra", Guid.Parse(dekiemtra.Madekiemtra));
                cmd_xoadekiemtra.ExecNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
                return false;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
        public ArrayList GetTatCaBaiKiemTraChuaNopByMaLopHoc(string malop)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT madekiemtra,c.machuong,tieude,thoigianbatdau,thoigianketthuc,hinhphat,xemdapan,dkt.thoigiantao,troncauhoi,dkt.daxoa FROM dekiemtra dkt JOIN chuong c ON dkt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc WHERE l.malophoc=@malophoc AND dkt.madekiemtra NOT IN (SELECT dkt.madekiemtra FROM dekiemtra dkt JOIN bailamkiemtra bl ON dkt.madekiemtra=bl.madekiemtra)";
                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                SqlDataReader dr = command.ExecuteReader();
                DeKiemTra tmp;
                while (dr.Read())
                {
                    tmp = new DeKiemTra
                    {
                        Madekiemtra = dr["madekiemtra"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Hinhphat = int.Parse(dr["hinhphat"].ToString()),
                        Xemdapan = int.Parse(dr["xemdapan"].ToString()),
                        Troncauhoi = int.Parse(dr["troncauhoi"].ToString()),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString()),
                    };
                    listBaitap.Add(tmp);

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }

            return listBaitap;
        }
        public ArrayList GetTatCaBaiKiemTraDaNopByMaLopHoc(string malop)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT madekiemtra,c.machuong,tieude,thoigianbatdau,thoigianketthuc,hinhphat,xemdapan,dkt.thoigiantao,troncauhoi,dkt.daxoa FROM dekiemtra dkt JOIN chuong c ON dkt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc WHERE l.malophoc=@malophoc AND dkt.madekiemtra IN (SELECT dkt.madekiemtra FROM dekiemtra dkt JOIN bailamkiemtra bl ON dkt.madekiemtra=bl.madekiemtra)";
                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                SqlDataReader dr = command.ExecuteReader();
                DeKiemTra tmp;
                while (dr.Read())
                {
                    tmp = new DeKiemTra
                    {
                        Madekiemtra = dr["madekiemtra"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Hinhphat = int.Parse(dr["hinhphat"].ToString()),
                        Xemdapan = int.Parse(dr["xemdapan"].ToString()),
                        Troncauhoi = int.Parse(dr["troncauhoi"].ToString()),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString()),
                    };
                    listBaitap.Add(tmp);

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }

            return listBaitap;
        }
    }
}
