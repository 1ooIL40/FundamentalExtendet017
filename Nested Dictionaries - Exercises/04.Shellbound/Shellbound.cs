namespace _04.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            var merge = new Dictionary<string, HashSet<int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "Aggregate")
            {
                string[] nameAndSize = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = nameAndSize[0];
                int size = int.Parse(nameAndSize[1]);

                if (!merge.ContainsKey(name))
                {
                    merge[name] = new HashSet<int>();
                }
                merge[name].Add(size);

                inputLine = Console.ReadLine();
            }


            foreach (var shell in merge)
            {
                int gianShellSize = shell.Value.Sum() - (int)shell.Value.Average();
                Console.WriteLine($"{shell.Key} -> {string.Join(", ",shell.Value)} ({gianShellSize})");
            }
        }
    }
}
