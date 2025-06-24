using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Input
    {
        private string input;
        private Dictionary<string, string> memory = new Dictionary<string, string>();
        private RandomResponses randomResponses = new RandomResponses();
        private Elaborator elaborator = new Elaborator();


        public Input() 
        { 
            input = null;
            LoadDefinitions();
        }

        public Input(string input)
        {
            this.input = input;
        }

        public string RespondToInput(string input, string userName)
        {

            string[,] cyberAttacks = { {"Malware", "Any software designed to harm or disrupt computer systems, including viruses, ransomware, and trojans."},
                                       {"Ransomware", "A type of malware that encrypts files or computer systems and demands a ransom for their decryption. "},
                                       {"DDoS (Distributed Denial of Service) attack", "An attack that floods a target system with traffic, making it unavailable to legitimate users."},
                                       {"SQL Injection", "This is a web security vulnerability that allows an attacker to manipulate database queries."},
                                       {"Cross-Site Scripting", "XSS is a web security vulnerability where attackers inject malicious code into websites."},
                                       {"Man-in-the-Middle (MITM) attack", "This attack occurs when an attacker intercepts communication between two parties, potentially stealing data or injecting malicious code."} };

            string[,] securityMeasures = { {"Encription", "The process of converting data into a secure format that can only be decrypted by authorized individuals."},
                                           {"Two-factor authentication (2FA)", "2FA adds an extra layer of security by requiring a second form of verification, such as a code sent to a mobile phone, in addition to a password."},
                                           {"Firewall", "This is a network security device that monitors and controls network traffic based on defined security rules."},
                                           {"Passkeys", "These are digital credentials that use biometric authentication or a PIN instead of passwords, offering increased security and convenience."},
                                           {"Patch Management", "Involves regularly updating software to address vulnerabilities and security flaws."} };

            
            Console.ForegroundColor = ConsoleColor.Blue;


            if (input.Contains("hey") || input.Contains("hello"))
            {
                if (input.Contains("how are you"))
                {
                    Console.WriteLine("Hey there! I'm as good as a chatbot can be. How are you?\n");

                }
                else
                {
                    Console.WriteLine("Hey there!\n");
                }

            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm as good as a chatbot can be. How are you?\n");

            }
            else if (input.Contains("good") || input.Contains("great") || input.Contains("amazing") || input.Contains("fine"))
            {
                Console.WriteLine("That's good to know. How can I make your day better?\n");

            }
            else if (input.Contains("not good") || input.Contains("bad") || input.Contains("sad") || input.Contains("angry"))
            {
                Console.WriteLine("I'm sorry to hear that. How can I make your day better?\n");

            }
            else if (input.Contains("purpose") || input.Contains("your purpose") || input.Contains("what do you do") || input.Contains("help"))
            {
                Console.WriteLine("I'm here to help you stay safe online. You can ask me about cybersecurity.\n");

            }
            else if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious"))
            {
                Console.WriteLine("Thank you for letting me know.\n");
                Sentiments(input);

            }
            else if (input.Contains("curious"))
            {
                Console.WriteLine("Curiosity is great! Let’s explore cybersecurity together.\n");

            }
            else if (input.Contains("frustrated") || input.Contains("confused"))
            {
                Console.WriteLine("No worries. Just ask your question in a different way, and I’ll do my best to help.\n");

            }
            else if (input.Contains("thank you") || input.Contains("appreciate"))
            {
                Console.WriteLine("It is my pleasure " + userName + "\n");

            }
            else if ((input.Contains("what can I ask you") || input.Contains("can I ask you") || input.Contains("ask")) || input.Contains("topics") || input.Contains("topic"))
            {
                Console.WriteLine("You can ask me about the topics mentioned above.\n");
                //AskUserPreferences();
            }
            else if (input.Contains("define") && input.Contains("cybersecurity") || input.Contains("what is cybersecurity"))
            {
                Console.WriteLine("Cybersecurity is the practice of protecting systems, networks, and data from digital attacks.\n");
            }
            else if ((input.Contains("how") && input.Contains("safe") && input.Contains("phishing") || input.Contains("precautions")) && input.Contains("phishing"))
            {
                Console.WriteLine("Safety precautions against phishing include:");
                Console.WriteLine("- Don't share personal info with unknown sources");
                Console.WriteLine("- Use strong, unique passwords");
                Console.WriteLine("- Enable multi-factor authentication");
                Console.WriteLine("- Avoid clicking on suspicious links or email attachments\n");

            }
            else if (input.Contains("types") && input.Contains("phishing"))
            {
                Console.WriteLine("Types of phishing include:");
                Console.WriteLine("- Email phishing");
                Console.WriteLine("- Spear phishing");
                Console.WriteLine("- Smishing (SMS phishing)");
                Console.WriteLine("- Vishing (voice phishing)");
                Console.WriteLine("- Clone phishing\n");


            }
            else if (input.Contains("practice") || (input.Contains("practices") || input.Contains("how") || input.Contains("precautions")) && input.Contains("password"))
            {
                Console.WriteLine("Password safety practices include:");
                Console.WriteLine("- Use strong, complex passwords");
                Console.WriteLine("- Avoid writing down or sharing passwords");
                Console.WriteLine("- Use a password manager\n");


            }
            else if (input.Contains("practice") || input.Contains("practices") && input.Contains("safe browsing"))
            {
                Console.WriteLine("Safe browsing practices include:");
                Console.WriteLine("- Keep antivirus software updated");
                Console.WriteLine("- Check that website URLs are correct");
                Console.WriteLine("- Use HTTPS-secured sites");
                Console.WriteLine("- Don't click suspicious links or ads\n");


            }
            else if (input.Contains("tools") && input.Contains("safe browsing"))
            {
                Console.WriteLine("Tools used for safe browsing include:");
                Console.WriteLine("- Google Safe Browsing (used by Chrome and Firefox)");
                Console.WriteLine("- Microsoft Defender SmartScreen (used by Edge)");
                Console.WriteLine("- Antivirus software with web protection features\n");


            }
            else if (input.Contains("types") && input.Contains("scams"))
            {
                Console.WriteLine("Types of scams include:");
                Console.WriteLine("- Investment scams");
                Console.WriteLine("- Romance fraud");
                Console.WriteLine("- Job scams");
                Console.WriteLine("- Identity theft");


            }
            else if (input.Contains("types") && input.Contains("privacy practices") || input.Contains("privacy practices"))
            {
                Console.WriteLine("Privacy practices include:");
                Console.WriteLine("- Make use of privacy policies");
                Console.WriteLine("- Restrict access to personal data to authorized personnel");
                Console.WriteLine("- Obtain explicit consent to make use of personal data");
                Console.WriteLine("- Implement procedures to ensure that data can be recovered in case of loss or damage.\n");


            }
            else if (input.Contains("common cyberattacks") || input.Contains("common cyber attacks") || input.Contains("a list of cyberattacks") || input.Contains("cyberattacks"))
            {
                for (int i = 0; i < cyberAttacks.Length; i++)
                {
                    Console.WriteLine("~ " + cyberAttacks[i, 0] + "\n");
                }

                Console.WriteLine("Would you like the definitions of these cyberattacks? Select a response:\n - 'No'\n - 'Yes'\n Or type the name of a cyberattack to learn more:");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "No":
                        Console.WriteLine("Ok, no problem.\nFeel free to ask me anything else.");
                        break;

                    case "Yes":
                        for (int i = 0; i < cyberAttacks.GetLength(0); i++)
                        {
                            Console.WriteLine(cyberAttacks[i, 0] + "\n" + cyberAttacks[i, 1] + "\n");
                        }
                        break;

                    default:
                        bool found = false;
                        for (int i = 0; i < cyberAttacks.GetLength(0); i++)
                        {
                            if (cyberAttacks[i, 0].Equals(answer, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(cyberAttacks[i, 0] + "\n" + cyberAttacks[i, 1] + "\n");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Your response was not recognized. Please try again.\n");
                        }
                        break;
                }

            }
            else if (input.Contains("a list of security measures") || input.Contains("security measures"))
            {
                for (int i = 0; i < securityMeasures.GetLength(0); i++)
                {
                    Console.WriteLine("~ " + securityMeasures[i, 0] + "\n");
                }

                Console.WriteLine("Would you like the definitions of these security measures? Select a response:\n - 'No'\n - 'Yes'\n Or type the name of a security measure to learn more:");
                string response = Console.ReadLine();

                switch (response)
                {
                    case "No":
                        Console.WriteLine("Ok, no problem.\nFeel free to ask me anything else.");
                        break;

                    case "Yes":
                        for (int i = 0; i < securityMeasures.GetLength(0); i++)
                        {
                            Console.WriteLine(securityMeasures[i, 0] + "\n" + securityMeasures[i, 1] + "\n");
                        }
                        break;

                    default:
                        bool found = false;
                        for (int i = 0; i < securityMeasures.GetLength(0); i++)
                        {
                            if (securityMeasures[i, 0].Equals(response, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(securityMeasures[i, 0] + "\n" + securityMeasures[i, 1] + "\n");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Your response was not recognized. Please try again.\n");
                        }
                        break;
                }



            }
            else if (input.Contains("interested in") || input.Contains("i'm a") || input.Contains("i am a") || input.Contains("i'm on social media") || input.Contains("i use social media"))
            {
                DetectUserPreferences(input);
            }
            else if (input.Contains("tell me more about"))
            {
                string topic = input.Replace("tell me more about", "").Trim();
                elaborator.Elaborate(topic);
            }
            else if (input.Contains("remember what cybersecurity topic") || input.Contains("my cybersecurity interest"))
            {
                Console.WriteLine("You mentioned that you are interested in " + memory["interest"]);

            }
            else if (input.Contains("what is") && input.Contains("level") || input.Contains("what is") && input.Contains("level of cybersecurity"))
            {
                Console.WriteLine("You mentioned that your level of cybersecurity knowledge is " + memory["knowledgeLevel"]);

            }
            else if (input.Contains("am I") && input.Contains("social media"))
            {
                if (memory["social media"].ToLower() == "yes")
                {
                    Console.WriteLine(memory["social media"] + ", you are.");
                }
                else
                {
                    Console.WriteLine(memory["social media"] + ", you are not.");
                }

            }
            else if (input.Contains("what do you remember about me"))
            {
                Console.WriteLine("Here's what I remember about you:");
                Console.WriteLine("• Your cybersecurity interest is: " + memory["interest"]);
                Console.WriteLine("• Your knowledge level is: " + memory["knowledgeLevel"]);
                Console.WriteLine("• Active on social media: " + memory["social media"]);

            }
            else if (input.Contains("what is my username") || input.Contains("what is my name"))
            {
                Console.WriteLine("Your username is " + userName);

            }
            else if (input.Contains("tell me something") || input.Contains("give me a fact"))
            {
                Console.WriteLine("What topic would you like to hear about? (e.g., phishing, privacy, cyberattacks, myths, funfacts)");
                string topic = Console.ReadLine().Trim().ToLower();
                Console.WriteLine(randomResponses.GetRandomResponse(topic) + "\n");

            }
            else if (input.Contains("define") || input.Contains("what is"))
            {
                //Console.WriteLine("Which term would you like defined?");
                if (input.Contains("define")) 
                {
                    string term = input.Replace("define", "").Trim();
                    Console.WriteLine(term + ": " + GetDefinition(term) + "\n");
                }
                else
                {
                    string term = input.Replace("what is", "").Trim();
                    Console.WriteLine(term + ": " + GetDefinition(term) + "\n");
                }
                

            }
            else
            {
                Console.WriteLine("Hmm... I didn’t quite understand that. Can you rephrase?");

            }
            

            Console.ResetColor();

            return input;
        }


        public void DetectUserPreferences(string input)
        {
            input = input.ToLower();

            // Detect cybersecurity interest
            
            if (input.Contains("phishing"))
            {
                memory["interest"] = "phishing";
                Console.WriteLine("I'll remember you're interested in phishing.\n");
            }
            else if (input.Contains("privacy"))
            {
                memory["interest"] = "privacy";
                Console.WriteLine("Got it! Privacy is a smart focus.\n");
            }
            else if (input.Contains("password"))
            {
                memory["interest"] = "password safety";
                Console.WriteLine("Password safety noted. I'll keep that in mind.\n");
            }
            else if (input.Contains("cyberattack"))
            {
                memory["interest"] = "cyberattacks";
                Console.WriteLine("Cyberattacks are a key topic. I’ll remember that’s your interest.\n");
            }
            

            // Detect knowledge level
            
            if (input.Contains("beginner") || input.Contains("novice"))
            {
                memory["knowledgeLevel"] = "beginner";
                Console.WriteLine("Got it! I'll keep things beginner-friendly.\n");
            }
            else if (input.Contains("intermediate"))
            {
                memory["knowledgeLevel"] = "intermediate";
                Console.WriteLine("I'll tailor the conversation for an intermediate level.\n");
            }
            else if (input.Contains("expert") || input.Contains("advanced") || input.Contains("pro"))
            {
                memory["knowledgeLevel"] = "expert";
                Console.WriteLine("Expert mode activated! We'll keep it in-depth.\n");
            }
            

            // Detect social media activity
            if (input.Contains("i'm on social media") || input.Contains("i use social media"))
            {
                memory["social media"] = "Yes";
                Console.WriteLine("Chatbot: I'll offer tips with social media in mind.\n");
            }
            else if (input.Contains("i'm not on social media") || input.Contains("i don't use social media"))
            {
                memory["social media"] = "No";
                Console.WriteLine("Chatbot: Noted! I'll avoid social media-specific advice.\n");
            }
        }

        public void AskUserPreferences()
        {
            Console.WriteLine("Before we continue, I'd like to get to know your cybersecurity interests better. Please answer the following questions.\n");

            // 1. Interest
            Console.WriteLine("1. What cybersecurity topic are you most interested in? (e.g., phishing, privacy, password safety, cyberattacks)");
            string interest = Console.ReadLine().Trim().ToLower();
            if (string.IsNullOrEmpty(interest))
            {
                interest = "general cybersecurity";
            }
            memory["interest"] = interest;
            Console.WriteLine("Got it! I'll remember that you're interested in " + interest + ".\n");

            // 2. Knowledge level
            string level = "";
            while (true)
            {
                Console.WriteLine("2. What’s your level of cybersecurity knowledge? (beginner, intermediate, expert)");
                level = Console.ReadLine().Trim().ToLower();

                switch (level)
                {
                    case "beginner":
                    case "novice":
                        level = "beginner";
                        break;
                    case "intermediate":
                        break;
                    case "expert":
                    case "advanced":
                    case "pro":
                        level = "expert";
                        break;
                    default:
                        Console.WriteLine("Sorry, I didn't understand that. Please type: beginner, intermediate, or expert.");
                        continue;
                }
                break;
            }
            memory["knowledgeLevel"] = level;
            Console.WriteLine("Thanks! I'll remember you're a(n) " + level + " user.\n");

            // 3. Social media
            string active = "";
            while (true)
            {
                Console.WriteLine("3. Are you active on social media? (Yes/No)");
                active = Console.ReadLine().Trim().ToLower();

                if (active == "yes" || active == "y")
                {
                    active = "Yes";
                    break;
                }
                else if (active == "no" || active == "n")
                {
                    active = "No";
                    break;
                }
                else
                {
                    Console.WriteLine("Please answer 'Yes' or 'No'.");
                }
            }
            memory["social media"] = active;
            Console.WriteLine("Understood! I'll provide friendly explanations when possible.\n");
            Console.WriteLine("\nThank you for this information... I will use it to ensure you have a pleasant experience.\nNow, we may proceed with our chat🙂\n.......\n");

        }


        private void LoadDefinitions()
        {
            memory["definition_phishing"] = "Phishing is a cyberattack where attackers impersonate trusted entities to trick people into revealing sensitive information.";
            memory["definition_malware"] = "Malware is malicious software designed to disrupt, damage, or gain unauthorized access to systems.";
            memory["definition_ransomware"] = "Ransomware is a type of malware that locks your data and demands payment for its release.";
            memory["definition_firewall"] = "A firewall is a network security system that monitors and filters incoming and outgoing traffic.";
            memory["definition_encryption"] = "Encryption is the process of encoding information to protect it from unauthorized access.";
            memory["definition_safe browsing"] = "Safe browsing means using habits and tools to avoid online threats such as phishing and malware.";
            memory["definition_password safety"] = "Password safety is the practice of creating, managing, and protecting strong passwords to secure online accounts and prevent unauthorized access.\n";
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

        public void Sentiments(string input)
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
                    Console.WriteLine(encouragements[topic] + "\n");
                    return;
                }
            }

            Console.WriteLine("I understand you're feeling uneasy. Don't worry, I'm here to help guide you through any cybersecurity concerns.\n");
        }





    }
}
