namespace _04_SoftUni_Beer_Pong
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayerPoints
    {
        public string Name { get; set; }

        public int Points { get; set; }
    }

    public class SoftUniBeerPong
    {
        public static void Main()
        {
            var leaderBoard = new Dictionary<string, Dictionary<string,int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "stop the game")
            {
                string[] tokens = inputLine
                    .Split(new char[] { '|' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string team = tokens[1];
                int points = int.Parse(tokens[2]);


                if (!leaderBoard.ContainsKey(team))
                {
                    leaderBoard[team] = new Dictionary<string, int>();
                }

                if(leaderBoard[team].Count < 3)
                {
                    leaderBoard[team][name] = points;
                }

                inputLine = Console.ReadLine();

            }

            leaderBoard = leaderBoard
                .Where(v => v.Value.Keys.Count == 3)
                .ToDictionary(k => k.Key, v => v.Value)
                .OrderByDescending(v => v.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);

            int indexer = 1;
            foreach (var team in leaderBoard)
            {
                Console.WriteLine($"{indexer}. {team.Key}; Players:");

                var player = team.Value
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var person in player)
                {
                    Console.WriteLine($"###{person.Key}: {person.Value}");
                }

                indexer++;
            }
            
        }
    }
}
