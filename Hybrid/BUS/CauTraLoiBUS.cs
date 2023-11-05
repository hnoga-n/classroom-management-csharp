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
            //list.Sort();
        }

        public void ThemCauTraLoi(CauTraLoi cautraloi)
        {
            this.list.Add(cautraloi);
            cautlDAO.ThemCauTraLoi(cautraloi);
        }

        /*public void XoaCauTraLoi(CauTraLoi cautraloi)
        {
            this.list.Remove(cautraloi);
            cautlDAO.XoaCauTraLoi(cautraloi.Macautraloi);
        }*/

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
