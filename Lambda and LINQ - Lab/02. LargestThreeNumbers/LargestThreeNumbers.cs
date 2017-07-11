namespace _02.Largest_Three_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestThreeNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToArray();

            Console.WriteLine($"{string.Join(" ",numbers)}");
        }
    }
}
