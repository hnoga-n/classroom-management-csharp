using Hybrid.DAO;
using Hybrid.DTO;
using ServiceStack;
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
    public class BaiTapDAO
    {

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_getall = "SELECT * FROM baitap ";
                SqlCommand cmd = new SqlCommand(sql_getall, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTap tmp = new BaiTap();
                    tmp.Mabaitap = dr["mabaitap"].ToString();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Tieude = dr["tieude"].ToString();
                    tmp.Noidungbaitap = dr["noidungbaitap"].ToString();
                    tmp.Noidungdapan = dr["noidungdapan"].ToString();
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString());
                    tmp.Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString());
                    tmp.Congkhaidapan = int.Parse(dr["congkhaidapan"].ToString());
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaitapDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
        public bool createBaiTap(BaiTap bt)
        {
            try
            {
                string sql_getall = "INSERT INTO baitap(mabaitap,machuong,tieude,noidungbaitap,noidungdapan,thoigiantao,thoigianbatdau,thoigianketthuc,congkhaidapan,daxoa) VALUES (@mabaitap,@machuong,@tieude,@noidungbaitap,@noidungdapan,@thoigiantao,@thoigianbatdau,@thoigianketthuc,@congkhaidapan,@daxoa)";
                SqlCommand command = new SqlCommand(sql_getall, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@mabaitap", Guid.Parse(bt.Mabaitap));
                command.Parameters.AddWithValue("@machuong", Guid.Parse(bt.Machuong));
                command.Parameters.AddWithValue("@tieude", bt.Tieude);
                command.Parameters.AddWithValue("@noidungbaitap", bt.Noidungbaitap);
                command.Parameters.AddWithValue("@noidungdapan", bt.Noidungdapan);
                command.Parameters.AddWithValue("@thoigiantao", bt.Thoigiantao.ToString());
                command.Parameters.AddWithValue("@thoigianbatdau", bt.Thoigianbatdau);
                command.Parameters.AddWithValue("@thoigianketthuc", bt.Thoigianketthuc);
                command.Parameters.AddWithValue("@congkhaidapan", bt.Congkhaidapan);
                command.Parameters.AddWithValue("@daxoa", bt.Daxoa);
                int index = command.ExecuteNonQuery();

                if (index > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return false;
        }
        public bool EditBaiTap(BaiTap bt)
        {
            try
            {
                string sql_getall = "UPDATE baitap SET tieude=@tieude,noidungbaitap=@noidungbaitap,noidungdapan=@noidungdapan,thoigianbatdau=@thoigianbatdau,thoigianketthuc=@thoigianketthuc,congkhaidapan=@congkhaidapan WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_getall, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@tieude", bt.Tieude);
                command.Parameters.AddWithValue("@noidungbaitap", bt.Noidungbaitap);
                command.Parameters.AddWithValue("@noidungdapan", bt.Noidungdapan);
                command.Parameters.AddWithValue("@thoigianbatdau", bt.Thoigianbatdau);
                command.Parameters.AddWithValue("@thoigianketthuc", bt.Thoigianketthuc);
                command.Parameters.AddWithValue("@congkhaidapan", bt.Congkhaidapan);
                command.Parameters.AddWithValue("@mabaitap", Guid.Parse(bt.Mabaitap));
                int index = command.ExecuteNonQuery();

                if (index > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return false;
        }

        public bool DeleteBaiTapByMaBaiTap(string mabaitap)
        {
            try
            {
                string sql_delete = "DELETE FROM baitap WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_delete, Ketnoisqlserver.GetConnection());
                command.Parameters.Add("@mabaitap", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mabaitap);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaitapDAO:" + ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return true;
        }
        public bool DeleteBaiTapByChangeState(string mabaitap)
        {
            try
            {
                string sql_delete = "UPDATE baitap SET daxoa=1 WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_delete, Ketnoisqlserver.GetConnection());
                command.Parameters.Add("@mabaitap", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mabaitap);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaitapDAO:" + ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return true;
        }

        public ArrayList GetTatCaBaiTapDaNopByMaLopHoc(string malop,string mataikhoan)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT bt.mabaitap,c.machuong,tieude,noidungbaitap,noidungdapan,bt.thoigiantao,thoigianbatdau,thoigianketthuc,congkhaidapan,bt.daxoa FROM baitap bt JOIN chuong c ON bt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc JOIN bailambaitap bl ON bl.mabaitap=bt.mabaitap WHERE l.malophoc=@malophoc AND bl.mataikhoan=@mataikhoan ";
                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                command.Parameters.AddWithValue("@mataikhoan", Guid.Parse(mataikhoan));
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    BaiTap tmp = new BaiTap
                    {
                        Mabaitap = dr["mabaitap"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Noidungbaitap = dr["noidungbaitap"].ToString(),
                        Noidungdapan = dr["noidungdapan"].ToString(),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Congkhaidapan = int.Parse(dr["congkhaidapan"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString())
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
        public ArrayList GetTatCaBaiTapChuaNopByMaLopHoc(string malop)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT bt.mabaitap,c.machuong,tieude,noidungbaitap,noidungdapan,bt.thoigiantao,thoigianbatdau,thoigianketthuc,congkhaidapan,bt.daxoa FROM baitap bt JOIN chuong c ON bt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc  WHERE l.malophoc=@malophoc AND (bt.nopbu=1 OR bt.thoigianketthuc > GETDATE()) bt.mabaitap NOT IN (SELECT bt2.mabaitap FROM baitap bt2 JOIN bailambaitap bl2 ON bl2.mabaitap=bt2.mabaitap)";
                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                SqlDataReader dr = command.ExecuteReader();
                BaiTap tmp;
                while (dr.Read())
                {
                    tmp = new BaiTap
                    {
                        Mabaitap = dr["mabaitap"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Noidungbaitap = dr["noidungbaitap"].ToString(),
                        Noidungdapan = dr["noidungdapan"].ToString(),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Congkhaidapan = int.Parse(dr["congkhaidapan"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString())
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
