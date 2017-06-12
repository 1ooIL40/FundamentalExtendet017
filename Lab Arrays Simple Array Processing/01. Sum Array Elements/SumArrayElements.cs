namespace _01.Sum_Array_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumArrayElements
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
