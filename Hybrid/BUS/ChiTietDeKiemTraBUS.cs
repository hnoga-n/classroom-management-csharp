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
        public ArrayList GetDanhSachChiTietDeKiemTraWithMaDeKiemTra(string madekiemtra)
        {
            ArrayList listcauhoi = new ArrayList();
            foreach (ChiTietDeKiemTra item in list)
            {
                if (item.Madekiemtra.Equals(madekiemtra))
                    listcauhoi.Add(item);
            }
            ChiTietDeKiemTraComparer comparer = new ChiTietDeKiemTraComparer();
            comparer.TypeToCompare = ChiTietDeKiemTraComparer.ComparisonType.sothutu;
            listcauhoi.Sort(comparer);
            return listcauhoi;
        }

        public bool KiemTraCauHoiDaDuocSuDung(string macauhoi)
        {
            foreach(ChiTietDeKiemTra ctdkt in this.list)
            {
                if(ctdkt.Macauhoi.Equals(macauhoi))
                    return true;
            }
            return false;
        }
    }
}
