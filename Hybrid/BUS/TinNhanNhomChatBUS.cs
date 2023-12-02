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
    public class TinNhanNhomChatBUS
    {
        private ArrayList list;
        private TinNhanNhomChatDAO tnncDAO;
        public TinNhanNhomChatBUS()
        {
            tnncDAO = new TinNhanNhomChatDAO();
            //loadList();
        }

        public ArrayList getList()
        {
            return list;
        }

        public TinNhanNhomChat getLatest(string maLop)
        {
            return tnncDAO.getLatest(maLop);
        }

        public void loadList(int perMess, int mess_index_value, string maLopHoc)
        {
            list = tnncDAO.loadList(perMess, mess_index_value, maLopHoc);
            //list.Sort();
        }

        public void insert(string maTN, string maNhomChat, string matk, string message, string thoiGianGui)
        {
            tnncDAO.insert(maTN, maNhomChat, matk, message, thoiGianGui);
        }

        public void delete(string maTN)
        {
            tnncDAO.delete(maTN);
        }
    }
}
