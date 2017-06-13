namespace _15.Count_of_Capital_Letters_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var singleLeters = text
                .Where(s => s.Length == 1)
                .ToArray();


            var count = 0;

            foreach (var letter in singleLeters)
            {
                var chars = char.Parse(letter);

                if(chars >= 65 && chars <= 90)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
