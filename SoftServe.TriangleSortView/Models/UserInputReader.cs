using System;

namespace SoftServe.TriangleSortView
{
    class UserInputReader
    {
        public static string ReadUserInput()
        {
            string message = "Enter triangle in format <name>,<side A>,<side B>,<side C>";
            
            Console.Clear();

            Printer printer = new Printer();

            printer.Message(message);

            string userInput = Console.ReadLine();

            return userInput;
        }

        public static bool ContinueInput()
        {
            bool continueUserInput = false;
            string message = "Continue? (Enter y/yes - to continue.)";
            string userAnswer = string.Empty;

            Console.Clear();

            Printer printer = new Printer();

            printer.Message(message);
            userAnswer = Console.ReadLine();
            userAnswer = userAnswer.ToLower();

            if (userAnswer == "y" || userAnswer == "yes")
            {
                continueUserInput = true;
            }

            return continueUserInput;
        }
    }
}
