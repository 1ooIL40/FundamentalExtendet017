namespace _02.Binary_Search
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BinarySearch
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int element = int.Parse(Console.ReadLine());


            LinearSearch(numbers, element);

            BinarySearching(numbers, element);

        }

        static void BinarySearching(List<int> numbers, int element)
        {
            bool isFound = false;
            numbers.Sort();

            int counter = 0;
            int first = 0;
            int last = numbers.Count - 1;
            int mid = 0;

            while (first <= last)
            {
                counter++;
                mid = (first + last) / 2;

                if (element > numbers[mid])
                {
                    first = mid + 1;
                }
                else if (element < numbers[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    isFound = true;
                    break;
                }

            }
            if (isFound)
            {
                Console.WriteLine($"Binary search made {counter} iterations");
            }
            else
            {
                Console.WriteLine($"Binary search made {counter} iterations");
            }
        }

        static void LinearSearch(List<int> numbers, int element)
        {
            int currendPosition = 0;
            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == element)
                {
                    currendPosition = i + 1;
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Linear search made {currendPosition} iterations");
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {numbers.Count} iterations");
            }
        }
    }
}
