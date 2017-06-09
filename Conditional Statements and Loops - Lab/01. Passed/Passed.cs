namespace _01.Passed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Passed
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if(grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
