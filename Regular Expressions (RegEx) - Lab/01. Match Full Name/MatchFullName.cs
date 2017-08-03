namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");

            string text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
        }
    }
}
