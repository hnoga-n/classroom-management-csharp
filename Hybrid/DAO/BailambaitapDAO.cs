using Hybrid.DTO;
using Hybrid.GUI.Baitap;
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

        public DataTable ThongKeDiemHocSinhTheoMaBaiTap(string mabaitap)
        {
            try
            {
                string sql_thamgia = "select t.hoten,b.diem,b.thoigiannopbai\r\nfrom taikhoan t join bailambaitap b on t.mataikhoan = b.mataikhoan\r\nwhere b.mabaitap = @mabaitap";
                SqlCommand cmd = new SqlCommand(sql_thamgia, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@mabaitap", Guid.Parse(mabaitap));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaiLamBaiTapDAO:" + ex.Message);
                return null;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }

        public DataTable ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(string mataikhoan,string machuong)
        {
            try
            {
                string sql_thamgia = "select bt.tieude,bl.diem,bl.thoigiannopbai\r\n" +
                    "from bailambaitap bl join baitap bt on bl.mabaitap = bt.mabaitap\r\n" +
                    "where bt.machuong = @machuong AND bl.mataikhoan = @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_thamgia, Ketnoisqlserver.GetConnection());
                cmd.Parameters.AddWithValue("@machuong", Guid.Parse(machuong));
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(mataikhoan));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaiLamBaiTapDAO:" + ex.Message);
                return null;
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
        }
    }
}
