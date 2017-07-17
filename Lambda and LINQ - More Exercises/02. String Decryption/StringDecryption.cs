namespace _02.String_Decryption
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StringDecryption
    {
        public static void Main()
        {
            int[] firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int m = firstLine[0];
            int n = firstLine[1];


            List<char> outputLine = secondLine
                .Where(num => (num > 64 && num < 91))
                .Skip(m)
                .Take(n)
                .Select(num => (char)num)
                .ToList();

            Console.WriteLine(string.Join("", outputLine));
        }
    }
}
