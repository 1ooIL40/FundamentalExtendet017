namespace _07.From_Terabytes_to_Bits
{
    using System;

    public class FromTerabytesToBits
    {
        public static void Main()
        {
            var teraBytes = double.Parse(Console.ReadLine());

            decimal oneBite = (decimal)1024 * 1024 * 1024 * 1024 * 8;

            var result = oneBite * (decimal)teraBytes;

            Console.WriteLine($"{result:f0}");
        }
    }
}
