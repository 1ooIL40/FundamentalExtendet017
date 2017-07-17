namespace _03.Camping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Camping
    {
        public static void Main()
        {
            var campingDays = new Dictionary<string, int>();
            var campingVechines = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string camperModel = tokens[1];
                int days = int.Parse(tokens[2]);

                if (!campingVechines.ContainsKey(name) && !campingDays.ContainsKey(name))
                {
                    campingVechines[name] = new List<string>();
                    campingDays[name] = 0;
                }
                campingVechines[name].Add(camperModel);
                campingDays[name] += days;

                inputLine = Console.ReadLine();
            }

            campingVechines = campingVechines
                .OrderBy(k => k.Key.Length)
                .OrderByDescending(v => v.Value.Count)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var person in campingVechines)
            {
                string name = person.Key;

                Console.WriteLine($"{name}: {person.Value.Count}");

                foreach (var vechine in person.Value)
                {
                    Console.WriteLine($"***{vechine}");
                }
                Console.WriteLine($"Total stay: {campingDays[name]} nights");
            }
        }
    }
}
