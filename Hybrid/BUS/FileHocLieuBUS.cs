using Hybrid.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class FileHocLieuBUS
    {
        private ArrayList list;
        private FileHocLieuDAO filehlDAO;
        public FileHocLieuBUS()
        {
            filehlDAO = new FileHocLieuDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = filehlDAO.loadList();
            list.Sort();
        }
    }
}
