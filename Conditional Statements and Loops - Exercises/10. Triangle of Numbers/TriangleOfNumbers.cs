namespace _10.Triangle_of_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TriangleOfNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
