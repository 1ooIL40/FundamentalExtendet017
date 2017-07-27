namespace _04.Palindromes
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            List<string> inputWords = Console.ReadLine()
                 .Split(",!?. ".ToCharArray(),
                 StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<string> result = new List<string>();

            foreach (var word in inputWords)
            {
                string reversedWord = ReversWord(word);

                if (reversedWord == word && !result.Contains(word))
                {
                    result.Add(reversedWord);
                }
            }



            result = result
                .OrderBy(w => w)
                .ToList();
            Console.WriteLine(string.Join(", ", result));
        }

        static string ReversWord(string word)
        {
            char[] reverse = word.ToCharArray();

            Array.Reverse(reverse);

            return (new string(reverse));
        }
    }
}
