using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid.DTO
{
    public class TinNhanNhomChat
    {
        private string matinnhan;
        private string manhomchat;
        private string mataikhoan;
        private string noidung;
        private DateTime thoigiangui;
        private int antinnhan;

        public TinNhanNhomChat() { }

        public TinNhanNhomChat(string matinnhan, string manhomchat, string mataikhoan, string noidung, DateTime thoigiangui, int antinnhan)
        {
            this.matinnhan = matinnhan;
            this.manhomchat = manhomchat;
            this.mataikhoan = mataikhoan;
            this.noidung = noidung;
            this.thoigiangui = thoigiangui;
            this.antinnhan = antinnhan;
        }

        public string Matinnhan { get => matinnhan; set => matinnhan = value; }
        public string Manhomchat { get => manhomchat; set => manhomchat = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public DateTime Thoigiangui { get => thoigiangui; set => thoigiangui = value; }
        public int Antinnhan { get => antinnhan; set => antinnhan = value; }

        public override string ToString()
        {
            return $"Mã tin nhắn: {matinnhan}\n" +
                   $"Mã nhóm chat: {manhomchat}\n" +
                   $"Mã tài khoản: {mataikhoan}\n" +
                   $"Nội dung: {noidung}\n" +
                   $"Thời gian gửi: {thoigiangui}\n" +
                   $"Ẩn tin nhắn: {antinnhan}";
        }
    }
}
