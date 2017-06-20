namespace _01.Remove_Elements_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            var elements = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var oddPositionElemnts = new List<string>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 2 != 0)
                {
                    oddPositionElemnts.Add(elements[i]);
                }
            }

            Console.WriteLine(string.Join("",oddPositionElemnts));
        }
    }
}
