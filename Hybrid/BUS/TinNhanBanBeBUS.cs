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
        private TinNhanBanBeDAO tnbbDAO;
        public TinNhanBanBeBUS()
        {
            tnbbDAO = new TinNhanBanBeDAO();
            //loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        /*public void loadList()
        {
            list = tnbbDAO.loadList();
            list.Sort();
        }*/
        public List<TinNhanBanBe> GetList(string u, string f)
        {
            List<TinNhanBanBe> list = tnbbDAO.GetList(u, f);
            return list;
        }

        public void AddMessage(string g, string n, string nd)
        {
            if (nd != "" || nd != "\n")
            tnbbDAO.AddMessage(g, n, nd);
        }

        public void UnFriendMessage(BanBe a)
        {
            tnbbDAO.UnFriendMessage(a);
        }
    }
}
