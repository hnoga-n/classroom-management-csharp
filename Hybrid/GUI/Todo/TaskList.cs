using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Todo
{
    public partial class TaskList : UserControl
    {
        private ArrayList tasks;

        public ArrayList Tasks { get => tasks; set => tasks = value; }

        public TaskList()
        {
            InitializeComponent();
        }
        public TaskList(ArrayList tasks)
        {
            InitializeComponent();
            this.Tasks = tasks;
        }

        public FlowLayoutPanel getTaskListPanel()
        {
            return this.taskListPanel;
        }

        public ComboBox GetComboBoxClass()
        {
            return this.cbbClass;
        }

        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.taskListPanel.Controls.Clear();
            object selectedItem = cbbClass.SelectedItem;
            string selectedValue = selectedItem.ToString();
            foreach(Control task in this.Tasks)
            {
                if (task is TaskHomework && (task as TaskHomework).getLabelClass().Text.Contains(selectedValue))
                {
                    taskListPanel.Controls.Add(task);
                    continue;
                } 
                if(task is TaskExam && (task as TaskExam).getLabelClass().Text.Contains(selectedValue))
                {
                    taskListPanel.Controls.Add(task);
                    continue;
                }
                else if(selectedValue.Contains("Tất cả"))
                {
                    taskListPanel.Controls.Add(task);
                }
            }
        }
    }
}
