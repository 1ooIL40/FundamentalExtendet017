namespace _06.Odd_Numbers_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(i % 2 != 0 && numbers[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }
        }
    }
}
