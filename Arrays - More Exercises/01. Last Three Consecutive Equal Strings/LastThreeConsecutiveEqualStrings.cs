namespace _01.Last_Three_Consecutive_Equal_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LastThreeConsecutiveEqualStrings
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToList();

            TakeLastThreeEqualWords(words);
        }

        static void TakeLastThreeEqualWords(List<string> words)
        {
            words.Reverse();

            for (int i = 0; i < words.Count; i++)
            {
                var wordOne = words[i];
                var wordTwo = words[i + 1];
                var wordThree = words[i + 2];

                if (wordOne == wordTwo && wordTwo == wordThree)
                {
                    Console.WriteLine($"{wordOne} {wordOne} {wordOne}");
                    break;
                }
            }
        }
    }
}
