using System;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what card do you have ? (eg 2d for two of diomands)");
            string userInfo = Console.ReadLine();
            string cardNum = "";
            string cardType = "";

            switch (userInfo[0])
            {
                case '2':
                    cardNum = "two";
                    break;
                case '3':
                    cardNum = "three";
                    break;
                case '4':
                    cardNum = "four";
                    break;
                case '5':
                    cardNum = "five";
                    break;
                case '6':
                    cardNum = "six";
                    break;
                case '7':
                    cardNum = "seven";
                    break;
                case '8':
                    cardNum = "eight";
                    break;
                case '9':
                    cardNum = "nine";
                    break;
                case 'q':
                    cardNum = "Queen";
                    break;
                case 'a':
                    cardNum = "ace";
                    break;
                case 'K':
                    cardNum = "king";
                    break;
                case 'j':
                    cardNum = "jack";
                    break;
                default:
                    cardNum = "ten";
                    break;
            }
            switch (userInfo[1])
            {
                case 'd':
                    cardType = " of diomands";
                    break;
                case 'h':
                    cardType = " of hearts";
                    break;
                case 's':
                    cardType = ""
                default:
                    break;
            }
        }
    }
}
