namespace _08.Commits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Comites
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public decimal Additions { get; set; }
        public decimal Deletions { get; set; }

        public Comites(string hash, string message, decimal additions, decimal deletions)
        {
            this.Hash = hash;
            this.Message = message;
            this.Additions = additions;
            this.Deletions = deletions;
        }
    }

    public class Commits
    {
        
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, List<Comites>>> usersInfo = new SortedDictionary<string, SortedDictionary<string, List<Comites>>>();

            Regex parts = new Regex(@"^https:\/\/github.com\/(?<ussername>[A-Za-z0-9\-]+)\/(?<repoName>[A-Za-z\-_]+)\/commit\/(?<hash>[0-9a-f]{40}),(?<message>[^\n]*),(?<additions>[0-9]*),(?<deletions>[0-9]*)$");


            string inputLine = Console.ReadLine();

            while (inputLine != "git push")
            {
                var allParts = parts.Match(inputLine);

                if (allParts.Success)
                {

                    string userName = allParts.Groups["ussername"].Value;
                    string repoName = allParts.Groups["repoName"].Value;
                    string hash = allParts.Groups["hash"].Value;
                    string message = allParts.Groups["message"].Value;
                    decimal additions = decimal.Parse(allParts.Groups["additions"].Value);
                    decimal deletions = decimal.Parse(allParts.Groups["deletions"].Value);

                    Comites commitInfo = new Comites(hash, message, additions, deletions);

                    if (!usersInfo.ContainsKey(userName))
                    {
                        usersInfo[userName] = new SortedDictionary<string, List<Comites>>();
                    }
                    if (!usersInfo[userName].ContainsKey(repoName))
                    {
                        usersInfo[userName][repoName] = new List<Comites>();
                    }

                    usersInfo[userName][repoName].Add(commitInfo);
                }

                inputLine = Console.ReadLine();
            }


            foreach (var person in usersInfo)
            {
                Console.WriteLine($"{person.Key}:");

                foreach (var repo in person.Value)
                {
                    Console.WriteLine($"{repo.Key}:");

                    decimal totalAdditions = 0m;
                    decimal totalDeletions = 0m;

                    foreach (var commit in repo.Value)
                    {
                        totalAdditions += commit.Additions;
                        totalDeletions += commit.Deletions;

                        Console.WriteLine($"commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    }

                    Console.WriteLine($"Total: {totalAdditions} additions, {totalDeletions} deletions");


                }
            }
        }
    }
}
