using System;

namespace week_3_question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what score did you get?");
            int gameScore = int.Parse(Console.ReadLine());
            string gameQuote = "";

            switch (gameScore / 10)
            {
                case 10:
                case 9:
                case 8:
                    gameQuote = "Awsome dude";
                    break;
                case 7:
                    gameQuote = "Your good dude";
                    break;
                case 6:
                    gameQuote = "Some potential here dude";
                    break;
                case 5:
                    gameQuote = "back to the training ground dude";
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    gameQuote = "dont quit your day job";
                    break;
            }
            Console.WriteLine(gameQuote);
        }
    }
}
