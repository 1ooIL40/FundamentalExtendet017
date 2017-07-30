namespace _05.Points_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PointsCounter
    {
        public static void Main()
        {
            string inputData = Console.ReadLine();

            string prohibitedSymbols = "@%$*";
            Dictionary<string,PlayerData> teams = new Dictionary<string, PlayerData>();

            while (inputData != "Result")
            {
                string[] tokens = inputData
                    .Split('|');

                string name = FindeName(tokens,prohibitedSymbols);
                string team = FindeTeam(tokens,prohibitedSymbols);

                if (teams.ContainsKey(team))
                {
                    teams[team] = new PlayerData();
                }
                

                int score = int.Parse(tokens[2]);

                //TODO logic for add to dictionary and end result


                inputData = Console.ReadLine();
            }
        }

        static string FindeTeam(string[] tokens, string prohibitedSymbols)
        {
            string first = tokens[0];
            string second = tokens[1];

            char[] badSymnols = prohibitedSymbols.ToCharArray();

            first = RemoveBadSymbols(first, badSymnols);
            second = RemoveBadSymbols(second, badSymnols);

            char lastLetter = first.Last();

            if (lastLetter > 64  && lastLetter < 91)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string RemoveBadSymbols(string word, char[] badSymnols)
        {
            for (int i = 0; i < badSymnols.Length; i++)
            {
                word = word.Replace(badSymnols[i].ToString(), "");
            }

            return word;
        }

        static string FindeName(string[] tokens, string prohibitedSymbols)
        {
            string first = tokens[0];
            string second = tokens[1];

            char[] badSymnols = prohibitedSymbols.ToCharArray();

            first = RemoveBadSymbols(first, badSymnols);
            second = RemoveBadSymbols(second, badSymnols);

            char lastLetter = first.Last();

            if (lastLetter > 64 && lastLetter < 91)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }

    public class PlayerData
    {
        public string Name { get; set; }
        public int Point { get; set; }
    }
}
