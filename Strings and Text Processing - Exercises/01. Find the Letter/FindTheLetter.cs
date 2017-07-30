namespace _01.Find_the_Letter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindTheLetter
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            string[] seoncLine = Console.ReadLine()
                .Split(' ');
            char finde = char.Parse(seoncLine[0]);
            int index = int.Parse(seoncLine[1]);
            int charIndex = inputString.IndexOf(finde, 0);

            while (index != 1)
            {
                charIndex = inputString.IndexOf(finde, charIndex + 1);
                
                index--;
            }
           
            if(charIndex > -1)
            {
                Console.WriteLine(charIndex);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
