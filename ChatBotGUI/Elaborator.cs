using System;
using System.Collections.Generic;

namespace ChatBotGUI
{
    public class Elaborator
    {
        private Dictionary<string, string> elaborations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Cybersecurity", "Cybersecurity includes practices like using strong passwords, enabling firewalls, keeping software updated, and being cautious online." },
            { "Cyberattack", "Cyberattacks include malware, ransomware, phishing, and other tactics used to gain unauthorized access or cause damage." },
            { "Cyberattacks", "Cyberattacks include malware, ransomware, phishing, and other tactics used to gain unauthorized access or cause damage." },
            { "Phishing", "Phishing emails may look legitimate but often contain suspicious links, urgent messages, and ask for personal info." },
            { "Password safety", "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords, and consider a password manager." },
            { "Safe browsing", "Avoid unknown sites, check for HTTPS, don’t download random files, and use browser security extensions." },
            { "Scam", "Be cautious of offers that seem too good to be true, and never share personal or banking info with strangers." },
            { "Scams", "Be cautious of offers that seem too good to be true, and never share personal or banking info with strangers." },
            { "Privacy", "Protect your privacy by limiting what you share online, using encrypted messaging apps, and regularly checking app permissions." },
            { "phishing safety precautions",
                "Safety precautions against phishing include:\n" +
                "- Don't share personal info with unknown sources\nAs long as you don't know the person online, do not give them any personal information.\n" +
                "- Use strong, unique passwords\nAvoid using the same password across multiple accounts, and consider using a password manager.\n" +
                "- Enable multi-factor authentication (MFA)\nRequire two or more verification factors before account access.\n" +
                "- Avoid clicking on suspicious links or email attachments\nHover over links before clicking and avoid attachments from unknown senders.\n"
            },
            { "types of phishing",
                "- Email phishing\nFake emails that appear real to steal sensitive info.\n" +
                "- Spear phishing\nTargeted emails to specific individuals with personalized details.\n" +
                "- Smishing (SMS phishing)\nFake texts tricking victims into clicking malicious links.\n" +
                "- Vishing (voice phishing)\nCalls pretending to be from trusted sources to get personal info.\n" +
                "- Clone phishing\nDuplication of legitimate emails to deceive recipients.\n"
            },
            { "types of scams",
                "- Investment scams\nFraudulent promises of high return with little risk.\n" +
                "- Romance fraud\nEmotional manipulation to get money or info online.\n" +
                "- Job scams\nFake job offers asking for fees or personal info.\n" +
                "- Identity theft\nStealing personal info to commit crimes or fraud.\n"
            }
        };

        public string Elaborate(string input)
        {
            if (elaborations.ContainsKey(input))
            {
                return elaborations[input] + "\n";
            }
            else
            {
                return "Sorry, I can't elaborate further on that topic.\n";
            }
        }

        public string PromptForElaboration(string topic)
        {
            return Elaborate(topic.Trim());
        }

        public bool CanElaborate(string input)
        {
            return elaborations.ContainsKey(input);
        }
    }
}
