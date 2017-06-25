namespace _01.Distinct_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(int.Parse)
                .ToList()
                .Distinct();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
