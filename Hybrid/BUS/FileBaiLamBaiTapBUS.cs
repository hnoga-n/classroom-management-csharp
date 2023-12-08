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
    public class FileBaiLamBaiTapBUS
    {
        private ArrayList list;
        private FileBaiLamBaiTapDAO fileblbtDAO;

        public ArrayList List { get => list; set => list = value; }

        public FileBaiLamBaiTapBUS()
        {
            fileblbtDAO = new FileBaiLamBaiTapDAO();
            loadList();
        }
        public void loadList()
        {
            List = fileblbtDAO.loadList();
            //List.Sort();
        }
        public bool createFile(ArrayList listFileblbt)
        {
            if (fileblbtDAO.createFile(listFileblbt))
            {
                loadList(); // reset fileblbtBUS
                return true;
            }
            return false;
        }

        public bool deleteFile(string mabailam)
        {
            if (fileblbtDAO.DeleteFileBaiLamBaiTapByMaBaiLam(mabailam))
            {
                foreach (FileBaiLamBaiTap file in this.List)
                {
                    if (file.Mabailam.Equals(mabailam))
                    {
                        this.List.Remove(file);
                    }
                }
                return true;
            }
            return false;
        }
    }
}
