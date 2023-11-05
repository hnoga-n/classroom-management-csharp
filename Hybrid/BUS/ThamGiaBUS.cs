using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class ThamGiaBUS
    {
        private ArrayList list;
        private ThamGiaDAO thamgiaDAO;
        public ThamGiaBUS()
        {
            thamgiaDAO = new ThamGiaDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = thamgiaDAO.loadList();
            list.Sort();
        }
    }
}
