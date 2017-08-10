namespace _07.Happiness_Index
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class HappinessIndex
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Regex happpyFaces = new Regex(@"(?:(?:[:;][\)D\*\]\}]){1})|(?:(?:[\(\[\*c][:;]){1})");
            Regex sadFaces = new Regex(@"(?:(?:[:;][\(c\[\{]){1})|(?:(?:[\)\]D][:;]){1})");

            var happynes = happpyFaces.Matches(inputLine);
            var sadnes = sadFaces.Matches(inputLine);

            double happynesIndex = happynes.Count / (double)sadnes.Count;

            string icon = GetTheIconOfHappyness(happynesIndex);

            Console.WriteLine($"Happiness index: {happynesIndex:f2} {icon}");
            Console.WriteLine($"[Happy count: {happynes.Count}, Sad count: {sadnes.Count}]");
        }

        static string GetTheIconOfHappyness(double happynesIndex)
        {
            string result = string.Empty;

            if(happynesIndex < 1)
            {
                result = ":(";
            }
            else if (happynesIndex == 1)
            {
                result = ":|";
            }
            else if (happynesIndex < 2)
            {
                result = ":)";
            }
            else if (happynesIndex >= 2)
            {
                result = ":D";
            }

            return result;
        }
    }
}
