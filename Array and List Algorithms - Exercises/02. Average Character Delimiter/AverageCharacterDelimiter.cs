namespace _02.Average_Character_Delimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            string[] letters = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int sumOfAllChars = 0;
            int allChars = 0;


            foreach (var letter in letters)
            {
                letter.ToCharArray();

                foreach (var let in letter)
                {
                    sumOfAllChars += (int)let;
                    allChars++;
                }
            }

            char delimeter = (char)(sumOfAllChars / allChars);

            Console.WriteLine(string.Join((delimeter
                .ToString()
                .ToUpper()),letters));
        }
    }
}
