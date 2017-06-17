namespace _03.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var phoneNames = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {

                phoneBook[phoneNames[i]] = phoneNumbers[i];

            }

            var name = Console.ReadLine();

            while (name != "done")
            {

                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }

                name = Console.ReadLine();
            }

        }
    }
}
