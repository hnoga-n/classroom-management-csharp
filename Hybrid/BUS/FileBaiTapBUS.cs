using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class FileBaiTapBUS
    {
        private ArrayList list;
        private FileBaiTapDAO filebtDAO;
        public FileBaiTapBUS()
        {
            filebtDAO = new FileBaiTapDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = filebtDAO.loadList();
            list.Sort();
        }
    }
}
