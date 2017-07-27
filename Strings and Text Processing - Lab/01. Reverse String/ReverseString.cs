namespace _01.Reverse_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            char[] readed = Console.ReadLine()
                .ToCharArray();

            Console.WriteLine(string.Join("", readed.Reverse()));
        }
    }
}
