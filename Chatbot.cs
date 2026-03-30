using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityChatbot
{
    internal class Chatbot
    {
            private string userName;

            public void Start()
            {
                UIHelper.TypeText("Hello! What is your name?");
                userName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    userName = "User";
                }

                UIHelper.TypeText($" Welcome, {userName}! Ask me anything about cybersecurity.");
                RunChat();
            }

            private void RunChat()
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{userName}: ");
                    Console.ResetColor();

                    string input = Console.ReadLine().ToLower();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        UIHelper.TypeText("Please enter something.");
                        continue;
                    }

                    if (input.Contains("how are you"))
                    {
                        UIHelper.TypeText("I'm just a bot, but I'm here to help!");
                    }
                    else if (input.Contains("purpose"))
                    {
                        UIHelper.TypeText("My purpose is to help you stay safe online.");
                    }
                    else if (input.Contains("ask"))
                    {
                        UIHelper.TypeText("You can ask me about passwords, phishing, and safe browsing.");
                    }
                    else if (input.Contains("password"))
                    {
                        UIHelper.TypeText("Use strong passwords with numbers, symbols, and uppercase letters.");
                    }
                    else if (input.Contains("phishing"))
                    {
                        UIHelper.TypeText("Be careful of suspicious emails asking for personal info.");
                    }
                    else if (input.Contains("browsing"))
                    {
                        UIHelper.TypeText("Always check if websites use HTTPS.");
                    }
                    else if (input.Contains("exit"))
                    {
                        UIHelper.TypeText("Goodbye! Stay safe online.");
                        break;
                    }
                    else
                    {
                        UIHelper.TypeText("I didn't quite understand that. Could you rephrase?");
                    }
                }
            }
        }
    }