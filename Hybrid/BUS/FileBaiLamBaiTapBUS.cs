using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class FileBaiLamBaiTapBUS
    {
        private ArrayList list;
        private FileBaiLamBaiTapDAO filebtDAO;
        public FileBaiLamBaiTapBUS()
        {
            filebtDAO = new FileBaiLamBaiTapDAO();
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
