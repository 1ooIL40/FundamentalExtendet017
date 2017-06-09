namespace _12.Test_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var outputSum = 0;
            var combinationsCount = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {

                    if(outputSum >= maxSum)
                    {
                        break;
                    }
                    outputSum += (3 * (i * j));
                    combinationsCount++;
                }
            }
            Console.WriteLine($"{combinationsCount} combinations");
            if (outputSum >= maxSum)
            {
                Console.WriteLine($"Sum: {outputSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {outputSum}");
            }
        }
    }
}
