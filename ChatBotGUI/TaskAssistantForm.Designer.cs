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
            txtInput = new TextBox();
            txtChat = new RichTextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(120, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 27);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 60);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 60);
            txtDescription.TabIndex = 1;
            // 
            // chkReminder
            // 
            chkReminder.Location = new Point(20, 140);
            chkReminder.Name = "chkReminder";
            chkReminder.Size = new Size(104, 24);
            chkReminder.TabIndex = 2;
            chkReminder.Text = "Set Reminder";
            chkReminder.CheckedChanged += chkReminder_CheckedChanged;
            // 
            // dateTimePickerReminder
            // 
            dateTimePickerReminder.Enabled = false;
            dateTimePickerReminder.Location = new Point(150, 140);
            dateTimePickerReminder.Name = "dateTimePickerReminder";
            dateTimePickerReminder.Size = new Size(220, 27);
            dateTimePickerReminder.TabIndex = 3;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(70, 184);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(100, 30);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Task";
            btnAddTask.Click += btnAddTask_Click;
            // 
            // lstTasks
            // 
            lstTasks.Location = new Point(20, 230);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(350, 104);
            lstTasks.TabIndex = 5;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.Location = new Point(20, 370);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(150, 30);
            btnMarkCompleted.TabIndex = 6;
            btnMarkCompleted.Text = "Mark Completed";
            btnMarkCompleted.Click += btnMarkCompleted_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Selected Task";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Task Title:";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 60);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(20, 420);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(250, 27);
            txtInput.TabIndex = 10;
            // 
            // txtChat
            // 
            txtChat.Location = new Point(400, 20);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(350, 330);
            txtChat.TabIndex = 11;
            txtChat.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(280, 418);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 34);
            btnSend.TabIndex = 12;
            btnSend.Text = "Send";
            btnSend.Click += btnSend_Click;
            // 
            // TaskAssistantForm
            // 
            ClientSize = new Size(780, 460);
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
            Controls.Add(txtInput);
            Controls.Add(txtChat);
            Controls.Add(btnSend);
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
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.Button btnSend;
    }
}
