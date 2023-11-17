﻿using Hybrid.DTO;
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
    public class BanbeDAO
    {
        private ArrayList list;

        public BanbeDAO()
        {
            list = loadList();
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM banbe";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BanbeDTO tmp = new BanbeDTO();
                    tmp.Mabanbe = dr["mabanbe"].ToString();
                    tmp.Manguoiketban = dr["manguoiketban"].ToString();
                    tmp.Manguoiduocketban = dr["manguoiduocketban"].ToString();
                    tmp.Thoigianketban = DateTime.Parse(dr["thoigianketban"].ToString());
                    tmp.Trangthaiketban= int.Parse(dr["thangthai"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BanbeDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
    }
}