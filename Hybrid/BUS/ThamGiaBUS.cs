using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class ThamGiaBUS
    {
        private ArrayList list;
        private ThamGiaDAO thamgiaDAO;
        ThamGiaDAO thamgialophocDAO = new ThamGiaDAO();
        DataTable dt = new DataTable();
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

        public DataTable DanhSachHocSinhTheoMaLop(string malop)
        {
            return thamgiaDAO.DanhSachHocSinhTheoMaLop(malop);
        }

        public bool ThemThamGia(ThamGia thamgia)
        {
            if (thamgiaDAO.ThemThamGia(thamgia))
            {
                list.Add(thamgia);
                return true;
            }
            else
                return false;
        }

        public bool XoaThamGia(ThamGia thamgia)
        {
            if (thamgiaDAO.XoaThamGia(thamgia))
            {
                foreach (ThamGia tg in this.list)
                {
                    if (tg.Mataikhoan.Equals(thamgia.Mataikhoan) && tg.Malop.Equals(thamgia.Malop))
                    {
                        this.list.Remove(tg);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool KiemTraDaThamGia(ThamGia thamgia)
        {
            foreach (ThamGia tg in this.list)
            {
                if (tg.Malop.Equals(thamgia.Malop) && tg.Mataikhoan.Equals(thamgia.Mataikhoan))
                    return true;
            }
            return false;
        }

        public ArrayList getDanhSachLopWithMaLopHoc(string malophoc)
        {
            ArrayList listHocSinh = new ArrayList();
            foreach (ThamGia hocsinh in list)
            {
                if (hocsinh.Malop.Equals(malophoc))
                    listHocSinh.Add(hocsinh.Mataikhoan);
            }
            return listHocSinh;
        }
        public DataTable LayAllThamGiaLopHocByMyID(String str)
        {
            dt = thamgialophocDAO.LayAllThamGiaLopHocByMyID(str);
            return dt;
        }
        public DataTable LayAllThamGiaLopHocByIDLopHoc(String str)
        {
            dt = thamgialophocDAO.LayAllThamGiaLopHocByIDLopHoc(str);
            return dt;
        }
        public Boolean RoiKhoiLopHoc(String str, String maLH)
        {
            if (thamgialophocDAO.RoiKhoiLopHoc(str, maLH))
            {
                return true;
            }
            else { return false; }
        }


    }
}