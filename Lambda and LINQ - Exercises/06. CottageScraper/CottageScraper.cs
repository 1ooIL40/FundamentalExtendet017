namespace _06.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScraper
    {
        public static void Main()
        {
            var materials = new Dictionary<string, List<int>>();

            string inputLine = Console.ReadLine();
            int materialCount = 0;

            while (inputLine != "chop chop")
            {
                string[] tokens = inputLine
                    .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);

                string types = tokens[0];
                int height = int.Parse(tokens[1]);


                //Add the material in to he dictionary
                if (!materials.ContainsKey(types))
                {
                    materials[types] = new List<int>();
                }
                materials[types].Add(height);

                materialCount++;
                inputLine = Console.ReadLine();
            }

            //sum of the total meters we have chopt
            int totalMaterialsReady = 0;
            foreach (var mats in materials)
            {
                totalMaterialsReady += mats.Value.Sum();
            }

            //Read the tree type and height
            string type = Console.ReadLine();
            int metersNeeded = int.Parse(Console.ReadLine());


            var usedLogs = materials[type]
                .ToList()
                .Where(item => item >= metersNeeded)
                .ToList();

            int usedLogsSum = usedLogs.Sum();


            double pricePerMeter = Math.Round((totalMaterialsReady / (double)materialCount), 2);
            double usedLogPrice = Math.Round((usedLogsSum * pricePerMeter), 2);
            double unusedLogPrice = Math.Round(((totalMaterialsReady - usedLogsSum) * pricePerMeter * 0.25), 2);
            double totalCottageScrapper = Math.Round((usedLogPrice + unusedLogPrice),2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalCottageScrapper:f2}");
        }
    }
}
