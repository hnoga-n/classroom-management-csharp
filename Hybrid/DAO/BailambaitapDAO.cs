﻿using Hybrid.DTO;
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
    public class BailambaitapDAO
    {

        public BailambaitapDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM bailambaitap";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiLamBaiTap tmp = new BaiLamBaiTap();
                    tmp.Mabailam = dr["mabailam"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Mabaitap = dr["mabaitap"].ToString();
                    tmp.Nhanxet = dr["nhanxet"].ToString();
                    tmp.Diem = float.Parse(dr["diem"].ToString());
                    tmp.Noptre = int.Parse(dr["noptre"].ToString());
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiannopbai = DateTime.Parse(dr["thoigiannopbai"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BailambaitapDAO: " + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public bool CreateBaiLamBaiTap(BaiLamBaiTap blbt)
        {
            try
            {
                string sql = "INSERT INTO bailambaitap(mabailam,mataikhoan,mabaitap,noidung,thoigiannopbai,nhanxet,diem,noptre) VALUES (@mabailam, @mataikhoan, @mabaitap, @noidung, @thoigiannopbai, @nhanxet, @diem, @noptre)";
                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@mabailam", blbt.Mabailam);
                command.Parameters.AddWithValue("@mataikhoan", blbt.Mataikhoan);
                command.Parameters.AddWithValue("@mabaitap", blbt.Mabaitap);
                command.Parameters.AddWithValue("@noidung", blbt.Noidung);
                command.Parameters.AddWithValue("@thoigiannopbai", blbt.Thoigiannopbai);
                command.Parameters.AddWithValue("@nhanxet", (object)blbt.Nhanxet ?? DBNull.Value);
                command.Parameters.AddWithValue("@diem", (object)blbt.Diem ?? DBNull.Value);
                command.Parameters.AddWithValue("@noptre", blbt.Noptre);
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xảy ra ở file BailambaitapDAO" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return false;
        }
        public bool DeleteBaiLamBaiTapByMaBaiLam(string mabailam)
        {
            try
            {
                string sql_delete = "DELETE FROM bailambaitap WHERE mabailam=@mabailam";
                SqlCommand command = new SqlCommand(sql_delete, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@mabailam", Guid.Parse(mabailam)) ;
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return false;
        }

        public bool ChamDiemBaiLamBaiTap(BaiLamBaiTap blbt)
        {
            try
            {
                string sql = "UPDATE bailambaitap SET diem=@diem, nhanxet=@nhanxet WHERE mabailam=@mabailam";
                SqlCommand command = new SqlCommand(sql, Ketnoisqlserver.GetConnection());
                command.Parameters.AddWithValue("@diem", blbt.Diem);
                command.Parameters.AddWithValue("@nhanxet", blbt.Nhanxet);
                command.Parameters.AddWithValue("@mabailam", blbt.Mabailam);
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return false;
        }
    }
}
