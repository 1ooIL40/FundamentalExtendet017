namespace _03.Miles_to_Kilometers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MilesToKilometers
    {
        public static void Main()
        {
            var miles = double.Parse(Console.ReadLine());

            var kilometers = miles* 1.60934;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
