using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotGUI
{
    public class CyberTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Reminder { get; set; }  // Nullable for optional reminder
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            string status = IsCompleted ? "[✔] " : "[ ] ";
            string reminderInfo = Reminder.HasValue ? $" (Remind: {Reminder.Value.ToShortDateString()})" : "";
            return status + Title + reminderInfo;
        }
    }

}
