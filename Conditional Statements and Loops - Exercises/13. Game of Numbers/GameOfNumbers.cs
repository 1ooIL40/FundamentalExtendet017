namespace _13.Game_of_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GameOfNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var firstNumber = 0;
            var secondNumber = 0;
            var combinationsCount = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    var sum = i + j;

                    if(sum == magicalNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                    }

                    combinationsCount++;
                }

            }

            var foundetNumbersSum = firstNumber + secondNumber;

            if(foundetNumbersSum == magicalNumber)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {foundetNumbersSum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
