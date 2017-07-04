namespace _01.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            var occurrences = new Dictionary<string, int>();


            foreach (var word in words)
            {
                if (!occurrences.ContainsKey(word))
                {
                    occurrences[word] = 0;
                }
                occurrences[word]++;
            }

            var result = new List<string>();

            foreach (var kvp in occurrences)
            {

                if (kvp.Value % 2 == 1)
                {
                    result.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
