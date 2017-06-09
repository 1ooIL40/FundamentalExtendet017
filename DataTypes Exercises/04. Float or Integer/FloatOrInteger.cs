namespace _04.Float_or_Integer
{
    using System;

    public class FloatOrInteger
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());

            var result = Math.Round(number);

            Console.WriteLine(result);
        }
    }
}
