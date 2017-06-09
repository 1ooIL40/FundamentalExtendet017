namespace _01.Debit_Card_Number
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DebitCardNumber
    {
        public static void Main()
        {
            var result = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                var number = int.Parse(Console.ReadLine());
                result.Add(number);
            }

            foreach (var num in result)
            {
                Console.Write("{0:d4} ", num);
            }
        }
    }
}
