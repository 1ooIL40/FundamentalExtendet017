namespace _05.Sort_Array_Using_Insertion_Sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int temp, j;
            for (int i = 1; i < numbers.Length; i++)
            {
                temp = numbers[i];
                j = i - 1;
                while (j >= 0 && numbers[j] > temp )
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
