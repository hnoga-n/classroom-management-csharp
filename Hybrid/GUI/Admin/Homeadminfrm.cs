using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Admin
{
    public partial class Homeadminfrm : Form
    {
        public Homeadminfrm()
        {
            InitializeComponent();
        }


        private void addFormtoPanelContainer(object Form)
        {
            if (this.pnlContainer.Controls.Count > 0)
                this.pnlContainer.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Controls.Add(this.btnMinimizeForm);
            f.Controls.Add(this.btnCloseForm);
            this.btnMinimizeForm.BringToFront();
            this.btnCloseForm.BringToFront();
            this.pnlContainer.Controls.Add(f);
            this.pnlContainer.Tag = f;
            f.Show();
        }



        private void btnContacts_Click_1(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new Userfrm());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            addFormtoPanelContainer(new Classfrm());
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
