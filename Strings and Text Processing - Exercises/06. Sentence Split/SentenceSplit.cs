namespace _06.Sentence_Split
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SentenceSplit
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();

            string delimeter = Console.ReadLine();

            string[] result = sentence
                .Split(new string[] { delimeter },
                StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
