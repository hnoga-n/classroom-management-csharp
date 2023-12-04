using System;
using System.Collections;
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

    }
}
