namespace _02.Passed_or_Failed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PassedOrFailed
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
