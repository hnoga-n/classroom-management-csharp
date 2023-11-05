using Hybrid.DAO;
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
            list.Sort();
        }
    }
}
