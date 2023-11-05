﻿using Hybrid.Comparer;
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
            list.Sort();
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
    }
}
