namespace _07.Largest_N_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            ////With Linq only
            //numbers = numbers
            //    .OrderByDescending(num => num)
            //    .Take(n)
            //    .ToArray();
            
            bool swaped;
            do
            {
                swaped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        Swap(i, numbers);
                        swaped = true;
                    }
                }
            }
            while (swaped);

            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            
        }
        static void Swap(int i, int[] numbers)
        {
            int swaping = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = swaping;

        }
    }
}
