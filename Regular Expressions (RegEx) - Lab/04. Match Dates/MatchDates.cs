namespace _04.Match_Dates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            Regex pattern = new Regex(@"\b(\d{2})([\.\/-])([A-Z][a-z]{2})\2(\d{4})\b");

            string text = Console.ReadLine();

            var dates = pattern.Matches(text);


            foreach (Match date in dates)
            {
                var day = date.Groups["1"].Value;
                var month = date.Groups["3"].Value;
                var year = date.Groups["4"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
