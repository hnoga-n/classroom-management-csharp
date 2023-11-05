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
    public class LopHocBUS
    {
        private ArrayList list;
        private LopHocDAO lopDAO;
        public LopHocBUS()
        {
            lopDAO = new LopHocDAO();
            list = lopDAO.loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = lopDAO.loadList();
        }

        public LopHoc getLophocWithMaLop(string malop)
        {
            LophocComparer comparer = new LophocComparer();
            comparer.TypeToCompare = LophocComparer.ComparisonType.malophoc;
            LopHoc lopSearch = new LopHoc();
            lopSearch.Malop= malop.ToLower();
            int index = list.BinarySearch(lopSearch, comparer);
            return (LopHoc) list[index];
        }

         

        public bool ThemLopHoc(LopHoc lophoc)
        {
            if (lophoc == null)
            {
                MessageBox.Show("Thông tin lớp học không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            this.list.Add(lophoc);
            lopDAO.ThemLopHoc(lophoc);
            return true;
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
