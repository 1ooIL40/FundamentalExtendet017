namespace _02.Multiply_an_Array_of_Doubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var n = double.Parse(Console.ReadLine());


            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] *= n;
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }

}
