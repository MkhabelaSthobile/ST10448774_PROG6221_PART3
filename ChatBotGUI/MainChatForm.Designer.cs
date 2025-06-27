namespace ChatBotGUI
{
    partial class MainChatForm
    {
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button btnShowLog;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            chatPanel = new Panel();
            panelInput = new Panel();
            txtInput = new TextBox();
            btnSend = new Button();
            btnShowLog = new Button();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // chatPanel
            // 
            chatPanel.AutoScroll = true;
            chatPanel.BackColor = Color.FromArgb(30, 30, 30);
            chatPanel.Dock = DockStyle.Fill;
            chatPanel.Location = new Point(0, 0);
            chatPanel.Margin = new Padding(4, 5, 4, 5);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(640, 561);
            chatPanel.TabIndex = 0;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.Black;
            panelInput.Controls.Add(txtInput);
            panelInput.Controls.Add(btnSend);
            panelInput.Controls.Add(btnShowLog);
            panelInput.Dock = DockStyle.Bottom;
            panelInput.Location = new Point(0, 561);
            panelInput.Name = "panelInput";
            panelInput.Padding = new Padding(10, 5, 10, 5);
            panelInput.Size = new Size(640, 70);
            panelInput.TabIndex = 1;
            panelInput.Paint += panelInput_Paint;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.BackColor = Color.WhiteSmoke;
            txtInput.Font = new Font("Segoe UI", 10F);
            txtInput.Location = new Point(10, 10);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(383, 30);
            txtInput.TabIndex = 0;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.BackColor = Color.DodgerBlue;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 9F);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(400, 8);
            btnSend.Margin = new Padding(4, 5, 4, 5);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 30);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnShowLog
            // 
            btnShowLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShowLog.BackColor = Color.Gray;
            btnShowLog.ForeColor = Color.White;
            btnShowLog.Location = new Point(510, 8);
            btnShowLog.Name = "btnShowLog";
            btnShowLog.Size = new Size(120, 30);
            btnShowLog.TabIndex = 2;
            btnShowLog.Text = "Show Activity Log";
            btnShowLog.UseVisualStyleBackColor = false;
            btnShowLog.Click += btnShowLog_Click;
            // 
            // MainChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(640, 631);
            Controls.Add(chatPanel);
            Controls.Add(panelInput);
            MinimumSize = new Size(500, 400);
            Name = "MainChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cybersecurity ChatBot";
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
