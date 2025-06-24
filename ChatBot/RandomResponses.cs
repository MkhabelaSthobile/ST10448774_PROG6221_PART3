using System;
using System.Collections.Generic;

namespace ChatBot
{
    public class RandomResponses
    {
        private Dictionary<string, List<string>> topicResponses;
        private Dictionary<string, string> definitions;
        private Random rand;

        public RandomResponses()
        {
            rand = new Random();

            topicResponses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
            {
                ["phishing"] = new List<string> {
                    "Be cautious of urgent messages asking for your info.",
                    "Check the URL of websites before logging in.",
                    "Never share your OTP with anyone — even if they say it's your bank.",
                    "Phishing often uses real-looking logos and email formats to trick you.",
                    "If in doubt, contact the organization directly instead of replying."
                },
                ["cyberattacks"] = new List<string> {
                    "Cyberattacks often begin with human error — stay alert.",
                    "A single outdated app can be a backdoor for attackers.",
                    "DDoS attacks overload websites to make them crash.",
                    "Ransomware locks your files and demands payment — backups are your defense.",
                    "Many attacks target small businesses because they have weaker defenses."
                },
                ["password"] = new List<string> {
                    "Avoid reusing passwords — it’s like using one key for every door.",
                    "Use at least 12 characters with a mix of letters, numbers, and symbols.",
                    "Password managers help you store strong, unique passwords safely.",
                    "Don’t use names or birthdays in passwords — they’re too easy to guess.",
                    "Update passwords regularly, especially after a breach."
                },
                ["privacy"] = new List<string> {
                    "Review app permissions — some apps ask for more access than needed.",
                    "Use a VPN when browsing on public Wi-Fi.",
                    "Avoid oversharing on social media — it helps scammers profile you.",
                    "Use privacy-focused browsers or extensions like DuckDuckGo or uBlock Origin.",
                    "Enable 2FA on accounts with sensitive info."
                },
                ["scams"] = new List<string> {
                    "If it sounds too good to be true, it probably is.",
                    "Don’t send money to someone you’ve only met online.",
                    "Always verify job offers or giveaways through official channels.",
                    "Be cautious of urgent or threatening language in messages.",
                    "Scammers often impersonate trusted organizations."
                },
                ["myths"] = new List<string> {
                    "Myth: Macs can’t get viruses. Truth: They can — they're just less common.",
                    "Myth: VPNs make you invisible. Truth: They encrypt data but don't erase your footprint.",
                    "Myth: Antivirus is enough. Truth: Security habits matter more than tools.",
                    "Myth: Only big companies are targeted. Truth: Individuals are often easier targets.",
                    "Myth: Incognito mode hides you. Truth: It only hides browsing locally — not from your ISP."
                },
                ["funfacts"] = new List<string> {
                    "Did you know? The first computer virus was made in 1986 and spread via floppy disks.",
                    "Did you know? Over 90% of data breaches are caused by human error.",
                    "Did you know? The average cost of a data breach is over $4 million.",
                    "Did you know? Even smart fridges and printers can be hacked.",
                    "Did you know? Hackers can scan the internet in minutes using automated tools."
                }
            };

            
        }

        public string GetRandomResponse(string topic)
        {
            if (topicResponses.ContainsKey(topic))
            {
                List<string> responses = topicResponses[topic];
                return responses[rand.Next(responses.Count)];
            }
            return "Sorry, I don't have any responses for that topic.";
        }

        public List<string> GetAvailableTopics()
        {
            return new List<string>(topicResponses.Keys);
        }
    }
}
