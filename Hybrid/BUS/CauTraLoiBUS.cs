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
    public class CauTraLoiBUS
    {
        private ArrayList list;
        private CauTraLoiDAO cautlDAO;
        public CauTraLoiBUS()
        {
            cautlDAO = new CauTraLoiDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = cautlDAO.loadList();
            list.Sort();
        }
        public ArrayList getCauTraLoiWithMaCauHoi(string macauhoi)
        {
            ArrayList listcautraloi = new ArrayList();
            foreach (CauTraLoi item in list)
            {
                if (item.Macauhoi.Equals(macauhoi))
                    listcautraloi.Add(item);
            }
            return listcautraloi;
        }
        public CauTraLoi getCauTraLoiWithMaCauTraLoi(string macautraloi)
        {
            CautraloiComparer comparer = new CautraloiComparer();
            comparer.TypeToCompare = CautraloiComparer.ComparisonType.macautraloi;
            CauTraLoi cauTraLoi = new CauTraLoi();
            cauTraLoi.Macautraloi = macautraloi;
            int index = list.BinarySearch(cauTraLoi, comparer);
            return (CauTraLoi)list[index];
        }
        public void ThemCauTraLoi(CauTraLoi cautraloi)
        {
            this.list.Add(cautraloi);
            cautlDAO.ThemCauTraLoi(cautraloi);
        }

        public bool SuaCauTraLoi(CauTraLoi cautraloi)
        {
            if(cautlDAO.SuaCauTraLoi(cautraloi)) {
                foreach(CauTraLoi ctl in this.list)
                {
                    if(ctl.Macautraloi.Equals(cautraloi.Macautraloi))
                    {
                        ctl.Noidung = cautraloi.Noidung;
                        ctl.Ladapan = cautraloi.Ladapan;
                        break;
                    }
                }
                return true;
            } else 
                return false;
        }

        public ArrayList GetDanhSachCauTraLoiByMaCauHoi(string macauhoi)
        {
            ArrayList resultList = new ArrayList();
            foreach(CauTraLoi ctl in this.list)
            {
                if(ctl.Macauhoi.Equals(macauhoi))
                    resultList.Add(ctl);
            }
            return resultList;
        }
    }
}
