namespace _04.Split_by_Word_Casing
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();



            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].All(char.IsLower))
                {
                    lowerCase.Add(input[i]);
                }
                else if (input[i].All(char.IsUpper))
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
