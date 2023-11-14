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
    public class BailambaitapBUS
    {
        private ArrayList list;
        private BailambaitapDAO bailambtDAO;
        public BailambaitapBUS()
        {
            bailambtDAO = new BailambaitapDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = bailambtDAO.loadList();
            list.Sort();
        }
        public int getBaiLamBaiTapWithMaBaiTap(string mabaitap)
        {
            BailambaitapComparer comparer = new BailambaitapComparer();
            comparer.TypeToCompare = BailambaitapComparer.ComparisonType.mabaitap;
            BaiLamBaiTap blbtSearch = new BaiLamBaiTap();
            blbtSearch.Mabaitap = mabaitap.ToLower();
            int index = list.BinarySearch(blbtSearch, comparer);
            return index;
        }
    }
}
