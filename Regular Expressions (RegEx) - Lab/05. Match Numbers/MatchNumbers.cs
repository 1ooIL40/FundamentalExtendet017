namespace _05.Match_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchNumbers
    {
        public static void Main()
        {
            Regex pattern = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            string numberString = Console.ReadLine();

            var numbers = pattern.Matches(numberString);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
