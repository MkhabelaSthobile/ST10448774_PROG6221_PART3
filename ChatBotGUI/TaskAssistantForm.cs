using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatBotGUI
{
    public partial class TaskAssistantForm : Form
    {
        private List<CyberTask> tasks = new List<CyberTask>();

        public TaskAssistantForm()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string desc = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            CyberTask newTask = new CyberTask()
            {
                Title = title,
                Description = desc,
                Reminder = chkReminder.Checked ? dateTimePickerReminder.Value.Date : (DateTime?)null,
                IsCompleted = false
            };

            tasks.Add(newTask);
            UpdateTaskList();

            txtTitle.Clear();
            txtDescription.Clear();
            chkReminder.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex < 0)
            {
                MessageBox.Show("Select a task to delete.");
                return;
            }

            tasks.RemoveAt(lstTasks.SelectedIndex);
            UpdateTaskList();
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex < 0)
            {
                MessageBox.Show("Select a task to mark as completed.");
                return;
            }

            tasks[lstTasks.SelectedIndex].IsCompleted = true;
            UpdateTaskList();
        }

        private void chkReminder_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerReminder.Enabled = chkReminder.Checked;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Placeholder for chatbot integration logic (if needed)
        }

        private void UpdateTaskList()
        {
            lstTasks.Items.Clear();
            foreach (var task in tasks)
            {
                lstTasks.Items.Add(task.ToString());
            }
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
