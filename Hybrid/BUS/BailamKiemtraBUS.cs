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
    public class BailamKiemtraBUS
    {
        private ArrayList list;
        private BailamKiemtraDAO blktDAO;
        public BailamKiemtraBUS()
        {
            blktDAO = new BailamKiemtraDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = blktDAO.loadList();
            list.Sort();
        }
        public bool addBaiLam(BaiLamKiemTra bldkt)
        {
            if (blktDAO.addBaiLamKiemTra(bldkt) == 0)
                return false;
            else
            {
                list.Add(bldkt);
                return true;
            }
        }
        public int getBaiLamKiemTraWithMaBaiLam(string mabailam)
        {
            BailambaitapComparer comparer = new BailambaitapComparer();
            comparer.TypeToCompare = BailambaitapComparer.ComparisonType.mabailam;
            BaiLamBaiTap blbtSearch = new BaiLamBaiTap();
            blbtSearch.Mabailam = mabailam.ToLower();
            int index = list.BinarySearch(blbtSearch, comparer);
            return index;
        }

    }
}
