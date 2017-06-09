namespace _05.Word_in_Plural
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WordInPlural
    {
        public static void Main()
        {
            var word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                Console.WriteLine($"{word}ies");
            }
            else if (word.EndsWith("o") ||
                word.EndsWith("sh") ||
                word.EndsWith("ch") ||
                word.EndsWith("s") || 
                word.EndsWith("x") || 
                word.EndsWith("z"))
            {
                Console.WriteLine($"{word}es");
            }
            else
            {
                Console.WriteLine($"{word}s");
            }

        }
    }
}
