namespace _04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Websites
    {
        public static List<Website> webSites = new List<Website>();

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokes = inputLine
                    .Split(" |,".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                AddWebsitesToLists(tokes);

                inputLine = Console.ReadLine();
            }

            PrintTheResults();
        }

        private static void PrintTheResults()
        {
            foreach (var site in webSites)
            {
                if(site.Queries.Count > 0 && site.Queries[0] != "null")
                {
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}/query?={string.Join("&",site.Queries)}");
                }
                else
                {
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}");
                }
            }
        }

#region Add all web sites in a list
        static void AddWebsitesToLists(string[] tokes)
        {
            string host = tokes[0];
            string domain = tokes[1];
            List<string> queries = new List<string>();

            if (tokes.Length > 2)
            {
                 queries = tokes
                    .Skip(2)
                    .Select(q => "[" + q + "]")
                    .ToList();

                Website newWebSite = new Website
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries
                };

                webSites.Add(newWebSite);
            }
            else
            {
                queries.Add("null");
                Website newWebSite = new Website
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries
                };

                webSites.Add(newWebSite);
            }
        }
    }
#endregion

    public class Website
    {
        public string Host { get; set; }
        public string Domain  { get; set; }
        public List<string> Queries { get; set; }
    }
}
