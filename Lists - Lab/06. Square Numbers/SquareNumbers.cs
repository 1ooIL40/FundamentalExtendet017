namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SquareNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x=> (Math.Sqrt(x) == (int)(Math.Sqrt(x))))
                .OrderByDescending(x => x)
                .ToList();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
