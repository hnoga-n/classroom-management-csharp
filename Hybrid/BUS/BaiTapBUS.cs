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
        public void loadList()
        {
            list = btDAO.loadList();
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
