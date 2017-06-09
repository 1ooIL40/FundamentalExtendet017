namespace _12.Number_Checker
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class NumberChecker
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            var num = 0;
            var itsNumber = int.TryParse(number, out num);

            if (itsNumber)
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
