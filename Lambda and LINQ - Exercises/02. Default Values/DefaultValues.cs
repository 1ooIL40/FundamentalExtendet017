namespace _02.Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            Dictionary<string, string> deffaultValues = new Dictionary<string, string>();

            string[] inputLine = Console.ReadLine()
                .Split(new string[] { " -> " },
                StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0] != "end")
            {
                string key = inputLine[0];
                string value = inputLine[1];

                
                deffaultValues[key] = value;

                inputLine = Console.ReadLine()
                .Split(new string[] { " -> " },
                StringSplitOptions.RemoveEmptyEntries);
            }

            string replacmentValue = Console.ReadLine();

            Dictionary<string, string> originalValues = deffaultValues
                .Where(v => v.Value != "null")
                .OrderByDescending(v => v.Value.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            Dictionary<string, string> nullValues = deffaultValues
                .Where(v => v.Value == "null")
                .ToDictionary(k => k.Key, v => replacmentValue);


            Dictionary<string, string> result = originalValues
                .Concat(nullValues)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
        }
    }
}
