namespace _14.Equal_Sequence_of_Elements_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSequenceOfElementsInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var answer = string.Empty;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                answer = "Yes";
                if (numbers[i] != numbers[i + 1])
                {
                    answer = "No";
                    break;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
