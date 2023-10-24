using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Hybrid.GUI;
using Hybrid.GUI.Danhba;
using Hybrid.GUI.Home;
using Hybrid.GUI.Todo;
using Hybrid.GUI.LichHoc;

namespace Hybrid
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addFormtoPanelContainer(object Form)
        {
            if(this.pnlContainer.Controls.Count > 0)
                this.pnlContainer.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(f);
            this.pnlContainer.Tag = f;
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new HomeFrm());
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new TodoFrm());
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new DanhbaFrm());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new Calendar());
        }
    }
}
