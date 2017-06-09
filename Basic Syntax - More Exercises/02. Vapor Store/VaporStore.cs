namespace _02.Vapor_Store
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class VaporStore
    {
        public static void Main()
        {
            var currentBalance = double.Parse(Console.ReadLine());
            var game = Console.ReadLine();

            var totalMoney = currentBalance;

            var gameDictionery = new Dictionary<string, double>();

            gameDictionery["OutFall 4"] = 39.99;
            gameDictionery["CS: OG"] = 15.99;
            gameDictionery["Zplinter Zell"] = 19.99;
            gameDictionery["Honored 2"] = 59.99;
            gameDictionery["RoverWatch"] = 29.99;
            gameDictionery["RoverWatch Origins Edition"] = 39.99;


            while (game != "Game Time")
            {
                if (!gameDictionery.ContainsKey(game))
                {
                    Console.WriteLine("Not Found");
                }
                else if(currentBalance < gameDictionery[game])
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= gameDictionery[game];
                }


                if(currentBalance > 0)
                {
                    game = Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${(totalMoney - currentBalance):f2}. Remaining: ${currentBalance:f2}");
            }
            
        }
    }
}
