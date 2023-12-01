using Hybrid.DAO;
using Hybrid.DTO;
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

        public ArrayList List { get => list; set => list = value; }

        public FileBaiTapBUS()
        {
            filebtDAO = new FileBaiTapDAO();
            loadList();
        }
        public void loadList()
        {
            List = filebtDAO.loadList();
        }

        public bool createFile(ArrayList listFilebt)
        {
            if (filebtDAO.createFile(listFilebt))
            {
                loadList(); // reset filebaitapBUS
                return true;
            }
            return false;
        }
        public bool EditFile(ArrayList listFilebt)
        {
            if (filebtDAO.EditFile(listFilebt))
            {
                loadList(); // reset filebaitapBUS
                return true;
            }
            return false;
        }

        public bool deleteFile(string mabaitap)
        {
            ArrayList copyArrayList = new ArrayList(this.list);
            if (filebtDAO.DeleteFileBaiTapByMaBaiTap(mabaitap))
            {
                foreach (FileBaiTap file in copyArrayList)
                {
                    if (file.Mabaitap.Equals(mabaitap))
                    {
                        this.list.Remove(file);
                    }
                }
                return true;
            }
            return false;
        }
    }
}
