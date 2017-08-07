namespace _03.Match_Hexadecimal_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            Regex patter = new Regex(@"\b(0x)?[0-9A-F]+\b");

            string text = Console.ReadLine();

            var matchColl = patter.Matches(text);

            foreach (Match m in matchColl)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
        }
    }
}
