namespace _04.Deserialize_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DeserializeString
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            StringBuilder output = new StringBuilder(new string(' ', 200));


            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(":/".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                char newChar = char.Parse(tokens[0]);
                List<int> possitions = tokens
                    .Skip(1)
                    .Select(int.Parse)
                    .ToList();

                foreach (var num in possitions)
                {
                    output[num] = newChar;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(output.ToString().Trim());
        }
    }
}
