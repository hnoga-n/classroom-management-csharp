﻿using Hybrid.DAO;
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

        public BaiTapDAO()
        {

        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_getall = "SELECT * FROM baitap";
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

        public bool DeleteBaiTapByMaBaiTap(string mabaitap)
        {
            try
            {
                string sql_delete = "DELETE FROM baitap WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_delete, Ketnoisqlserver.GetConnection());
                command.Parameters.Add("@mabaitap", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mabaitap);
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
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
            return false;
        }
    }
}
