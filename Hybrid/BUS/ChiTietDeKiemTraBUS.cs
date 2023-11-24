﻿using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class ChiTietDeKiemTraBUS
    {
        private ArrayList list;
        private ChiTietDeKiemTraDAO ctdktDAO;
        public ChiTietDeKiemTraBUS()
        {
            ctdktDAO = new ChiTietDeKiemTraDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = ctdktDAO.loadList();
            //list.Sort();
        }

        public bool ThemChiTietDeKiemTra(ChiTietDeKiemTra ctdkt)
        {
            if(ctdktDAO.ThemChiTietDeKiemTra(ctdkt))
            {
                list.Add(ctdkt);
                return true;
            }
            return false;
        }
        public ArrayList getChiTietDeKiemTraWithMaDeKiemTra(string madekiemtra)
        {
            ArrayList listcauhoi = new ArrayList();
            foreach (ChiTietDeKiemTra item in list)
            {
                if (item.Madekiemtra.Equals(madekiemtra))
                    listcauhoi.Add(item);
            }
            return listcauhoi;
        }
        public ArrayList GetDanhSachChiTietDeKiemTraWithMaDeKiemTra(string madekiemtra)
        {
            ArrayList listcauhoi = new ArrayList();
            foreach (ChiTietDeKiemTra item in list)
            {
                if (item.Madekiemtra.Equals(madekiemtra))
                    listcauhoi.Add(item);
            }
            return listcauhoi;
        }
    }
}
