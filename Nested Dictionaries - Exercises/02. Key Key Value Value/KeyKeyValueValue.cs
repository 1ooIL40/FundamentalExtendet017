namespace _02.Key_Key_Value_Value
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyKeyValueValue
    {
        public static void Main()
        {

            var dict = new Dictionary<string, List<string>>();

            string key = Console.ReadLine();
            string value = Console.ReadLine();

            PutTheDateInDictionary(dict);

            PrintKeys(dict, key, value);


        }

        static void PutTheDateInDictionary(Dictionary<string,List<string>> dict)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] keys = Console.ReadLine()
                    .Split(new string[] { " => " },
                    StringSplitOptions.RemoveEmptyEntries);


                List<string> values = keys[1].Split(';').ToList();

                if (!dict.ContainsKey(keys[0]))
                {
                    dict[keys[0]] = new List<string>();
                }
                dict[keys[0]] = values;
            }
        }

        //Chek did keys in the dictionary contains the input key and values contains the input value
        static void PrintKeys(Dictionary<string,List<string>> dict,string key,string value)
        {
            
            foreach (var kvp in dict)
            {
                bool containsInKey = kvp.Key.Contains(key);

                if (containsInKey)
                {
                    Console.WriteLine($"{kvp.Key}:");

                    foreach (var val in kvp.Value)
                    {
                        bool containsInValue = val.Contains(value);

                        if (containsInValue)
                        {
                            Console.WriteLine($"-{val}");
                        }
                    }
                }
            }
        }
    }
}
