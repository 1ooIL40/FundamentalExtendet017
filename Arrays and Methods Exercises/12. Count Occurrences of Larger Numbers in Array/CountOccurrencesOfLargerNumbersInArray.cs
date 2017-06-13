namespace _12.Count_Occurrences_of_Larger_Numbers_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOccurrencesOfLargerNumbersInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                 .Split(new char[] { ' ' },
                 StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToArray();

            var p = double.Parse(Console.ReadLine());


            numbers = numbers
                .Where(x => x > p)
                .ToArray();

            Console.WriteLine(numbers.Length);
        }
    }
}
