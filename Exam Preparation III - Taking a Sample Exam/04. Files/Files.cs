namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    
    public class Files
    {
        public static Dictionary<string,Dictionary<string,decimal>> dirAndFiles = new Dictionary<string,Dictionary<string,decimal>>();

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Regex pattertn = new Regex(@"^(?<path>[a-zA-Z].+\\)(?<file>.+)\;(?<size>[0-9]+)$");

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                var match = pattertn.Match(inputLine);

                string path = match.Groups["path"].Value;
                string fileAndExtention = match.Groups["file"].Value;
                decimal size = decimal.Parse(match.Groups["size"].Value);

                if (!dirAndFiles.ContainsKey(path))
                {
                    dirAndFiles[path] = new Dictionary<string, decimal>();
                }
                if (!dirAndFiles[path].ContainsKey(fileAndExtention))
                {
                    dirAndFiles[path][fileAndExtention] = 0;
                }
                dirAndFiles[path][fileAndExtention] = size;
            }
            string[] tokens = Console.ReadLine()
                .Split(new char[] { ' ' },
                 StringSplitOptions.RemoveEmptyEntries);

            string root = tokens[2];
            string file = tokens[0];

            Dictionary<string, decimal> result = new Dictionary<string, decimal>();

            foreach (var path in dirAndFiles)
            {
                if (path.Key.Contains(root))
                {
                    foreach (var files in path.Value)
                    {
                        result[files.Key] = files.Value;
                    }
                }
            }

            result = result
                .OrderByDescending(v=>v.Value)
                .ThenBy(k=>k.Key)
                .Where(k => k.Key.Contains(file))
                .ToDictionary(k => k.Key, v => v.Value);

            if(result.Count != 0)
            {
                foreach (var output in result)
                {
                    Console.WriteLine($"{output.Key} - {output.Value} KB ");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
