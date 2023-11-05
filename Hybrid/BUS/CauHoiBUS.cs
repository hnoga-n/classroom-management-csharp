using Hybrid.Comparer;
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
    public class CauHoiBUS
    {
        private ArrayList list;
        private CauHoiDAO cauhoiDAO;
        public CauHoiBUS()
        {
            cauhoiDAO = new CauHoiDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = cauhoiDAO.loadList();
            //list.Sort();
        }

        public ArrayList GetDanhSachCauHoiByMaTaiKhoan(string matk)
        {
            return cauhoiDAO.GetDanhSachCauHoiByMaTaiKhoan(matk);
        }

        public bool ThemCauHoi(CauHoi cauhoi)
        {
            if(cauhoi == null) return false;
            this.list.Add(cauhoi);
            cauhoiDAO.ThemCauHoi(cauhoi);
            return true;
        }

        public void XoaCauHoi(CauHoi cauhoi)
        {
            cauhoiDAO.XoaCauHoi(cauhoi.Macauhoi);
        }
    }
}
