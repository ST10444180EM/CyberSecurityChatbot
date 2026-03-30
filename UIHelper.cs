using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CyberSecurityChatbot
{
    internal class UIHelper
    {
            public static void ShowHeader()
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("=========================================");
                Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
                Console.WriteLine("=========================================");

                Console.WriteLine(@"
       (^_^)
      <(   )>
       /   \
");

                Console.ResetColor();
            }

            public static void TypeText(string message)
            {
                foreach (char c in message)
                {
                    Console.Write(c);
                    Thread.Sleep(30);
                }
                Console.WriteLine();
            }
        }
    }