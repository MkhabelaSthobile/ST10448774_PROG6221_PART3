using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatBotGUI
{
    public partial class MainChatForm : Form
    {
        private Input input = new Input();
        private List<CyberQuiz> quizQuestions;
        private int currentQuestionIndex = -1;
        private int score = 0;
        private bool quizInProgress = false;

        public MainChatForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = new Size(500, 400);
            this.AutoScroll = true;
            this.DoubleBuffered = true;

        }

        private void DisplayMessage(string message, bool isUser)
        {
            Label bubble = new Label();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(320, 0);
            bubble.Font = new Font("Segoe UI", 10);
            bubble.ForeColor = isUser ? Color.White : Color.Black;
            bubble.BackColor = isUser ? Color.DodgerBlue : Color.WhiteSmoke;
            bubble.Padding = new Padding(10);
            bubble.Margin = new Padding(5);
            bubble.Text = message;

            // Place left or right
            bubble.Left = isUser ? (chatPanel.ClientSize.Width - bubble.PreferredWidth - 30) : 10;
            bubble.Top = chatPanel.Controls.Count > 0
                ? chatPanel.Controls[chatPanel.Controls.Count - 1].Bottom + 10
                : 10;

            chatPanel.Controls.Add(bubble);
            chatPanel.ScrollControlIntoView(bubble);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(inputText)) return;

            DisplayMessage(inputText, true);

            // 1. Handle quiz answer before chatbot responds
            if (quizInProgress && int.TryParse(inputText, out int userChoice))
            {
                CheckAnswer(userChoice - 1);
                txtInput.Clear();
                return;
            }

            // 2. Handle quiz starting
            if (inputText.Contains("start") && inputText.Contains("quiz") || inputText.Contains("cybersecurity quiz") || inputText.Contains("quiz"))
            {
                DisplayMessage("Let's begin the cybersecurity quiz!", false);
                StartQuiz();
                txtInput.Clear();
                return;
            }

            // 3. Get chatbot response
            string response = input.RespondToInput(inputText, "Sithobile");
            DisplayMessage(response, false);

            // 4. Handle response triggers
            if (inputText.Contains("task assistant") || inputText.Contains("open task") || inputText.Contains("add a task"))
            {
                TaskAssistantForm taskForm = new TaskAssistantForm();
                taskForm.ShowDialog();
            }
            txtInput.Clear();
        }

        private void btnClearChat_Click(object sender, EventArgs e)
        {
            chatPanel.Controls.Clear(); // Clear all message bubbles from chat
        }


        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
            }
        }

        private void LoadQuizQuestions()
        {
            quizQuestions = new List<CyberQuiz>
    {
                new CyberQuiz
                {
                    QuestionText = "What is phishing?",
                    Options = new List<string> { "A security software", "A fake website to steal info", "An antivirus tool", "None of the above" },
                    CorrectOptionIndex = 1,
                    Explanation = "Phishing is a scam where attackers trick you into revealing personal info using fake emails or sites."
                },
                new CyberQuiz
                {
                    QuestionText = "What is the best way to protect your online accounts?",
                    Options = new List<string> { "Using a simple password", "Sharing passwords with friends", "Using two-factor authentication", "Saving passwords in a text file" },
                    CorrectOptionIndex = 2,
                    Explanation = "Two-factor authentication adds an extra layer of protection beyond just your password."
                },
                new CyberQuiz
                {
                    QuestionText = "Which of the following is a strong password?",
                    Options = new List<string> { "123456", "password", "P@ssw0rd!2023", "qwerty" },
                    CorrectOptionIndex = 2,
                    Explanation = "Strong passwords use a mix of upper/lowercase letters, numbers, and special characters."
                },
                new CyberQuiz
                {
                    QuestionText = "What is malware?",
                    Options = new List<string> { "A type of food", "A malicious software", "A computer game", "An email provider" },
                    CorrectOptionIndex = 1,
                    Explanation = "Malware is any software created to harm or exploit computer systems."
                },
                new CyberQuiz
                {
                    QuestionText = "What should you do if you receive a suspicious email?",
                    Options = new List<string> { "Click all links quickly", "Forward it to everyone", "Ignore or delete it", "Reply with your personal info" },
                    CorrectOptionIndex = 2,
                    Explanation = "Suspicious emails should be ignored or deleted to avoid falling for scams."
                },
                new CyberQuiz
                {
                    QuestionText = "What does HTTPS mean in a website URL?",
                    Options = new List<string> { "The website is secure", "It is hosted in the USA", "It is a government site", "It has ads" },
                    CorrectOptionIndex = 0,
                    Explanation = "HTTPS shows the website uses encryption for secure communication."
                },
                new CyberQuiz
                {
                    QuestionText = "What is ransomware?",
                    Options = new List<string> { "Free antivirus software", "A browser extension", "Malware that locks files and demands payment", "A software update" },
                    CorrectOptionIndex = 2,
                    Explanation = "Ransomware is a type of malware that demands payment to unlock your files."
                },
                new CyberQuiz
                {
                    QuestionText = "Which of the following is a good cybersecurity habit?",
                    Options = new List<string> { "Using the same password everywhere", "Ignoring software updates", "Sharing passwords", "Backing up your data regularly" },
                    CorrectOptionIndex = 3,
                    Explanation = "Regular backups protect your data in case of an attack or system failure."
                },
                new CyberQuiz
                {
                    QuestionText = "What should you do before clicking on a link in an email?",
                    Options = new List<string> { "Hover to preview the link", "Click immediately", "Ignore the email", "Forward it to your contacts" },
                    CorrectOptionIndex = 0,
                    Explanation = "Hovering over a link lets you check its real destination before clicking."
                },
                new CyberQuiz
                {
                    QuestionText = "Why is it important to update your software regularly?",
                    Options = new List<string> { "To make the icons look better", "To fix spelling errors", "To patch security vulnerabilities", "To add new emojis" },
                    CorrectOptionIndex = 2,
                    Explanation = "Software updates often include fixes for security holes that hackers might exploit."
                },
                new CyberQuiz
                {
                    QuestionText = "Which of the following is an example of a cyberattack?",
                    Options = new List<string> { "Email login", "Installing updates", "SQL Injection", "Creating a password" },
                    CorrectOptionIndex = 2,
                    Explanation = "SQL Injection is a method used by attackers to exploit database vulnerabilities."
                }
            };
        }


        private void StartQuiz()
        {
            LoadQuizQuestions();
            quizInProgress = true;
            currentQuestionIndex = 0;
            score = 0;
            ShowCurrentQuestion();
        }

        private void ShowCurrentQuestion()
        {
            if (currentQuestionIndex < quizQuestions.Count)
            {
                var q = quizQuestions[currentQuestionIndex];
                string message = $"Q{currentQuestionIndex + 1}: {q.QuestionText}\n";
                for (int i = 0; i < q.Options.Count; i++)
                {
                    message += $"{i + 1}. {q.Options[i]}\n";
                }
                //message += "Type the number of your answer below:\n";
                DisplayMessage(message, false);
            }
            else
            {
                FinishQuiz();
            }
        }

        private void CheckAnswer(int selectedIndex)
        {
            var currentQ = quizQuestions[currentQuestionIndex];
            bool isCorrect = selectedIndex == currentQ.CorrectOptionIndex;

            if (isCorrect)
            {
                DisplayMessage("✅ Correct!\n", false);
                score++;
            }
            else
            {
                DisplayMessage($"❌ Incorrect. The correct answer was: {currentQ.Options[currentQ.CorrectOptionIndex]}", false);
            }

            DisplayMessage($"💡 {currentQ.Explanation}", false);
            currentQuestionIndex++;
            ShowCurrentQuestion();
        }

        private void FinishQuiz()
        {
            DisplayMessage($"🎉 Quiz complete! You scored {score} out of {quizQuestions.Count}.", false);

            if (score >= 8)
                DisplayMessage("🔥 You're a cybersecurity pro!", false);
            else if (score >= 5)
                DisplayMessage("👍 Good effort! Keep learning.", false);
            else
                DisplayMessage("📘 Study up! You're on the right track.", false);

            quizInProgress = false;
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            var logs = input.GetActivityLog();

            if (logs.Count == 0)
            {
                DisplayMessage("📭 Your activity log is empty.", false);
                return;
            }

            DisplayMessage("📜 Full Activity Log:\n", false);

            foreach (string log in logs)
            {
                DisplayMessage(log, false);
            }
        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
