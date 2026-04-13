
namespace CybersecurityChatbot
{
    /// <summary>
    /// Provides helper methods for enhanced console UI output.
    /// Includes ASCII art, colours, borders, and typing effect.
    /// </summary>
    public static class DisplayHelper
    {
        /// <summary>
        /// Displays the ASCII art logo for the Cybersecurity Chatbot.
        /// </summary>
        public static void ShowLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
  
  ║                                                              ║
  ║   ███╗   ███╗██████╗     ██╗    ██╗███████╗███████╗████████╗ ║
  ║   ████╗ ████║██╔══██╗    ██║    ██║██╔════╝██╔════╝╚══██╔══╝ ║
  ║   ██╔████╔██║██████╔╝    ██║ █╗ ██║█████╗  ███████╗   ██║    ║
  ║   ██║╚██╔╝██║██╔══██╗    ██║███╗██║██╔══╝  ╚════██║   ██║    ║
  ║   ██║ ╚═╝ ██║██║  ██║    ╚███╔███╔╝███████╗███████║   ██║    ║
  ║   ╚═╝     ╚═╝╚═╝  ╚═╝     ╚══╝╚══╝ ╚══════╝╚══════╝   ╚═╝    ║
  ║                                                              ║
  ║          CYBERSECURITY BOT  |  Stay Safe Online              ║
  ║           Uviwe Booi                2025                     ║
  
");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypeWrite("  Hello! Welcome to the MrWest Cybersecurity Bot, Created by Uviwe Booi.");
            Console.WriteLine();
            TypeWrite("  I'm here to help you stay safe online.\n");
            Console.ResetColor();

            DrawDivider();
        }

        /// <summary>
        /// Prints a coloured divider line across the console.
        /// </summary>
        public static void DrawDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("  " + new string('─', 58));
            Console.ResetColor();
        }

        /// <summary>
        /// Prints text one character at a time to simulate a typing effect.
        /// </summary>
        /// <param name="text">Text to display.</param>
        /// <param name="delayMs">Milliseconds between each character (default 25ms).</param>
        public static void TypeWrite(string text, int delayMs = 25)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Prints a bot response with cyan colour and a small label prefix.
        /// </summary>
        public static void BotSay(string message)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Bot: ");
            Console.ResetColor();
            TypeWrite(message, 18);
            Console.WriteLine();
        }

        /// <summary>
        /// Prints the prompt for user input.
        /// </summary>
        public static void UserPrompt(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {userName}: ");
            Console.ResetColor();
        }
    }
}