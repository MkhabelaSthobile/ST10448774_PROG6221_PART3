using System;
using System.Collections.Generic;

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
            "- Use strong, unique passwords\nAvoid using the same password across multiple accounts, and consider using a password manager to generate and store strong, unique passwords.\n" +
            "- Enable multi-factor authentication(MFA)\nThis means requiring users to provide two or more verification factors, such as a password and a code sent to their phone, before they can access an account or system.\n" +
            "- Avoid clicking on suspicious links or email attachments\nHover over links to see where they actually lead before clicking, and be cautious about opening attachments from unknown senders.\n"
        },
        { "types of phishing",
            "- Email phishing\nThe most prevalent type, using emails that appear legitimate to trick recipients into revealing sensitive information or clicking malicious links.\n" +
            "- Spear phishing\nTargets a specific individual or group within an organization, often with personalized messages, to exploit their trust and gather more specific information.\n" +
            "- Smishing (SMS phishing)\nUtilizes SMS messages to deceive victims into revealing information or clicking malicious links.\n" +
            "- Vishing (voice phishing)\nInvolves phone calls designed to trick individuals into revealing personal information.\n" +
            "- Clone phishing\nCreates exact replicas of legitimate emails or websites to trick victims into providing sensitive information.\n"
        },
        { "types of scams",
            "- Investment scams\nThese scams involve fraudulent investment opportunities, often promising high returns with little risk.\n" +
            "- Romance fraud\nScammers build relationships with victims online, then request money or personal information under false pretenses.\n" +
            "- Job Scams\nScammers offer fake job opportunities, often requiring upfront fees or personal information.\n" +
            "- Identity theft\nScammers steal personal information to open fraudulent accounts or commit other crimes.\n"
        }
    };

    public void Elaborate(string input)
    {
        if (elaborations.ContainsKey(input))
        {
            Console.WriteLine(elaborations[input] + "\n");
        }
        else
        {
            Console.WriteLine("Sorry, I can't elaborate further on that topic.\n");
        }
    }

    public void PromptForElaboration()
    {
        Console.WriteLine("What topic would you like to know more about?");
        string topic = Console.ReadLine().Trim();
        Elaborate(topic);
    }

    public bool CanElaborate(string input)
    {
        return elaborations.ContainsKey(input);
    }
}
