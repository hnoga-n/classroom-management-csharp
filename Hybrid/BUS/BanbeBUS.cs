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
        }

        public List<BanBe> GetList()
        {
            List<BanBe> list = banbeDAO.GetList();
            return list;
        }

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
        public void SuaTrangThai(BanBe banbe)
        {
            banbeDAO.SuaTrangThai(banbe);
        }

        public void ThemLoiMoi(BanBe banbe)
        {
            banbeDAO.ThemLoiMoi(banbe);
        }

        public void XoaLoiMoi(BanBe banbe)
        {
            banbeDAO.XoaLoiMoi(banbe);
        }

        public List<Taikhoan> TimKiem(string a)
        {
            List<Taikhoan> list = banbeDAO.TimKiem(a);
            return list;
        }

        public void XoaBan(BanBe a)
        {
            banbeDAO.XoaBan(a);
        }

        public void LoiMoiSauXoaBan(BanBe a)
        {
            banbeDAO.LoiMoiSauXoaBan(a);
        }
    }
}
