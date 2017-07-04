namespace _02.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRef
    {
        public static void Main()
        {
            string[] userInput = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, int> dictRef = new Dictionary<string, int>();

            while (userInput[0] != "end")
            {
                string entry = userInput[0];
                string secondEntry = userInput[2];
                int value = 0;

                
                if (int.TryParse(secondEntry, out value))
                {
                    dictRef[entry] = value;
                }
                else
                {
                    if (dictRef.ContainsKey(secondEntry))
                    {
                        int secondEntryValue = dictRef[secondEntry];
                        dictRef[entry] = secondEntryValue;
                    }
                }

                userInput = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var kvp in dictRef)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
