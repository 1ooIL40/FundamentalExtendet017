namespace _02.Circle_Perimeter_12_Digits_Precision
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CirclePerimeter12DigitsPrecision
    {
        public static void Main()
        {
            var r = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(2*Math.PI*r):f12}");
        }
    }
}
