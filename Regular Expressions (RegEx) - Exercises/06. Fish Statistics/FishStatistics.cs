namespace _06.Fish_Statistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FishStatistics
    {
        public static void Main()
        {
            string findFish = Console.ReadLine();

            Regex fishes = new Regex(@"(?<tail>>*)<(?<body>\(+?)(?<eye>['\-x])>");

            //Close the program if there is no fish;
            if (!fishes.IsMatch(findFish))
            {
                Console.WriteLine("No fish found.");
                return;
            }

            var catchFish = fishes.Matches(findFish);
            int fishNumber = 1;
            
            //Print result for evry one of the fishes
            foreach (Match fish in catchFish)
            {
                int tail = fish.Groups["tail"].Length;
                int body = fish.Groups["body"].Length;
                string status = fish.Groups["eye"].Value;
                string theFish = fish.Groups[0].Value;

                Console.WriteLine($"Fish {fishNumber}: {theFish}");

                TailOutputResult(tail);
                BodyOutputResult(body);
                CeckStatus(status);

                fishNumber++;
            }
        }

        static void CeckStatus(string status)
        {
            if(status == "'")
            {
                Console.WriteLine($"Status: Awake");

            }
            else if(status == "-")
            {
                Console.WriteLine($"Status: Asleep");
            }
            else if (status == "x")
            {
                Console.WriteLine($"Status: Dead");
            }
        }

        static void TailOutputResult(int tail)
        {
            if(tail == 0)
            {
                Console.WriteLine($"Tail type: None");
            }
            else if(tail == 1)
            {
                Console.WriteLine($"Tail type: Short ({tail *2} cm)");
            }
            else if (tail > 1 && tail <= 5)
            {
                Console.WriteLine($"Tail type: Medium ({tail * 2} cm)");
            }
            else if(tail > 5)
            {
                Console.WriteLine($"Tail type: Long ({tail * 2} cm)");
            }
        }

        static void BodyOutputResult(int body)
        {
            if (body >= 1 && body <= 5)
            {
                Console.WriteLine($"Body type: Short ({body * 2} cm)");
            }
            else if (body > 5 && body <= 10)
            {
                Console.WriteLine($"Body type: Medium ({body * 2} cm)");
            }
            else if (body > 10)
            {
                Console.WriteLine($"Body type: Long ({body * 2} cm)");
            }
        }
    }
}
