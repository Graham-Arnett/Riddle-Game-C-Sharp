using System.Diagnostics.CodeAnalysis;

namespace RiddleGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my riddle game app!\n" +
                "You'll be asked a random question, and have to give the word you think is the answer.\n" +
                "You have 3 tries per question, if you fail or get through you will be told what your score was at the end.");

            string[] questions = new string[]{"When you say my name I cease to exist: ", "Poor men have me but rich men don't: "};
            //I might make a class or a method for the questions and the answer key but this is the general idea, though I think I'll save that for the advanced version
            //answers array has riddle answers, maybe we check if its right by if the index positions match?
            string[] answers = new string[] {"silence", "nothing"};

            foreach (string question in questions) 
            {
                Console.WriteLine(question);
            }
        }
    }
}
