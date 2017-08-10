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
        public string Additions { get; set; }
        public string Deletions { get; set; }

        public Comites(string hash, string message, string additions, string deletions)
        {
            this.Hash = hash;
            this.Message = message;
            this.Additions = additions;
            this.Deletions = deletions;
        }
    }

    public class Commits
    {

        public static SortedDictionary<string, SortedDictionary<string, List<Comites>>> usersInfo = new SortedDictionary<string, SortedDictionary<string, List<Comites>>>();

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "git push")
            {
                Regex parts = new Regex(@"(?:^https\:\/\/github\.com\/)(?<ussername>[a-zA-z0-9-]+)\/(?<repoName>[\[a-zA-Z\-]+)\/(?<commit>commit)\/(?<hash>[a-fA-F0-9]{40})\,(?<message>.*[^\r\n]),(?<additions>\d+),(?<deletions>\d+)$");

                var allParts = parts.Match(inputLine);

                string userName = allParts.Groups["ussername"].Value;
                string repoName = allParts.Groups["repoName"].Value;
                string commit = allParts.Groups["commit"].Value;
                string hash = allParts.Groups["hash"].Value;
                string message = allParts.Groups["message"].Value;
                string additions = allParts.Groups["additions"].Value;
                string deletions = allParts.Groups["deletions"].Value;

                Comites commitInfo = new Comites(hash, message, additions, deletions);

                if (userName != string.Empty && repoName != string.Empty)
                {
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
                decimal totalAdditions = 0;
                decimal totalDeletions = 0;

                foreach (var repo in person.Value)
                {
                    Console.WriteLine($"  {repo.Key}:");

                    foreach (var commit in repo.Value)
                    {
                        Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");

                        totalAdditions += decimal.Parse(commit.Additions);
                        totalDeletions += decimal.Parse(commit.Deletions);
                    }

                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");
                }
            }
        }
    }
}
