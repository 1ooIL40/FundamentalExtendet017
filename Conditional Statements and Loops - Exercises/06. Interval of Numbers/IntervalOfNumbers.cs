namespace _06.Interval_of_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntervalOfNumbers
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var endPoint = Math.Max(firstNumber, secondNumber);
            var startPoint = Math.Min(firstNumber, secondNumber);

            for (int i = startPoint; i <= endPoint; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
