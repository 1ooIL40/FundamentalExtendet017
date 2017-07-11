namespace _03.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(" .,:;()[]\"'\\/!?".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();

            Console.WriteLine($"{string.Join(", ", words)}");
        } 
    }
}
