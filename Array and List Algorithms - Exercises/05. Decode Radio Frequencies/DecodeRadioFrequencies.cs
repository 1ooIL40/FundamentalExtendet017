namespace _05.Decode_Radio_Frequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            string[] frequencies = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<char> convertedNumbers = new List<char>();

            for (int i = 0; i < frequencies.Length; i++)
            {
                int[] separatedFrequenci = frequencies[i]
                    .Split(new char[] { '.' })
                    .Select(int.Parse)
                    .ToArray();

                int left = separatedFrequenci[0];
                int right = separatedFrequenci[1];

                if (left > 0)
                {
                    convertedNumbers.Insert(i, (char)left);
                }
                if (right > 0)
                {
                    convertedNumbers.Insert(i + 1, (char)right);
                }
            }

            Console.WriteLine(string.Join("", convertedNumbers));
        }
    }
}
