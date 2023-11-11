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
            //list.Sort();
        }

        public bool ThemThamGia(ThamGia thamgia)
        {
            if(thamgiaDAO.ThemThamGia(thamgia))
            {
                list.Add(thamgia);
                return true;
            } else 
                return false;
        }
    }
}
