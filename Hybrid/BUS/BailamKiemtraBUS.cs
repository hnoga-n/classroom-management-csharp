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
    public class BailamKiemtraBUS
    {
        private ArrayList list;
        private BailamKiemtraDAO blktDAO;

        public ArrayList List { get => list; set => list = value; }

        public BailamKiemtraBUS()
        {
            blktDAO = new BailamKiemtraDAO();
            loadList();
        }
        public void loadList()
        {
            List = blktDAO.loadList();
        }
        public bool addBaiLam(BaiLamKiemTra bldkt)
        {
            if (blktDAO.addBaiLamKiemTra(bldkt) == 0)
                return false;
            else
            {
                List.Add(bldkt);
                return true;
            }
        }
        public int getBaiLamKiemTraWithMaBaiLam(string mabailam)
        {
            
            BailamkiemtraComparer comparer = new BailamkiemtraComparer();
            comparer.TypeToCompare = BailamkiemtraComparer.ComparisonType.mabailam;
            BaiLamKiemTra blktSearch = new BaiLamKiemTra();
            blktSearch.Mabailam = mabailam;
            List.Sort(comparer);
            int index = List.BinarySearch(blktSearch, comparer);
            return index;
        }

        public int getBaiLamKiemTraWithMaTaiKhoanAndMaDeKiemTra(string mataikhoan,string madekiemtra)
        {
            int index = 0;
            foreach (BaiLamKiemTra blkt in List)
            {
                if (blkt.Mataikhoan.Equals(mataikhoan) && blkt.Madekiemtra.Equals(madekiemtra))
                    return index;
                else
                    index++;
            }
            return -1;
        }
        public int isSubmited(string mataikhoan,string madekiemtra)
        {
            foreach(BaiLamKiemTra blkt in List)
            {
                if (blkt.Mataikhoan.Equals(mataikhoan) && blkt.Madekiemtra.Equals(madekiemtra))
                    return 1;
            }
            return 0;
        }

    }
}
