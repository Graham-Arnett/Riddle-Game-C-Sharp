namespace RiddleGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my riddle game app!\n" +
                "You'll be asked a random question, and have to give the word you think is the answer.\n" +
                "You have 3 tries per question, if you fail or get through you will be told what your score was at the end.");

            string[] questions = new string[]{"When you say my name I cease to exist: "};
            //I might make a class or a method for the questions and the answer key but this is the general idea
        }
    }
}
