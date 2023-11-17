using ComponentFactory.Krypton.Toolkit;
using Hybrid.BUS;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hybrid.GUI.Todo
{
    public partial class TodoFrm : Form
    {
        private bool flagBtnClicked ;
        private Taikhoan taikhoanhienhanh;
        private BaiTapBUS btBUS;
        private BailambaitapBUS blbtBUS;
        private BailamKiemtraBUS blktBUS;
        private DeKiemTraBUS ktBUS;
        private ChuongBUS chuongBUS;
        private LopHocBUS lopHocBUS;
        private TaskNotDoneButton btnNot ;
        private TaskDoneButton btnDone ;

        public TodoFrm()
        {
            InitializeComponent();
        }
        public TodoFrm(Taikhoan taikhoanhienhanh, BaiTapBUS btBUS,BailambaitapBUS blbtBUS, DeKiemTraBUS dktBUS,BailamKiemtraBUS blktBUS)
        {
            InitializeComponent();
            this.flagBtnClicked = false;
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.lopHocBUS = new LopHocBUS();
            this.chuongBUS = new ChuongBUS() ;
            this.blbtBUS = blbtBUS;
            this.blktBUS = blktBUS;
            this.btBUS = btBUS;
            this.ktBUS = dktBUS;
            loadButton();
        }

        private void loadButton()
        {
            btnNot = new TaskNotDoneButton();
            btnDone = new TaskDoneButton();
            btnNot.btnNotDone().Click += new System.EventHandler(this.btnChuaxuly_Click);
            btnDone.getBtnDone().Click += new System.EventHandler(this.btnDaxuly_Click);
            leftFlowPanel.Controls.Add(btnNot);
            leftFlowPanel.Controls.Add(btnDone);
        }

        private void btnChuaxuly_Click(object sender, EventArgs e)
        {
            flagBtnClicked = true;
            this.rightFlowPanel.Controls.Clear();
            TaskList taskPanel = new TaskList();
            ArrayList taskList = new ArrayList();
            if (btBUS.getList().Count != 0)
            {
                foreach (BaiTap bt in btBUS.getList())
                {
                    //if (blbtBUS.getBaiLamBaiTapWithMaBaiTap(bt.Mabaitap) <0)
                    {
                        TaskHomework hw = new TaskHomework(bt);
                        Chuong chuongcuabaitap = chuongBUS.getChuongWithMaChuong(bt.Machuong);
                        LopHoc lophoccuabaitap = this.lopHocBUS.getLophocWithMaLop(chuongcuabaitap.Malop);
                        hw.getLabelClass().Text = lophoccuabaitap.Tenlop;
                        taskPanel.getTaskListPanel().Controls.Add(hw);
                        taskList.Add(hw);
                        if (!taskPanel.GetComboBoxClass().Items.Contains(lophoccuabaitap.Tenlop))
                            taskPanel.GetComboBoxClass().Items.Add(lophoccuabaitap.Tenlop);
                    }
                }
            }
            if (ktBUS.getList().Count != 0)
            { 
                foreach (DeKiemTra dekt in ktBUS.getList())
                {
                    //if (dekt.Dahoanthanh == 0)
                    {
                        TaskExam ex = new TaskExam(dekt);
                        Chuong chuongcuadkt = chuongBUS.getChuongWithMaChuong(dekt.Machuong);
                        ex.getLabelClass().Text = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop).Tenlop;
                        LopHoc lophoccuabaikt = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop);
                        taskPanel.getTaskListPanel().Controls.Add(ex);
                        taskList.Add(ex);
                        if (!taskPanel.GetComboBoxClass().Items.Contains(lophoccuabaikt.Tenlop))
                            taskPanel.GetComboBoxClass().Items.Add(lophoccuabaikt.Tenlop);
                    }
                }
            }
            if (taskPanel.getTaskListPanel().Controls.Count > 0)
            {
                taskPanel.Tasks = taskList;
                taskPanel.GetComboBoxClass().Items.Add("Tất cả");
                taskPanel.GetComboBoxClass().SelectedIndex = taskPanel.GetComboBoxClass().Items.Count - 1;
            }
            else
            {
                TaskEmpty emptPanel = new TaskEmpty("Tuyệt vời !", "Hãy tận hưởng cuộc sống không có deadline, dù chỉ là vài giờ <3, hoặc vài phút....");
                this.rightFlowPanel.Controls.Add(emptPanel);
                return;
            }
            this.rightFlowPanel.Controls.Add(taskPanel);
        }

        private void btnDaxuly_Click(object sender, EventArgs e)
        {
            flagBtnClicked = false;
            rightFlowPanel.Controls.Clear();
            ArrayList taskList = new ArrayList();
            TaskList taskPanel = new TaskList();
            if (btBUS.getList().Count != 0)
            {
                foreach (BaiTap bt in btBUS.getList())
                {
                    //if (bt.Dahoanthanh == 1)
                    {
                        TaskHomework hw = new TaskHomework(bt);
                        Chuong chuongcuabaitap = chuongBUS.getChuongWithMaChuong(bt.Machuong);
                        LopHoc lophoccuabaitap = this.lopHocBUS.getLophocWithMaLop(chuongcuabaitap.Malop);
                        hw.getLabelClass().Text = lophoccuabaitap.Tenlop;
                        taskList.Add(hw);
                        taskPanel.getTaskListPanel().Controls.Add(hw);
                        if (!taskPanel.GetComboBoxClass().Items.Contains(lophoccuabaitap.Tenlop))
                            taskPanel.GetComboBoxClass().Items.Add(lophoccuabaitap.Tenlop);
                    }
                }
            }
            if (ktBUS.getList().Count != 0)
            {
                foreach (DeKiemTra dekt in ktBUS.getList())
                {
                    //if (dekt.Dahoanthanh == 1)
                    {
                        TaskExam ex = new TaskExam(dekt);
                        Chuong chuongcuadkt = chuongBUS.getChuongWithMaChuong(dekt.Machuong);
                        ex.getLabelClass().Text = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop).Tenlop;
                        LopHoc lophoccuabaikt = this.lopHocBUS.getLophocWithMaLop(chuongcuadkt.Malop);
                        taskList.Add(ex);
                        taskPanel.getTaskListPanel().Controls.Add(ex);
                        if (!taskPanel.GetComboBoxClass().Items.Contains(lophoccuabaikt.Tenlop))
                            taskPanel.GetComboBoxClass().Items.Add(lophoccuabaikt.Tenlop);
                    }
                }
            }
            if (taskPanel.getTaskListPanel().Controls.Count > 0)
            {
                taskPanel.Tasks = taskList;
                taskPanel.GetComboBoxClass().Items.Add("Tất cả");
                taskPanel.GetComboBoxClass().SelectedIndex = taskPanel.GetComboBoxClass().Items.Count - 1;
                this.rightFlowPanel.Controls.Add(taskPanel);
            }
            else
            {
                TaskEmpty emptPanel = new TaskEmpty("Hmmm...", "Có vẻ bạn chưa hoàn thành công việc nào, hãy làm nó trước khi hết hạn nào!");
                this.rightFlowPanel.Controls.Add(emptPanel);
                return;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.btBUS.loadList();
            this.ktBUS.loadList() ;
            this.chuongBUS.loadList();
            this.lopHocBUS.loadList();
            if (flagBtnClicked)
                this.btnNot.btnNotDone().PerformClick();
            else
                this.btnDone.getBtnDone().PerformClick();
        }
    }

}
