namespace _03.Mixed_Phones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MixedPhones
    {
        public static void Main()
        {
            SortedDictionary<string, long> phoneNumbers = new SortedDictionary<string, long>();

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "Over")
            {
                long phoneNumber = 0;
                string name = string.Empty;

                //Check position one for number or name
                if (long.TryParse(input[0], out phoneNumber))
                {
                    name = input[2];
                }
                else
                {
                    name = input[0];
                    phoneNumber = long.Parse(input[2]);
                }

                //Add to the sorted phone book
                if (!phoneNumbers.ContainsKey(name))
                {
                    phoneNumbers[name] = 0;
                }
                phoneNumbers[name] = phoneNumber;


                input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var kvp in phoneNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
