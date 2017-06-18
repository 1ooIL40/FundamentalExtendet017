namespace _07.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var coutList = new int[numbers.Max() + 1];

            foreach (var number in numbers)
            {
                coutList[number]++;
            }

            for (int i = 0; i < coutList.Length; i++)
            {
                if(coutList[i] != 0)
                {
                    Console.WriteLine($"{i} -> {coutList[i]}");
                }
            }
        }
    }
}
