# ST10448774_PROG6221_PART3

Programming 2A (PROG6221) - Part 3

GitHub link: https://github.com/MkhabelaSthobile/ST10448774_PROG6221_PART3.git

Video link: https://youtu.be/LsUQbJuMYeM?si=Kg1ARDDfbe3BCEzT


App instructions:

# Cybersecurity ChatBot

This is a C# Windows Forms application that simulates a chatbot focused on cybersecurity education. The bot helps users learn about safe online practices, manage cybersecurity-related tasks, and test their knowledge through a quiz.

## Features

- Chat with a bot that responds to cybersecurity questions
- Recognises different ways users phrase questions using simple keyword detection
- Allows users to add and manage cybersecurity-related tasks and reminders
- Provides a cybersecurity quiz with multiple-choice questions
- Keeps an activity log of user actions such as tasks added or quizzes taken

## How to Use

1. Run the application by opening `MainChatForm`.
2. Type your messages in the input box and click "Send".
3. You can interact with the chatbot by typing commands such as:
   - `Add a task to update my password`
   - `Remind me to check privacy settings`
   - `Start quiz`
   - `Show activity log`
4. The chatbot will respond accordingly or open the Task Assistant window when needed.

## Technologies Used

- C# (.NET Windows Forms)
- Basic string matching and keyword detection for NLP simulation
- Lists and dictionaries for managing tasks, quiz questions, and user memory

## Project Files

- `MainChatForm.cs` – The main chatbot interface
- `Input.cs` – Handles the bot's logic and responses
- `TaskAssistantForm.cs` – Allows users to view and manage tasks
- `CyberQuiz.cs` – Stores quiz questions and explanations
- `RandomResponses.cs`, `Elaborator.cs` – Handle extra responses and definitions

## Example Prompts to Try

- What is phishing?
- How do I stay safe online?
- Start the quiz
- Add a task to enable two-factor authentication
- What have you done?

## Notes

- The form is resizable and anchored so it adjusts to different screen sizes.
- The chatbot uses simulated NLP by detecting keywords in user input.
- The activity log displays the last 5 actions by default.
