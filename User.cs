// Manages user name input
namespace CybersecurityChatbot
{
    /// <summary>
    /// Represents the user interacting with the chatbot.
    /// Stores the user's name for personalised responses.
    /// </summary>
    public class User
    {
        public string Name { get; private set; } = "User";

        /// <summary>
        /// Prompts the user to enter their name and validates the input.
        /// </summary>
        public void GetName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            DisplayHelper.TypeWrite("Before we begin, what is your name? ");
            Console.ResetColor();

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Name = "User";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  No name entered. I'll call you 'User' for now.\n");
                Console.ResetColor();
            }
            else
            {
                Name = input.Trim();
                Console.ForegroundColor = ConsoleColor.Green;
                DisplayHelper.TypeWrite($"\n  Nice to meet you, {Name}! Let's get you cyber-safe.\n");
                Console.ResetColor();
            }

            DisplayHelper.DrawDivider();
        }
    }
}
