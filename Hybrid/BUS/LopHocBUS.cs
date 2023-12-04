﻿using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System.Collections;

namespace Hybrid.BUS
{
    public class LopHocBUS
    {
        private ArrayList list;
        private LopHocDAO lopDAO;
        public LopHocBUS()
        {
            lopDAO = new LopHocDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = lopDAO.loadList();
            LophocComparer comparer = new LophocComparer();
            comparer.TypeToCompare = LophocComparer.ComparisonType.malophoc;
            list.Sort(comparer);
        }

        public ArrayList GetDanhSachTatCaLopHocByMaTaiKhoan(string mataikhoan)
        {
            return lopDAO.GetDanhSachTatCaLopHocByMaTaiKhoan(mataikhoan);
        }

        public LopHoc getLophocWithMaLop(string malop)
        {
            LophocComparer comparer = new LophocComparer();
            comparer.TypeToCompare = LophocComparer.ComparisonType.malophoc;
            LopHoc lopSearch = new LopHoc();
            lopSearch.Malop= malop;
            int index = list.BinarySearch(lopSearch, comparer);
            return (LopHoc) list[index];
        }

        public bool ThemLopHoc(LopHoc lophoc)
        {
            if (lopDAO.ThemLopHoc(lophoc))
            {
                this.list.Add(lophoc);
                return true;
            }
            return false;
        }
        public bool SuaLopHoc(LopHoc lophoc)
        {
            if(lopDAO.SuaLopHoc(lophoc))
            {
                foreach(LopHoc l in this.list)
                {
                    if(l.Malop.Equals(lophoc.Malop))
                    {
                        l.Tenlop = lophoc.Tenlop;
                        l.Mota = lophoc.Mota;
                        return true;
                    }
                }
            }
            return false;
        }
        
        public bool XoaLopHoc(string malop)
        {
            if(lopDAO.XoaLopHoc(malop))
            {
                foreach (LopHoc l in this.list)
                {
                    if (l.Malop.Equals(malop))
                    {
                        l.Daxoa = 1;
                        return true;
                    }
                }
            }
            return false;
        }

        public LopHoc GetLopHocByMaLop(string malophoc)
        {
            foreach (LopHoc lop in list)
            {
                if(lop.Malop.Equals(malophoc))
                    return lop;
            }
            return null;
        }

       public ArrayList GetLopHocByMaGiangVien(string magiangvien) { 
            ArrayList listResult = new ArrayList();
            foreach(LopHoc lopHoc in list)
            {
                if(lopHoc.Magiangvien == magiangvien)
                    listResult.Add(lopHoc);
            }
            return listResult;
       }
    }
}
