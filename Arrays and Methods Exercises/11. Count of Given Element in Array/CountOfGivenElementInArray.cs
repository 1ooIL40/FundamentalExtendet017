namespace _11.Count_of_Given_Element_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var num = int.Parse(Console.ReadLine());

            var count = 0;

            foreach (var number in numbers)
            {
                if(number == num)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
