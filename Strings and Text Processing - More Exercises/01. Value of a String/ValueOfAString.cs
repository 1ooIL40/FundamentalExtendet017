namespace _01.Value_of_a_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ValueOfAString
    {
        public static void Main()
        {
            StringBuilder letters = new StringBuilder(Console.ReadLine());
            string possibilities = Console.ReadLine().ToUpper();
            int totalSum = 0;

            if(possibilities == "LOWERCASE")
            {
                totalSum = SumOfLowerCaseLetters(letters);
            }
            else
            {
                totalSum = SumOfUpperCaseLetters(letters);
            }
            Console.WriteLine($"The total sum is: {totalSum}");
        }

        private static int SumOfUpperCaseLetters(StringBuilder letters)
        {
            int sum = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 64 && letters[i] < 91) {
                    sum += (int)letters[i];
                }
            }

            return sum;
        }

        private static int SumOfLowerCaseLetters(StringBuilder letters)
        {
            int sum = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 96 && letters[i] < 123)
                {
                    sum += (int)letters[i];
                }
            }

            return sum;
        }
    }
}
