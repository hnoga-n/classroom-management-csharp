using Hybrid.Comparer;
using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;

namespace Hybrid.BUS
{
    public class DeKiemTraBUS
    {
        private ArrayList list;
        private DeKiemTraDAO dektDAO;
        public DeKiemTraBUS()
        {
            dektDAO = new DeKiemTraDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = dektDAO.loadList();
            //list.Sort();
        }

        //public Chuong getChuongWithMaChuong(string machuong)
        //{
        //    ChuongComparer comparer = new ChuongComparer();
        //    comparer.TypeToCompare = ChuongComparer.ComparisonType.machuong;
        //    Chuong chuongSearch = new Chuong();
        //    chuongSearch.Machuong = machuong.ToLower();
        //    int index = list.BinarySearch(chuongSearch, comparer);
        //    return (Chuong)list[index];
        //}
        //public ArrayList getChuongWithMaLop(string malop)
        //{
        //    ArrayList listchuong = new ArrayList();
        //    foreach (Chuong ch in list)
        //    {
        //        if (ch.Malop.Equals(malop))
        //            listchuong.Add(ch);
        //    }
        //    return listchuong;
        //}

        public DeKiemTra GetDeKiemTraByMaDe(string made)
        {
            foreach (DeKiemTra dkt in this.list)
            {
                if (dkt.Madekiemtra.Equals(made))
                    return dkt;
            }
            return null;
        }

        public bool ThemDeKiemTra(DeKiemTra dekiemtra)
        {
            if( dekiemtra == null ) return false;
            if(dektDAO.ThemDeKiemTra(dekiemtra))
            {
                this.list.Add( dekiemtra );
                return true;
            }
            return false;
        }

        public bool SuaDeKiemTra(DeKiemTra dkt)
        {
            if(dektDAO.SuaDeKiemTra(dkt))
            {
                foreach(DeKiemTra d in this.list)
                {
                    if(d.Madekiemtra.Equals(dkt.Madekiemtra))
                    {
                        d.Thoigianbatdau = dkt.Thoigianbatdau;
                        d.Thoigianketthuc = dkt.Thoigianketthuc;
                        break;
                    }
                }
                return true;
            } else 
                return false;
        }
        public bool XoaDeKiemTra(DeKiemTra dekiemtra)
        {
            if (dektDAO.XoaDeKiemTra(dekiemtra))
            {
                foreach(DeKiemTra dkt in this.list)
                {
                    if(dkt.Madekiemtra.Equals(dekiemtra.Madekiemtra))
                    {
                        dkt.Daxoa = 1;
                        return true;
                    }

                }
                return false;
            }
            else
                return false;
        }

        public ArrayList GetDanhSachDeKiemTraTheoMaChuong(string machuong,string tukhoa = "")
        {
            ArrayList rslist = new ArrayList();
            foreach(DeKiemTra dkt in this.list)
            {
                if(dkt.Machuong.Equals(machuong) && dkt.Tieude.ToLower().Contains(tukhoa.ToLower()) && dkt.Daxoa == 0)
                    rslist.Add( dkt );  
            }
            return rslist;
        }

        public ArrayList GetTatCaBaiKiemTraDaNopByMaLopHoc(string malophoc)
        {
            return dektDAO.GetTatCaBaiKiemTraDaNopByMaLopHoc(malophoc);
        }
        public ArrayList GetTatCaBaiKiemTraChuaNopByMaLopHoc(string malophoc)
        {
            return dektDAO.GetTatCaBaiKiemTraChuaNopByMaLopHoc(malophoc);

        }
    }
}
