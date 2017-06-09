namespace _09.Count_the_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountTheIntegers
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var number = 0;
            var count = 0;
            
            while (int.TryParse(inputLine, out number))
            {
                inputLine = Console.ReadLine();
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
