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
    public class ChiTietDeKiemTraBUS
    {
        private ArrayList list;
        private ChiTietDeKiemTraDAO ctdktDAO;
        public ChiTietDeKiemTraBUS()
        {
            ctdktDAO = new ChiTietDeKiemTraDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = ctdktDAO.loadList();
            //list.Sort();
        }

        public void ThemChiTietDeKiemTra(ChiTietDeKiemTra ctdkt)
        {
            list.Add(ctdkt);
            ctdktDAO.ThemChiTietDeKiemTra(ctdkt);
        }

        public ArrayList GetMaCauHoiByMaDeKiemTra(string madekiemtra)
        {
            ArrayList rslist = new ArrayList();
            foreach(ChiTietDeKiemTra ctdkt in this.list)
            {
                if(ctdkt.Madekiemtra.Equals(madekiemtra))
                {
                    rslist.Add(ctdkt);
                }
            }
            return rslist;
        }
    }
}
