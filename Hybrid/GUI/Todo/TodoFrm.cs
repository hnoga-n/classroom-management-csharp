﻿using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DAO;
using Hybrid.DTO;
using Hybrid.GUI.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hybrid.GUI.Todo
{
    public partial class TodoFrm : Form
    {
        private bool flagBtnClicked;
        private Taikhoan taikhoanhienhanh;
        private BaiTapBUS btBUS;
        private BailambaitapBUS blbtBUS;
        private BailamKiemtraBUS blktBUS;
        private DeKiemTraBUS ktBUS;
        private ChuongBUS chuongBUS;
        private LopHocBUS lopHocBUS;
        private TaskNotDoneButton btnNot;
        private TaskDoneButton btnDone;
        private ArrayList listClass;
        private ArrayList baitapDxl;
        private ArrayList baitapCxl;
        private ArrayList kiemtraDxl;
        private ArrayList kiemtraCxl;


        public TodoFrm()
        {
            InitializeComponent();
        }
        public TodoFrm(Taikhoan taikhoanhienhanh, BaiTapBUS btBUS, LopHocBUS lopHocBUS, DeKiemTraBUS dktBUS, ChuongBUS chuongBUS, BailambaitapBUS blbtBUS, BailamKiemtraBUS blktBUS)
        {
            InitializeComponent();
            this.flagBtnClicked = false;
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.btBUS = btBUS;
            this.ktBUS = dktBUS;
            this.lopHocBUS = lopHocBUS;
            this.chuongBUS = chuongBUS;
            this.blbtBUS = blbtBUS;
            this.blktBUS = blktBUS;
        }

        private void TodoFrm_Load(object sender, EventArgs e)
        {
            btnNot = new TaskNotDoneButton();
            btnDone = new TaskDoneButton();
            baitapDxl = new ArrayList();
            baitapCxl = new ArrayList();
            kiemtraDxl = new ArrayList();
            kiemtraCxl = new ArrayList();
            listClass = lopHocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(this.taikhoanhienhanh.Mataikhoan);
            LoadList();
            btnNot.btnNotDone().Click += new System.EventHandler(this.btnChuaxuly_Click);
            btnDone.getBtnDone().Click += new System.EventHandler(this.btnDaxuly_Click);
            leftFlowPanel.Controls.Add(btnNot);
            leftFlowPanel.Controls.Add(btnDone);
            this.btnNot.btnNotDone().PerformClick();
        }

        private void LoadList()
        {
            baitapDxl.Clear();
            baitapCxl.Clear();
            kiemtraDxl.Clear();
            kiemtraCxl.Clear();
            foreach (LopHoc lh in listClass)
            {
                baitapDxl.AddRange(btBUS.GetTatCaBaiTapDaNopByMaLopHoc(lh.Malop,this.taikhoanhienhanh.Mataikhoan));
                baitapCxl.AddRange(btBUS.GetTatCaBaiTapChuaNopByMaLopHoc(lh.Malop));
                kiemtraDxl.AddRange(ktBUS.GetTatCaBaiKiemTraDaNopByMaLopHoc(lh.Malop,this.taikhoanhienhanh.Mataikhoan));
                kiemtraCxl.AddRange(ktBUS.GetTatCaBaiKiemTraChuaNopByMaLopHoc(lh.Malop));
            }
        }
        private void btnChuaxuly_Click(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            flagBtnClicked = true;
            this.rightFlowPanel.Controls.Clear();
            TaskList taskListPanel = new TaskList();
            if (baitapCxl.Count != 0)
            {
                foreach (BaiTap bt in this.baitapCxl)
                {
                    Chuong chuongcuabaitap = chuongBUS.getChuongWithMaChuong(bt.Machuong);
                    LopHoc lophoccuabaitap = this.lopHocBUS.getLophocWithMaLop(chuongcuabaitap.Malop);
                    TaskHomework hw = new TaskHomework(this.taikhoanhienhanh, bt, lophoccuabaitap, chuongcuabaitap,blbtBUS);
                    taskListPanel.getTaskListPanel().Controls.Add(hw);
                    taskListPanel.Tasks.Add(hw);
                }
            }

            if (kiemtraCxl.Count != 0)
            {
                foreach (DeKiemTra dekt in this.kiemtraCxl)
                {
                    Chuong chuongcuadkt = chuongBUS.getChuongWithMaChuong(dekt.Machuong);
                    LopHoc lophoccuabaikt = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop);
                    TaskExam ex = new TaskExam(this.taikhoanhienhanh, dekt, lophoccuabaikt, chuongcuadkt,blktBUS);
                    ex.getLabelClass().Text = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop).Tenlop;
                    taskListPanel.getTaskListPanel().Controls.Add(ex);
                    taskListPanel.Tasks.Add(ex);
                }
            }
            loading.CloseForm();
            if (taskListPanel.getTaskListPanel().Controls.Count <= 0)
            {
                TaskEmpty emptPanel = new TaskEmpty("Tuyệt vời !", "Hãy tận hưởng cuộc sống không có deadline, dù chỉ là vài giờ <3, hoặc vài phút....");
                this.rightFlowPanel.Controls.Add(emptPanel);
                return;
            }
            this.rightFlowPanel.Controls.Add(taskListPanel);
            
        }


        private void btnDaxuly_Click(object sender, EventArgs e)
        {
            loading.ShowSplashScreen();
            flagBtnClicked = false;
            this.rightFlowPanel.Controls.Clear();
            TaskList taskListPanel = new TaskList();
            if (baitapDxl.Count != 0)
            {
                foreach (BaiTap bt in this.baitapDxl)
                {
                    Chuong chuongcuabaitap = chuongBUS.getChuongWithMaChuong(bt.Machuong);
                    LopHoc lophoccuabaitap = this.lopHocBUS.getLophocWithMaLop(chuongcuabaitap.Malop);
                    TaskHomework hw = new TaskHomework(this.taikhoanhienhanh, bt, lophoccuabaitap, chuongcuabaitap, blbtBUS);
                    taskListPanel.getTaskListPanel().Controls.Add(hw);
                    taskListPanel.Tasks.Add(hw);
                }
            }

            if (kiemtraDxl.Count != 0)
            {
                foreach (DeKiemTra dekt in this.kiemtraDxl)
                {
                    Chuong chuongcuadkt = chuongBUS.getChuongWithMaChuong(dekt.Machuong);
                    LopHoc lophoccuabaikt = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop);
                    TaskExam ex = new TaskExam(this.taikhoanhienhanh,dekt,lophoccuabaikt,chuongcuadkt, blktBUS);
                    ex.getLabelClass().Text = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop).Tenlop;
                    taskListPanel.getTaskListPanel().Controls.Add(ex);
                    taskListPanel.Tasks.Add(ex);
                }
            }
            loading.CloseForm();
            if (taskListPanel.getTaskListPanel().Controls.Count <= 0)
            {
                TaskEmpty emptPanel = new TaskEmpty("Hmmm...", "Có vẻ bạn chưa hoàn thành công việc nào, nhanh tay hoàn thành trước khi hết hạn nào!");
                this.rightFlowPanel.Controls.Add(emptPanel);
                return;
            }
            this.rightFlowPanel.Controls.Add(taskListPanel);
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            LoadList();
            if (flagBtnClicked)
                this.btnNot.btnNotDone().PerformClick();
            else
                this.btnDone.getBtnDone().PerformClick();
        }
    }

}
