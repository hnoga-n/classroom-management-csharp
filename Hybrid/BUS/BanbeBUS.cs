using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class BanbeBUS
    {
        private ArrayList list;
        private BanbeDAO banbeDAO;
        public BanbeBUS()
        {
            banbeDAO = new BanbeDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = banbeDAO.loadList();
            list.Sort();
        }
    }
}
