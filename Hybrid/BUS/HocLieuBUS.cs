using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class HocLieuBUS
    {
        private ArrayList list;
        private HocLieuDAO hoclieuDAO;
        public HocLieuBUS()
        {
            hoclieuDAO = new HocLieuDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = hoclieuDAO.loadList();
            list.Sort();
        }
    }
}
