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
    public class TinNhanBanBeBUS
    {
        private ArrayList list;
        private TinNhanBanBeDAO dao;
        public TinNhanBanBeBUS()
        {
            dao = new TinNhanBanBeDAO();
            //loadList();
        }

        public ArrayList getList()
        {
            return list;
        }

        public TinNhanBanBe getLatest(String currentID, String friendAccountID)
        {
            return dao.getLatest(currentID, friendAccountID);
        }
        public void loadList(int perMess, int mess_index_value, String currentID, String friendAccountID)
        {
            list = dao.loadList(perMess, mess_index_value, currentID, friendAccountID);
            //list.Sort();
        }

        public void insert(string maTN, String maNguoiGui, String maNguoiNhan, string message, string thoiGianGui)
        {
            dao.insert(maTN, maNguoiGui, maNguoiNhan, message, thoiGianGui);
        }

        public void delete(string maTN)
        {
            dao.delete(maTN);
        }
    }
}
