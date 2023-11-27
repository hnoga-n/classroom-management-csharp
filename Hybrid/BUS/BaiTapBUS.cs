using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class BaiTapBUS
    {
        private ArrayList list;
        private BaiTapDAO btDAO;
        public BaiTapBUS() { 
            btDAO = new BaiTapDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public ArrayList GetDanhSachBaiTapTheoMaChuong(string machuong, string tukhoa = "")
        {
            ArrayList rslist = new ArrayList();
            foreach (BaiTap bt in this.list)
            {
                if (bt.Machuong.Equals(machuong) && bt.Tieude.ToLower().Contains(tukhoa.ToLower()) && bt.Daxoa == 0)
                    rslist.Add(bt);
            }
            return rslist;
        }
        public void loadList()
        {
            list = btDAO.loadList();
            list.Sort();
        }

        public ArrayList getBaitapCuaTaiKhoan(string matk)
        {
            ArrayList listBt = new ArrayList();
            foreach (BaiTap bt in list) {
                if (bt.Mabaitap.Equals(matk))
                    listBt.Add(bt);
            }
            return listBt;
        }

        public bool createBaitap(BaiTap bt)
        {
            if (btDAO.createBaiTap(bt))
            {
                this.list.Add(bt);
                return true;
            }
            return false;
        }

        public bool deleteBaitap(string mabaitap)
        {
            if (btDAO.DeleteBaiTapByMaBaiTap(mabaitap))
            {
                BaiTapComparer comparer = new BaiTapComparer();
                comparer.TypeToCompare = BaiTapComparer.ComparisonType.mabaitap;
                BaiTap bt = new BaiTap();
                bt.Mabaitap = mabaitap;
                int index = this.list.BinarySearch(bt,comparer);
                if(index < 0)  return true;
                this.list.RemoveAt(index);
                return true;
            }
            return false;
        }

        public ArrayList GetDanhSachBaiTapTheoMaChuong(string machuong, string tukhoa = "")
        {
            ArrayList rslist = new ArrayList();
            foreach (BaiTap bt in this.list)
            {
                if (bt.Machuong.Equals(machuong) && bt.Tieude.ToLower().Contains(tukhoa.ToLower()) && bt.Daxoa == 0)
                    rslist.Add(bt);
            }
            return rslist;
        }

        public BaiTap GetBaiTapByMaBaiTap(string mabaitap)
        {
            foreach(BaiTap bt in this.list)
            {
                if (bt.Mabaitap.Equals(mabaitap))
                    return bt;
            }
            return null;
        }
    }
}
