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
                "You have 3 tries per question, if you fail or get through you will be told what your score was at the end. Note all answers are a single word. If you want a hint, say hint when prompted for an answer.");
            string choice;
            
            string[] questions = new string[]{"When you say my name I cease to exist: ", "Poor men have me but rich men don't: ","I have a face and a tail, but no body: ", "I am made of neither flesh nor bone. I have no arms, but I have fingers and thumbs of my own: "};
          
            string[] answers = new string[] {"silence", "nothing","coin", "glove"};

            string[] hints = new string[] {"The absence of volume", "The opposite of everything", "A currency made of metal","A clothing item that you wear during the winter"};
            do
            {
                int score = 0;
                int hintUse = 0;
         
                for (int i = 0; i < questions.Length; i++)
                {
                    Console.Write(questions[i]);

                   
                    string userAnswer = Console.ReadLine().Trim().ToLower();

                    if (userAnswer == "hint")
                    {
                        Console.WriteLine(hints[i]);
                        hintUse++;
                        i--;
                    }
                        
                    else if (userAnswer == answers[i].ToLower())
                    {
                        Console.WriteLine("You are CORRECT!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You are WRONG!");
                    }
                }
                Console.WriteLine($"You ended up with a score of: {score}!");
                if (hintUse == 0)
                {
                    Console.WriteLine("Woah! You're a real super sleuth!");
                }
                else if (hintUse == 1) 
                {
                    Console.WriteLine("Not bad, but you could do better!");
                }
                else 
                {
                    Console.WriteLine("Riddles might not be your strong suit.");
                }
                Console.Write("\nWould you like to try again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
