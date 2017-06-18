namespace _05.Sort_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SortNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .OrderBy(n => n)
                .ToList();


            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
