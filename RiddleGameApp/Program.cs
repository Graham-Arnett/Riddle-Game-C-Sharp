using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;

namespace RiddleGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my riddle game app!\n" +
                "You'll be asked a random question, and have to give the word you think is the answer.\n" +
                "You have 3 tries per question, if you fail or get through you will be told what your score was at the end. Note all answers are a single word.");
            string choice;
            
            string[] questions = new string[]{"When you say my name I cease to exist: ", "Poor men have me but rich men don't: ","I have a face and a tail, but no body: "};
          
            string[] answers = new string[] {"silence", "nothing","coin"};
            do
            {
                int score = 0;
         
                for (int i = 0; i < questions.Length; i++)
                {
                    Console.Write(questions[i]);

                   
                    string userAnswer = Console.ReadLine().Trim().ToLower();

                    if (userAnswer == answers[i].ToLower())
                    {
                        Console.WriteLine("You are CORRECT!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You are WRONG!");
                    }
                }
                Console.WriteLine($"You ended up with a score of: {score}");
                Console.Write("\nWould you like to try again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
