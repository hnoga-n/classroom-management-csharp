using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class TinNhanBanBeBUS
    {
        private ArrayList list;
        private TinNhanBanBeDAO tnbbDAO;
        public TinNhanBanBeBUS()
        {
            tnbbDAO = new TinNhanBanBeDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = tnbbDAO.loadList();
            list.Sort();
        }
    }
}
