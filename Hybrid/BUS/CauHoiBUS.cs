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
            //list.Sort();
        }

        public ArrayList GetDanhSachCauHoiByMaTaiKhoan(string mataikhoan)
        {
            return cauhoiDAO.GetDanhSachCauHoiByMaTaiKhoan(mataikhoan);
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
            foreach(CauHoi ch in this.list)
            {
                if (ch.Macauhoi.Equals(cauhoi.Macauhoi))
                {
                    ch.Trangthai = 0;
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
                        ch.Trangthai = cauhoi.Trangthai; 
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
                if (cauhoi.Noidung.Contains(tukhoa) && cauhoi.Matk.Equals(mataikhoan) && cauhoi.Trangthai == 1)
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
