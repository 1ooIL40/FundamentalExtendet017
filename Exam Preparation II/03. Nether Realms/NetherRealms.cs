namespace _03.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Stats
    {
        public decimal Healt { get; set; }
        public decimal Damage { get; set; }

        public Stats(decimal healt, decimal damage)
        {
            this.Healt = healt;
            this.Damage = damage;
        }
    }

    public class NetherRealms
    {
        public static SortedDictionary<string, Stats> demonBook = new SortedDictionary<string, Stats>();

        public static void Main()
        {
            string[] inputLine = Console.ReadLine()
                .Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            Regex letters = new Regex(@"[^\+\,\-\*\/\.0-9]");
            Regex numbers = new Regex(@"-?\d+\.?\d*");
            Regex symbols = new Regex(@"\*|\/");

            foreach (var names in inputLine)
            {
                if(names.Contains(" ") || names.Contains(","))
                {
                    continue;
                }

                string name = names;
                decimal health = 0m;
                decimal damage = 0m;
                var letterMatches = letters.Matches(names);
                var numberMatches = numbers.Matches(names);
                var symbolMatches = symbols.Matches(names);

                foreach (Match match in letterMatches)
                {
                    health += char.Parse(match.Value);
                }
                foreach (Match num in numberMatches)
                {
                    damage += decimal.Parse(num.Value);
                }

                if(damage > 0)
                {
                    foreach (Match symbol in symbolMatches)
                    {
                        if(symbol.Value == "*")
                        {
                            damage *= 2;
                        }
                        if(symbol.Value == "/")
                        {
                            damage /= 2;
                        }
                    }
                }

                Stats stats = new Stats(health, damage);
                
                demonBook[name] = stats;
            }

            foreach (var demonName in demonBook)
            {
                Console.WriteLine($"{demonName.Key} - {demonName.Value.Healt} health, {demonName.Value.Damage:f2} damage");
            }

        }
    }
}
