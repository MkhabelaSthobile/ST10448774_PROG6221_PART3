using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChatBotGUI
{
    public class Input
    {
        private Dictionary<string, string> memory = new Dictionary<string, string>();
        private RandomResponses randomResponses = new RandomResponses();
        private Elaborator elaborator = new Elaborator();
        private List<string> activityLog = new List<string>();

        private void LogAction(string action)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            activityLog.Add($"[{timestamp}] {action}");
            if (activityLog.Count > 50)
                activityLog.RemoveAt(0);
        }


        public Input()
        {
            LoadDefinitions();
        }

        public string RespondToInput(string input, string userName)
        {
            string[,] cyberAttacks = {
        {"Malware", "Any software designed to harm or disrupt computer systems, including viruses, ransomware, and trojans."},
        {"Ransomware", "A type of malware that encrypts files or computer systems and demands a ransom for their decryption."},
        {"DDoS (Distributed Denial of Service) attack", "An attack that floods a target system with traffic, making it unavailable to legitimate users."},
        {"SQL Injection", "This is a web security vulnerability that allows an attacker to manipulate database queries."},
        {"Cross-Site Scripting", "XSS is a web security vulnerability where attackers inject malicious code into websites."},
        {"Man-in-the-Middle (MITM) attack", "This attack occurs when an attacker intercepts communication between two parties, potentially stealing data or injecting malicious code."}
    };

            string[,] securityMeasures = {
        {"Encryption", "The process of converting data into a secure format that can only be decrypted by authorized individuals."},
        {"Two-factor authentication (2FA)", "2FA adds an extra layer of security by requiring a second form of verification, such as a code sent to a mobile phone, in addition to a password."},
        {"Firewall", "This is a network security device that monitors and controls network traffic based on defined security rules."},
        {"Passkeys", "These are digital credentials that use biometric authentication or a PIN instead of passwords, offering increased security and convenience."},
        {"Patch Management", "Involves regularly updating software to address vulnerabilities and security flaws."}
    };

            var response = new StringBuilder();
            input = input.ToLower();

            if (input.Contains("hey") || input.Contains("hello"))
            {
                if (input.Contains("how are you"))
                {
                    response.AppendLine("Hey there! I'm as good as a chatbot can be. How are you?\n");
                }
                else
                {
                    response.AppendLine("Hey there!\n");
                }
                LogAction($"Greeting between user and chatbot: '{input}'");
            }
            else if (input.Contains("how are you"))
            {
                response.AppendLine("I'm as good as a chatbot can be. How are you?\n");
            }
            else if (input.Contains("good") || input.Contains("great") || input.Contains("amazing") || input.Contains("fine"))
            {
                response.AppendLine("That's good to know. How can I make your day better?\n");
            }
            else if (input.Contains("not good") || input.Contains("bad") || input.Contains("sad") || input.Contains("angry"))
            {
                response.AppendLine("I'm sorry to hear that. How can I make your day better?\n");
            }
            else if (input.Contains("purpose") || input.Contains("your purpose") || input.Contains("what do you do") || input.Contains("help"))
            {
                response.AppendLine("I'm here to help you stay safe online. You can ask me about cybersecurity.\n");
            }
            else if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious"))
            {
                response.AppendLine("Thank you for letting me know.\n");
                response.AppendLine(Sentiments(input));
                LogAction($"Responded to user sentiment about: '{input}'");
            }
            else if (input.Contains("curious"))
            {
                response.AppendLine("Curiosity is great! Let’s explore cybersecurity together.\n");
            }
            else if (input.Contains("frustrated") || input.Contains("confused"))
            {
                response.AppendLine("No worries. Just ask your question in a different way, and I’ll do my best to help.\n");
            }
            else if (input.Contains("thank you") || input.Contains("appreciate"))
            {
                response.AppendLine("It is my pleasure " + userName + "\n");
            }
            else if (input.Contains("what can i ask you") || input.Contains("can i ask you") || input.Contains(" ask") || input.Contains("topics") || input.Contains("topic"))
            {
                response.AppendLine("You can ask me about the topics mentioned above.\n");
            }
            else if ((input.Contains("define") && input.Contains("cybersecurity")) || input.Contains("what is cybersecurity"))
            {
                response.AppendLine("Cybersecurity is the practice of protecting systems, networks, and data from digital attacks.\n");
                LogAction("Provided definition for 'cybersecurity'");
            }
            else if ((input.Contains("how") && input.Contains("safe") && input.Contains("phishing")) || input.Contains("precautions") && input.Contains("phishing"))
            {
                response.AppendLine("Safety precautions against phishing include:");
                response.AppendLine("- Don't share personal info with unknown sources");
                response.AppendLine("- Use strong, unique passwords");
                response.AppendLine("- Enable multi-factor authentication");
                response.AppendLine("- Avoid clicking on suspicious links or email attachments\n");
            }
            else if (input.Contains("types") && input.Contains("phishing"))
            {
                response.AppendLine("Types of phishing include:");
                response.AppendLine("- Email phishing");
                response.AppendLine("- Spear phishing");
                response.AppendLine("- Smishing (SMS phishing)");
                response.AppendLine("- Vishing (voice phishing)");
                response.AppendLine("- Clone phishing\n");
            }
            else if ((input.Contains("practice") || input.Contains("practices") || input.Contains("how") || input.Contains("precautions")) && input.Contains("password"))
            {
                response.AppendLine("Password safety practices include:");
                response.AppendLine("- Use strong, complex passwords");
                response.AppendLine("- Avoid writing down or sharing passwords");
                response.AppendLine("- Use a password manager\n");
            }
            else if ((input.Contains("practice") || input.Contains("practices")) && input.Contains("safe browsing"))
            {
                response.AppendLine("Safe browsing practices include:");
                response.AppendLine("- Keep antivirus software updated");
                response.AppendLine("- Check that website URLs are correct");
                response.AppendLine("- Use HTTPS-secured sites");
                response.AppendLine("- Don't click suspicious links or ads\n");
            }
            else if (input.Contains("tools") && input.Contains("safe browsing"))
            {
                response.AppendLine("Tools used for safe browsing include:");
                response.AppendLine("- Google Safe Browsing (used by Chrome and Firefox)");
                response.AppendLine("- Microsoft Defender SmartScreen (used by Edge)");
                response.AppendLine("- Antivirus software with web protection features\n");
            }
            else if (input.Contains("types") && input.Contains("scams"))
            {
                response.AppendLine("Types of scams include:");
                response.AppendLine("- Investment scams");
                response.AppendLine("- Romance fraud");
                response.AppendLine("- Job scams");
                response.AppendLine("- Identity theft\n");
            }
            else if ((input.Contains("types") && input.Contains("privacy practices")) || input.Contains("privacy practices"))
            {
                response.AppendLine("Privacy practices include:");
                response.AppendLine("- Make use of privacy policies");
                response.AppendLine("- Restrict access to personal data to authorized personnel");
                response.AppendLine("- Obtain explicit consent to make use of personal data");
                response.AppendLine("- Implement procedures to ensure that data can be recovered in case of loss or damage.\n");
            }
            else if (input.Contains("common cyberattacks") || input.Contains("common cyber attacks") || input.Contains("a list of cyberattacks") || input.Contains("cyberattacks"))
            {
                for (int i = 0; i < cyberAttacks.GetLength(0); i++)
                {
                    response.AppendLine("~ " + cyberAttacks[i, 0]);
                }

                response.AppendLine("\nYou can ask for definitions by typing 'Yes' or 'No', or type the name of a cyberattack to learn more.");
            }
            else if (input.Contains("a list of security measures") || input.Contains("security measures"))
            {
                for (int i = 0; i < securityMeasures.GetLength(0); i++)
                {
                    response.AppendLine("~ " + securityMeasures[i, 0]);
                }

                response.AppendLine("\nYou can ask for definitions by typing 'Yes' or 'No', or type the name of a security measure to learn more.");
            }
            else if (input.Contains("interested in") || input.Contains("i'm a") || input.Contains("i am a") || input.Contains("i'm on social media") || input.Contains("i use social media"))
            {
                response.AppendLine(DetectUserPreferences(input));
            }
            else if (input.Contains("tell me more about"))
            {
                string topic = input.Replace("tell me more about", "").Trim();
                response.AppendLine(elaborator.Elaborate(topic));
                LogAction($"User asked to know more about '{topic}'");
            }
            else if (input.Contains("remember what cybersecurity topic") || input.Contains("my cybersecurity interest"))
            {
                if (memory.ContainsKey("interest"))
                {
                    response.AppendLine("You mentioned that you are interested in " + memory["interest"]);
                }
                else
                {
                    response.AppendLine("I don't have any record of your interests yet.");
                }
            }
            else if (input.Contains("what is") && input.Contains("level") || input.Contains("what is") && input.Contains("level of cybersecurity"))
            {
                if (memory.ContainsKey("knowledgeLevel"))
                {
                    response.AppendLine("You mentioned that your level of cybersecurity knowledge is " + memory["knowledgeLevel"]);
                }
                else
                {
                    response.AppendLine("I don't have any record of your knowledge level yet.");
                }
            }
            else if (input.Contains("am i") && input.Contains("social media"))
            {
                if (memory.ContainsKey("social media"))
                {
                    var sm = memory["social media"].ToLower();
                    if (sm == "yes")
                    {
                        response.AppendLine("Yes, you are active on social media.");
                    }
                    else
                    {
                        response.AppendLine("No, you are not active on social media.");
                    }
                }
                else
                {
                    response.AppendLine("I don't know your social media activity yet.");
                }
            }
            else if (input.Contains("what do you remember about me"))
            {
                response.AppendLine("Here's what I remember about you:");
                if (memory.ContainsKey("interest"))
                    response.AppendLine("• Your cybersecurity interest is: " + memory["interest"]);
                if (memory.ContainsKey("knowledgeLevel"))
                    response.AppendLine("• Your knowledge level is: " + memory["knowledgeLevel"]);
                if (memory.ContainsKey("social media"))
                    response.AppendLine("• Active on social media: " + memory["social media"]);
            }
            else if (input.Contains("what is my username") || input.Contains("what is my name"))
            {
                response.AppendLine("Your username is " + userName);
            }
            else if (input.Contains("tell me something") || input.Contains("give me a fact"))
            {
                response.AppendLine("What topic would you like to hear about? (e.g., phishing, privacy, cyberattacks, myths, funfacts)");
            }
            else if (input.Contains("define") || input.Contains("what is"))
            {
                string term;
                if (input.Contains("define"))
                {
                    term = input.Replace("define", "").Trim();
                }
                else
                {
                    term = input.Replace("what is", "").Trim();
                }
                response.AppendLine(GetDefinition(term) + "\n");
                LogAction($"Provided definition for '{term}'");
            }
            else if (input.Contains("task assistant") || input.Contains("open task") || input.Contains("add a task"))
            {
                LogAction("User requested to open the Task Assistant.");
                return "Opening Task Assistant...";
            }
            else if ((input.Contains("remind") || input.Contains("reminder") || input.Contains("add task") || input.Contains("set task")) && (input.Contains("to") || input.Contains("about")))
            {
                LogAction("User requested to set a reminder or task.");
                return "It sounds like you want to add a task or reminder. Opening Task Assistant...";
            }
            else if (Regex.IsMatch(input, @"\b(remind|remember|add task)\b.*\b(password|2fa|privacy|update|check)\b"))
            {
                LogAction("Recognized NLP-based reminder request.");
                return "Got it — you want to set a cybersecurity reminder.";
            }
            else if (input.Contains("activity log") || input.Contains("what activities have I done"))
            {
                LogAction("User viewed the full activity log.");

                if (activityLog.Count == 0)
                {
                    response.AppendLine("Your activity log is currently empty.");
                }
                else
                {
                    response.AppendLine("Here’s your full activity log:");
                    foreach (var entry in activityLog)
                    {
                        response.AppendLine(entry);
                    }
                }
            }
            else
            {
                response.AppendLine("Hmm... I didn’t quite understand that. Can you rephrase?");
            }

            return response.ToString();
        }




        public string DetectUserPreferences(string input)
        {
            input = input.ToLower();
            StringBuilder response = new StringBuilder();

            // Detect cybersecurity interest
            if (input.Contains("phishing"))
            {
                memory["interest"] = "phishing";
                response.AppendLine("I'll remember you're interested in phishing.\n");
            }
            else if (input.Contains("privacy"))
            {
                memory["interest"] = "privacy";
                response.AppendLine("Got it! Privacy is a smart focus.\n");
            }
            else if (input.Contains("password"))
            {
                memory["interest"] = "password safety";
                response.AppendLine("Password safety noted. I'll keep that in mind.\n");
            }
            else if (input.Contains("cyberattack"))
            {
                memory["interest"] = "cyberattacks";
                response.AppendLine("Cyberattacks are a key topic. I’ll remember that’s your interest.\n");
            }

            // Detect knowledge level
            if (input.Contains("beginner") || input.Contains("novice"))
            {
                memory["knowledgeLevel"] = "beginner";
                response.AppendLine("Got it! I'll keep things beginner-friendly.\n");
            }
            else if (input.Contains("intermediate"))
            {
                memory["knowledgeLevel"] = "intermediate";
                response.AppendLine("I'll tailor the conversation for an intermediate level.\n");
            }
            else if (input.Contains("expert") || input.Contains("advanced") || input.Contains("pro"))
            {
                memory["knowledgeLevel"] = "expert";
                response.AppendLine("Expert mode activated! We'll keep it in-depth.\n");
            }

            // Detect social media activity
            if (input.Contains("i'm on social media") || input.Contains("i use social media"))
            {
                memory["social media"] = "Yes";
                response.AppendLine("I'll offer tips with social media in mind.\n");
            }
            else if (input.Contains("i'm not on social media") || input.Contains("i don't use social media"))
            {
                memory["social media"] = "No";
                response.AppendLine("Noted! I'll avoid social media-specific advice.\n");
            }

            return response.ToString();
        }

        public string AskUserPreferences(string interest, string level, string socialMedia)
        {
            StringBuilder response = new StringBuilder();

            if (string.IsNullOrWhiteSpace(interest))
            {
                interest = "general cybersecurity";
            }

            memory["interest"] = interest.ToLower();
            response.AppendLine("Got it! You're interested in " + interest + ".");

            level = level.ToLower();
            switch (level)
            {
                case "beginner":
                case "novice":
                    memory["knowledgeLevel"] = "beginner";
                    response.AppendLine("Thanks! I'll keep things beginner-friendly.");
                    break;
                case "intermediate":
                    memory["knowledgeLevel"] = "intermediate";
                    response.AppendLine("Thanks! I'll use intermediate-level explanations.");
                    break;
                case "expert":
                case "advanced":
                case "pro":
                    memory["knowledgeLevel"] = "expert";
                    response.AppendLine("Thanks! I’ll provide more advanced info.");
                    break;
                default:
                    response.AppendLine("I didn't quite get your skill level, so I’ll default to general explanations.");
                    memory["knowledgeLevel"] = "beginner";
                    break;
            }

            if (socialMedia.ToLower().StartsWith("y"))
            {
                memory["social media"] = "Yes";
                response.AppendLine("Thanks! I’ll give tips relevant to social media too.");
            }
            else
            {
                memory["social media"] = "No";
                response.AppendLine("Got it. I’ll avoid social media-specific tips.");
            }

            response.AppendLine("\nThank you for this info! Let's continue the conversation. 😊");

            return response.ToString();
        }

        private void LoadDefinitions()
        {
            memory["definition_phishing"] = "Phishing is a cyberattack where attackers impersonate trusted entities to trick people into revealing sensitive information.";
            memory["definition_malware"] = "Malware is malicious software designed to disrupt, damage, or gain unauthorized access to systems.";
            memory["definition_ransomware"] = "Ransomware is a type of malware that locks your data and demands payment for its release.";
            memory["definition_firewall"] = "A firewall is a network security system that monitors and filters incoming and outgoing traffic.";
            memory["definition_encryption"] = "Encryption is the process of encoding information to protect it from unauthorized access.";
            memory["definition_safe browsing"] = "Safe browsing means using habits and tools to avoid online threats such as phishing and malware.";
            memory["definition_password safety"] = "Password safety is the practice of creating, managing, and protecting strong passwords to secure online accounts.";
            memory["definition_vpn"] = "A VPN (Virtual Private Network) encrypts your internet traffic and hides your IP address.";
            memory["definition_social engineering"] = "Social engineering is manipulating people into revealing confidential information.";
            memory["definition_scams"] = "Scams are fraudulent schemes intended to steal money or personal information.";
            memory["definition_privacy"] = "Privacy is your right to control how your personal data is collected and used.";
        }

        private string GetDefinition(string term)
        {
            string key = "definition_" + term.ToLower();
            if (memory.ContainsKey(key))
            {
                return memory[key];
            }
            else
            {
                return "Sorry, I don't have a definition for that term.";
            }
        }

        public string Sentiments(string input)
        {
            Dictionary<string, string> encouragements = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "cybersecurity", "It's okay to feel overwhelmed. Cybersecurity is a journey, and you're already making progress by asking questions!" },
        { "phishing", "Phishing can be scary, but with awareness and good habits, you can avoid falling victim to these tricks." },
        { "password safety", "Keeping your passwords safe is easier than it sounds. Use a password manager and you'll be ahead of most people!" },
        { "safe browsing", "With a few good habits like using HTTPS and avoiding sketchy sites, you can browse the internet confidently." },
        { "scams", "Scammers can be deceptive, but knowing the signs helps you stay protected and one step ahead." },
        { "privacy", "You don’t need to be an expert to protect your privacy. Small steps like adjusting app settings and limiting what you share online make a big difference." },
        { "cyberattacks", "Cyberattacks sound intense, but learning about them gives you the power to avoid and defend against them." }
    };

            foreach (var topic in encouragements.Keys)
            {
                if (input.Contains(topic.ToLower()))
                {
                    return encouragements[topic] + "\n";
                }
            }

            return "I understand you're feeling uneasy. Don't worry, I'm here to help guide you through any cybersecurity concerns.\n";
        }

        public List<string> GetActivityLog()
        {
            return activityLog;
        }





    }
}
