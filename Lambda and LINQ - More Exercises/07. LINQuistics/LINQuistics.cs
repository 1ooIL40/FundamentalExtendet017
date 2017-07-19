namespace _07.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LINQuistics
    {
        static void Main()
        {
            var data = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(new string[] { ".", "()" }, 
                StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "exit")
            {
                string collection = input[0];

                int num = 0;
                if (input.Length == 1)
                {
                    try
                    {
                        num = int.Parse(collection);

                        string[] numberMetods = data.Values.OrderByDescending(d => d.Count)
                            .First()
                            .ToArray()
                            .OrderBy(d => d.Length)
                            .Take(num)
                            .ToArray();

                        for (int i = 0; i < numberMetods.Length; i++)
                        {
                            Console.WriteLine($"* {numberMetods[i]}");
                        }
                    }
                    catch (Exception)
                    {
                        if (!data.ContainsKey(collection))
                        {

                        }
                        else
                        {

                            string[] metods = data[collection].OrderByDescending(d => d.Length)
                            .ThenByDescending(d => d.Distinct().Count()).ToArray();

                            for (int i = 0; i < metods.Length; i++)
                            {
                                Console.Write("* ");
                                Console.WriteLine(metods[i]);
                            }
                        }
                    }
                }
                else
                {

                    if (!data.ContainsKey(collection))
                    {
                        data.Add(collection, new List<string>());
                    }

                    for (int i = 1; i < input.Length; i++)
                    {
                        if (!data[collection].Contains(input[i]))
                        {
                            data[collection].Add(input[i]);
                        }
                    }
                }
                input = Console.ReadLine().Split(new string[] { ".", "()" }, StringSplitOptions.RemoveEmptyEntries);

            }
            string[] lastCommand = Console.ReadLine().Split(' ');

            string metodName = lastCommand[0];
            string command = lastCommand[1];

            if (command == "collection")
            {

                foreach (var collections in data.Where(d => d.Value.Contains(metodName))
                    .OrderByDescending(d => d.Value.Count)
                    .ThenBy(s => s.Value.Min()))
                {
                    Console.WriteLine(collections.Key);
                }
            }
            else if (command == "all")
            {
                foreach (var collections in data
                    .Where(d => d.Value.Contains(metodName))
                    .OrderByDescending(d => d.Value.Count)
                    .ThenByDescending(d => d.Value.Min()))
                {
                    Console.WriteLine(collections.Key);
                    List<string> collectionMetods = collections.Value.OrderByDescending(d => d.Length).ToList();
                    for (int i = 0; i < collectionMetods.Count; i++)
                    {
                        Console.WriteLine($"* {collectionMetods[i]}");
                    }
                }
            }
        }
    }
}