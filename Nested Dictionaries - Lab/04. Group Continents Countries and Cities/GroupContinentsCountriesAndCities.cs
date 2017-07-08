namespace _04.Group_Continents_Countries_and_Cities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> ccc = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputCCC = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string continent = inputCCC[0];
                string country = inputCCC[1];
                string citie = inputCCC[2];

                //Chek did we already have the continent addet
                if (!ccc.ContainsKey(continent))
                {
                    ccc[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                //add the country to the continent
                if (!ccc[continent].ContainsKey(country))
                {
                    ccc[continent][country] = new SortedSet<string>();
                }
                //add the cities in the country
                ccc[continent][country].Add(citie);

            }

            //Loop thru teh dictionary
            foreach (var continet in ccc)
            {
                Console.WriteLine($"{continet.Key}:");

                //Print the country and cities in it
                foreach (var country in continet.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
