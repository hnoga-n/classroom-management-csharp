using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class NhomQuyenBUS
    {
        private ArrayList list;
        private NhomQuyenDAO nhomquyenDAO;
        public NhomQuyenBUS()
        {
            nhomquyenDAO = new NhomQuyenDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = nhomquyenDAO.loadList();
            list.Sort();
        }
    }
}
