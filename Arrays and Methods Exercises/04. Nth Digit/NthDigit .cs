namespace _04.Nth_Digit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var result = FindNthDigit(number, index);

            Console.WriteLine(result);
        }

        static int FindNthDigit(long number, int index)
        {
            var numToString = number.ToString().ToCharArray();

            var result = numToString[numToString.Length - index];

            return int.Parse(result.ToString());
        }
    }
}
