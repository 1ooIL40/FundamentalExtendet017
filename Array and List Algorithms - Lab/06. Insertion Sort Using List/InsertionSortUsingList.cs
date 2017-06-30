namespace _06.Insertion_Sort_Using_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int temp, j;
            for (int i = 1; i < numbers.Count; i++)
            {
                temp = numbers[i];
                j = i - 1;
                while (j >= 0 && numbers[j] > temp)
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
