namespace _04.Array_Histogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayHistogram
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            Dictionary<string,int> wordsContainer = new Dictionary<string, int>();

            int len = words.Length;

            for (int i = 0; i < words.Length; i++)
            {
                if (!wordsContainer.ContainsKey(words[i]))
                {
                    wordsContainer[words[i]] = 0;
                }
                wordsContainer[words[i]]++;
            }

            wordsContainer = wordsContainer
                .OrderByDescending(w => w.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var word in wordsContainer)
            {
                double percentage = ((double)word.Value / len) * 100;
                Console.WriteLine($"{word.Key} -> {word.Value} times ({percentage:F2}%)");
            }

        }
    }
}
