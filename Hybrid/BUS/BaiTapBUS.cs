using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Hybrid.BUS
{
    public class BaiTapBUS
    {
        private ArrayList list;
        private BaiTapDAO btDAO;
        public BaiTapBUS()
        {
            btDAO = new BaiTapDAO();
            loadList();
        }

        public void loadList()
        {
            list = btDAO.loadList();
            BaiTapComparer comparer = new BaiTapComparer();
            comparer.TypeToCompare = BaiTapComparer.ComparisonType.mabaitap;
            list.Sort(comparer);
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

        public bool createBaitap(BaiTap bt)
        {
            if (btDAO.createBaiTap(bt))
            {
                this.list.Add(bt);
                return true;
            }
            return false;
        }
        public bool EditBaitap(BaiTap bt)
        {
            if (btDAO.EditBaiTap(bt))
            {
                BaiTapComparer comparer = new BaiTapComparer
                {
                    TypeToCompare = BaiTapComparer.ComparisonType.mabaitap
                };
                BaiTap tmp = new BaiTap
                {
                    Mabaitap = bt.Mabaitap
                };
                int index = this.list.BinarySearch(tmp, comparer);
                if (index < 0) return false;
                this.list.RemoveAt(index);
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
                int index = this.list.BinarySearch(bt, comparer);
                if (index < 0) return true;
                this.list.RemoveAt(index);
                return true;
            }
            return false;
        }
        public bool DeleteBaitapByChangeState(string mabaitap)
        {
            if (btDAO.DeleteBaiTapByChangeState(mabaitap))
            {
                BaiTapComparer comparer = new BaiTapComparer();
                comparer.TypeToCompare = BaiTapComparer.ComparisonType.mabaitap;
                BaiTap bt = new BaiTap
                {
                    Mabaitap = mabaitap
                };
                int index = this.list.BinarySearch(bt, comparer);
                if (index < 0) return true;
                (this.list[index] as BaiTap).Daxoa = 1;
                return true;
            }
            return false;
        }

        public BaiTap GetBaiTapByMaBaiTap(string mabaitap)
        {
            foreach (BaiTap bt in this.list)
            {
                if (bt.Mabaitap.Equals(mabaitap))
                    return bt;
            }
            return null;
        }

        public ArrayList GetTatCaBaiTapDaNopByMaLopHoc(string malophoc)
        {
            return btDAO.GetTatCaBaiTapDaNopByMaLopHoc(malophoc);
        }
        public ArrayList GetTatCaBaiTapChuaNopByMaLopHoc(string malophoc)
        {
            return btDAO.GetTatCaBaiTapChuaNopByMaLopHoc(malophoc);

        }
    }
}
