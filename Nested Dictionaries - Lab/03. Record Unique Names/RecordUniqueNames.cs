namespace _03.Record_Unique_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
