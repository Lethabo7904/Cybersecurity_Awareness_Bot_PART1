using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Net;
using System.Threading;

namespace Cybersecurity_Awareness_Bot_PART1
{

    public class cybersecurity_chatbot
    {

        //constructor
        public cybersecurity_chatbot()
        {
           
            // displaying the header
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            DisplayHeader("WELCOME TO THE CYBERSECURITY AWARENESS CHATBOT.");
            Console.ResetColor();

            // Prompt for user's name
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Please enter your name: \n");
            string userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            DisplayAiChat($"hello, {userName}");

            Console.ForegroundColor = ConsoleColor.Blue;
            DisplayAiChat("You are more than welcome to ask me any questions to feed your curiosity pertaining" +
            " cybersecurity.\n");
            Console.WriteLine("Type 'exit' to end the chat.");
            Console.ResetColor();



            // Dictionary to hold general questions and responses
            Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "how are you?", "I am fantastic, how about yourself?" },
            { "what is your purpose?", "I am designed to educate and inform users like you about cybersecurity best practices, " +
            "potential threats, and how to protect themselves and their organizations from cyber attacks." },
            { "what can i ask you about?", "You are more than welcome to ask me anything pertaining to cybersecurity.\n" }
        };

            // Arrays for specific topics
            string[] phishingInfo = {
            "Phishing is a type of cyberattack that uses fraudulent emails, text messages, phone calls, or websites to trick people into sharing sensitive data.",
            "Phishing attacks often impersonate legitimate organizations to gain the trust of the victim.",
            "Common signs of phishing include poor spelling and grammar, generic greetings, and urgent requests for personal information.\n"
        };

            string[] passwordSafetyInfo = {
            "To ensure a strong password, use at least 12 characters and include a mix of letters, numbers, and special characters.",
            "Avoid using easily guessable information like your name, birthday, or common words.",
            "Consider using a password manager to generate and store complex passwords securely.\n"
        };

            string[] malwareInfo = {
            "Malware, short for malicious software, refers to any intrusive software developed by cybercriminals to steal data or damage systems.",
            "Common types of malware include viruses, worms, trojan horses, ransomware, and spyware.",
            "To protect against malware, keep your software updated, use antivirus programs, and avoid downloading files from untrusted sources.\n"
        };


            string userInput;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{userName}: "); // The user's personalized name
                userInput = Console.ReadLine().ToLower();

                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    DisplayAiChat("ChatBot: Goodbye. Remember to stay safe online ;)!");
                    Console.ResetColor();
                    break;
                }

                // Check if the input exists in the dictionary
                if (responses.TryGetValue(userInput, out string response))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    DisplayAiChat($"ChatBot: {response}");
                }
                else if (userInput.Contains("phishing"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("ChatBot: Here is some information about phishing:");
                    foreach (string info in phishingInfo)
                    {
                        Console.ForegroundColor = ConsoleColor.White ;
                        Console.WriteLine($"- {info}");
                    }
                }
                else if (userInput.Contains("password safety"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("ChatBot: Here is some information about password safety:");
                    foreach (string info in passwordSafetyInfo)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"- {info}");
                    }
                }
                else if (userInput.Contains("malware"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("ChatBot: Here is some information about malware:");
                    foreach (string info in malwareInfo)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"- {info}");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("ChatBot: I am sorry I do not have the answer to that question, " +
                        "please ask questions that are cybersecurity related :(!!!");
                }
                Console.ResetColor(); // Reset color to default
            }

            while (true);
        }//end of constructor
            

            //method for displaying header
            private void DisplayHeader(string header)
        {
            string border = new string('=', 160);
            Console.WriteLine(border);
            Console.WriteLine(header.PadLeft((border.Length + header.Length) / 2));
            Console.WriteLine(border);
        }

        private void DisplayAiChat(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ChatBot:");
            Console.ResetColor();
            TypingEffect(message);
        }

        //Typing effect method
        private void TypingEffect(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
            Console.ResetColor();


            //end of constructor

            //Typing effect with ChatBot label

        }//end of TypingEffect method
    }//end of class
   } //end of namespace
