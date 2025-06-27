using ChatBotGUI;

namespace ChatBotGUI
{
    partial class TaskAssistantForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            chkReminder = new CheckBox();
            dateTimePickerReminder = new DateTimePicker();
            btnAddTask = new Button();
            lstTasks = new ListBox();
            btnMarkCompleted = new Button();
            btnDelete = new Button();
            lblTitle = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(252, 17);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 27);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(252, 66);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 60);
            txtDescription.TabIndex = 1;
            // 
            // chkReminder
            // 
            chkReminder.Location = new Point(142, 140);
            chkReminder.Name = "chkReminder";
            chkReminder.Size = new Size(104, 24);
            chkReminder.TabIndex = 2;
            chkReminder.Text = "Set Reminder";
            chkReminder.CheckedChanged += chkReminder_CheckedChanged;
            // 
            // dateTimePickerReminder
            // 
            dateTimePickerReminder.Enabled = false;
            dateTimePickerReminder.Location = new Point(252, 140);
            dateTimePickerReminder.Name = "dateTimePickerReminder";
            dateTimePickerReminder.Size = new Size(220, 27);
            dateTimePickerReminder.TabIndex = 3;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(177, 193);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(100, 30);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Task";
            btnAddTask.Click += btnAddTask_Click;
            // 
            // lstTasks
            // 
            lstTasks.Location = new Point(122, 241);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(350, 104);
            lstTasks.TabIndex = 5;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.Location = new Point(41, 370);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(150, 30);
            btnMarkCompleted.TabIndex = 6;
            btnMarkCompleted.Text = "Mark Completed";
            btnMarkCompleted.Click += btnMarkCompleted_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Selected Task";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(91, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Task Title:";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(91, 69);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // TaskAssistantForm
            // 
            ClientSize = new Size(657, 460);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(chkReminder);
            Controls.Add(dateTimePickerReminder);
            Controls.Add(btnAddTask);
            Controls.Add(lstTasks);
            Controls.Add(btnMarkCompleted);
            Controls.Add(btnDelete);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Name = "TaskAssistantForm";
            Text = "Cybersecurity Task Assistant";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkReminder;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
    }
}
