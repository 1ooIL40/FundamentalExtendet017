namespace _03.Booming_Cannon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class BoomingCannon
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                           .Split(new char[] { ' ' },
                               StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            int skipArea = numbers[0];
            int areaDamage = numbers[1];

            string targets = Console.ReadLine();

            Regex cannons = new Regex(@"\\<<<.+?(?=\\<<<)|\\<<<.+$");

            var targetsAndArea = cannons.Matches(targets);

            List<string> shootingTargets = new List<string>();

            shootingTargets = targetsAndArea
                .Cast<Match>()
                .Select(w => w.Value.Trim())
                .Select(w => w.Substring(4))
                .ToList();

            List<string> result = new List<string>();

            foreach (var shot in shootingTargets)
            {
                string output = string.Empty;

                if (shot.Length > areaDamage + skipArea)
                {
                    output = shot.Substring(skipArea, areaDamage);
                }
                else if (shot.Length < skipArea)
                {
                    output = string.Empty;
                }
                else
                {
                    output = shot.Substring(skipArea);
                }

                if (output != string.Empty)
                {
                    result.Add(output);
                }

            }


            Console.WriteLine(string.Join("/\\", result));
        }
    }
}