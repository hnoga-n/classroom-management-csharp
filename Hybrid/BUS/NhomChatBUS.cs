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
    public class NhomChatBUS
    {
        private ArrayList list;
        private NhomChatDAO nhomchatDAO;
        public NhomChatBUS()
        {
            nhomchatDAO = new NhomChatDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = nhomchatDAO.loadList();
            //list.Sort();
        }

        public bool ThemNhomChat(NhomChat nhomchat)
        {
            if(nhomchatDAO.ThemNhomChat(nhomchat))
            {
                list.Add(nhomchat);
                return true;
            }
            return false;
        }

        public NhomChat GetNhomChatByMaLop(string maLop)
        {
            return nhomchatDAO.GetNhomChatByMaLop(maLop);
        }

    
    }
}
