#  MrWest Cybersecurity Bot

**PROG6221 – Portfolio of Evidence – Part 1**  
**Student:** Uviwe Booi  
**Student Number:** ST10491015  

---

##  Overview

A C# console-based chatbot called **MrWest Cybersecurity Bot** that raises cybersecurity awareness. The bot greets users with a voice message and ASCII art logo, asks for their name, and then answers cybersecurity questions in an interactive conversation loop.

---

##  Features

-  **Voice Greeting** – Plays `greeting.wav` on startup using `SoundPlayer`
-  **ASCII Art Logo** – Cybersecurity-themed banner displayed on launch
-  **User Interaction** – Asks for the user's name and personalises all responses
-  **Response System** – Responds to 10+ cybersecurity topics
-  **Input Validation** – Handles empty input and unknown questions gracefully
-  **Enhanced Console UI** – Colour-coded output, typing effect, and styled borders
-  **Proper Code Structure** – Split across multiple classes

---

## Project Structure

```
CybersecurityChatbot/
├── Program.cs          → Entry point
├── Chatbot.cs          → Main conversation logic & responses
├── User.cs             → Stores and retrieves user name
├── AudioPlayer.cs      → Plays greeting.wav at startup
├── DisplayHelper.cs    → Console UI (colours, ASCII art, typing effect)
├── greeting.wav        → Voice greeting file (add your own recording)
├── CybersecurityChatbot.csproj
├── README.md
└── .github/
    └── workflows/
        └── dotnet.yml  → GitHub Actions CI
```

---

##  Supported Topics

Ask the bot about any of the following:

| Topic | Example input |
|-------|---------------|
| Passwords | `tell me about passwords` |
| Phishing | `what is phishing` |
| Malware | `how does malware work` |
| Two-Factor Auth | `what is 2fa` |
| Privacy | `how do I protect my privacy` |
| Safe Browsing | `safe browsing tips` |
| Social Engineering | `what is social engineering` |
| VPN | `what is a vpn` |
| Firewall | `tell me about firewalls` |
| Software Updates | `why should I update my software` |

---

##  Adding Your Voice Greeting

1. Record a WAV file using Windows Voice Recorder
2. Say: *"Hello! Welcome to the MR WEST Cybersecurity Awareness Bot. I'm here to help you stay safe online."*
3. Rename the file to `greeting.wav`
4. Place it in the same folder as the compiled `.exe` (`bin/Debug/net8.0/`)

---

##  How to Run

```bash
# Clone the repository
git clone https://github.com/uviwbooi10/CybersecurityChatbot.git
cd CybersecurityChatbot

# Build and run
dotnet run
```

---

##  CI/CD

GitHub Actions automatically builds the project on every push to `main`. Check the **Actions** tab for the build status badge.

---

### Workflow Screenshot

<img width="1907" height="1079" alt="Screenshot 2026-04-13 222538" src="https://github.com/user-attachments/assets/80115f16-5f6f-4a1e-8c3c-699674421f93" />


##  References

- Microsoft Docs – [Console class](https://learn.microsoft.com/en-us/dotnet/api/system.console)
- Microsoft Docs – [SoundPlayer](https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer)
