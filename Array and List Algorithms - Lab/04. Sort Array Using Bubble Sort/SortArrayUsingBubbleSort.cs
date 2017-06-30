namespace _04.Sort_Array_Using_Bubble_Sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool swaped;
            do
            {
                swaped = false;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if(numbers[i] < numbers[i + 1])
                    {
                        Swap(i, numbers);
                        swaped = true;
                    }
                }
            }
            while (swaped);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void Swap(int i, List<int> numbers)
        {
            int swaping = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = swaping;

        }
    }
}
