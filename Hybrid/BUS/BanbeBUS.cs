using Hybrid.DAO;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.BUS
{
    public class BanbeBUS
    {
        private ArrayList list;
        private BanbeDAO banbeDAO;
        DataTable dt = new DataTable();
        public BanbeBUS()
        {
            banbeDAO = new BanbeDAO();
            //loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        /* public void loadList()
         {
             list = banbeDAO.loadList();
             //list.Sort();
         }*/
        public DataTable LayAllBanBe()
        {
            dt = banbeDAO.LayAllBanBe();
            return dt;
        }
        public DataTable LayBanBeDeFind()
        {
            dt = banbeDAO.LayBanBeDeFind();
            return dt;
        }
        public Boolean XoaBanBe(String MaNguoiKetBan, String MaNguoiDuocKetBan)
        {
            if (banbeDAO.XoaBanBe(MaNguoiKetBan, MaNguoiDuocKetBan))
            {
                return true;
            }
            else { return false; }

        }
        public DataTable LayAllBanBeChuaKetBan(String str)
        {
            dt = banbeDAO.LayAllBanBeChuaKetBan(str);
            return dt;
        }
        public Boolean ChapNhanKetBan(BanBe bb)
        {
            if (banbeDAO.ChapNhanKetBan(bb))
            {
                return true;
            }
            else { return false; }

        }
        public Boolean GuiKetBan(BanBe bb)
        {
            if (banbeDAO.GuiKetban(bb))
            {
                return true;
            }
            else { return false; }

        }
    }
}
