namespace _05.Count_of_Odd_Numbers_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            var oddNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(num => (num% 2 != 0))
                .ToArray();

            Console.WriteLine(oddNumbers.Length);
        }
    }
}
