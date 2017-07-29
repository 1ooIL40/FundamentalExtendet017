namespace _03.Serialize_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SerializeString
    {
        public static void Main()
        {
            Dictionary<char, List<string>> output = new Dictionary<char, List<string>>();
            char[] inputLine = Console.ReadLine().ToCharArray();

            for (int i = 0; i < inputLine.Length; i++)
            {
                char character = inputLine[i];
                if (!output.ContainsKey(character))
                {
                    output[character] = new List<string>();
                }
                output[character].Add(i.ToString());
            }


            foreach (var character in output)
            {
                Console.WriteLine($"{character.Key}:{string.Join("/",character.Value)}");
            }
        }
    }
}
