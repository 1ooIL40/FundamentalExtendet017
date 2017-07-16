namespace _05.Flatten_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var flattenDict = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 2)
                {
                    string type = tokens[0];
                    string mark = tokens[1];
                    string model = tokens[2];

                    //TODO

                    if (!flattenDict.ContainsKey(type))
                    {
                        flattenDict[type] = new Dictionary<string, string>();
                    }
                    flattenDict[type][mark] = model;

                }
                else
                {
                    string type = tokens[1];

                    //flatten the key and the value and se it to key, and for the value set it to string.empty
                    flattenDict[type] = flattenDict[type]
                        .ToDictionary(k => k.Key + k.Value + "", v => string.Empty);
                    
                }

                inputLine = Console.ReadLine();
            }

            flattenDict = flattenDict
                .OrderByDescending(k => k.Key.Length)
                .ToDictionary(k => k.Key, v => v.Value);



            foreach (var type in flattenDict)
            {
                Console.WriteLine(type.Key);

                var resultValues = type.Value
                    .Where(v => v.Value != string.Empty)
                    .ToDictionary(k => k.Key, v => v.Value)
                    .OrderBy(k => k.Key.Length)
                    .ToDictionary(k => k.Key, v => v.Value);

                var flattenValues = type.Value
                    .Where(v => v.Value == string.Empty)
                    .ToDictionary(k => k.Key, v => v.Value);
                int index = 1;

                foreach (var mark in resultValues)
                {

                    Console.WriteLine($"{index}. {mark.Key} - {mark.Value}");
                    
                    index++;
                }

                foreach (var mark in flattenValues)
                {
                    Console.WriteLine($"{index}. {mark.Key}");
                    index++;
                }
            }
        }
    }
}
