namespace _13.Digits_with_Words
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DigitsWithWords
    {
        public static void Main()
        {

            var number = Console.ReadLine();
            var digtsAsWords = new List<string>
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };

            for (int i = 0; i < digtsAsWords.Count; i++)
            {
                if(number == digtsAsWords[i])
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
