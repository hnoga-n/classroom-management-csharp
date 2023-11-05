using Hybrid.DAO;
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

    }
}
