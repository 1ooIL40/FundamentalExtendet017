namespace _07.Capitalize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CapitalizeWords
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine().ToLower();
            char[] symbols = new char[] { '.', ',', '-', '_', '!', '"', '?', ':', ';', '(', ')',
                '{', '}', '[', ']', '§', '$', '%', '&', '/', '\\', '=',
                '|', '^', '°', '*', '#', '+', '~', '²', '³', '<', '>', ' '};

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(symbols,
                    StringSplitOptions.RemoveEmptyEntries);

                List<string> result = new List<string>();

                foreach (var word in tokens)
                {
                    string newWord = string.Empty;

                    for (int i = 0; i < word.Length; i++)
                    {
                        string curretChar = word[i].ToString();

                        if(i == 0)
                        {
                            curretChar = curretChar.ToUpper();
                        }

                        newWord += curretChar;
                    }
                    result.Add(newWord);
                }

                Console.WriteLine($"{string.Join(",       s", result)}");

                inputLine = Console.ReadLine().ToLower();
            }
        }
    }
}
