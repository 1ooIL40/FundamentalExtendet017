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
            Regex pattern = new Regex(@"\b(?<day>\d{2})(?<separator>[\.\/-])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b");

            string text = Console.ReadLine();

            var dates = pattern.Matches(text);


            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
