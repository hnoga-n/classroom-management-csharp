using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class BailambaitapBUS
    {
        private ArrayList list;
        private BailambaitapDAO bailambtDAO;

        public ArrayList List { get => list; set => list = value; }

        public BailambaitapBUS()
        {
            bailambtDAO = new BailambaitapDAO();
            loadList();
        }
        public void loadList()
        {
            list = bailambtDAO.loadList();
            //list.Sort();
        }
        public int GetBaiLamBaiTapWithMaBaiLam(string mabailam)
        {
            BailambaitapComparer comparer = new BailambaitapComparer();
            comparer.TypeToCompare = BailambaitapComparer.ComparisonType.mabailam;
            BaiLamBaiTap blbtSearch = new BaiLamBaiTap();
            blbtSearch.Mabailam = mabailam.ToLower();
            int index = list.BinarySearch(blbtSearch, comparer);
            return index;
        }*/

        public Dictionary<float, int> ThongKePhoDiemTheoMaBaiTap(string mabt)
        {
            Dictionary<float, int> rslist = new Dictionary<float, int>();
            List<float> diemList = new List<float>();
            foreach (BaiLamBaiTap b in this.list)
            {
                if (b.Mabaitap.Equals(mabt))
                {
                    diemList.Add(b.Diem);
                }
            }
            foreach (float diem in diemList)
            {
                if (rslist.ContainsKey(diem))
                {
                    rslist[diem]++;
                }
                else
                {
                    rslist[diem] = 1;
                }
            }
            return rslist;
        }

        public Dictionary<string, float> ThongKePhoDiemTheoMaTaiKhoan(string matk)
        {
            Dictionary<string, float> rslist = new Dictionary<string, float>();
            foreach (BaiLamBaiTap blbt in this.list)
            {
                if (blbt.Mataikhoan.Equals(matk))
                {
                    rslist.Add(blbt.Mabaitap, blbt.Diem);
                }
            }
            return rslist;
        }

        public DataTable ThongKeDiemThongKeDiemHocSinhTheoMaBaiTap(string mabaitap)
        {
            return bailambtDAO.ThongKeDiemHocSinhTheoMaBaiTap(mabaitap);
        }
        public DataTable ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(string mataikhoan, string machuong)
        {
            return bailambtDAO.ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(mataikhoan,machuong);
        }
        public int GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(string mataikhoan, string mabaitap)
        {
            int index = 0;
            foreach (BaiLamBaiTap blbt in this.list)
            {
                if (blbt.Mataikhoan.Equals(mataikhoan) && blbt.Mabaitap.Equals(mabaitap))
                    return index;
                else
                    index++;
            }
            return -1;
        }

        public bool CreateBaiLamBaiTap(BaiLamBaiTap blbt)
        {
            if(bailambtDAO.CreateBaiLamBaiTap(blbt))
            {
                this.list.Add(blbt);
                return true;
            }
            return false;
        }
        public bool DeleteBaiLamBaiTap(string mabailam)
        {
            if (bailambtDAO.DeleteBaiLamBaiTapByMaBaiLam(mabailam))
            {
                BailambaitapComparer comparer = new BailambaitapComparer();
                comparer.TypeToCompare = BailambaitapComparer.ComparisonType.mabailam;
                BaiLamBaiTap blbt = new BaiLamBaiTap();
                blbt.Mabailam = mabailam;   
                int index = this.list.BinarySearch(blbt, comparer);
                if (index < 0) return true;
                this.list.RemoveAt(index);
                return true;
            }
            return false;
        }
        
        public bool ChamDiemBaiLamBaiTap(BaiLamBaiTap blbt)
        {
            if (bailambtDAO.ChamDiemBaiLamBaiTap(blbt))
            {
                int index = GetBaiLamBaiTapWithMaBaiLam(blbt.Mabailam);
                if (index < 0) return false;
                (this.list[index] as BaiLamBaiTap).Diem = blbt.Diem;
                (this.list[index] as BaiLamBaiTap).Nhanxet = blbt.Nhanxet;
                return true;
            }
            return false;
        }
    }
}
