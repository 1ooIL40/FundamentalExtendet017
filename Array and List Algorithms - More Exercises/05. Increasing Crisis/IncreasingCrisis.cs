using System;
using System.Collections.Generic;
using System.Linq;

namespace Increasing_Crisis
{
    class IncreasingCrisis
    {
        static void Main()
        {
            // 100/100 judge NM
            var n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int input = 0; input < n; input++)
            {
                InsertNumbers(numbers);
                RemoveNumbers(numbers);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void RemoveNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    for (int removed = i + 1; removed < numbers.Count; removed++)
                    {
                        numbers.RemoveAt(removed);
                        removed--;
                    }
                }
            }
        }

        public static void InsertNumbers(List<int> numbers)
        {
            var inputLines = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            bool Empty = numbers.Count == 0 || numbers[numbers.Count - 1] <= inputLines[0];

            if (Empty)
            {
                for (int i = 0; i < inputLines.Count; i++)
                {
                    numbers.Add(inputLines[i]);
                }
            }
            else
            {
                int positionStart = Position(numbers, inputLines);
                var positionEnd = positionStart + inputLines.Count;
                var count = 0;
                for (int position = positionStart; position < positionEnd; position++)
                {
                    numbers.Insert(position, inputLines[count]);
                    count++;
                    if (numbers[position] > numbers[position + 1])
                    {
                        break;
                    }
                }
            }
        }

        public static int Position(List<int> numbers, List<int> inputLines)
        {
            var positionStart = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > inputLines[0])
                {
                    positionStart = i;
                    break;
                }
            }

            return positionStart;
        }
    }
}
