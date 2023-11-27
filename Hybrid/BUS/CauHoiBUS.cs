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
            list.Sort();
        }

        public ArrayList GetDanhSachCauHoiByMaTaiKhoan(string mataikhoan)
        {
            return cauhoiDAO.GetDanhSachCauHoiByMaTaiKhoan(mataikhoan);
        }
        public CauHoi getCauhoiWithMaCauHoi(string macauhoi)
        {
            CauhoiComparer comparer = new CauhoiComparer();
            comparer.TypeToCompare = CauhoiComparer.ComparisonType.macauhoi;
            CauHoi chSearch = new CauHoi();
            chSearch.Macauhoi = macauhoi;
            int index = list.BinarySearch(chSearch, comparer);
            return (CauHoi)list[index];
        }

        public bool ThemCauHoi(CauHoi cauhoi)
        {
            if(cauhoiDAO.ThemCauHoi(cauhoi))
            {
                this.list.Add(cauhoi);
                return true;
            }
            return false;
        }

        public void XoaCauHoi(CauHoi cauhoi)
        {
            foreach(CauHoi ch in this.list)
            {
                if (ch.Macauhoi.Equals(cauhoi.Macauhoi))
                {
                    ch.Daxoa = 1;
                    break;
                }
            }
            cauhoiDAO.XoaCauHoi(cauhoi.Macauhoi);
        }

        public bool SuaCauHoi(CauHoi cauhoi)
        {
            if(cauhoiDAO.SuaCauHoi(cauhoi))
            {
                foreach(CauHoi ch in this.list)
                {
                    if(ch.Macauhoi.Equals(cauhoi.Macauhoi)) {
                        ch.Noidung = cauhoi.Noidung;
                        ch.Daxoa = cauhoi.Daxoa; 
                        break;
                    }
                }
                return true;
            } else 
                return false;
        }

        public ArrayList TimKiemCauHoiThuocTaiKhoan(string tukhoa, string mataikhoan)
        {
            ArrayList resultlist = new ArrayList();
            foreach (CauHoi cauhoi in GetDanhSachCauHoiByMaTaiKhoan(mataikhoan))
            {
                if (cauhoi.Noidung.ToLower().Contains(tukhoa.ToLower()) && cauhoi.Mataikhoan.Equals(mataikhoan) && cauhoi.Daxoa == 0)
                {
                    resultlist.Add(cauhoi);
                }
            }
            return resultlist;  
        }

        public CauHoi GetCauHoiByMaCauHoi(string macauhoi)
        {
            CauHoi cauhoi = null;
            foreach (CauHoi ch in this.list)
            {
                if (ch.Macauhoi.Equals(macauhoi))
                    return ch;
            }
            return cauhoi;
        }
    }
}
