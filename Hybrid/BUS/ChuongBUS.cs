using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.BUS
{
    public class ChuongBUS
    {
        private ArrayList list;
        private ChuongDAO chuongDAO;
        public ChuongBUS()
        {
            chuongDAO = new ChuongDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = chuongDAO.loadList();
            list.Sort();
        }

        public bool ThemChuong(Chuong chuong)
        {
            if (chuongDAO.ThemChuong(chuong))
            {
                this.list.Add(chuong);
                return true;
            }
            return false;

        }

        public bool SuaChuong(Chuong chuong)
        {
            if (chuongDAO.SuaChuong(chuong))
            {
                foreach (Chuong c in this.list)
                {
                    if (c.Machuong.Equals(chuong.Machuong))
                    {
                        c.Tenchuong = chuong.Tenchuong;
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }
        public bool XoaChuong(Chuong chuong)
        {
            if (chuongDAO.XoaChuong(chuong.Machuong))
            {
                foreach(Chuong c in this.list)
                {
                    if(c.Machuong.Equals(chuong.Machuong))
                    {
                        c.Daxoa = 1;
                        return true;    
                    }
                }
                return false;
            }else
                return false;
        }

        public Chuong getChuongWithMaChuong(string machuong)
        {
            ChuongComparer comparer = new ChuongComparer();
            comparer.TypeToCompare = ChuongComparer.ComparisonType.machuong;
            Chuong chuongSearch = new Chuong();
            chuongSearch.Machuong = machuong.ToLower();
            int index = list.BinarySearch(chuongSearch, comparer);
            return (Chuong) list[index];
        }
        public ArrayList getChuongWithMaLop(string malop)
        {
            ArrayList listchuong = new ArrayList();
            foreach (Chuong ch in list)
            {
                if (ch.Malop.Equals(malop))
                    listchuong.Add(ch);
            }
            return listchuong;
        }

    }
}
