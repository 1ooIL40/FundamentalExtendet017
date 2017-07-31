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

            string prohibitedSymbols = "@%$*&";
            var teams = new Dictionary<string, Dictionary<string,int>>();

            while (inputData != "Result")
            {
                string[] tokens = inputData
                    .Split('|');

                //Find wich is the Player name and wich is the Team Name
                string name = FindName(tokens,prohibitedSymbols);
                string team = FindTeam(tokens,prohibitedSymbols);
                int score = int.Parse(tokens[2]);
                
                //Add to dictionary
                if (!teams.ContainsKey(team))
                {
                    teams[team] = new Dictionary<string, int>();
                }
                if (!teams[team].ContainsKey(name))
                {
                    teams[team][name] = score;
                }
                teams[team][name] = score;

                inputData = Console.ReadLine();
            }

            //Order the players in descending order by points earnd
            teams = teams
                .ToDictionary(k => k.Key, v => v.Value
                     .OrderByDescending(val => val.Value)
                     .ToDictionary(k => k.Key, val => val.Value))
                    .ToDictionary(k => k.Key, v => v.Value);



            //Get the total sum of points in the teams
            var teamTotalScore = new Dictionary<string, int>();

            foreach (var team in teams)
            {
                int totalSum = 0;
                foreach (var player in team.Value)
                {
                    totalSum += player.Value;
                }
                teamTotalScore[team.Key] = totalSum;
            }

            //Order them 
            teamTotalScore = teamTotalScore
                .OrderByDescending(v => v.Value)
                .ToDictionary(k => k.Key, v => v.Value);


            //Print the end result 
            foreach (var team in teamTotalScore)
            {
                Console.WriteLine($"{team.Key} => {team.Value}");

                foreach (var Player in teams[team.Key].Keys)
                {
                    Console.WriteLine($"Most points scored by {Player}");
                    break;
                }
            }

        }

        static string FindTeam(string[] tokens, string prohibitedSymbols)
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

        static string FindName(string[] tokens, string prohibitedSymbols)
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
        public static string Name { get; set; }
        public static int Point { get; set; }
    }
}
