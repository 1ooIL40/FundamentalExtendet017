namespace _03.Exact_Product_of_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExactProductOfRealNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var outputNum = 1m;

            for (int i = 0; i < n; i++)
            {
                var number = decimal.Parse(Console.ReadLine());

                outputNum *= number;
            }
            Console.WriteLine(outputNum);
        }
    }
}
