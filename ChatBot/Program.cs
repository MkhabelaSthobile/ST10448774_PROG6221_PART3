using System;
using System.Collections.Generic;
using System.Media;
using System.Speech.Synthesis;
using System.Threading;

namespace ChatBot
{
    class Program
    {

        static string userName;
        
        static void Main(string[] args)
        {


            
            // Logo
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
>>=====================================================================================================================================================<<
||                                                                                                                                                     ||
||  ________       ___    ___  ________   _______    ________   ________   _______    ________   ___  ___   ________   ___   _________     ___    ___  ||
|| |\   ____\     |\  \  /  /||\   __  \ |\  ___ \  |\   __  \ |\   ____\ |\  ___ \  |\   ____\ |\  \|\  \ |\   __  \ |\  \ |\___   ___\  |\  \  /  /| ||
|| \ \  \___|     \ \  \/  / /\ \  \|\ /_\ \   __/| \ \  \|\  \\ \  \___|_\ \   __/| \ \  \___| \ \  \\\  \\ \  \|\  \\ \  \\|___ \  \_|  \ \  \/  / / ||
||  \ \  \         \ \    / /  \ \   __  \\ \  \_|/__\ \   _  _\\ \_____  \\ \  \_|/__\ \  \     \ \  \\\  \\ \   _  _\\ \  \    \ \  \    \ \    / /  ||
||   \ \  \____     \/  /  /    \ \  \|\  \\ \  \_|\ \\ \  \\  \|\|____|\  \\ \  \_|\ \\ \  \____ \ \  \\\  \\ \  \\  \|\ \  \    \ \  \    \/  /  /   ||
||    \ \_______\ __/  / /       \ \_______\\ \_______\\ \__\\ _\  ____\_\  \\ \_______\\ \_______\\ \_______\\ \__\\ _\ \ \__\    \ \__\ __/  / /     ||
||     \|_______||\___/ /         \|_______| \|_______| \|__|\|__||\_________\\|_______| \|_______| \|_______| \|__|\|__| \|__|     \|__||\___/ /      ||
||               \|___|/                                          \|_________|                                                           \|___|/       ||
||  ________   ___  ___   ________   _________   ________   ________   _________                                                                       ||
|| |\   ____\ |\  \|\  \ |\   __  \ |\___   ___\|\   __  \ |\   __  \ |\___   ___\                                                                     ||
|| \ \  \___| \ \  \\\  \\ \  \|\  \\|___ \  \_|\ \  \|\ /_\ \  \|\  \\|___ \  \_|                                                                     ||
||  \ \  \     \ \   __  \\ \   __  \    \ \  \  \ \   __  \\ \  \\\  \    \ \  \                                                                      ||
||   \ \  \____ \ \  \ \  \\ \  \ \  \    \ \  \  \ \  \|\  \\ \  \\\  \    \ \  \                                                                     ||
||    \ \_______\\ \__\ \__\\ \__\ \__\    \ \__\  \ \_______\\ \_______\    \ \__\                                                                    ||
||     \|_______| \|__|\|__| \|__|\|__|     \|__|   \|_______| \|_______|     \|__|                                                                    ||
||                                                                                                                                                     ||
>>=====================================================================================================================================================<<");
            Console.ResetColor();
            Console.WriteLine();

            // Voice greeting
            try
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Sithobile Mkhabela\OneDrive\Documentos\IIE MSA\2025\Semester 1\PROG6221\PROG6221_POE_PART1_ST10448774\ChatBot\bin\Debug\VoiceAudio.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠ Could not play greeting audio: " + ex.Message);
                Console.ResetColor();
            }

            Dictionary<string, string> memory = new Dictionary<string, string>();
            //Welcome message
            Console.WriteLine("\n<<<<<<<<<<  Welcome to the Cybersecurity Chatbot!  >>>>>>>>>>");
            Console.WriteLine();

            Console.Write("\nEnter your username: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            userName = Console.ReadLine().Trim() ?? "User";
            memory["userName"] = userName;
            Console.WriteLine("Got it! I'll remember that your username is " + userName + ".\n");
            Console.ResetColor();
            TypeWrite("Nice to meet you, " + userName + "!", 30);
            Console.WriteLine();

            StartChat();
            
            
        }

        static void StartChat()
        {
            Console.WriteLine("Topics:\n- Cybersecurity\n  *Common cyberattacks\r\n  *Security measures against cyberattacks\r\n- Phishing\n  *Phishing safety precautions\r\n  *Types of phishing\r\n  *Phishing tips\r\n- Password safety\n  *Password safety practices\r\n- Safe browsing\n  *Safe browsing practices\r\n  *Tools used to ensure safe browsing\r\n- Scams\n  *Types of scams\r\n- Privacy *Privacy practices\r\n");
            Console.WriteLine("\nYou can ask me questions like:");
            Console.WriteLine("- How are you?");
            Console.WriteLine("- What's your purpose?");
            Console.WriteLine("- What can I ask you?");
            Console.WriteLine("- What is/define...");
            Console.WriteLine("- Give me a list of security measures/ ");
            Console.WriteLine("- Tell me more/elaborate...INSERT TOPIC");
            Console.WriteLine("- Tell me more...INSERT PRACTICE");
            Console.WriteLine("Type 'exit' or 'bye' to leave.\n");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>\n" + "\n Start the chat:\n");

            Input inputt = new Input();
            inputt.AskUserPreferences();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(userName + ": ");
                Console.ResetColor();

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("I didn't catch that. Can you rephrase?");
                    continue;
                }

                input = input.ToLower();

                if (input == "exit" || input == "bye")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    TypeWrite("<<<<<<<<<<  Goodbye, " + userName + "! Stay safe online.  >>>>>>>>>>", 40);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(new string('=', 154));
                    Console.ResetColor();
                    break;
                }

                
                inputt.RespondToInput(input, userName);
                

            }
        }

        static void TypeWrite(string text, int delayMs)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }
    }
}
