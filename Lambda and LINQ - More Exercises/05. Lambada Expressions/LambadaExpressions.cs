namespace _01.Lambada_Expressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var result = new Dictionary<string, string>();

            while (inputString != "lambada")
            {

                var tokens = inputString
                    .Split(" =>".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                //add to dictionary

                if (tokens.Count > 1)
                {
                    string key = tokens[0];
                    string value = tokens[1];

                    if (!result.ContainsKey(key))
                    {
                        result[key] = string.Empty;
                    }
                    result[key] = value;
                }
                else
                {
                    //add the new value
                    result = result
                        .ToDictionary(res => res.Key, res => res.Key + "." + res.Value);
                }

                inputString = Console.ReadLine();
            }

            foreach (var item in result)
            {
                var key = item.Key;
                var value = item.Value;

                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}
