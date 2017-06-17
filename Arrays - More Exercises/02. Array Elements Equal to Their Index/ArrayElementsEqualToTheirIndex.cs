namespace _02.Array_Elements_Equal_to_Their_Index
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = EqualElementsAndIdexes(numbers);

            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> EqualElementsAndIdexes(List<int> numbers)
        {
            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers[i])
                {
                    result.Add(numbers[i]);
                }
            }

            return result;
        }
    }
}
