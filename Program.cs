

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play voice greeting on startup
            AudioPlayer.PlayGreeting();

            // Display ASCII art logo
            DisplayHelper.ShowLogo();

            // Create user and start chatbot
            User user = new User();
            user.GetName();

            Chatbot chatbot = new Chatbot(user);
            chatbot.Start();
        }
    }
}