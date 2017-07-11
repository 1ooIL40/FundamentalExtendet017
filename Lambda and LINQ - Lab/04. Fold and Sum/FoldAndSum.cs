namespace _04.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] firstTopPart = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            int[] secondTopPart = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            int[] topPart = firstTopPart
                .Concat(secondTopPart)
                .ToArray();

            int[] bottomPart = numbers
                .Skip(k)
                .Take(k * 2)
                .ToArray();


            for (int i = 0; i < bottomPart.Length; i++)
            {
                Console.Write($"{topPart[i] + bottomPart[i]} ");
            }
        }
    }
}
