namespace _10.Count_of_Negative_Elements_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfNegativeElementsInArray
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                var n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }

            var count = 0;

            foreach (var numi in numbers)
            {
                if (numi < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
