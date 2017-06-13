namespace _05.Integer_to_Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerToBase
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var result = IntToBase(number, toBase);

            Console.WriteLine(result);
        }

        static string IntToBase(long number, int toBase)
        {
            var result = string.Empty;
            while (number > 0)
            {
                var reminder = number % toBase;

                result = reminder + result;

                number /= toBase;

            }

            return result;
        }
    }
}
