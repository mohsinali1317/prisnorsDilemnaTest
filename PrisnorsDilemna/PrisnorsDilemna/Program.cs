using System;

namespace PrisnorsDilemna
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter player one name");
            string playerOneName = Console.ReadLine();


            Console.WriteLine("Select a strategy for the " + playerOneName);
            Console.WriteLine("Press 1 for Tit for Tat");
            Console.WriteLine("Press 2 for doing Defect All");
            Console.WriteLine("Press 3 for doing Coperate All");

            ConsoleKeyInfo ck = Console.ReadKey();

            Strategy strategy;

            if (ck.Key == ConsoleKey.D1 || ck.Key == ConsoleKey.NumPad1)
                strategy = Strategy.TitForTat;

            else if (ck.Key == ConsoleKey.D2 || ck.Key == ConsoleKey.NumPad2)
                strategy = Strategy.AlwaysDefect;

            else if (ck.Key == ConsoleKey.D3 || ck.Key == ConsoleKey.NumPad3)
                strategy = Strategy.AlwaysCoperate;
            else
                strategy = Strategy.AlwaysDefect;

            Player playerOne = new Player(playerOneName, 0, strategy);

            Console.WriteLine("");
            Console.WriteLine("Enter player two name");
            string playerTwoName = Console.ReadLine();


            Console.WriteLine("Select a strategy for the " + playerOneName);
            Console.WriteLine("Press 1 for Tit for Tat");
            Console.WriteLine("Press 2 for doing Defect All");
            Console.WriteLine("Press 3 for doing Coperate All");

            ck = Console.ReadKey();

            if (ck.Key == ConsoleKey.D1 || ck.Key == ConsoleKey.NumPad1)
                strategy = Strategy.TitForTat;

            else if (ck.Key == ConsoleKey.D2 || ck.Key == ConsoleKey.NumPad2)
                strategy = Strategy.AlwaysDefect;

            else if (ck.Key == ConsoleKey.D3 || ck.Key == ConsoleKey.NumPad3)
                strategy = Strategy.AlwaysCoperate;
            else
                strategy = Strategy.AlwaysDefect;

            Player playerTwo = new Player(playerTwoName, 0, strategy);

            Console.WriteLine();

            int count = 0;
            while(count <= 5)
            {

                Console.WriteLine(playerOne.Name + " " + playerOne.DoMove(playerTwo));
                Console.WriteLine(playerOne.Name + " " + playerTwo.DoMove(playerOne));

                Score.GetScore(ref playerOne, ref playerTwo);

                Console.WriteLine(playerOne.Name + " -- " + playerOne.Score);
                Console.WriteLine(playerTwo.Name + " -- " + playerTwo.Score);

                count++;
            }


            Console.WriteLine("**Final Score**");

            Console.WriteLine(playerOne.Name + " " + playerOne.Score);
            Console.WriteLine(playerTwo.Name + " " + playerTwo.Score);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();



        }
    }
}