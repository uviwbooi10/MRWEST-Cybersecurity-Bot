using System;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace CybersecurityChatbot
{
    public static class AudioPlayer
    {
        private const string GreetingFile = "greeting.wav";

        public static void PlayGreeting()
        {
            // Only works on Windows
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return;
            }

            if (!File.Exists(GreetingFile))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("[Audio] greeting.wav not found — skipping voice greeting.");
                Console.ResetColor();
                return;
            }

            try
            {
                SoundPlayer player = new SoundPlayer(GreetingFile);
                player.Play(); // plays without blocking program
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"[Audio] Error: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}