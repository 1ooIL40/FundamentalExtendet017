namespace _14.ASCII_String
{
    using System;

    public class ASCIIString
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var characters = int.Parse(Console.ReadLine());

                result += (char)characters;
            }
            Console.WriteLine(result);
        }
    }
}
