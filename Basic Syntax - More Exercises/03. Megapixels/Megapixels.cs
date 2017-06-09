namespace _03.Megapixels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Megapixels
    {
        public static void Main()
        {
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());

            var megapixels = (width * height) / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(megapixels,1)}MP");
        }
    }
}
