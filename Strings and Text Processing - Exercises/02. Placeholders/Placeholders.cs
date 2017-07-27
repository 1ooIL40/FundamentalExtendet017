namespace _02.Placeholders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Placeholders
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);

                string stringResult = tokens[0];
                string[] replacePlaceholders = tokens[1]
                    .Split(", ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < replacePlaceholders.Length; i++)
                {
                    string placeHolder = $"{"{" + i + "}"}";
                    string replacment = replacePlaceholders[i];

                    if (stringResult.Contains(placeHolder))
                    {
                        stringResult = stringResult.Replace(placeHolder, replacment);
                    }
                }

                Console.WriteLine(stringResult);
                inputLine = Console.ReadLine();
            }
        }
    }
}
