using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace CyberSecurityChatbot
{
    internal class AudioHelper
    {

        public static void PlayGreeting()
        {
            try
            {
                //Audio plays in the beginning
                SoundPlayer player = new SoundPlayer("welcome.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio could not be played.");
            }
        }
    }
}



