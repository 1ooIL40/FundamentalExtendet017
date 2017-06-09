namespace _14.Magic_Letter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MagicLetter
    {
        public static void Main()
        {
            var firsLetter = char.Parse(Console.ReadLine().ToLower());
            var secondLetter = char.Parse(Console.ReadLine().ToLower());
            var thirdLetter = char.Parse(Console.ReadLine().ToLower());


            for (int i = firsLetter; i <= secondLetter; i++)
            {
                for (int j = firsLetter; j <= secondLetter; j++)
                {
                    for (int p = firsLetter; p <= secondLetter; p++)
                    {
                        if (i != thirdLetter && j != thirdLetter && p != thirdLetter)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)p} ");
                        }

                    }
                }
            }
            Console.WriteLine();
        }
    }
}
