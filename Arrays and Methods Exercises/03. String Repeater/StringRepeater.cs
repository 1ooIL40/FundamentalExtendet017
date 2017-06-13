namespace _03.String_Repeater
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StringRepeater
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var repeated = ReapeatedString(word, count);

            Console.WriteLine(repeated);
        }

        static string ReapeatedString(string word, int count)
        {
            var result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += word;
            }
            return result;
        }
    }
}
