namespace CyberSecurityChatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Header 
            Console.Title = "Cybersecurity Awareness Bot";

            UIHelper.ShowHeader();
            AudioHelper.PlayGreeting();

            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}