namespace _09.Largest_Element_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestElementInArray
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var arrayOfIntegers = new int[number];

            for (int i = 0; i < number; i++)
            {
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arrayOfIntegers.Max());
        }
    }
}
