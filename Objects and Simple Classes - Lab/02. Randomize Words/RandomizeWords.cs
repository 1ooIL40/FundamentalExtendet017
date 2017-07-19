namespace _02.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var rnd = new Random();

            var random = rnd.Next(0, inputLine.Length);

            for (int i = 0; i < inputLine.Length; i++)
            {
                var word = inputLine[i];

                if (i != random)
                {
                    var tempWord = inputLine[random];
                    inputLine[random] = word;
                    inputLine[i] = tempWord;

                }
            }

            foreach (var word in inputLine)
            {
                Console.WriteLine(word);
            }
        }
    }
}
