namespace _05.SoftUni_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            Regex pattern = new Regex(@"[0-9]+(?<message>[a-zA-Z]+).*[0-9]+");

            while (inputLine != "Decrypt!")
            {
                int searchLenght = int.Parse(Console.ReadLine());


                var matches = pattern.Matches(inputLine);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups["message"]);
                }


                inputLine = Console.ReadLine();
            }
        }
    }
}
