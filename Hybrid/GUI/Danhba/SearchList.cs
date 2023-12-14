using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Hybrid.DTO;

namespace Hybrid.GUI.Danhba
{
    public partial class SearchList : UserControl
    {
        private string mataikhoan;
        private string mauser;
        private string mabanbe;
        private BanBe a;
        private ItemList sender;

        public event EventHandler btChapNhan;
        public event EventHandler btTN;


        public SearchList(List<Taikhoan> tk, string matk)
        {
            InitializeComponent();
            mataikhoan = matk;
            loadData(tk);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadData(List<Taikhoan> tk)
        {
            foreach (Taikhoan t in tk)
            {
                if (t.Mataikhoan != mataikhoan)
                {
                    ItemList itemList = new ItemList(t, mataikhoan);
                    itemList.Update += Update;
                    itemList.TN += TN;
                    
                  

                    flowLayoutPanel1.Controls.Add(itemList);
                }
            }
        }

        private void TN(object sender, EventArgs e)
        {
            ItemList click = sender as ItemList;
            a = click.dto();
            btTN?.Invoke(this, EventArgs.Empty);

        }

        private void Update(object sender, EventArgs e)
        {
            btChapNhan?.Invoke(this, EventArgs.Empty);
        }

        public BanBe dto()
        {
            return a;
        }
    }
}
