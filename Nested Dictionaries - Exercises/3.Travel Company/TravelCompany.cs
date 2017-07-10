namespace _03.Travel_Company
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TravelCompany
    {
        public static void Main()
        {
            var travelCompanyOffers = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "ready")
            {
                string[] packages = inputLine.Split(':');
                string cityes = packages[0];

                string[] vechiesAndCapacyti = packages[1].
                    Split("-,".ToCharArray());

                List<string> vechine = new List<string>();
                List<int> capacity = new List<int>();

                SplitTheVechinesAndCapacity(vechiesAndCapacyti, vechine, capacity);

            #region Add all things to the Dictionary
                if (!travelCompanyOffers.ContainsKey(cityes))
                {
                    travelCompanyOffers[cityes] = new Dictionary<string, int>();
                }

                for (int i = 0; i < capacity.Count; i++)
                {
                    if (!travelCompanyOffers[cityes].ContainsKey(vechine[i]))
                    {
                        travelCompanyOffers[cityes][vechine[i]] = 0;
                    }
                    travelCompanyOffers[cityes][vechine[i]] = capacity[i];
                }
            #endregion

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "travel time!")
            {
                string[] group = inputLine
                    .Split(' ');
                string citye = group[0];
                int peopleCount = int.Parse(group[1]);

            #region Print result
                foreach (var city in travelCompanyOffers)
                {
                    int sum = 0;
                    if (city.Key == citye)
                    {
                        foreach (var places in city.Value)
                        {
                            sum += places.Value;
                        }

                        if(sum >= peopleCount)
                        {
                            Console.WriteLine($"{city.Key} -> all {peopleCount} accommodated");
                        }
                        else
                        {
                            Console.WriteLine($"{city.Key} -> all except {peopleCount- sum} accommodated");
                        }
                    }
                }
            #endregion

                inputLine = Console.ReadLine();
            }
        }

        static void SplitTheVechinesAndCapacity(string[] vechiesAndCapacyti, List<string> vechine, List<int> capacity)
        {
            for (int i = 0; i < vechiesAndCapacyti.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vechine.Add(vechiesAndCapacyti[i]);
                }
                if (i % 2 != 0)
                {
                    capacity.Add(int.Parse(vechiesAndCapacyti[i]));
                }
            }
        }
    }
}
