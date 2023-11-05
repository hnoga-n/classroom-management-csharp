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
            if (chuong == null)
            {
                MessageBox.Show("Thông tin chương không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            this.list.Add(chuong);
            chuongDAO.ThemChuong(chuong);
            return true;
        }

        public bool XoaChuong(Chuong chuong)
        {
            if (chuong == null)
            {
                MessageBox.Show("Thông tin chương không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show(chuong.Machuong);
            this.list.Remove(chuong);
            chuongDAO.XoaChuong(chuong.Machuong);
            return true;
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
