namespace _02.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                   .Split(new char[] { ' ' },
                   StringSplitOptions.RemoveEmptyEntries)
                   .Select(double.Parse)
                   .ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }
                result[num]++;
            }

            foreach (var kvp in result)
            {
                //var timeString = kvp.Value == 1 ? "time" : "times";

                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
