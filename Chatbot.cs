
namespace CybersecurityChatbot
{
    /// <summary>
    /// The main chatbot class. Handles the conversation loop,
    /// input validation, and cybersecurity response logic.
    /// </summary>
    public class Chatbot
    {
        private readonly User _user;
        private bool _isRunning;

        public Chatbot(User user)
        {
            _user = user;
            _isRunning = true;
        }

        /// <summary>
        /// Starts the main chatbot conversation loop.
        /// </summary>
        public void Start()
        {
            DisplayHelper.BotSay($"Hello, {_user.Name}! I'm the MrWest Cybersecurity Bot.");
            DisplayHelper.BotSay("You can ask me about: passwords, phishing, malware, privacy,");
            DisplayHelper.BotSay("safe browsing, two-factor authentication, or social engineering.");
            DisplayHelper.BotSay("Type 'help' to see all topics, or 'exit' to quit.");
            DisplayHelper.DrawDivider();

            while (_isRunning)
            {
                DisplayHelper.UserPrompt(_user.Name);
                string? rawInput = Console.ReadLine();

                // --- Input Validation: empty or whitespace ---
                if (string.IsNullOrWhiteSpace(rawInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Please enter something. I'm here to help!");
                    Console.ResetColor();
                    continue;
                }

                string input = rawInput.Trim().ToLower();
                ProcessInput(input);
            }
        }

        /// <summary>
        /// Routes user input to the appropriate response method.
        /// </summary>
        private void ProcessInput(string input)
        {
            // Exit command
            if (input == "exit" || input == "quit" || input == "bye")
            {
                HandleExit();
                return;
            }

            // Help menu
            if (input == "help" || input == "topics" || input == "menu")
            {
                ShowHelpMenu();
                return;
            }

            // --- General Questions ---
            if (input.Contains("how are you") || input.Contains("how r u"))
            {
                DisplayHelper.BotSay("I'm just code, but I'm running great and ready to keep you safe online!");
                return;
            }

            if (input.Contains("what is your purpose") || input.Contains("what do you do") || input.Contains("your purpose"))
            {
                DisplayHelper.BotSay($"My purpose, {_user.Name}, is to raise your cybersecurity awareness.");
                DisplayHelper.BotSay("I'll teach you how to protect yourself from online threats like");
                DisplayHelper.BotSay("phishing, malware, weak passwords, and more.");
                return;
            }

            if (input.Contains("your name") || input.Contains("who are you"))
            {
                DisplayHelper.BotSay("I'm the MrWest Cybersecurity Bot — built to keep YOU safe online!");
                return;
            }

            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
            {
                DisplayHelper.BotSay($"Hey there, {_user.Name}! How can I help you stay cyber-safe today?");
                return;
            }

            // --- Cybersecurity Topics ---
            if (input.Contains("password"))
            {
                HandlePassword();
                return;
            }

            if (input.Contains("phishing") || input.Contains("phish"))
            {
                HandlePhishing();
                return;
            }

            if (input.Contains("malware") || input.Contains("virus") || input.Contains("ransomware"))
            {
                HandleMalware();
                return;
            }

            if (input.Contains("two factor") || input.Contains("2fa") || input.Contains("two-factor") || input.Contains("authentication"))
            {
                HandleTwoFactor();
                return;
            }

            if (input.Contains("privacy") || input.Contains("personal data") || input.Contains("data protection"))
            {
                HandlePrivacy();
                return;
            }

            if (input.Contains("safe browsing") || input.Contains("browsing") || input.Contains("browser"))
            {
                HandleSafeBrowsing();
                return;
            }

            if (input.Contains("social engineering") || input.Contains("scam") || input.Contains("fraud"))
            {
                HandleSocialEngineering();
                return;
            }

            if (input.Contains("vpn"))
            {
                HandleVPN();
                return;
            }

            if (input.Contains("firewall"))
            {
                HandleFirewall();
                return;
            }

            if (input.Contains("update") || input.Contains("patch") || input.Contains("software update"))
            {
                HandleUpdates();
                return;
            }

            // --- Unknown input fallback ---
            DisplayHelper.BotSay($"I'm not sure I understood that, {_user.Name}.");
            DisplayHelper.BotSay("Try asking about: passwords, phishing, malware, privacy, 2FA,");
            DisplayHelper.BotSay("safe browsing, VPN, firewall, or social engineering.");
            DisplayHelper.BotSay("Or type 'help' to see all available topics.");
        }

        // ─────────────────────────────────────────────────────────
        // Response Handlers
        // ─────────────────────────────────────────────────────────

        private void HandlePassword()
        {
            DisplayHelper.BotSay($"Great question, {_user.Name}! Here are some password safety tips:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  Use at least 12 characters with symbols, numbers & letters.");
            Console.WriteLine("    ✔  Never reuse the same password across different sites.");
            Console.WriteLine("    ✔  Use a password manager (e.g. Bitwarden, LastPass).");
            Console.WriteLine("    ✔  Avoid using personal info like birthdays or names.");
            Console.WriteLine("    ✔  Change your passwords regularly — especially after a breach.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandlePhishing()
        {
            DisplayHelper.BotSay("Phishing is a major online threat. Here's how to protect yourself:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    Never click suspicious links in emails or SMS messages.");
            Console.WriteLine("    Check the sender's email address carefully for typos.");
            Console.WriteLine("    Legitimate organisations will NEVER ask for your password.");
            Console.WriteLine("    Look for HTTPS and a padlock icon before entering data.");
            Console.WriteLine("    When in doubt — delete the email and contact the company directly.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleMalware()
        {
            DisplayHelper.BotSay("Malware (malicious software) can seriously damage your system:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    Install and keep antivirus software up to date.");
            Console.WriteLine("    Don't download files from untrusted or unknown sources.");
            Console.WriteLine("    Avoid clicking pop-up ads or suspicious download buttons.");
            Console.WriteLine("    Regularly back up your files to an external drive or cloud.");
            Console.WriteLine("    Ransomware encrypts your files — backups are your best defence.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleTwoFactor()
        {
            DisplayHelper.BotSay("Two-Factor Authentication (2FA) adds an extra layer of security:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  Enable 2FA on all important accounts (email, banking, social).");
            Console.WriteLine("    ✔  Use an authenticator app (e.g. Google Authenticator, Authy).");
            Console.WriteLine("    ✔  Avoid SMS-based 2FA where possible — apps are more secure.");
            Console.WriteLine("    ✔  Even if your password is stolen, 2FA blocks unauthorised access.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandlePrivacy()
        {
            DisplayHelper.BotSay("Protecting your personal data is essential online:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  Read privacy policies before signing up for services.");
            Console.WriteLine("    ✔  Limit personal information shared on social media.");
            Console.WriteLine("    ✔  Use private/incognito browsing when on shared computers.");
            Console.WriteLine("    ✔  Review app permissions — does a torchlight app really need contacts?");
            Console.WriteLine("    ✔  Use encrypted messaging apps like Signal for sensitive conversations.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleSafeBrowsing()
        {
            DisplayHelper.BotSay("Safe browsing habits protect you from many online threats:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  Always check for HTTPS before entering personal information.");
            Console.WriteLine("    ✔  Avoid using public Wi-Fi for banking or sensitive tasks.");
            Console.WriteLine("    ✔  Use a browser with built-in security features (Chrome, Firefox).");
            Console.WriteLine("    ✔  Install an ad blocker to reduce exposure to malicious ads.");
            Console.WriteLine("    ✔  Clear cookies and browser history regularly.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleSocialEngineering()
        {
            DisplayHelper.BotSay("Social engineering tricks people into revealing sensitive info:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  Be suspicious of urgent, threatening, or too-good-to-be-true messages.");
            Console.WriteLine("    ✔  Verify identities before sharing any personal or financial data.");
            Console.WriteLine("    ✔  Scammers often impersonate banks, IT support, or government bodies.");
            Console.WriteLine("    ✔  Never allow remote access to your device unless absolutely certain.");
            Console.WriteLine("    ✔  If a deal sounds too good to be true — it probably is.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleVPN()
        {
            DisplayHelper.BotSay("A VPN (Virtual Private Network) keeps your internet traffic private:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  A VPN encrypts your connection, hiding it from your ISP.");
            Console.WriteLine("    ✔  Always use a VPN on public Wi-Fi networks.");
            Console.WriteLine("    ✔  Choose a reputable VPN provider — avoid free ones with unknown policies.");
            Console.WriteLine("    ✔  A VPN hides your IP address, improving anonymity.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleFirewall()
        {
            DisplayHelper.BotSay("A firewall monitors and controls incoming and outgoing network traffic:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  Always keep your system's built-in firewall enabled.");
            Console.WriteLine("    ✔  A firewall acts as a barrier between your device and the internet.");
            Console.WriteLine("    ✔  Hardware firewalls (routers) provide an extra layer of defence.");
            Console.WriteLine("    ✔  Review firewall rules periodically to remove outdated exceptions.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleUpdates()
        {
            DisplayHelper.BotSay("Keeping software updated is one of the simplest ways to stay safe:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ✔  Updates patch known security vulnerabilities in software.");
            Console.WriteLine("    ✔  Enable automatic updates for your OS and applications.");
            Console.WriteLine("    ✔  Outdated software is one of the top causes of cyber attacks.");
            Console.WriteLine("    ✔  This includes your browser, antivirus, and mobile apps.");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void ShowHelpMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  ╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("  ║                    AVAILABLE TOPICS                        ║");
            Console.WriteLine("  ╠════════════════════════════════════════════════════════════╣");
            Console.WriteLine("  ║  passwords          phishing           malware             ║");
            Console.WriteLine("  ║  two-factor / 2fa   privacy            safe browsing       ║");
            Console.WriteLine("  ║  social engineering vpn                firewall            ║");
            Console.WriteLine("  ║  updates            how are you        what is your purpose║");
            Console.WriteLine("  ╠════════════════════════════════════════════════════════════╣");
            Console.WriteLine("  ║  Type 'exit' to quit the chatbot.                          ║");
            Console.WriteLine("  ╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        private void HandleExit()
        {
            _isRunning = false;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            DisplayHelper.TypeWrite($"  Goodbye, {_user.Name}! Stay safe and cyber-aware out there. Love You");
            Console.ResetColor();
            DisplayHelper.DrawDivider();
        }
    }
}