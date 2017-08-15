namespace _03.Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine().ToUpper();
            string repeatingSymbols = Repeate(inputLine);
            int uniqueSymols = UniqueSymbolsReturn(repeatingSymbols);

            

            Console.WriteLine($"Unique symbols used: {uniqueSymols}");
            Console.WriteLine(repeatingSymbols);
        }

        static string Repeate(string inputLine)
        {
            List<int> reapeateTimes = new List<int>();
            Regex nums = new Regex(@"\d+");
            var matches = nums.Matches(inputLine);
            inputLine = nums.Replace(inputLine, "1");

            string[] splitedSymbols = inputLine
                .Split(new char[] { '1' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (Match match in matches)
            {
                reapeateTimes.Add(int.Parse(match.Value));
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < reapeateTimes.Count; i++)
            {
                string newString = string.Concat(Enumerable.Repeat(splitedSymbols[i], reapeateTimes[i]));
                result.Append(newString);
            }



            return result.ToString();
        }

        static int UniqueSymbolsReturn(string syblos)
        {
            int result = syblos.Distinct().Count();

            return result;
        }
    }
}
