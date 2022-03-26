using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit){
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Exit");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Play.Start();
                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("This is not a valid selection");
                        break;
                }
            }
        }
    }
}
