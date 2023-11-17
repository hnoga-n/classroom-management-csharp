using ComponentFactory.Krypton.Toolkit;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Kiemtra
{
    public partial class CauhoiPanel : UserControl
    {
        private string macauhoi;
        private string madapanchon = null;
        private ArrayList listdapan;

        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Madapanchon { get => madapanchon; set => madapanchon = value; }

        public CauhoiPanel()
        {
            InitializeComponent();
        }
        public CauhoiPanel(CauHoi cauhoi, ArrayList listdapan, string dapandachon, bool congkhaidapan)
        {
            InitializeComponent();
            isEnable(true);
            this.Macauhoi = cauhoi.Macauhoi;
            this.listdapan = listdapan;
            this.question.Text = cauhoi.Noidung;
            // cautraloi
            this.answer1.Text = (listdapan[0] as CauTraLoi).Noidung;
            this.answer2.Text = (listdapan[1] as CauTraLoi).Noidung;
            this.answer3.Text = (listdapan[2] as CauTraLoi).Noidung;
            this.answer4.Text = (listdapan[3] as CauTraLoi).Noidung;
            if ((listdapan[0] as CauTraLoi).Macautraloi.Equals(dapandachon))
            {
                answer1.Checked = true;
            }
            else if ((listdapan[1] as CauTraLoi).Macautraloi.Equals(dapandachon))
            {
                answer2.Checked = true;
            }
            else if ((listdapan[2] as CauTraLoi).Macautraloi.Equals(dapandachon))
            {
                answer3.Checked = true;
            }
            else if ((listdapan[3] as CauTraLoi).Macautraloi.Equals(dapandachon))
            {
                answer4.Checked = true;
            }

            if (congkhaidapan)
            {
                isEnable(false);
                foreach (CauTraLoi ctl in listdapan)
                {
                    if (ctl.Ladapan == 1)
                    {
                        this.rightAnswer.Text = "Đáp án: "+ ctl.Noidung;
                        if (ctl.Macautraloi.Equals(dapandachon))
                            this.rightAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                        else
                            this.rightAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        return;
                    }

                }
            }
        }

        private void isEnable(bool val)
        {
            this.answer1.Enabled = val;
            this.answer2.Enabled = val;
            this.answer3.Enabled = val;
            this.answer4.Enabled = val;
            this.rightAnswer.Visible = !val;
        }
        public Label getOrder()
        {
            return this.order;
        }
        public KryptonRichTextBox getQuestionTextBox()
        {
            return this.question;
        }
        public RadioButton getAnswer1Radbtn()
        {
            return this.answer1;
        }
        public RadioButton getAnswer2Radbtn()
        {
            return this.answer2;
        }
        public RadioButton getAnswer3Radbtn()
        {
            return this.answer3;
        }
        public RadioButton getAnswer4Radbtn()
        {
            return this.answer4;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "answer1":
                    this.madapanchon = (this.listdapan[0] as CauTraLoi).Macautraloi;
                    break;
                case "answer2":
                    this.madapanchon = (this.listdapan[1] as CauTraLoi).Macautraloi;
                    break;
                case "answer3":
                    this.madapanchon = (this.listdapan[2] as CauTraLoi).Macautraloi;
                    break;
                case "answer4":
                    this.madapanchon = (this.listdapan[3] as CauTraLoi).Macautraloi;
                    break;
            }
        }
    }
}
